using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GEN_TARGET_PROPERTIES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_GEN_TARGET_PROPERTIESController : Controller
{
    private readonly ICDI_GEN_TARGET_PROPERTIESService _service;

    public CDI_GEN_TARGET_PROPERTIESController(ICDI_GEN_TARGET_PROPERTIESService service
    )
    {
        _service = service;
    }

    // GET: CDI_GEN_TARGET_PROPERTIES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Index.cshtml", result);
    }

    // GET: CDI_GEN_TARGET_PROPERTIES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Details.cshtml", result);
    }

    // GET: CDI_GEN_TARGET_PROPERTIES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Create.cshtml", new CreateCDI_GEN_TARGET_PROPERTIESDto());
    }

    // POST: CDI_GEN_TARGET_PROPERTIES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_GEN_TARGET_PROPERTIESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Create.cshtml", createDto);
    }

    // GET: CDI_GEN_TARGET_PROPERTIES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_GEN_TARGET_PROPERTIESDto
        {
            TARGET_NAME = result.TARGET_NAME,
            TYPE = result.TYPE,
            NAME = result.NAME,
            VALUE = result.VALUE,
        };
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Edit.cshtml", updateDto);
    }

    // POST: CDI_GEN_TARGET_PROPERTIES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_GEN_TARGET_PROPERTIESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.TARGET_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Edit.cshtml", updateDto);
    }

    // GET: CDI_GEN_TARGET_PROPERTIES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_GEN_TARGET_PROPERTIES/Delete.cshtml", result);
    }

    // POST: CDI_GEN_TARGET_PROPERTIES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
