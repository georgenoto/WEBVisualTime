using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RNULLCONDI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7505;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RNULLCONDIController : Controller
{
    private readonly IRNULLCONDIService _service;
    private readonly ITABLE95Service _TABLE95Service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE7505Service _TABLE7505Service;

    public RNULLCONDIController(IRNULLCONDIService service
        , ITABLE95Service TABLE95Service
        , ITABLE10Service TABLE10Service
        , ITABLE7505Service TABLE7505Service
    )
    {
        _service = service;
        _TABLE95Service = TABLE95Service;
        _TABLE10Service = TABLE10Service;
        _TABLE7505Service = TABLE7505Service;
    }

    // GET: RNULLCONDI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/RNULLCONDI/Index.cshtml");

    // GET: RNULLCONDI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RNULLCONDI/Details.cshtml", result);
    }

    // GET: RNULLCONDI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE7505DropdownAsync();
        return View("~/Views/Insudb/RNULLCONDI/Create.cshtml", new CreateRNULLCONDIDto());
    }

    // POST: RNULLCONDI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRNULLCONDIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE7505DropdownAsync();
        return View("~/Views/Insudb/RNULLCONDI/Create.cshtml", createDto);
    }

    // GET: RNULLCONDI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRNULLCONDIDto
        {
            NNULLCODE = result.NNULLCODE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SPOLITYPE = result.SPOLITYPE,
            NTRATYPEI = result.NTRATYPEI,
            SPOLICY = result.SPOLICY,
            SCERTIF = result.SCERTIF,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
        };
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE7505DropdownAsync();
        return View("~/Views/Insudb/RNULLCONDI/Edit.cshtml", updateDto);
    }

    // POST: RNULLCONDI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateRNULLCONDIDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE7505DropdownAsync();
        return View("~/Views/Insudb/RNULLCONDI/Edit.cshtml", updateDto);
    }

    // GET: RNULLCONDI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RNULLCONDI/Delete.cshtml", result);
    }

    // POST: RNULLCONDI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE95DropdownAsync()
    {
        var items = await _TABLE95Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE95Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE7505DropdownAsync()
    {
        var items = await _TABLE7505Service.GetAllAsync();
        ViewData["SPOLICY"] = new SelectList(items, nameof(TABLE7505Dto.SNULLACTION), "SDESCRIPT");
        ViewData["SCERTIF"] = new SelectList(items, nameof(TABLE7505Dto.SNULLACTION), "SDESCRIPT");
    }

}
