using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_FOLDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHEMA_FOLDERController : Controller
{
    private readonly ISCHEMA_FOLDERService _service;

    public SCHEMA_FOLDERController(ISCHEMA_FOLDERService service
    )
    {
        _service = service;
    }

    // GET: SCHEMA_FOLDER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SCHEMA_FOLDER/Index.cshtml");

    // GET: SCHEMA_FOLDER/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHEMA_FOLDER/Details.cshtml", result);
    }

    // GET: SCHEMA_FOLDER/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SCHEMA_FOLDER/Create.cshtml", new CreateSCHEMA_FOLDERDto());
    }

    // POST: SCHEMA_FOLDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHEMA_FOLDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHEMA_FOLDER/Create.cshtml", createDto);
    }

    // GET: SCHEMA_FOLDER/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHEMA_FOLDERDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NFOLDER = result.NFOLDER,
            NINQLEVEL = result.NINQLEVEL,
            SPERMITTED = result.SPERMITTED,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/SCHEMA_FOLDER/Edit.cshtml", updateDto);
    }

    // POST: SCHEMA_FOLDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateSCHEMA_FOLDERDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHEMA_FOLDER/Edit.cshtml", updateDto);
    }

    // GET: SCHEMA_FOLDER/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHEMA_FOLDER/Delete.cshtml", result);
    }

    // POST: SCHEMA_FOLDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
