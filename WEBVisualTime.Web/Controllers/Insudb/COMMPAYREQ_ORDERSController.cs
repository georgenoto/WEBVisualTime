using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMPAYREQ_ORDERSController : Controller
{
    private readonly ICOMMPAYREQ_ORDERSService _service;
    private readonly ICOMMPAYMENTREQUESTSService _COMMPAYMENTREQUESTSService;
    private readonly ICLAIM_ORDERService _CLAIM_ORDERService;
    private readonly IMASTERCL_ORDERService _MASTERCL_ORDERService;
    private readonly ITABLE9265Service _TABLE9265Service;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9241Service _TABLE9241Service;

    public COMMPAYREQ_ORDERSController(ICOMMPAYREQ_ORDERSService service
        , ICOMMPAYMENTREQUESTSService COMMPAYMENTREQUESTSService
        , ICLAIM_ORDERService CLAIM_ORDERService
        , IMASTERCL_ORDERService MASTERCL_ORDERService
        , ITABLE9265Service TABLE9265Service
        , ITABLE8604Service TABLE8604Service
        , ITABLE11Service TABLE11Service
        , IUSERSService USERSService
        , ITABLE9241Service TABLE9241Service
    )
    {
        _service = service;
        _COMMPAYMENTREQUESTSService = COMMPAYMENTREQUESTSService;
        _CLAIM_ORDERService = CLAIM_ORDERService;
        _MASTERCL_ORDERService = MASTERCL_ORDERService;
        _TABLE9265Service = TABLE9265Service;
        _TABLE8604Service = TABLE8604Service;
        _TABLE11Service = TABLE11Service;
        _USERSService = USERSService;
        _TABLE9241Service = TABLE9241Service;
    }

    // GET: COMMPAYREQ_ORDERS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMMPAYREQ_ORDERS/Index.cshtml");

    // GET: COMMPAYREQ_ORDERS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Details.cshtml", result);
    }

    // GET: COMMPAYREQ_ORDERS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Create.cshtml", new CreateCOMMPAYREQ_ORDERSDto());
    }

    // POST: COMMPAYREQ_ORDERS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMPAYREQ_ORDERSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Create.cshtml", createDto);
    }

    // GET: COMMPAYREQ_ORDERS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMPAYREQ_ORDERSDto
        {
            NID_COMMPAYREQ = result.NID_COMMPAYREQ,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NORDER_NUM = result.NORDER_NUM,
            NMASTERORDER = result.NMASTERORDER,
            NMASTERORDERTYPE = result.NMASTERORDERTYPE,
            STYPECARE = result.STYPECARE,
            DIAGNOSIS_ORDER = result.DIAGNOSIS_ORDER,
            REASONREJECT_ORDER = result.REASONREJECT_ORDER,
            NCURRENCY_MO = result.NCURRENCY_MO,
            NAMOUNTREJECTED_ORDER = result.NAMOUNTREJECTED_ORDER,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NSTATUS_ORDER = result.NSTATUS_ORDER,
        };
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Edit.cshtml", updateDto);
    }

    // POST: COMMPAYREQ_ORDERS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCOMMPAYREQ_ORDERSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Edit.cshtml", updateDto);
    }

    // GET: COMMPAYREQ_ORDERS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_ORDERS/Delete.cshtml", result);
    }

    // POST: COMMPAYREQ_ORDERS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOMMPAYMENTREQUESTSDropdownAsync()
    {
        var items = await _COMMPAYMENTREQUESTSService.GetAllAsync();
        ViewData["NID_COMMPAYREQ"] = new SelectList(items, nameof(COMMPAYMENTREQUESTSDto.NID_COMMPAYREQ), "SCLIENAME_HOLDER");
    }

    private async Task PopulateCLAIM_ORDERDropdownAsync()
    {
        var items = await _CLAIM_ORDERService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCLAIM), "STYPECARE");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCASE_NUM), "STYPECARE");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CLAIM_ORDERDto.NDEMAN_TYPE), "STYPECARE");
        ViewData["NORDER_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NORDER_NUM), "STYPECARE");
    }

    private async Task PopulateMASTERCL_ORDERDropdownAsync()
    {
        var items = await _MASTERCL_ORDERService.GetAllAsync();
        ViewData["NMASTERORDER"] = new SelectList(items, nameof(MASTERCL_ORDERDto.NMASTERORDER), "SNAMECLIENT");
    }

    private async Task PopulateTABLE9265DropdownAsync()
    {
        var items = await _TABLE9265Service.GetAllAsync();
        ViewData["NMASTERORDERTYPE"] = new SelectList(items, nameof(TABLE9265Dto.NMASTERORDERTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY_MO"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE9241DropdownAsync()
    {
        var items = await _TABLE9241Service.GetAllAsync();
        ViewData["NSTATUS_ORDER"] = new SelectList(items, nameof(TABLE9241Dto.NSTATUS_ORDER), "SDESCRIPT");
    }

}
