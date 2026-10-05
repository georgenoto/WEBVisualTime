using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PIE_ELEMENT_TYPESController : Controller
{
    private readonly IPIE_ELEMENT_TYPESService _service;

    public PIE_ELEMENT_TYPESController(IPIE_ELEMENT_TYPESService service
    )
    {
        _service = service;
    }

    // GET: PIE_ELEMENT_TYPES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Index.cshtml", result);
    }

    // GET: PIE_ELEMENT_TYPES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Details.cshtml", result);
    }

    // GET: PIE_ELEMENT_TYPES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Create.cshtml", new CreatePIE_ELEMENT_TYPESDto());
    }

    // POST: PIE_ELEMENT_TYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePIE_ELEMENT_TYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Create.cshtml", createDto);
    }

    // GET: PIE_ELEMENT_TYPES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePIE_ELEMENT_TYPESDto
        {
            DISPLAY_NAME = result.DISPLAY_NAME,
            NAME = result.NAME,
            RM_ID = result.RM_ID,
            PLURAL = result.PLURAL,
            GIF_FILE = result.GIF_FILE,
            ROOT_PROCEDURE = result.ROOT_PROCEDURE,
            SHORT_NAME = result.SHORT_NAME,
            DETAIL_PROCEDURE = result.DETAIL_PROCEDURE,
            DISPLAY_SEQUENCE = result.DISPLAY_SEQUENCE,
        };
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Edit.cshtml", updateDto);
    }

    // POST: PIE_ELEMENT_TYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePIE_ELEMENT_TYPESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SHORT_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Edit.cshtml", updateDto);
    }

    // GET: PIE_ELEMENT_TYPES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PIE_ELEMENT_TYPES/Delete.cshtml", result);
    }

    // POST: PIE_ELEMENT_TYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
