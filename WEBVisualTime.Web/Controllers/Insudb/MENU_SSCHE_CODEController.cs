using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MENU_SSCHE_CODE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MENU_SSCHE_CODEController : Controller
{
    private readonly IMENU_SSCHE_CODEService _service;

    public MENU_SSCHE_CODEController(IMENU_SSCHE_CODEService service
    )
    {
        _service = service;
    }

    // GET: MENU_SSCHE_CODE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Index.cshtml", result);
    }

    // GET: MENU_SSCHE_CODE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Details.cshtml", result);
    }

    // GET: MENU_SSCHE_CODE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Create.cshtml", new CreateMENU_SSCHE_CODEDto());
    }

    // POST: MENU_SSCHE_CODE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMENU_SSCHE_CODEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Create.cshtml", createDto);
    }

    // GET: MENU_SSCHE_CODE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMENU_SSCHE_CODEDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            SCOD_LVL0 = result.SCOD_LVL0,
            SLVL0 = result.SLVL0,
            SCOD_LVL1 = result.SCOD_LVL1,
            SLVL1 = result.SLVL1,
            SCOD_LVL2 = result.SCOD_LVL2,
            SLVL2 = result.SLVL2,
            SCOD_LVL3 = result.SCOD_LVL3,
            SLVL3 = result.SLVL3,
            SCOD_LVL4 = result.SCOD_LVL4,
            SLVL4 = result.SLVL4,
            NCOUNT_LVL = result.NCOUNT_LVL,
            SPERMITTED = result.SPERMITTED,
            DCOMPDATE = result.DCOMPDATE,
            NORDER = result.NORDER,
        };
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Edit.cshtml", updateDto);
    }

    // POST: MENU_SSCHE_CODE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMENU_SSCHE_CODEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Edit.cshtml", updateDto);
    }

    // GET: MENU_SSCHE_CODE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MENU_SSCHE_CODE/Delete.cshtml", result);
    }

    // POST: MENU_SSCHE_CODE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
