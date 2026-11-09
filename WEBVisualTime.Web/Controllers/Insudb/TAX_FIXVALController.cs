using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAX_FIXVAL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAX_FIXVALController : Controller
{
    private readonly ITAX_FIXVALService _service;
    private readonly ITABLE5602Service _TABLE5602Service;
    private readonly ITABLE5570Service _TABLE5570Service;

    public TAX_FIXVALController(ITAX_FIXVALService service
        , ITABLE5602Service TABLE5602Service
        , ITABLE5570Service TABLE5570Service
    )
    {
        _service = service;
        _TABLE5602Service = TABLE5602Service;
        _TABLE5570Service = TABLE5570Service;
    }

    // GET: TAX_FIXVAL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAX_FIXVAL/Index.cshtml");

    // GET: TAX_FIXVAL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAX_FIXVAL/Details.cshtml", result);
    }

    // GET: TAX_FIXVAL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5602DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/TAX_FIXVAL/Create.cshtml", new CreateTAX_FIXVALDto());
    }

    // POST: TAX_FIXVAL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAX_FIXVALDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5602DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/TAX_FIXVAL/Create.cshtml", createDto);
    }

    // GET: TAX_FIXVAL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAX_FIXVALDto
        {
            NCODE = result.NCODE,
            STYPETAX = result.STYPETAX,
            NTYPESUPPORT = result.NTYPESUPPORT,
            DEFFECDATE = result.DEFFECDATE,
            NPERCENT = result.NPERCENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
            SDESCRIPT = result.SDESCRIPT,
            NBRANCH = result.NBRANCH,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
        };
        await PopulateTABLE5602DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/TAX_FIXVAL/Edit.cshtml", updateDto);
    }

    // POST: TAX_FIXVAL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTAX_FIXVALDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5602DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/TAX_FIXVAL/Edit.cshtml", updateDto);
    }

    // GET: TAX_FIXVAL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAX_FIXVAL/Delete.cshtml", result);
    }

    // POST: TAX_FIXVAL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5602DropdownAsync()
    {
        var items = await _TABLE5602Service.GetAllAsync();
        ViewData["STYPETAX"] = new SelectList(items, nameof(TABLE5602Dto.STYPETAX), "SDESCRIPT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NTYPESUPPORT"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

}
