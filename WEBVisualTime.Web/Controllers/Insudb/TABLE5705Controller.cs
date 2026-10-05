using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5705;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5705Controller : Controller
{
    private readonly ITABLE5705Service _service;

    public TABLE5705Controller(ITABLE5705Service service
    )
    {
        _service = service;
    }

    // GET: TABLE5705
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE5705/Index.cshtml", result);
    }

    // GET: TABLE5705/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5705/Details.cshtml", result);
    }

    // GET: TABLE5705/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE5705/Create.cshtml", new CreateTABLE5705Dto());
    }

    // POST: TABLE5705/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE5705Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5705/Create.cshtml", createDto);
    }

    // GET: TABLE5705/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE5705Dto
        {
            NSYSTEM = result.NSYSTEM,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TABLE5705/Edit.cshtml", updateDto);
    }

    // POST: TABLE5705/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE5705Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSYSTEM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5705/Edit.cshtml", updateDto);
    }

    // GET: TABLE5705/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5705/Delete.cshtml", result);
    }

    // POST: TABLE5705/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
