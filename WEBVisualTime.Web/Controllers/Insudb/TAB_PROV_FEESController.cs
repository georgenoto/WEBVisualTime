using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_FEES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_ZONE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8601;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_FEESController : Controller
{
    private readonly ITAB_PROV_FEESService _service;
    private readonly ITAB_PROV_ZONEService _TAB_PROV_ZONEService;
    private readonly ITABLE8600Service _TABLE8600Service;
    private readonly ITABLE8601Service _TABLE8601Service;

    public TAB_PROV_FEESController(ITAB_PROV_FEESService service
        , ITAB_PROV_ZONEService TAB_PROV_ZONEService
        , ITABLE8600Service TABLE8600Service
        , ITABLE8601Service TABLE8601Service
    )
    {
        _service = service;
        _TAB_PROV_ZONEService = TAB_PROV_ZONEService;
        _TABLE8600Service = TABLE8600Service;
        _TABLE8601Service = TABLE8601Service;
    }

    // GET: TAB_PROV_FEES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_FEES/Index.cshtml");

    // GET: TAB_PROV_FEES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_FEES/Details.cshtml", result);
    }

    // GET: TAB_PROV_FEES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROV_ZONEDropdownAsync();
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE8601DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_FEES/Create.cshtml", new CreateTAB_PROV_FEESDto());
    }

    // POST: TAB_PROV_FEES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_FEESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROV_ZONEDropdownAsync();
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE8601DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_FEES/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_FEES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_FEESDto
        {
            NPROVIDER = result.NPROVIDER,
            NZONE = result.NZONE,
            STYPEBENEFIT = result.STYPEBENEFIT,
            SBENEFITCLAS = result.SBENEFITCLAS,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NDISC_FEE = result.NDISC_FEE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_PROV_ZONEDropdownAsync();
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE8601DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_FEES/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_FEES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_FEESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROV_ZONEDropdownAsync();
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE8601DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_FEES/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_FEES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_FEES/Delete.cshtml", result);
    }

    // POST: TAB_PROV_FEES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROV_ZONEDropdownAsync()
    {
        var items = await _TAB_PROV_ZONEService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROV_ZONEDto.NPROVIDER), "NPROVIDER");
        ViewData["NZONE"] = new SelectList(items, nameof(TAB_PROV_ZONEDto.NZONE), "NPROVIDER");
    }

    private async Task PopulateTABLE8600DropdownAsync()
    {
        var items = await _TABLE8600Service.GetAllAsync();
        ViewData["STYPEBENEFIT"] = new SelectList(items, nameof(TABLE8600Dto.STYPEBENEFIT), "SDESCRIPT");
    }

    private async Task PopulateTABLE8601DropdownAsync()
    {
        var items = await _TABLE8601Service.GetAllAsync();
        ViewData["SBENEFITCLAS"] = new SelectList(items, nameof(TABLE8601Dto.SBENEFITCLAS), "SDESCRIPT");
    }

}
