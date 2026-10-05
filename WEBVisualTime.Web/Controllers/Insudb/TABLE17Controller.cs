using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE17;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE17Controller : Controller
{
    private readonly ITABLE17Service _service;

    public TABLE17Controller(ITABLE17Service service
    )
    {
        _service = service;
    }

    // GET: TABLE17
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE17/Index.cshtml", result);
    }

    // GET: TABLE17/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE17/Details.cshtml", result);
    }

    // GET: TABLE17/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE17/Create.cshtml", new CreateTABLE17Dto());
    }

    // POST: TABLE17/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE17Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE17/Create.cshtml", createDto);
    }

    // GET: TABLE17/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE17Dto
        {
            NCODIGINT = result.NCODIGINT,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TABLE17/Edit.cshtml", updateDto);
    }

    // POST: TABLE17/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE17Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCODIGINT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE17/Edit.cshtml", updateDto);
    }

    // GET: TABLE17/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE17/Delete.cshtml", result);
    }

    // POST: TABLE17/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
