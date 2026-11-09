using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CUR_ALLOW;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CUR_ALLOWController : Controller
{
    private readonly ICUR_ALLOWService _service;

    public CUR_ALLOWController(ICUR_ALLOWService service
    )
    {
        _service = service;
    }

    // GET: CUR_ALLOW
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CUR_ALLOW/Index.cshtml");

    // GET: CUR_ALLOW/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CUR_ALLOW/Details.cshtml", result);
    }

    // GET: CUR_ALLOW/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CUR_ALLOW/Create.cshtml", new CreateCUR_ALLOWDto());
    }

    // POST: CUR_ALLOW/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCUR_ALLOWDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CUR_ALLOW/Create.cshtml", createDto);
    }

    // GET: CUR_ALLOW/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCUR_ALLOWDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCURRENCY = result.NCURRENCY,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            NUSERCODE = result.NUSERCODE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
        };
        return View("~/Views/Insudb/CUR_ALLOW/Edit.cshtml", updateDto);
    }

    // POST: CUR_ALLOW/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCUR_ALLOWDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CUR_ALLOW/Edit.cshtml", updateDto);
    }

    // GET: CUR_ALLOW/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CUR_ALLOW/Delete.cshtml", result);
    }

    // POST: CUR_ALLOW/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
