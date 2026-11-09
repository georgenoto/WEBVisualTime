using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSCAPOFF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SIGNSCAPOFFController : Controller
{
    private readonly ISIGNSCAPOFFService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly IUSERSService _USERSService;

    public SIGNSCAPOFFController(ISIGNSCAPOFFService service
        , ITABLE10Service TABLE10Service
        , ITABLE9Service TABLE9Service
        , ITABLE11Service TABLE11Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _TABLE9Service = TABLE9Service;
        _TABLE11Service = TABLE11Service;
        _USERSService = USERSService;
    }

    // GET: SIGNSCAPOFF
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SIGNSCAPOFF/Index.cshtml");

    // GET: SIGNSCAPOFF/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SIGNSCAPOFF/Details.cshtml", result);
    }

    // GET: SIGNSCAPOFF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSCAPOFF/Create.cshtml", new CreateSIGNSCAPOFFDto());
    }

    // POST: SIGNSCAPOFF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSIGNSCAPOFFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSCAPOFF/Create.cshtml", createDto);
    }

    // GET: SIGNSCAPOFF/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSIGNSCAPOFFDto
        {
            NBRANCH = result.NBRANCH,
            NOFFICE = result.NOFFICE,
            NCURRENCY = result.NCURRENCY,
            NUSERSIGN = result.NUSERSIGN,
            NORDSIGN = result.NORDSIGN,
            NCAPMINSING = result.NCAPMINSING,
            NCAPMAXSING = result.NCAPMAXSING,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTATREG = result.SSTATREG,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSCAPOFF/Edit.cshtml", updateDto);
    }

    // POST: SIGNSCAPOFF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateSIGNSCAPOFFDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSCAPOFF/Edit.cshtml", updateDto);
    }

    // GET: SIGNSCAPOFF/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SIGNSCAPOFF/Delete.cshtml", result);
    }

    // POST: SIGNSCAPOFF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERSIGN"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
