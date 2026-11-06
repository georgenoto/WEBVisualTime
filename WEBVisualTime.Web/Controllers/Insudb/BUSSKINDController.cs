using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BUSSKIND;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPEPERGROUP;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BUSSKINDController : Controller
{
    private readonly IBUSSKINDService _service;
    private readonly ITYPEPERGROUPService _TYPEPERGROUPService;

    public BUSSKINDController(IBUSSKINDService service
        , ITYPEPERGROUPService TYPEPERGROUPService
    )
    {
        _service = service;
        _TYPEPERGROUPService = TYPEPERGROUPService;
    }

    // GET: BUSSKIND
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BUSSKIND/Index.cshtml");

    // GET: BUSSKIND/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BUSSKIND/Details.cshtml", result);
    }

    // GET: BUSSKIND/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTYPEPERGROUPDropdownAsync();
        return View("~/Views/Insudb/BUSSKIND/Create.cshtml", new CreateBUSSKINDDto());
    }

    // POST: BUSSKIND/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBUSSKINDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTYPEPERGROUPDropdownAsync();
        return View("~/Views/Insudb/BUSSKIND/Create.cshtml", createDto);
    }

    // GET: BUSSKIND/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBUSSKINDDto
        {
            SCOMPLCOD = result.SCOMPLCOD,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBUSINESSTY = result.NBUSINESSTY,
            NCOMMERGRP = result.NCOMMERGRP,
            NCODKIND = result.NCODKIND,
        };
        await PopulateTYPEPERGROUPDropdownAsync();
        return View("~/Views/Insudb/BUSSKIND/Edit.cshtml", updateDto);
    }

    // POST: BUSSKIND/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBUSSKINDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBUSINESSTY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTYPEPERGROUPDropdownAsync();
        return View("~/Views/Insudb/BUSSKIND/Edit.cshtml", updateDto);
    }

    // GET: BUSSKIND/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BUSSKIND/Delete.cshtml", result);
    }

    // POST: BUSSKIND/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTYPEPERGROUPDropdownAsync()
    {
        var items = await _TYPEPERGROUPService.GetAllAsync();
        ViewData["NBUSINESSTY"] = new SelectList(items, nameof(TYPEPERGROUPDto.NBUSINESSTY), "SSTATREGT");
        ViewData["NCOMMERGRP"] = new SelectList(items, nameof(TYPEPERGROUPDto.NCOMMERGRP), "SSTATREGT");
    }

}
