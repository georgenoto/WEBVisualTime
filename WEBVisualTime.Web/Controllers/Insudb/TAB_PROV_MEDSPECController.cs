using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_MEDSPEC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_MEDSPECController : Controller
{
    private readonly ITAB_PROV_MEDSPECService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE8603Service _TABLE8603Service;

    public TAB_PROV_MEDSPECController(ITAB_PROV_MEDSPECService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE8603Service TABLE8603Service
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE8603Service = TABLE8603Service;
    }

    // GET: TAB_PROV_MEDSPEC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_MEDSPEC/Index.cshtml");

    // GET: TAB_PROV_MEDSPEC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Details.cshtml", result);
    }

    // GET: TAB_PROV_MEDSPEC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Create.cshtml", new CreateTAB_PROV_MEDSPECDto());
    }

    // POST: TAB_PROV_MEDSPEC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_MEDSPECDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_MEDSPEC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_MEDSPECDto
        {
            NPROVIDER = result.NPROVIDER,
            SMEDSPECIALIALTY = result.SMEDSPECIALIALTY,
            NMAIN_MEDSPECIALIALTY = result.NMAIN_MEDSPECIALIALTY,
            SREG_MEDICALPROF = result.SREG_MEDICALPROF,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_MEDSPEC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTAB_PROV_MEDSPECDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_MEDSPEC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_MEDSPEC/Delete.cshtml", result);
    }

    // POST: TAB_PROV_MEDSPEC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE8603DropdownAsync()
    {
        var items = await _TABLE8603Service.GetAllAsync();
        ViewData["SMEDSPECIALIALTY"] = new SelectList(items, nameof(TABLE8603Dto.SMEDSPECIALIALTY), "SDESCRIPT");
    }

}
