using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8206Controller : Controller
{
    private readonly ITABLE8206Service _service;

    public TABLE8206Controller(ITABLE8206Service service
    )
    {
        _service = service;
    }

    // GET: TABLE8206
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE8206/Index.cshtml", result);
    }

    // GET: TABLE8206/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8206/Details.cshtml", result);
    }

    // GET: TABLE8206/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE8206/Create.cshtml", new CreateTABLE8206Dto());
    }

    // POST: TABLE8206/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE8206Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8206/Create.cshtml", createDto);
    }

    // GET: TABLE8206/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE8206Dto
        {
            NACTION = result.NACTION,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TABLE8206/Edit.cshtml", updateDto);
    }

    // POST: TABLE8206/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE8206Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NACTION, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8206/Edit.cshtml", updateDto);
    }

    // GET: TABLE8206/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8206/Delete.cshtml", result);
    }

    // POST: TABLE8206/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
