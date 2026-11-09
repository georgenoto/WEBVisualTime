using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_PARAM_INTERFACE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_PARAM_INTERFACEController : Controller
{
    private readonly IT_PARAM_INTERFACEService _service;

    public T_PARAM_INTERFACEController(IT_PARAM_INTERFACEService service
    )
    {
        _service = service;
    }

    // GET: T_PARAM_INTERFACE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/T_PARAM_INTERFACE/Index.cshtml");

    // GET: T_PARAM_INTERFACE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Details.cshtml", result);
    }

    // GET: T_PARAM_INTERFACE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Create.cshtml", new CreateT_PARAM_INTERFACEDto());
    }

    // POST: T_PARAM_INTERFACE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_PARAM_INTERFACEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Create.cshtml", createDto);
    }

    // GET: T_PARAM_INTERFACE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_PARAM_INTERFACEDto
        {
            SKEY = result.SKEY,
            NFIELD = result.NFIELD,
            SVALUE = result.SVALUE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Edit.cshtml", updateDto);
    }

    // POST: T_PARAM_INTERFACE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateT_PARAM_INTERFACEDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Edit.cshtml", updateDto);
    }

    // GET: T_PARAM_INTERFACE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_PARAM_INTERFACE/Delete.cshtml", result);
    }

    // POST: T_PARAM_INTERFACE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
