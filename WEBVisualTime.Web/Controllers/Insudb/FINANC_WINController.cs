using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_WIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FINANC_WINController : Controller
{
    private readonly IFINANC_WINService _service;
    private readonly IUSERSService _USERSService;

    public FINANC_WINController(IFINANC_WINService service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _USERSService = USERSService;
    }

    // GET: FINANC_WIN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/FINANC_WIN/Index.cshtml", result);
    }

    // GET: FINANC_WIN/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_WIN/Details.cshtml", result);
    }

    // GET: FINANC_WIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_WIN/Create.cshtml", new CreateFINANC_WINDto());
    }

    // POST: FINANC_WIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFINANC_WINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_WIN/Create.cshtml", createDto);
    }

    // GET: FINANC_WIN/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFINANC_WINDto
        {
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NUSERCODE = result.NUSERCODE,
            SV_CONCONTR = result.SV_CONCONTR,
            SV_WINCONTR = result.SV_WINCONTR,
        };
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_WIN/Edit.cshtml", updateDto);
    }

    // POST: FINANC_WIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateFINANC_WINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONTRAT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_WIN/Edit.cshtml", updateDto);
    }

    // GET: FINANC_WIN/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_WIN/Delete.cshtml", result);
    }

    // POST: FINANC_WIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
