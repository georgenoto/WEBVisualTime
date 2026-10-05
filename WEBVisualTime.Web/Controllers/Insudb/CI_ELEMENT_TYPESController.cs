using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CI_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CI_ELEMENT_TYPESController : Controller
{
    private readonly ICI_ELEMENT_TYPESService _service;

    public CI_ELEMENT_TYPESController(ICI_ELEMENT_TYPESService service
    )
    {
        _service = service;
    }

    // GET: CI_ELEMENT_TYPES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Index.cshtml", result);
    }

    // GET: CI_ELEMENT_TYPES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Details.cshtml", result);
    }

    // GET: CI_ELEMENT_TYPES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Create.cshtml", new CreateCI_ELEMENT_TYPESDto());
    }

    // POST: CI_ELEMENT_TYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCI_ELEMENT_TYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Create.cshtml", createDto);
    }

    // GET: CI_ELEMENT_TYPES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCI_ELEMENT_TYPESDto
        {
            NAME = result.NAME,
            SHORT_NAME = result.SHORT_NAME,
            EL_TYPE_OF = result.EL_TYPE_OF,
            PRODUCT = result.PRODUCT,
            RELEASE = result.RELEASE,
            PACK_GEN = result.PACK_GEN,
            VIEW_GEN = result.VIEW_GEN,
            SUPERTYPE = result.SUPERTYPE,
            PARENT = result.PARENT,
            ADDED_TYPE = result.ADDED_TYPE,
            EXTENSIBLE = result.EXTENSIBLE,
        };
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Edit.cshtml", updateDto);
    }

    // POST: CI_ELEMENT_TYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCI_ELEMENT_TYPESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Edit.cshtml", updateDto);
    }

    // GET: CI_ELEMENT_TYPES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CI_ELEMENT_TYPES/Delete.cshtml", result);
    }

    // POST: CI_ELEMENT_TYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
