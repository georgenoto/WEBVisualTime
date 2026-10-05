using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TRACEController : Controller
{
    private readonly ITRACEService _service;

    public TRACEController(ITRACEService service
    )
    {
        _service = service;
    }

    // GET: TRACE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TRACE/Index.cshtml", result);
    }

    // GET: TRACE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRACE/Details.cshtml", result);
    }

    // GET: TRACE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TRACE/Create.cshtml", new CreateTRACEDto());
    }

    // POST: TRACE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTRACEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRACE/Create.cshtml", createDto);
    }

    // GET: TRACE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTRACEDto
        {
            ID = result.ID,
            PROC = result.PROC,
            NUSERCODE = result.NUSERCODE,
            TEXT = result.TEXT,
        };
        return View("~/Views/Insudb/TRACE/Edit.cshtml", updateDto);
    }

    // POST: TRACE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTRACEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRACE/Edit.cshtml", updateDto);
    }

    // GET: TRACE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRACE/Delete.cshtml", result);
    }

    // POST: TRACE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
