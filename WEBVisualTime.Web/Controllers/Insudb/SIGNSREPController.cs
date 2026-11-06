using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSREP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SIGNSREPController : Controller
{
    private readonly ISIGNSREPService _service;
    private readonly IUSERSService _USERSService;

    public SIGNSREPController(ISIGNSREPService service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _USERSService = USERSService;
    }

    // GET: SIGNSREP
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SIGNSREP/Index.cshtml");

    // GET: SIGNSREP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SIGNSREP/Details.cshtml", result);
    }

    // GET: SIGNSREP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSREP/Create.cshtml", new CreateSIGNSREPDto());
    }

    // POST: SIGNSREP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSIGNSREPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSREP/Create.cshtml", createDto);
    }

    // GET: SIGNSREP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSIGNSREPDto
        {
            NUSERSIGN = result.NUSERSIGN,
            DEFFECDATE = result.DEFFECDATE,
            SPOSITION = result.SPOSITION,
            SPATHSING = result.SPATHSING,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTATREG = result.SSTATREG,
        };
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSREP/Edit.cshtml", updateDto);
    }

    // POST: SIGNSREP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSIGNSREPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NUSERSIGN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/SIGNSREP/Edit.cshtml", updateDto);
    }

    // GET: SIGNSREP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SIGNSREP/Delete.cshtml", result);
    }

    // POST: SIGNSREP/Delete/{id}
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
        ViewData["NUSERSIGN"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
