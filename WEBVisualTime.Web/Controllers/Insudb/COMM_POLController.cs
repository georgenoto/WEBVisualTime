using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_POL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5567;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5568;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMM_POLController : Controller
{
    private readonly ICOMM_POLService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5567Service _TABLE5567Service;
    private readonly ITABLE5568Service _TABLE5568Service;
    private readonly ITABLE24Service _TABLE24Service;
    private readonly ITABLE6Service _TABLE6Service;

    public COMM_POLController(ICOMM_POLService service
        , IINTERMEDIAService INTERMEDIAService
        , ICERTIFICATService CERTIFICATService
        , ITABLE5567Service TABLE5567Service
        , ITABLE5568Service TABLE5568Service
        , ITABLE24Service TABLE24Service
        , ITABLE6Service TABLE6Service
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5567Service = TABLE5567Service;
        _TABLE5568Service = TABLE5568Service;
        _TABLE24Service = TABLE24Service;
        _TABLE6Service = TABLE6Service;
    }

    // GET: COMM_POL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMM_POL/Index.cshtml");

    // GET: COMM_POL/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMM_POL/Details.cshtml", result);
    }

    // GET: COMM_POL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5567DropdownAsync();
        await PopulateTABLE5568DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/COMM_POL/Create.cshtml", new CreateCOMM_POLDto());
    }

    // POST: COMM_POL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMM_POLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5567DropdownAsync();
        await PopulateTABLE5568DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/COMM_POL/Create.cshtml", createDto);
    }

    // GET: COMM_POL/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMM_POLDto
        {
            NINTERMED = result.NINTERMED,
            NCURRENCY = result.NCURRENCY,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NID = result.NID,
            NTYPMOV_COMM = result.NTYPMOV_COMM,
            STYP_COMM = result.STYP_COMM,
            NTOTAL_COM = result.NTOTAL_COM,
            NINSTALLMENTS = result.NINSTALLMENTS,
            NPEN_INSTALL = result.NPEN_INSTALL,
            NINSTALL_AMO = result.NINSTALL_AMO,
            NPAY_COMM = result.NPAY_COMM,
            NCURR_ACC = result.NCURR_ACC,
            NAVAILABLE = result.NAVAILABLE,
            NAVAIL_AFEC = result.NAVAIL_AFEC,
            NAVAIL_EXEN = result.NAVAIL_EXEN,
            DEFFECDATE = result.DEFFECDATE,
            NSTATUS_COMM = result.NSTATUS_COMM,
            STYPEDOCU = result.STYPEDOCU,
            NDOCUMENT = result.NDOCUMENT,
            NDRAFT = result.NDRAFT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTRATYPEI = result.NTRATYPEI,
            NTYPE = result.NTYPE,
            NTRANSAC = result.NTRANSAC,
            NMAINYEAR_COMM = result.NMAINYEAR_COMM,
            NRECEIPT = result.NRECEIPT,
            NPERCADV_PAY = result.NPERCADV_PAY,
            DACCRUALDATE = result.DACCRUALDATE,
            NPREMIUMN_AN = result.NPREMIUMN_AN,
            NPREMIUM_AN = result.NPREMIUM_AN,
            NBALANCE = result.NBALANCE,
            SIND_DESC = result.SIND_DESC,
            SIND_BALANCE = result.SIND_BALANCE,
            NCOD_SALDIS = result.NCOD_SALDIS,
            NCATEGORY = result.NCATEGORY,
            NID_CAMPAIGN = result.NID_CAMPAIGN,
            DDATEEND_CAMP = result.DDATEEND_CAMP,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5567DropdownAsync();
        await PopulateTABLE5568DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/COMM_POL/Edit.cshtml", updateDto);
    }

    // POST: COMM_POL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMM_POLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERMED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5567DropdownAsync();
        await PopulateTABLE5568DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/COMM_POL/Edit.cshtml", updateDto);
    }

    // GET: COMM_POL/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMM_POL/Delete.cshtml", result);
    }

    // POST: COMM_POL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE5567DropdownAsync()
    {
        var items = await _TABLE5567Service.GetAllAsync();
        ViewData["NTYPMOV_COMM"] = new SelectList(items, nameof(TABLE5567Dto.NTYPMOV_COMM), "SDESCRIPT");
    }

    private async Task PopulateTABLE5568DropdownAsync()
    {
        var items = await _TABLE5568Service.GetAllAsync();
        ViewData["NSTATUS_COMM"] = new SelectList(items, nameof(TABLE5568Dto.NSTATUS_COMM), "SDESCRIPT");
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
    }

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

}
