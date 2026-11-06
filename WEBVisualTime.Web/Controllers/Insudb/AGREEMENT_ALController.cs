using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT_AL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class AGREEMENT_ALController : Controller
{
    private readonly IAGREEMENT_ALService _service;
    private readonly IUSERSService _USERSService;
    private readonly IINTERMEDIAService _INTERMEDIAService;

    public AGREEMENT_ALController(IAGREEMENT_ALService service
        , IUSERSService USERSService
        , IINTERMEDIAService INTERMEDIAService
    )
    {
        _service = service;
        _USERSService = USERSService;
        _INTERMEDIAService = INTERMEDIAService;
    }

    // GET: AGREEMENT_AL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/AGREEMENT_AL/Index.cshtml");

    // GET: AGREEMENT_AL/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGREEMENT_AL/Details.cshtml", result);
    }

    // GET: AGREEMENT_AL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/AGREEMENT_AL/Create.cshtml", new CreateAGREEMENT_ALDto());
    }

    // POST: AGREEMENT_AL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAGREEMENT_ALDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/AGREEMENT_AL/Create.cshtml", createDto);
    }

    // GET: AGREEMENT_AL/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateAGREEMENT_ALDto
        {
            NAGREEMENT = result.NAGREEMENT,
            SDESCRIPT = result.SDESCRIPT,
            DSTARTDATE = result.DSTARTDATE,
            DNULLDATE = result.DNULLDATE,
            SLEVELINT = result.SLEVELINT,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NAGREE_TYPE = result.NAGREE_TYPE,
            NINTERMED = result.NINTERMED,
        };
        await PopulateUSERSDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/AGREEMENT_AL/Edit.cshtml", updateDto);
    }

    // POST: AGREEMENT_AL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateAGREEMENT_ALDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NAGREEMENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/AGREEMENT_AL/Edit.cshtml", updateDto);
    }

    // GET: AGREEMENT_AL/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGREEMENT_AL/Delete.cshtml", result);
    }

    // POST: AGREEMENT_AL/Delete/{id}
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

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

}
