using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_VOUCHER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETT_VOUCHERController : Controller
{
    private readonly ICLAIM_SETT_VOUCHERService _service;
    private readonly ICLAIM_SETTLEMENTService _CLAIM_SETTLEMENTService;
    private readonly ICLAIM_VOUCHERService _CLAIM_VOUCHERService;
    private readonly ITABLE9254Service _TABLE9254Service;

    public CLAIM_SETT_VOUCHERController(ICLAIM_SETT_VOUCHERService service
        , ICLAIM_SETTLEMENTService CLAIM_SETTLEMENTService
        , ICLAIM_VOUCHERService CLAIM_VOUCHERService
        , ITABLE9254Service TABLE9254Service
    )
    {
        _service = service;
        _CLAIM_SETTLEMENTService = CLAIM_SETTLEMENTService;
        _CLAIM_VOUCHERService = CLAIM_VOUCHERService;
        _TABLE9254Service = TABLE9254Service;
    }

    // GET: CLAIM_SETT_VOUCHER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_SETT_VOUCHER/Index.cshtml");

    // GET: CLAIM_SETT_VOUCHER/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Details.cshtml", result);
    }

    // GET: CLAIM_SETT_VOUCHER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateCLAIM_VOUCHERDropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Create.cshtml", new CreateCLAIM_SETT_VOUCHERDto());
    }

    // POST: CLAIM_SETT_VOUCHER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETT_VOUCHERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateCLAIM_VOUCHERDropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETT_VOUCHER/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETT_VOUCHERDto
        {
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NCLAIM_VOUCHER = result.NCLAIM_VOUCHER,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NAMOUNT_TOTAL = result.NAMOUNT_TOTAL,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NAMOUNT_VAT = result.NAMOUNT_VAT,
            NAMOUNT_FTT = result.NAMOUNT_FTT,
            NAMOUNT_AGREE = result.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = result.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = result.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = result.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = result.NAMOUNT_FTT_LOSS,
            NTYPEDISC_PROV = result.NTYPEDISC_PROV,
            NAMOUNT_BASE = result.NAMOUNT_BASE,
            NAGREE_DISCOUNT = result.NAGREE_DISCOUNT,
        };
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateCLAIM_VOUCHERDropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETT_VOUCHER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLAIM_SETT_VOUCHERDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateCLAIM_VOUCHERDropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETT_VOUCHER/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_VOUCHER/Delete.cshtml", result);
    }

    // POST: CLAIM_SETT_VOUCHER/Delete/{id}
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

    private async Task PopulateCLAIM_VOUCHERDropdownAsync()
    {
        var items = await _CLAIM_VOUCHERService.GetAllAsync();
        ViewData["NCLAIM_VOUCHER"] = new SelectList(items, nameof(CLAIM_VOUCHERDto.NCLAIM_VOUCHER), "SCLINUMDOCU");
    }

    private async Task PopulateTABLE9254DropdownAsync()
    {
        var items = await _TABLE9254Service.GetAllAsync();
        ViewData["NTYPEDISC_PROV"] = new SelectList(items, nameof(TABLE9254Dto.NTYPEDISC_PROV), "SDESCRIPT");
    }

}
