using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPEPERGROUP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9005;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TYPEPERGROUPController : Controller
{
    private readonly ITYPEPERGROUPService _service;
    private readonly ITABLE9005Service _TABLE9005Service;
    private readonly ITABLE9000Service _TABLE9000Service;

    public TYPEPERGROUPController(ITYPEPERGROUPService service
        , ITABLE9005Service TABLE9005Service
        , ITABLE9000Service TABLE9000Service
    )
    {
        _service = service;
        _TABLE9005Service = TABLE9005Service;
        _TABLE9000Service = TABLE9000Service;
    }

    // GET: TYPEPERGROUP
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TYPEPERGROUP/Index.cshtml");

    // GET: TYPEPERGROUP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPEPERGROUP/Details.cshtml", result);
    }

    // GET: TYPEPERGROUP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9005DropdownAsync();
        await PopulateTABLE9000DropdownAsync();
        return View("~/Views/Insudb/TYPEPERGROUP/Create.cshtml", new CreateTYPEPERGROUPDto());
    }

    // POST: TYPEPERGROUP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTYPEPERGROUPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9005DropdownAsync();
        await PopulateTABLE9000DropdownAsync();
        return View("~/Views/Insudb/TYPEPERGROUP/Create.cshtml", createDto);
    }

    // GET: TYPEPERGROUP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTYPEPERGROUPDto
        {
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBUSINESSTY = result.NBUSINESSTY,
            NCOMMERGRP = result.NCOMMERGRP,
        };
        await PopulateTABLE9005DropdownAsync();
        await PopulateTABLE9000DropdownAsync();
        return View("~/Views/Insudb/TYPEPERGROUP/Edit.cshtml", updateDto);
    }

    // POST: TYPEPERGROUP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTYPEPERGROUPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBUSINESSTY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9005DropdownAsync();
        await PopulateTABLE9000DropdownAsync();
        return View("~/Views/Insudb/TYPEPERGROUP/Edit.cshtml", updateDto);
    }

    // GET: TYPEPERGROUP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPEPERGROUP/Delete.cshtml", result);
    }

    // POST: TYPEPERGROUP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9005DropdownAsync()
    {
        var items = await _TABLE9005Service.GetAllAsync();
        ViewData["NBUSINESSTY"] = new SelectList(items, nameof(TABLE9005Dto.NBUSINESSTY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9000DropdownAsync()
    {
        var items = await _TABLE9000Service.GetAllAsync();
        ViewData["NCOMMERGRP"] = new SelectList(items, nameof(TABLE9000Dto.NCOMMERGRP), "SDESCRIPT");
    }

}
