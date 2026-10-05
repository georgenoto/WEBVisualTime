using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_COM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FINANC_COMController : Controller
{
    private readonly IFINANC_COMService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly IUSERSService _USERSService;

    public FINANC_COMController(IFINANC_COMService service
        , IINTERMEDIAService INTERMEDIAService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _USERSService = USERSService;
    }

    // GET: FINANC_COM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/FINANC_COM/Index.cshtml", result);
    }

    // GET: FINANC_COM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_COM/Details.cshtml", result);
    }

    // GET: FINANC_COM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_COM/Create.cshtml", new CreateFINANC_COMDto());
    }

    // POST: FINANC_COM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFINANC_COMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_COM/Create.cshtml", createDto);
    }

    // GET: FINANC_COM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFINANC_COMDto
        {
            NAMOUNT = result.NAMOUNT,
            NRECEIPT = result.NRECEIPT,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NINTERMED = result.NINTERMED,
            NPERCENT = result.NPERCENT,
            NSHARE = result.NSHARE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_COM/Edit.cshtml", updateDto);
    }

    // POST: FINANC_COM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateFINANC_COMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRECEIPT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/FINANC_COM/Edit.cshtml", updateDto);
    }

    // GET: FINANC_COM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_COM/Delete.cshtml", result);
    }

    // POST: FINANC_COM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
