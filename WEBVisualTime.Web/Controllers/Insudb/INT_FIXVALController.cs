using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INT_FIXVAL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INT_FIXVALController : Controller
{
    private readonly IINT_FIXVALService _service;

    public INT_FIXVALController(IINT_FIXVALService service
    )
    {
        _service = service;
    }

    // GET: INT_FIXVAL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INT_FIXVAL/Index.cshtml");

    // GET: INT_FIXVAL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INT_FIXVAL/Details.cshtml", result);
    }

    // GET: INT_FIXVAL/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/INT_FIXVAL/Create.cshtml", new CreateINT_FIXVALDto());
    }

    // POST: INT_FIXVAL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINT_FIXVALDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/INT_FIXVAL/Create.cshtml", createDto);
    }

    // GET: INT_FIXVAL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINT_FIXVALDto
        {
            NCODE = result.NCODE,
            DEFFECDATE = result.DEFFECDATE,
            SDESCRIPT = result.SDESCRIPT,
            NAMOUNT = result.NAMOUNT,
            NRATE = result.NRATE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/INT_FIXVAL/Edit.cshtml", updateDto);
    }

    // POST: INT_FIXVAL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateINT_FIXVALDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/INT_FIXVAL/Edit.cshtml", updateDto);
    }

    // GET: INT_FIXVAL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INT_FIXVAL/Delete.cshtml", result);
    }

    // POST: INT_FIXVAL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
