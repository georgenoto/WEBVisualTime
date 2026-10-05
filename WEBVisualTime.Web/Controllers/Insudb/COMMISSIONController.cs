using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISSION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMISSIONController : Controller
{
    private readonly ICOMMISSIONService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly IINTERM_TYPService _INTERM_TYPService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE47Service _TABLE47Service;

    public COMMISSIONController(ICOMMISSIONService service
        , ICERTIFICATService CERTIFICATService
        , IINTERM_TYPService INTERM_TYPService
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE47Service TABLE47Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _INTERM_TYPService = INTERM_TYPService;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE47Service = TABLE47Service;
    }

    // GET: COMMISSION
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COMMISSION/Index.cshtml", result);
    }

    // GET: COMMISSION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMISSION/Details.cshtml", result);
    }

    // GET: COMMISSION/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE47DropdownAsync();
        return View("~/Views/Insudb/COMMISSION/Create.cshtml", new CreateCOMMISSIONDto());
    }

    // POST: COMMISSION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMISSIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE47DropdownAsync();
        return View("~/Views/Insudb/COMMISSION/Create.cshtml", createDto);
    }

    // GET: COMMISSION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMISSIONDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NINTERTYP = result.NINTERTYP,
            NINTERMED = result.NINTERMED,
            DEFFECDATE = result.DEFFECDATE,
            NAMOUNT = result.NAMOUNT,
            SCOMMITYP = result.SCOMMITYP,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NPERCENT = result.NPERCENT,
            NSHARE = result.NSHARE,
            NUSERCODE = result.NUSERCODE,
            NPERDISCOUNT = result.NPERDISCOUNT,
            SPLUSCOLLEC = result.SPLUSCOLLEC,
            SPLUSOFFICE = result.SPLUSOFFICE,
            SPLUSQUALITY = result.SPLUSQUALITY,
            NAGREEMENT = result.NAGREEMENT,
            NPERCENT_CE = result.NPERCENT_CE,
            NCERTIF = result.NCERTIF,
            NINSTALLCOM = result.NINSTALLCOM,
            NCATEGORY = result.NCATEGORY,
            NID_CAMPAIGN = result.NID_CAMPAIGN,
            DDATEEND_CAMP = result.DDATEEND_CAMP,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE47DropdownAsync();
        return View("~/Views/Insudb/COMMISSION/Edit.cshtml", updateDto);
    }

    // POST: COMMISSION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMMISSIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE47DropdownAsync();
        return View("~/Views/Insudb/COMMISSION/Edit.cshtml", updateDto);
    }

    // GET: COMMISSION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMISSION/Delete.cshtml", result);
    }

    // POST: COMMISSION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE47DropdownAsync()
    {
        var items = await _TABLE47Service.GetAllAsync();
        ViewData["SCOMMITYP"] = new SelectList(items, nameof(TABLE47Dto.SCOMMITYP), "SDESCRIPT");
    }

}
