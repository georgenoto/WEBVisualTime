using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9248;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9247;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_VOUCHERController : Controller
{
    private readonly ICLAIM_VOUCHERService _service;
    private readonly ITABLE9248Service _TABLE9248Service;
    private readonly ITABLE9247Service _TABLE9247Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;

    public CLAIM_VOUCHERController(ICLAIM_VOUCHERService service
        , ITABLE9248Service TABLE9248Service
        , ITABLE9247Service TABLE9247Service
        , ITAB_PROVIDERService TAB_PROVIDERService
    )
    {
        _service = service;
        _TABLE9248Service = TABLE9248Service;
        _TABLE9247Service = TABLE9247Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
    }

    // GET: CLAIM_VOUCHER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_VOUCHER/Index.cshtml");

    // GET: CLAIM_VOUCHER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Details.cshtml", result);
    }

    // GET: CLAIM_VOUCHER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9248DropdownAsync();
        await PopulateTABLE9247DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Create.cshtml", new CreateCLAIM_VOUCHERDto());
    }

    // POST: CLAIM_VOUCHER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_VOUCHERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9248DropdownAsync();
        await PopulateTABLE9247DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Create.cshtml", createDto);
    }

    // GET: CLAIM_VOUCHER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_VOUCHERDto
        {
            NCLAIM_VOUCHER = result.NCLAIM_VOUCHER,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            SCLINUMDOCU = result.SCLINUMDOCU,
            DISSUEDAT = result.DISSUEDAT,
            SELECTRONIC_DOC = result.SELECTRONIC_DOC,
            SSENDER_NAME = result.SSENDER_NAME,
            SCUF_NUMBER = result.SCUF_NUMBER,
            SVOUCHER_SERIES = result.SVOUCHER_SERIES,
            NVOUCHER_NUM = result.NVOUCHER_NUM,
            SCONTROL_CODE = result.SCONTROL_CODE,
            NSTATUS = result.NSTATUS,
            SOBSERV = result.SOBSERV,
            NAMOUNT_DOCU = result.NAMOUNT_DOCU,
            NEXCHANGE = result.NEXCHANGE,
            NBALANCE = result.NBALANCE,
            NCURRENCY = result.NCURRENCY,
            NFOREIGNDOCTYPE = result.NFOREIGNDOCTYPE,
            NPROVIDER = result.NPROVIDER,
            SCLIENT = result.SCLIENT,
            NNOTENUM = result.NNOTENUM,
            NSEQUENCE_ID = result.NSEQUENCE_ID,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCODIGINT = result.NCODIGINT,
            NAMOUNT_VAT = result.NAMOUNT_VAT,
            NAMOUNT_FTT = result.NAMOUNT_FTT,
            NAMOUNT_VAT_RATE = result.NAMOUNT_VAT_RATE,
            NAMOUNT_FTT_RATE = result.NAMOUNT_FTT_RATE,
            NAMOUNT_BASE = result.NAMOUNT_BASE,
        };
        await PopulateTABLE9248DropdownAsync();
        await PopulateTABLE9247DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_VOUCHER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_VOUCHERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM_VOUCHER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9248DropdownAsync();
        await PopulateTABLE9247DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_VOUCHER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_VOUCHER/Delete.cshtml", result);
    }

    // POST: CLAIM_VOUCHER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9248DropdownAsync()
    {
        var items = await _TABLE9248Service.GetAllAsync();
        ViewData["NSTATUS"] = new SelectList(items, nameof(TABLE9248Dto.NSTATUS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9247DropdownAsync()
    {
        var items = await _TABLE9247Service.GetAllAsync();
        ViewData["NFOREIGNDOCTYPE"] = new SelectList(items, nameof(TABLE9247Dto.NFOREIGNDOCTYPE), "SDESCRIPT");
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

}
