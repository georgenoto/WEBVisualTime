using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8200Controller : Controller
{
    private readonly ITABLE8200Service _service;

    public TABLE8200Controller(ITABLE8200Service service
    )
    {
        _service = service;
    }

    // GET: TABLE8200
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE8200/Index.cshtml", result);
    }

    // GET: TABLE8200/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8200/Details.cshtml", result);
    }

    // GET: TABLE8200/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE8200/Create.cshtml", new CreateTABLE8200Dto());
    }

    // POST: TABLE8200/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE8200Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8200/Create.cshtml", createDto);
    }

    // GET: TABLE8200/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE8200Dto
        {
            NPROCESS = result.NPROCESS,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TABLE8200/Edit.cshtml", updateDto);
    }

    // POST: TABLE8200/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE8200Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROCESS, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE8200/Edit.cshtml", updateDto);
    }

    // GET: TABLE8200/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE8200/Delete.cshtml", result);
    }

    // POST: TABLE8200/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
