using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_NAME_B;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_NAME_BController : Controller
{
    private readonly ITAB_NAME_BService _service;
    private readonly ITABLE10Service _TABLE10Service;

    public TAB_NAME_BController(ITAB_NAME_BService service
        , ITABLE10Service TABLE10Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
    }

    // GET: TAB_NAME_B
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_NAME_B/Index.cshtml");

    // GET: TAB_NAME_B/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_NAME_B/Details.cshtml", result);
    }

    // GET: TAB_NAME_B/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/TAB_NAME_B/Create.cshtml", new CreateTAB_NAME_BDto());
    }

    // POST: TAB_NAME_B/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_NAME_BDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/TAB_NAME_B/Create.cshtml", createDto);
    }

    // GET: TAB_NAME_B/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_NAME_BDto
        {
            NBRANCH = result.NBRANCH,
            DCOMPDATE = result.DCOMPDATE,
            STABNAME = result.STABNAME,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/TAB_NAME_B/Edit.cshtml", updateDto);
    }

    // POST: TAB_NAME_B/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_NAME_BDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/TAB_NAME_B/Edit.cshtml", updateDto);
    }

    // GET: TAB_NAME_B/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_NAME_B/Delete.cshtml", result);
    }

    // POST: TAB_NAME_B/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

}
