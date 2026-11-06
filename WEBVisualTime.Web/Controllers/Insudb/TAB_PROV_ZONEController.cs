using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_ZONE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_ZONEController : Controller
{
    private readonly ITAB_PROV_ZONEService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;

    public TAB_PROV_ZONEController(ITAB_PROV_ZONEService service
        , ITAB_PROVIDERService TAB_PROVIDERService
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
    }

    // GET: TAB_PROV_ZONE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_ZONE/Index.cshtml");

    // GET: TAB_PROV_ZONE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Details.cshtml", result);
    }

    // GET: TAB_PROV_ZONE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Create.cshtml", new CreateTAB_PROV_ZONEDto());
    }

    // POST: TAB_PROV_ZONE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_ZONEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_ZONE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_ZONEDto
        {
            NPROVIDER = result.NPROVIDER,
            NZONE = result.NZONE,
            NORDER = result.NORDER,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DINPDATE = result.DINPDATE,
            DOUTDATE = result.DOUTDATE,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_ZONE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_ZONEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_ZONE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_ZONE/Delete.cshtml", result);
    }

    // POST: TAB_PROV_ZONE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

}
