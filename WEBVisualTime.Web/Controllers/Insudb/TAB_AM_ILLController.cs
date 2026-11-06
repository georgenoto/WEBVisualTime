using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8602;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_AM_ILLController : Controller
{
    private readonly ITAB_AM_ILLService _service;
    private readonly ITABLE8602Service _TABLE8602Service;

    public TAB_AM_ILLController(ITAB_AM_ILLService service
        , ITABLE8602Service TABLE8602Service
    )
    {
        _service = service;
        _TABLE8602Service = TABLE8602Service;
    }

    // GET: TAB_AM_ILL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_AM_ILL/Index.cshtml");

    // GET: TAB_AM_ILL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AM_ILL/Details.cshtml", result);
    }

    // GET: TAB_AM_ILL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8602DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_ILL/Create.cshtml", new CreateTAB_AM_ILLDto());
    }

    // POST: TAB_AM_ILL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_AM_ILLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8602DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_ILL/Create.cshtml", createDto);
    }

    // GET: TAB_AM_ILL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_AM_ILLDto
        {
            SILLNESS = result.SILLNESS,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SILL_OMS = result.SILL_OMS,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SIND_SEVERITY = result.SIND_SEVERITY,
            SIND_FRECUENCY = result.SIND_FRECUENCY,
        };
        await PopulateTABLE8602DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_ILL/Edit.cshtml", updateDto);
    }

    // POST: TAB_AM_ILL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_AM_ILLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SILLNESS, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8602DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_ILL/Edit.cshtml", updateDto);
    }

    // GET: TAB_AM_ILL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AM_ILL/Delete.cshtml", result);
    }

    // POST: TAB_AM_ILL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8602DropdownAsync()
    {
        var items = await _TABLE8602Service.GetAllAsync();
        ViewData["SILL_OMS"] = new SelectList(items, nameof(TABLE8602Dto.SGROUP_ILL), "SDESCRIPT");
    }

}
