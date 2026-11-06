using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_QUOTA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COVER_QUOTAController : Controller
{
    private readonly ICOVER_QUOTAService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ITABLE12Service _TABLE12Service;

    public COVER_QUOTAController(ICOVER_QUOTAService service
        , IPOLICYService POLICYService
        , ITABLE12Service TABLE12Service
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _TABLE12Service = TABLE12Service;
    }

    // GET: COVER_QUOTA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COVER_QUOTA/Index.cshtml");

    // GET: COVER_QUOTA/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_QUOTA/Details.cshtml", result);
    }

    // GET: COVER_QUOTA/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/COVER_QUOTA/Create.cshtml", new CreateCOVER_QUOTADto());
    }

    // POST: COVER_QUOTA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOVER_QUOTADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/COVER_QUOTA/Create.cshtml", createDto);
    }

    // GET: COVER_QUOTA/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOVER_QUOTADto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NGROUP = result.NGROUP,
            NMODULEC = result.NMODULEC,
            NROLE = result.NROLE,
            NCOVER = result.NCOVER,
            NCAPITAL = result.NCAPITAL,
            NTAXIVA = result.NTAXIVA,
            NTAX = result.NTAX,
            NPREMIUM = result.NPREMIUM,
            NINSUCOUNT = result.NINSUCOUNT,
            NINSURED = result.NINSURED,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCERTIF = result.NCERTIF,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/COVER_QUOTA/Edit.cshtml", updateDto);
    }

    // POST: COVER_QUOTA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOVER_QUOTADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/COVER_QUOTA/Edit.cshtml", updateDto);
    }

    // GET: COVER_QUOTA/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_QUOTA/Delete.cshtml", result);
    }

    // POST: COVER_QUOTA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

}
