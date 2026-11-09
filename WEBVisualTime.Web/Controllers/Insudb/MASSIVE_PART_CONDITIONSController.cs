using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_PART_CONDITIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASSIVE_PART_CONDITIONSController : Controller
{
    private readonly IMASSIVE_PART_CONDITIONSService _service;

    public MASSIVE_PART_CONDITIONSController(IMASSIVE_PART_CONDITIONSService service
    )
    {
        _service = service;
    }

    // GET: MASSIVE_PART_CONDITIONS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MASSIVE_PART_CONDITIONS/Index.cshtml");

    // GET: MASSIVE_PART_CONDITIONS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Details.cshtml", result);
    }

    // GET: MASSIVE_PART_CONDITIONS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Create.cshtml", new CreateMASSIVE_PART_CONDITIONSDto());
    }

    // POST: MASSIVE_PART_CONDITIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASSIVE_PART_CONDITIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Create.cshtml", createDto);
    }

    // GET: MASSIVE_PART_CONDITIONS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASSIVE_PART_CONDITIONSDto
        {
            NIDCONDI = result.NIDCONDI,
            SDESCRIPT = result.SDESCRIPT,
            SENABLED = result.SENABLED,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            STYP_CONDI = result.STYP_CONDI,
            NSECTION = result.NSECTION,
            NSHEET = result.NSHEET,
        };
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Edit.cshtml", updateDto);
    }

    // POST: MASSIVE_PART_CONDITIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateMASSIVE_PART_CONDITIONSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Edit.cshtml", updateDto);
    }

    // GET: MASSIVE_PART_CONDITIONS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_PART_CONDITIONS/Delete.cshtml", result);
    }

    // POST: MASSIVE_PART_CONDITIONS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
