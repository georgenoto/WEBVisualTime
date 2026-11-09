using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.STIPEND_POL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class STIPEND_POLController : Controller
{
    private readonly ISTIPEND_POLService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE47Service _TABLE47Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;

    public STIPEND_POLController(ISTIPEND_POLService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE47Service TABLE47Service
        , IINTERMEDIAService INTERMEDIAService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE47Service = TABLE47Service;
        _INTERMEDIAService = INTERMEDIAService;
    }

    // GET: STIPEND_POL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/STIPEND_POL/Index.cshtml");

    // GET: STIPEND_POL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/STIPEND_POL/Details.cshtml", result);
    }

    // GET: STIPEND_POL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/STIPEND_POL/Create.cshtml", new CreateSTIPEND_POLDto());
    }

    // POST: STIPEND_POL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSTIPEND_POLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/STIPEND_POL/Create.cshtml", createDto);
    }

    // GET: STIPEND_POL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSTIPEND_POLDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NROLE = result.NROLE,
            SCLIENT = result.SCLIENT,
            NTYPE_CONTRAT = result.NTYPE_CONTRAT,
            DEFFECDATE = result.DEFFECDATE,
            NUSERCODE = result.NUSERCODE,
            SCOMMITYP = result.SCOMMITYP,
            NCONTRAT_PAY = result.NCONTRAT_PAY,
            NINTERMED = result.NINTERMED,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NPERCENT = result.NPERCENT,
            NSHARE = result.NSHARE,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/STIPEND_POL/Edit.cshtml", updateDto);
    }

    // POST: STIPEND_POL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateSTIPEND_POLDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/STIPEND_POL/Edit.cshtml", updateDto);
    }

    // GET: STIPEND_POL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/STIPEND_POL/Delete.cshtml", result);
    }

    // POST: STIPEND_POL/Delete/{id}
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

    private async Task PopulateTABLE47DropdownAsync()
    {
        var items = await _TABLE47Service.GetAllAsync();
        ViewData["SCOMMITYP"] = new SelectList(items, nameof(TABLE47Dto.SCOMMITYP), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

}
