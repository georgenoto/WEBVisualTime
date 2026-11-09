using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DETAIL_PRE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DETAIL_PREController : Controller
{
    private readonly IDETAIL_PREService _service;
    private readonly IPREMIUMService _PREMIUMService;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE9207Service _TABLE9207Service;

    public DETAIL_PREController(IDETAIL_PREService service
        , IPREMIUMService PREMIUMService
        , ITABLE71Service TABLE71Service
        , ITABLE75Service TABLE75Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE9207Service TABLE9207Service
    )
    {
        _service = service;
        _PREMIUMService = PREMIUMService;
        _TABLE71Service = TABLE71Service;
        _TABLE75Service = TABLE75Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE9207Service = TABLE9207Service;
    }

    // GET: DETAIL_PRE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DETAIL_PRE/Index.cshtml");

    // GET: DETAIL_PRE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DETAIL_PRE/Details.cshtml", result);
    }

    // GET: DETAIL_PRE/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/DETAIL_PRE/Create.cshtml", new CreateDETAIL_PREDto());
    }

    // POST: DETAIL_PRE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDETAIL_PREDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/DETAIL_PRE/Create.cshtml", createDto);
    }

    // GET: DETAIL_PRE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDETAIL_PREDto
        {
            NPRODUCT = result.NPRODUCT,
            NRECEIPT = result.NRECEIPT,
            NBRANCH = result.NBRANCH,
            SCERTYPE = result.SCERTYPE,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NID_BILL = result.NID_BILL,
            SADDSUINI = result.SADDSUINI,
            STYPE_DETAI = result.STYPE_DETAI,
            NDET_CODE = result.NDET_CODE,
            DCOMPDATE = result.DCOMPDATE,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            NPREMIUM = result.NPREMIUM,
            NTAX = result.NTAX,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            NUSERCODE = result.NUSERCODE,
            NPREMANUAL = result.NPREMANUAL,
            SADDTAX = result.SADDTAX,
            NCOMANUAL = result.NCOMANUAL,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NREL_IDCODE = result.NREL_IDCODE,
            NSTIPEND_AMOUNT = result.NSTIPEND_AMOUNT,
            NSTIPEND_ANNUAL = result.NSTIPEND_ANNUAL,
            NTAXRATE = result.NTAXRATE,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
            NCOM_SUPER = result.NCOM_SUPER,
            NCOMANUAL_SUPER = result.NCOMANUAL_SUPER,
            NCOMSUP_RATE = result.NCOMSUP_RATE,
        };
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/DETAIL_PRE/Edit.cshtml", updateDto);
    }

    // POST: DETAIL_PRE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateDETAIL_PREDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/DETAIL_PRE/Edit.cshtml", updateDto);
    }

    // GET: DETAIL_PRE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DETAIL_PRE/Delete.cshtml", result);
    }

    // POST: DETAIL_PRE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePREMIUMDropdownAsync()
    {
        var items = await _PREMIUMService.GetAllAsync();
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PREMIUMDto.NPRODUCT), "SCESSIONS");
        ViewData["NRECEIPT"] = new SelectList(items, nameof(PREMIUMDto.NRECEIPT), "SCESSIONS");
        ViewData["NBRANCH"] = new SelectList(items, nameof(PREMIUMDto.NBRANCH), "SCESSIONS");
        ViewData["SCERTYPE"] = new SelectList(items, nameof(PREMIUMDto.SCERTYPE), "SCESSIONS");
        ViewData["NDIGIT"] = new SelectList(items, nameof(PREMIUMDto.NDIGIT), "SCESSIONS");
        ViewData["NPAYNUMBE"] = new SelectList(items, nameof(PREMIUMDto.NPAYNUMBE), "SCESSIONS");
    }

    private async Task PopulateTABLE71DropdownAsync()
    {
        var items = await _TABLE71Service.GetAllAsync();
        ViewData["NBRANCH_EST"] = new SelectList(items, nameof(TABLE71Dto.NBRANCH_EST), "SDESCRIPT");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE9207DropdownAsync()
    {
        var items = await _TABLE9207Service.GetAllAsync();
        ViewData["NDISSUR_TYPE"] = new SelectList(items, nameof(TABLE9207Dto.NDISSUR_TYPE), "SDESCRIPT");
    }

}
