using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPESUBTYPE_RELATIONSHIP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TYPESUBTYPE_RELATIONSHIPController : Controller
{
    private readonly ITYPESUBTYPE_RELATIONSHIPService _service;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ITABLE8605Service _TABLE8605Service;
    private readonly IUSERSService _USERSService;

    public TYPESUBTYPE_RELATIONSHIPController(ITYPESUBTYPE_RELATIONSHIPService service
        , ITABLE8604Service TABLE8604Service
        , ITABLE8605Service TABLE8605Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TABLE8604Service = TABLE8604Service;
        _TABLE8605Service = TABLE8605Service;
        _USERSService = USERSService;
    }

    // GET: TYPESUBTYPE_RELATIONSHIP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Index.cshtml", result);
    }

    // GET: TYPESUBTYPE_RELATIONSHIP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Details.cshtml", result);
    }

    // GET: TYPESUBTYPE_RELATIONSHIP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Create.cshtml", new CreateTYPESUBTYPE_RELATIONSHIPDto());
    }

    // POST: TYPESUBTYPE_RELATIONSHIP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTYPESUBTYPE_RELATIONSHIPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Create.cshtml", createDto);
    }

    // GET: TYPESUBTYPE_RELATIONSHIP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTYPESUBTYPE_RELATIONSHIPDto
        {
            STYPECARE = result.STYPECARE,
            SCARECLASS = result.SCARECLASS,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Edit.cshtml", updateDto);
    }

    // POST: TYPESUBTYPE_RELATIONSHIP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTYPESUBTYPE_RELATIONSHIPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STYPECARE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Edit.cshtml", updateDto);
    }

    // GET: TYPESUBTYPE_RELATIONSHIP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPESUBTYPE_RELATIONSHIP/Delete.cshtml", result);
    }

    // POST: TYPESUBTYPE_RELATIONSHIP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateTABLE8605DropdownAsync()
    {
        var items = await _TABLE8605Service.GetAllAsync();
        ViewData["SCARECLASS"] = new SelectList(items, nameof(TABLE8605Dto.SCARECLASS), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
