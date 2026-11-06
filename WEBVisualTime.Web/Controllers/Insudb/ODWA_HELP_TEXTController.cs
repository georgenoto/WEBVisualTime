using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_TEXT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_HELP_TEXTController : Controller
{
    private readonly IODWA_HELP_TEXTService _service;
    private readonly IODWA_HELP_ITEMSService _ODWA_HELP_ITEMSService;

    public ODWA_HELP_TEXTController(IODWA_HELP_TEXTService service
        , IODWA_HELP_ITEMSService ODWA_HELP_ITEMSService
    )
    {
        _service = service;
        _ODWA_HELP_ITEMSService = ODWA_HELP_ITEMSService;
    }

    // GET: ODWA_HELP_TEXT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ODWA_HELP_TEXT/Index.cshtml");

    // GET: ODWA_HELP_TEXT/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Details.cshtml", result);
    }

    // GET: ODWA_HELP_TEXT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateODWA_HELP_ITEMSDropdownAsync();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Create.cshtml", new CreateODWA_HELP_TEXTDto());
    }

    // POST: ODWA_HELP_TEXT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateODWA_HELP_TEXTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateODWA_HELP_ITEMSDropdownAsync();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Create.cshtml", createDto);
    }

    // GET: ODWA_HELP_TEXT/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateODWA_HELP_TEXTDto
        {
            HIM_ID = result.HIM_ID,
            SEQ = result.SEQ,
            TXT = result.TXT,
        };
        await PopulateODWA_HELP_ITEMSDropdownAsync();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Edit.cshtml", updateDto);
    }

    // POST: ODWA_HELP_TEXT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateODWA_HELP_TEXTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.HIM_ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateODWA_HELP_ITEMSDropdownAsync();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Edit.cshtml", updateDto);
    }

    // GET: ODWA_HELP_TEXT/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_TEXT/Delete.cshtml", result);
    }

    // POST: ODWA_HELP_TEXT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateODWA_HELP_ITEMSDropdownAsync()
    {
        var items = await _ODWA_HELP_ITEMSService.GetAllAsync();
        ViewData["HIM_ID"] = new SelectList(items, nameof(ODWA_HELP_ITEMSDto.ID), "DESCRIPTION");
    }

}
