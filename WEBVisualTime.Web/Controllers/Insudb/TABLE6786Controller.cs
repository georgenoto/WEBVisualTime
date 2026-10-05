using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6786Controller : Controller
{
    private readonly ITABLE6786Service _service;

    public TABLE6786Controller(ITABLE6786Service service
    )
    {
        _service = service;
    }

    // GET: TABLE6786
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE6786/Index.cshtml", result);
    }

    // GET: TABLE6786/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE6786/Details.cshtml", result);
    }

    // GET: TABLE6786/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE6786/Create.cshtml", new CreateTABLE6786Dto());
    }

    // POST: TABLE6786/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE6786Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE6786/Create.cshtml", createDto);
    }

    // GET: TABLE6786/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE6786Dto
        {
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            NDEFTYPE = result.NDEFTYPE,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TABLE6786/Edit.cshtml", updateDto);
    }

    // POST: TABLE6786/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE6786Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NDEFTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE6786/Edit.cshtml", updateDto);
    }

    // GET: TABLE6786/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE6786/Delete.cshtml", result);
    }

    // POST: TABLE6786/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
