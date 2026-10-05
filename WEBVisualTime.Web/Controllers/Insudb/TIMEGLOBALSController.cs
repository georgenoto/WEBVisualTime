using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TIMEGLOBALSController : Controller
{
    private readonly ITIMEGLOBALSService _service;

    public TIMEGLOBALSController(ITIMEGLOBALSService service
    )
    {
        _service = service;
    }

    // GET: TIMEGLOBALS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TIMEGLOBALS/Index.cshtml", result);
    }

    // GET: TIMEGLOBALS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TIMEGLOBALS/Details.cshtml", result);
    }

    // GET: TIMEGLOBALS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TIMEGLOBALS/Create.cshtml", new CreateTIMEGLOBALSDto());
    }

    // POST: TIMEGLOBALS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTIMEGLOBALSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TIMEGLOBALS/Create.cshtml", createDto);
    }

    // GET: TIMEGLOBALS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTIMEGLOBALSDto
        {
            SCODE = result.SCODE,
            DCOMPDATE = result.DCOMPDATE,
            NTYPEDATA = result.NTYPEDATA,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TIMEGLOBALS/Edit.cshtml", updateDto);
    }

    // POST: TIMEGLOBALS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTIMEGLOBALSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TIMEGLOBALS/Edit.cshtml", updateDto);
    }

    // GET: TIMEGLOBALS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TIMEGLOBALS/Delete.cshtml", result);
    }

    // POST: TIMEGLOBALS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
