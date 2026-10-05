using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE32Controller : Controller
{
    private readonly ITABLE32Service _service;

    public TABLE32Controller(ITABLE32Service service
    )
    {
        _service = service;
    }

    // GET: TABLE32
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE32/Index.cshtml", result);
    }

    // GET: TABLE32/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE32/Details.cshtml", result);
    }

    // GET: TABLE32/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE32/Create.cshtml", new CreateTABLE32Dto());
    }

    // POST: TABLE32/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE32Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE32/Create.cshtml", createDto);
    }

    // GET: TABLE32/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE32Dto
        {
            NCRTHECNI = result.NCRTHECNI,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTABLE8000 = result.NTABLE8000,
        };
        return View("~/Views/Insudb/TABLE32/Edit.cshtml", updateDto);
    }

    // POST: TABLE32/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE32Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCRTHECNI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE32/Edit.cshtml", updateDto);
    }

    // GET: TABLE32/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE32/Delete.cshtml", result);
    }

    // POST: TABLE32/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
