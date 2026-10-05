using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMISS_PR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMISS_PRController : Controller
{
    private readonly ICOMMISS_PRService _service;
    private readonly IPREMIUMService _PREMIUMService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly IPROVINCEService _PROVINCEService;
    private readonly IINTERM_TYPService _INTERM_TYPService;

    public COMMISS_PRController(ICOMMISS_PRService service
        , IPREMIUMService PREMIUMService
        , IINTERMEDIAService INTERMEDIAService
        , IPROVINCEService PROVINCEService
        , IINTERM_TYPService INTERM_TYPService
    )
    {
        _service = service;
        _PREMIUMService = PREMIUMService;
        _INTERMEDIAService = INTERMEDIAService;
        _PROVINCEService = PROVINCEService;
        _INTERM_TYPService = INTERM_TYPService;
    }

    // GET: COMMISS_PR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COMMISS_PR/Index.cshtml", result);
    }

    // GET: COMMISS_PR/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMISS_PR/Details.cshtml", result);
    }

    // GET: COMMISS_PR/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePREMIUMDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/COMMISS_PR/Create.cshtml", new CreateCOMMISS_PRDto());
    }

    // POST: COMMISS_PR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMISS_PRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/COMMISS_PR/Create.cshtml", createDto);
    }

    // GET: COMMISS_PR/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMISS_PRDto
        {
            NRECEIPT = result.NRECEIPT,
            NPRODUCT = result.NPRODUCT,
            NBRANCH = result.NBRANCH,
            SCERTYPE = result.SCERTYPE,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NINTERMED = result.NINTERMED,
            NPROVINCE = result.NPROVINCE,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NPERCENT = result.NPERCENT,
            NROLE = result.NROLE,
            NSHARE = result.NSHARE,
            NUSERCODE = result.NUSERCODE,
            NCOM_AFEC = result.NCOM_AFEC,
            NCOM_EXEN = result.NCOM_EXEN,
            NDISC_AMOUNT = result.NDISC_AMOUNT,
            NCATEGORY = result.NCATEGORY,
            NID_CAMPAIGN = result.NID_CAMPAIGN,
        };
        await PopulatePREMIUMDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/COMMISS_PR/Edit.cshtml", updateDto);
    }

    // POST: COMMISS_PR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMMISS_PRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRECEIPT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/COMMISS_PR/Edit.cshtml", updateDto);
    }

    // GET: COMMISS_PR/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMISS_PR/Delete.cshtml", result);
    }

    // POST: COMMISS_PR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePREMIUMDropdownAsync()
    {
        var items = await _PREMIUMService.GetAllAsync();
        ViewData["NRECEIPT"] = new SelectList(items, nameof(PREMIUMDto.NRECEIPT), "SCESSIONS");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PREMIUMDto.NPRODUCT), "SCESSIONS");
        ViewData["NBRANCH"] = new SelectList(items, nameof(PREMIUMDto.NBRANCH), "SCESSIONS");
        ViewData["SCERTYPE"] = new SelectList(items, nameof(PREMIUMDto.SCERTYPE), "SCESSIONS");
        ViewData["NDIGIT"] = new SelectList(items, nameof(PREMIUMDto.NDIGIT), "SCESSIONS");
        ViewData["NPAYNUMBE"] = new SelectList(items, nameof(PREMIUMDto.NPAYNUMBE), "SCESSIONS");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulatePROVINCEDropdownAsync()
    {
        var items = await _PROVINCEService.GetAllAsync();
        ViewData["NPROVINCE"] = new SelectList(items, nameof(PROVINCEDto.NPROVINCE), "SDESCRIPT");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

}
