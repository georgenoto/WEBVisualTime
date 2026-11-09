using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_REG_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RM_REG_TYPESController : Controller
{
    private readonly IRM_REG_TYPESService _service;

    public RM_REG_TYPESController(IRM_REG_TYPESService service
    )
    {
        _service = service;
    }

    // GET: RM_REG_TYPES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/RM_REG_TYPES/Index.cshtml");

    // GET: RM_REG_TYPES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_REG_TYPES/Details.cshtml", result);
    }

    // GET: RM_REG_TYPES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/RM_REG_TYPES/Create.cshtml", new CreateRM_REG_TYPESDto());
    }

    // POST: RM_REG_TYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRM_REG_TYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_REG_TYPES/Create.cshtml", createDto);
    }

    // GET: RM_REG_TYPES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRM_REG_TYPESDto
        {
            TABLE_NAME = result.TABLE_NAME,
            PRODUCT = result.PRODUCT,
            NAME = result.NAME,
            SHORT_NAME = result.SHORT_NAME,
            PLURAL_NAME = result.PLURAL_NAME,
            NLS_NAME = result.NLS_NAME,
            NLS_PLURAL_NAME = result.NLS_PLURAL_NAME,
            USER_EXTENSION = result.USER_EXTENSION,
            HELP_TAG = result.HELP_TAG,
        };
        return View("~/Views/Insudb/RM_REG_TYPES/Edit.cshtml", updateDto);
    }

    // POST: RM_REG_TYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateRM_REG_TYPESDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_REG_TYPES/Edit.cshtml", updateDto);
    }

    // GET: RM_REG_TYPES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_REG_TYPES/Delete.cshtml", result);
    }

    // POST: RM_REG_TYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
