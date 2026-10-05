using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FONASA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_FONASAController : Controller
{
    private readonly ITAB_FONASAService _service;
    private readonly IUSERSService _USERSService;

    public TAB_FONASAController(ITAB_FONASAService service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _USERSService = USERSService;
    }

    // GET: TAB_FONASA
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_FONASA/Index.cshtml", result);
    }

    // GET: TAB_FONASA/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_FONASA/Details.cshtml", result);
    }

    // GET: TAB_FONASA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TAB_FONASA/Create.cshtml", new CreateTAB_FONASADto());
    }

    // POST: TAB_FONASA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_FONASADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TAB_FONASA/Create.cshtml", createDto);
    }

    // GET: TAB_FONASA/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_FONASADto
        {
            NYEAR = result.NYEAR,
            SSERVICE = result.SSERVICE,
            SSUBSERVICE = result.SSUBSERVICE,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NAMOUNT = result.NAMOUNT,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
        };
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TAB_FONASA/Edit.cshtml", updateDto);
    }

    // POST: TAB_FONASA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_FONASADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NYEAR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TAB_FONASA/Edit.cshtml", updateDto);
    }

    // GET: TAB_FONASA/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_FONASA/Delete.cshtml", result);
    }

    // POST: TAB_FONASA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
