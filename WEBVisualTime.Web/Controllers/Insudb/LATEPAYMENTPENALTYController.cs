using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LATEPAYMENTPENALTY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LATEPAYMENTPENALTYController : Controller
{
    private readonly ILATEPAYMENTPENALTYService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly IPRODMASTERService _PRODMASTERService;

    public LATEPAYMENTPENALTYController(ILATEPAYMENTPENALTYService service
        , ITABLE10Service TABLE10Service
        , IPRODMASTERService PRODMASTERService
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _PRODMASTERService = PRODMASTERService;
    }

    // GET: LATEPAYMENTPENALTY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LATEPAYMENTPENALTY/Index.cshtml");

    // GET: LATEPAYMENTPENALTY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Details.cshtml", result);
    }

    // GET: LATEPAYMENTPENALTY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Create.cshtml", new CreateLATEPAYMENTPENALTYDto());
    }

    // POST: LATEPAYMENTPENALTY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLATEPAYMENTPENALTYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Create.cshtml", createDto);
    }

    // GET: LATEPAYMENTPENALTY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLATEPAYMENTPENALTYDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NDAY_INI = result.NDAY_INI,
            DEFFECTDATE = result.DEFFECTDATE,
            NDAY_END = result.NDAY_END,
            NDAYSPENALTY = result.NDAYSPENALTY,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Edit.cshtml", updateDto);
    }

    // POST: LATEPAYMENTPENALTY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLATEPAYMENTPENALTYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Edit.cshtml", updateDto);
    }

    // GET: LATEPAYMENTPENALTY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LATEPAYMENTPENALTY/Delete.cshtml", result);
    }

    // POST: LATEPAYMENTPENALTY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulatePRODMASTERDropdownAsync()
    {
        var items = await _PRODMASTERService.GetAllAsync();
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PRODMASTERDto.NPRODUCT), "SDESCRIPT");
    }

}
