using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9218;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9218;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9218Controller : Controller
{
    private readonly ITABLE9218Service _service;
    private readonly ITABLE9218Service _TABLE9218Service;
    private readonly IUSERSService _USERSService;

    public TABLE9218Controller(ITABLE9218Service service
        , ITABLE9218Service TABLE9218Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TABLE9218Service = TABLE9218Service;
        _USERSService = USERSService;
    }

    // GET: TABLE9218
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TABLE9218/Index.cshtml");

    // GET: TABLE9218/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9218/Details.cshtml", result);
    }

    // GET: TABLE9218/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9218DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9218/Create.cshtml", new CreateTABLE9218Dto());
    }

    // POST: TABLE9218/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE9218Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9218DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9218/Create.cshtml", createDto);
    }

    // GET: TABLE9218/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE9218Dto
        {
            NIDSTATPRECLAIM = result.NIDSTATPRECLAIM,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE9218DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9218/Edit.cshtml", updateDto);
    }

    // POST: TABLE9218/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE9218Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDSTATPRECLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9218DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9218/Edit.cshtml", updateDto);
    }

    // GET: TABLE9218/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9218/Delete.cshtml", result);
    }

    // POST: TABLE9218/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TABLE9218/GetByNUSERCODE?NUSERCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNUSERCODE(int NUSERCODE)
    {
        var items = await _service.FindAsync(p => p.NUSERCODE == NUSERCODE);
        return Json(items.Select(i => new { value = i.NIDSTATPRECLAIM, text = i.SDESCRIPT }));
    }

    private async Task PopulateTABLE9218DropdownAsync()
    {
        var items = await _TABLE9218Service.GetAllAsync();
        ViewData["NIDSTATPRECLAIM"] = new SelectList(items, nameof(TABLE9218Dto.NIDSTATPRECLAIM), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
