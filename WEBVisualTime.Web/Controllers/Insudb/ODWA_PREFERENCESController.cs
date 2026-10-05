using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_PREFERENCESController : Controller
{
    private readonly IODWA_PREFERENCESService _service;

    public ODWA_PREFERENCESController(IODWA_PREFERENCESService service
    )
    {
        _service = service;
    }

    // GET: ODWA_PREFERENCES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ODWA_PREFERENCES/Index.cshtml", result);
    }

    // GET: ODWA_PREFERENCES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_PREFERENCES/Details.cshtml", result);
    }

    // GET: ODWA_PREFERENCES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ODWA_PREFERENCES/Create.cshtml", new CreateODWA_PREFERENCESDto());
    }

    // POST: ODWA_PREFERENCES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateODWA_PREFERENCESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_PREFERENCES/Create.cshtml", createDto);
    }

    // GET: ODWA_PREFERENCES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateODWA_PREFERENCESDto
        {
            PREFERENCE_NAME = result.PREFERENCE_NAME,
            PREFERENCE_VALUE = result.PREFERENCE_VALUE,
            PREFERENCE_DESCRIPTION = result.PREFERENCE_DESCRIPTION,
        };
        return View("~/Views/Insudb/ODWA_PREFERENCES/Edit.cshtml", updateDto);
    }

    // POST: ODWA_PREFERENCES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateODWA_PREFERENCESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.PREFERENCE_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_PREFERENCES/Edit.cshtml", updateDto);
    }

    // GET: ODWA_PREFERENCES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_PREFERENCES/Delete.cshtml", result);
    }

    // POST: ODWA_PREFERENCES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
