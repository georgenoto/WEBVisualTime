using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6007Controller : Controller
{
    private readonly ITABLE6007Service _service;

    public TABLE6007Controller(ITABLE6007Service service
    )
    {
        _service = service;
    }

    // GET: TABLE6007
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE6007/Index.cshtml", result);
    }

    // GET: TABLE6007/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE6007/Details.cshtml", result);
    }

    // GET: TABLE6007/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE6007/Create.cshtml", new CreateTABLE6007Dto());
    }

    // POST: TABLE6007/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE6007Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE6007/Create.cshtml", createDto);
    }

    // GET: TABLE6007/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE6007Dto
        {
            NZONETYPE = result.NZONETYPE,
            SDESCRIPT = result.SDESCRIPT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TABLE6007/Edit.cshtml", updateDto);
    }

    // POST: TABLE6007/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE6007Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NZONETYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE6007/Edit.cshtml", updateDto);
    }

    // GET: TABLE6007/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE6007/Delete.cshtml", result);
    }

    // POST: TABLE6007/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
