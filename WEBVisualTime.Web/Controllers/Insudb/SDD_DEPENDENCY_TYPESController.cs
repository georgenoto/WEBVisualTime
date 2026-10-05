using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPENDENCY_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_DEPENDENCY_TYPESController : Controller
{
    private readonly ISDD_DEPENDENCY_TYPESService _service;

    public SDD_DEPENDENCY_TYPESController(ISDD_DEPENDENCY_TYPESService service
    )
    {
        _service = service;
    }

    // GET: SDD_DEPENDENCY_TYPES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Index.cshtml", result);
    }

    // GET: SDD_DEPENDENCY_TYPES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Details.cshtml", result);
    }

    // GET: SDD_DEPENDENCY_TYPES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Create.cshtml", new CreateSDD_DEPENDENCY_TYPESDto());
    }

    // POST: SDD_DEPENDENCY_TYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSDD_DEPENDENCY_TYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Create.cshtml", createDto);
    }

    // GET: SDD_DEPENDENCY_TYPES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSDD_DEPENDENCY_TYPESDto
        {
            IRID = result.IRID,
            IVID = result.IVID,
            TYPE = result.TYPE,
            SYSTEM_FLAG = result.SYSTEM_FLAG,
            TRANSITIVE = result.TRANSITIVE,
            NUMBER_OF_TIMES_MODIFIED = result.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = result.DATE_CREATED,
            CREATED_BY = result.CREATED_BY,
            DATE_CHANGED = result.DATE_CHANGED,
            CHANGED_BY = result.CHANGED_BY,
            SUBTYPE = result.SUBTYPE,
        };
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Edit.cshtml", updateDto);
    }

    // POST: SDD_DEPENDENCY_TYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSDD_DEPENDENCY_TYPESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.IRID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Edit.cshtml", updateDto);
    }

    // GET: SDD_DEPENDENCY_TYPES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_DEPENDENCY_TYPES/Delete.cshtml", result);
    }

    // POST: SDD_DEPENDENCY_TYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
