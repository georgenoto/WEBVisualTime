using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5008Controller : Controller
{
    private readonly ITABLE5008Service _service;

    public TABLE5008Controller(ITABLE5008Service service
    )
    {
        _service = service;
    }

    // GET: TABLE5008
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE5008/Index.cshtml", result);
    }

    // GET: TABLE5008/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5008/Details.cshtml", result);
    }

    // GET: TABLE5008/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE5008/Create.cshtml", new CreateTABLE5008Dto());
    }

    // POST: TABLE5008/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE5008Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5008/Create.cshtml", createDto);
    }

    // GET: TABLE5008/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE5008Dto
        {
            NCODIGINT = result.NCODIGINT,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TABLE5008/Edit.cshtml", updateDto);
    }

    // POST: TABLE5008/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE5008Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCODIGINT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5008/Edit.cshtml", updateDto);
    }

    // GET: TABLE5008/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5008/Delete.cshtml", result);
    }

    // POST: TABLE5008/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
