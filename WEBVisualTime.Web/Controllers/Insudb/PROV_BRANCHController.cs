using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROV_BRANCH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROV_BRANCHController : Controller
{
    private readonly IPROV_BRANCHService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE10Service _TABLE10Service;

    public PROV_BRANCHController(IPROV_BRANCHService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE10Service TABLE10Service
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE10Service = TABLE10Service;
    }

    // GET: PROV_BRANCH
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PROV_BRANCH/Index.cshtml");

    // GET: PROV_BRANCH/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROV_BRANCH/Details.cshtml", result);
    }

    // GET: PROV_BRANCH/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/PROV_BRANCH/Create.cshtml", new CreatePROV_BRANCHDto());
    }

    // POST: PROV_BRANCH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROV_BRANCHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/PROV_BRANCH/Create.cshtml", createDto);
    }

    // GET: PROV_BRANCH/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROV_BRANCHDto
        {
            NPROVIDER = result.NPROVIDER,
            NBRANCH = result.NBRANCH,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/PROV_BRANCH/Edit.cshtml", updateDto);
    }

    // POST: PROV_BRANCH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROV_BRANCHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/PROV_BRANCH/Edit.cshtml", updateDto);
    }

    // GET: PROV_BRANCH/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROV_BRANCH/Delete.cshtml", result);
    }

    // POST: PROV_BRANCH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

}
