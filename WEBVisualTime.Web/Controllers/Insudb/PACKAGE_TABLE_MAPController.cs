using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PACKAGE_TABLE_MAP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PACKAGE_TABLE_MAPController : Controller
{
    private readonly IPACKAGE_TABLE_MAPService _service;

    public PACKAGE_TABLE_MAPController(IPACKAGE_TABLE_MAPService service
    )
    {
        _service = service;
    }

    // GET: PACKAGE_TABLE_MAP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Index.cshtml", result);
    }

    // GET: PACKAGE_TABLE_MAP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Details.cshtml", result);
    }

    // GET: PACKAGE_TABLE_MAP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Create.cshtml", new CreatePACKAGE_TABLE_MAPDto());
    }

    // POST: PACKAGE_TABLE_MAP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePACKAGE_TABLE_MAPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Create.cshtml", createDto);
    }

    // GET: PACKAGE_TABLE_MAP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePACKAGE_TABLE_MAPDto
        {
            OWNER = result.OWNER,
            PACKAGE_NAME = result.PACKAGE_NAME,
            TABLE_NAME = result.TABLE_NAME,
        };
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Edit.cshtml", updateDto);
    }

    // POST: PACKAGE_TABLE_MAP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePACKAGE_TABLE_MAPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.OWNER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Edit.cshtml", updateDto);
    }

    // GET: PACKAGE_TABLE_MAP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PACKAGE_TABLE_MAP/Delete.cshtml", result);
    }

    // POST: PACKAGE_TABLE_MAP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
