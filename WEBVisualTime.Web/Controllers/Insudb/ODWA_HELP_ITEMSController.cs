using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_HELP_ITEMSController : Controller
{
    private readonly IODWA_HELP_ITEMSService _service;

    public ODWA_HELP_ITEMSController(IODWA_HELP_ITEMSService service
    )
    {
        _service = service;
    }

    // GET: ODWA_HELP_ITEMS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Index.cshtml", result);
    }

    // GET: ODWA_HELP_ITEMS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Details.cshtml", result);
    }

    // GET: ODWA_HELP_ITEMS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Create.cshtml", new CreateODWA_HELP_ITEMSDto());
    }

    // POST: ODWA_HELP_ITEMS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateODWA_HELP_ITEMSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Create.cshtml", createDto);
    }

    // GET: ODWA_HELP_ITEMS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateODWA_HELP_ITEMSDto
        {
            ID = result.ID,
            DESCRIPTION = result.DESCRIPTION,
            DOCUMENT = result.DOCUMENT,
            KEYWORDS = result.KEYWORDS,
        };
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Edit.cshtml", updateDto);
    }

    // POST: ODWA_HELP_ITEMS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateODWA_HELP_ITEMSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Edit.cshtml", updateDto);
    }

    // GET: ODWA_HELP_ITEMS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_ITEMS/Delete.cshtml", result);
    }

    // POST: ODWA_HELP_ITEMS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
