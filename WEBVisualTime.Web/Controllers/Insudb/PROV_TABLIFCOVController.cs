using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_TABLIFCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROV_TABLIFCOVController : Controller
{
    private readonly IPROV_TABLIFCOVService _service;
    private readonly ITAB_LIFCOVService _TAB_LIFCOVService;
    private readonly IAGREEMENTService _AGREEMENTService;
    private readonly IUSERSService _USERSService;

    public PROV_TABLIFCOVController(IPROV_TABLIFCOVService service
        , ITAB_LIFCOVService TAB_LIFCOVService
        , IAGREEMENTService AGREEMENTService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TAB_LIFCOVService = TAB_LIFCOVService;
        _AGREEMENTService = AGREEMENTService;
        _USERSService = USERSService;
    }

    // GET: PROV_TABLIFCOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PROV_TABLIFCOV/Index.cshtml");

    // GET: PROV_TABLIFCOV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Details.cshtml", result);
    }

    // GET: PROV_TABLIFCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Create.cshtml", new CreatePROV_TABLIFCOVDto());
    }

    // POST: PROV_TABLIFCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROV_TABLIFCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Create.cshtml", createDto);
    }

    // GET: PROV_TABLIFCOV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROV_TABLIFCOVDto
        {
            NCOVERGEN = result.NCOVERGEN,
            NCOD_AGREE = result.NCOD_AGREE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Edit.cshtml", updateDto);
    }

    // POST: PROV_TABLIFCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROV_TABLIFCOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOVERGEN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Edit.cshtml", updateDto);
    }

    // GET: PROV_TABLIFCOV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROV_TABLIFCOV/Delete.cshtml", result);
    }

    // POST: PROV_TABLIFCOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_LIFCOVDropdownAsync()
    {
        var items = await _TAB_LIFCOVService.GetAllAsync();
        ViewData["NCOVERGEN"] = new SelectList(items, nameof(TAB_LIFCOVDto.NCOVERGEN), "SCACALFRI");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
