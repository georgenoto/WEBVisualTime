using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_PRE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FINANC_PREController : Controller
{
    private readonly IFINANC_PREService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly IUSERSService _USERSService;
    private readonly ICOMPANYService _COMPANYService;

    public FINANC_PREController(IFINANC_PREService service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE9Service TABLE9Service
        , ICLIENTService CLIENTService
        , IUSERSService USERSService
        , ICOMPANYService COMPANYService
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE9Service = TABLE9Service;
        _CLIENTService = CLIENTService;
        _USERSService = USERSService;
        _COMPANYService = COMPANYService;
    }

    // GET: FINANC_PRE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FINANC_PRE/Index.cshtml");

    // GET: FINANC_PRE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_PRE/Details.cshtml", result);
    }

    // GET: FINANC_PRE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/FINANC_PRE/Create.cshtml", new CreateFINANC_PREDto());
    }

    // POST: FINANC_PRE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFINANC_PREDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/FINANC_PRE/Create.cshtml", createDto);
    }

    // GET: FINANC_PRE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFINANC_PREDto
        {
            NBRANCH = result.NBRANCH,
            NCOMMISSION = result.NCOMMISSION,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NCURRENCY = result.NCURRENCY,
            DSTARTDATE = result.DSTARTDATE,
            NEXCHANGE = result.NEXCHANGE,
            DEXPIRDAT = result.DEXPIRDAT,
            NINTERMED = result.NINTERMED,
            NOFFICE = result.NOFFICE,
            NPOLICY = result.NPOLICY,
            NPREMIUM = result.NPREMIUM,
            NRECEIPT = result.NRECEIPT,
            SSTAT_FINPR = result.SSTAT_FINPR,
            SSTATREGT = result.SSTATREGT,
            SCLIENT = result.SCLIENT,
            NUSERCODE = result.NUSERCODE,
            NPRODUCT = result.NPRODUCT,
            NCOMPANY = result.NCOMPANY,
            SEXTRECEIPT = result.SEXTRECEIPT,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/FINANC_PRE/Edit.cshtml", updateDto);
    }

    // POST: FINANC_PRE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateFINANC_PREDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONTRAT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/FINANC_PRE/Edit.cshtml", updateDto);
    }

    // GET: FINANC_PRE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_PRE/Delete.cshtml", result);
    }

    // POST: FINANC_PRE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

}
