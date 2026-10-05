using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8Controller : Controller
{
    private readonly ITABLE8Service _service;

    public TABLE8Controller(ITABLE8Service service
    )
    {
        _service = service;
    }

    // GET: TABLE8
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE8/Index.cshtml", result);
    }

    // GET: TABLE8/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8/Details.cshtml", result);
    }

    // GET: TABLE8/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE8/Create.cshtml", new CreateTABLE8Dto());
    }

    // POST: TABLE8/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE8Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8/Create.cshtml", createDto);
    }

    // GET: TABLE8/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE8Dto
        {
            SREINTYPE = result.SREINTYPE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TABLE8/Edit.cshtml", updateDto);
    }

    // POST: TABLE8/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE8Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SREINTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8/Edit.cshtml", updateDto);
    }

    // GET: TABLE8/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8/Delete.cshtml", result);
    }

    // POST: TABLE8/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
