using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.EXCHANGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class EXCHANGEController : Controller
{
    private readonly IEXCHANGEService _service;

    public EXCHANGEController(IEXCHANGEService service
    )
    {
        _service = service;
    }

    // GET: EXCHANGE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/EXCHANGE/Index.cshtml");

    // GET: EXCHANGE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EXCHANGE/Details.cshtml", result);
    }

    // GET: EXCHANGE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/EXCHANGE/Create.cshtml", new CreateEXCHANGEDto());
    }

    // POST: EXCHANGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateEXCHANGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/EXCHANGE/Create.cshtml", createDto);
    }

    // GET: EXCHANGE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateEXCHANGEDto
        {
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NEXCHANGE = result.NEXCHANGE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/EXCHANGE/Edit.cshtml", updateDto);
    }

    // POST: EXCHANGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateEXCHANGEDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/EXCHANGE/Edit.cshtml", updateDto);
    }

    // GET: EXCHANGE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EXCHANGE/Delete.cshtml", result);
    }

    // POST: EXCHANGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
