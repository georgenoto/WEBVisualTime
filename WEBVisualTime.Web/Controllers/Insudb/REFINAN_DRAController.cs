using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REFINAN_DRA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE252;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REFINAN_DRAController : Controller
{
    private readonly IREFINAN_DRAService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE252Service _TABLE252Service;

    public REFINAN_DRAController(IREFINAN_DRAService service
        , ITABLE10Service TABLE10Service
        , ICLIENTService CLIENTService
        , IUSERSService USERSService
        , ITABLE252Service TABLE252Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _CLIENTService = CLIENTService;
        _USERSService = USERSService;
        _TABLE252Service = TABLE252Service;
    }

    // GET: REFINAN_DRA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REFINAN_DRA/Index.cshtml");

    // GET: REFINAN_DRA/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REFINAN_DRA/Details.cshtml", result);
    }

    // GET: REFINAN_DRA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE252DropdownAsync();
        return View("~/Views/Insudb/REFINAN_DRA/Create.cshtml", new CreateREFINAN_DRADto());
    }

    // POST: REFINAN_DRA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREFINAN_DRADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE252DropdownAsync();
        return View("~/Views/Insudb/REFINAN_DRA/Create.cshtml", createDto);
    }

    // GET: REFINAN_DRA/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREFINAN_DRADto
        {
            NBRANCH = result.NBRANCH,
            NCOMMISSION = result.NCOMMISSION,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NCONTRAT_D = result.NCONTRAT_D,
            NCURRENCY = result.NCURRENCY,
            NDRAFT_D = result.NDRAFT_D,
            DSTARTDATE = result.DSTARTDATE,
            NEXCHANGE = result.NEXCHANGE,
            DEXPIRDAT = result.DEXPIRDAT,
            NPREMIUM = result.NPREMIUM,
            SSTAT_FINPR = result.SSTAT_FINPR,
            SSTATREGT = result.SSTATREGT,
            SCLIENT = result.SCLIENT,
            NUSERCODE = result.NUSERCODE,
            NOPT_DRAFT = result.NOPT_DRAFT,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE252DropdownAsync();
        return View("~/Views/Insudb/REFINAN_DRA/Edit.cshtml", updateDto);
    }

    // POST: REFINAN_DRA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREFINAN_DRADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONTRAT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE252DropdownAsync();
        return View("~/Views/Insudb/REFINAN_DRA/Edit.cshtml", updateDto);
    }

    // GET: REFINAN_DRA/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REFINAN_DRA/Delete.cshtml", result);
    }

    // POST: REFINAN_DRA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
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

    private async Task PopulateTABLE252DropdownAsync()
    {
        var items = await _TABLE252Service.GetAllAsync();
        ViewData["NOPT_DRAFT"] = new SelectList(items, nameof(TABLE252Dto.NCODIGINT), "SDESCRIPT");
    }

}
