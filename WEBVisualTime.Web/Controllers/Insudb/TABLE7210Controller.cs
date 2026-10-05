using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7210Controller : Controller
{
    private readonly ITABLE7210Service _service;

    public TABLE7210Controller(ITABLE7210Service service
    )
    {
        _service = service;
    }

    // GET: TABLE7210
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE7210/Index.cshtml", result);
    }

    // GET: TABLE7210/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE7210/Details.cshtml", result);
    }

    // GET: TABLE7210/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE7210/Create.cshtml", new CreateTABLE7210Dto());
    }

    // POST: TABLE7210/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE7210Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE7210/Create.cshtml", createDto);
    }

    // GET: TABLE7210/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE7210Dto
        {
            NDEPRECIATION = result.NDEPRECIATION,
            SDESCRIPT = result.SDESCRIPT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TABLE7210/Edit.cshtml", updateDto);
    }

    // POST: TABLE7210/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE7210Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NDEPRECIATION, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE7210/Edit.cshtml", updateDto);
    }

    // GET: TABLE7210/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE7210/Delete.cshtml", result);
    }

    // POST: TABLE7210/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
