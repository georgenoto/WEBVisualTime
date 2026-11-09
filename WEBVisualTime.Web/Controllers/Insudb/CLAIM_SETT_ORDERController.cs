using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_ORDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETT_ORDERController : Controller
{
    private readonly ICLAIM_SETT_ORDERService _service;
    private readonly ICLAIM_SETTLEMENTService _CLAIM_SETTLEMENTService;

    public CLAIM_SETT_ORDERController(ICLAIM_SETT_ORDERService service
        , ICLAIM_SETTLEMENTService CLAIM_SETTLEMENTService
    )
    {
        _service = service;
        _CLAIM_SETTLEMENTService = CLAIM_SETTLEMENTService;
    }

    // GET: CLAIM_SETT_ORDER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_SETT_ORDER/Index.cshtml");

    // GET: CLAIM_SETT_ORDER/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Details.cshtml", result);
    }

    // GET: CLAIM_SETT_ORDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Create.cshtml", new CreateCLAIM_SETT_ORDERDto());
    }

    // POST: CLAIM_SETT_ORDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETT_ORDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETT_ORDER/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETT_ORDERDto
        {
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NORDER_NUM = result.NORDER_NUM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NAMOUNT_ORDEN = result.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = result.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = result.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NAMOUNT_VAT = result.NAMOUNT_VAT,
            NAMOUNT_FTT = result.NAMOUNT_FTT,
            NAMOUNT_AGREE = result.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = result.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = result.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = result.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = result.NAMOUNT_FTT_LOSS,
            NAMOUNT_BASE = result.NAMOUNT_BASE,
        };
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETT_ORDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLAIM_SETT_ORDERDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETT_ORDER/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_ORDER/Delete.cshtml", result);
    }

    // POST: CLAIM_SETT_ORDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_SETTLEMENTDropdownAsync()
    {
        var items = await _CLAIM_SETTLEMENTService.GetAllAsync();
        ViewData["NSETTLEMENT_NUM"] = new SelectList(items, nameof(CLAIM_SETTLEMENTDto.NSETTLEMENT_NUM), "SCLIENT2");
    }

}
