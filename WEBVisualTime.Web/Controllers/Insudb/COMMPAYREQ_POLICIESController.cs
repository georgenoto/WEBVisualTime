using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_POLICIES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMPAYREQ_POLICIESController : Controller
{
    private readonly ICOMMPAYREQ_POLICIESService _service;
    private readonly ICOMMPAYMENTREQUESTSService _COMMPAYMENTREQUESTSService;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly IINTERM_TYPService _INTERM_TYPService;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly IUSERSService _USERSService;

    public COMMPAYREQ_POLICIESController(ICOMMPAYREQ_POLICIESService service
        , ICOMMPAYMENTREQUESTSService COMMPAYMENTREQUESTSService
        , ICERTIFICATService CERTIFICATService
        , IINTERMEDIAService INTERMEDIAService
        , IINTERM_TYPService INTERM_TYPService
        , ITABLE11Service TABLE11Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _COMMPAYMENTREQUESTSService = COMMPAYMENTREQUESTSService;
        _CERTIFICATService = CERTIFICATService;
        _INTERMEDIAService = INTERMEDIAService;
        _INTERM_TYPService = INTERM_TYPService;
        _TABLE11Service = TABLE11Service;
        _USERSService = USERSService;
    }

    // GET: COMMPAYREQ_POLICIES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMMPAYREQ_POLICIES/Index.cshtml");

    // GET: COMMPAYREQ_POLICIES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Details.cshtml", result);
    }

    // GET: COMMPAYREQ_POLICIES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Create.cshtml", new CreateCOMMPAYREQ_POLICIESDto());
    }

    // POST: COMMPAYREQ_POLICIES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMPAYREQ_POLICIESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Create.cshtml", createDto);
    }

    // GET: COMMPAYREQ_POLICIES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMPAYREQ_POLICIESDto
        {
            NID_COMMPAYREQ = result.NID_COMMPAYREQ,
            NCONSEC = result.NCONSEC,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMODULEC = result.NMODULEC,
            NGROUP_INSU = result.NGROUP_INSU,
            SPOLITYPE = result.SPOLITYPE,
            NIND_POLICY = result.NIND_POLICY,
            NIND_CURRENT_POLICY = result.NIND_CURRENT_POLICY,
            NINTERMED = result.NINTERMED,
            NINTERTYP = result.NINTERTYP,
            SCLIENAME_INTERMEDIA = result.SCLIENAME_INTERMEDIA,
            DSTARTDATE = result.DSTARTDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NCURRENCY = result.NCURRENCY,
            NCAPITAL = result.NCAPITAL,
            NBALANCECAPITAL = result.NBALANCECAPITAL,
            NBALANCEDEDUC = result.NBALANCEDEDUC,
            NPREMIUM = result.NPREMIUM,
            NPREMIUMN = result.NPREMIUMN,
            NPREMIUMNPAID = result.NPREMIUMNPAID,
            NCLAIMSAMOUNTBASE_SETT = result.NCLAIMSAMOUNTBASE_SETT,
            NCLAIMSAMOUNTBASE_PEND = result.NCLAIMSAMOUNTBASE_PEND,
            NRATECLAIMS = result.NRATECLAIMS,
            NRATEPROFIT = result.NRATEPROFIT,
            NRATEPROJECTED_CLAIMS = result.NRATEPROJECTED_CLAIMS,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Edit.cshtml", updateDto);
    }

    // POST: COMMPAYREQ_POLICIES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMMPAYREQ_POLICIESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_COMMPAYREQ, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Edit.cshtml", updateDto);
    }

    // GET: COMMPAYREQ_POLICIES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_POLICIES/Delete.cshtml", result);
    }

    // POST: COMMPAYREQ_POLICIES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOMMPAYMENTREQUESTSDropdownAsync()
    {
        var items = await _COMMPAYMENTREQUESTSService.GetAllAsync();
        ViewData["NID_COMMPAYREQ"] = new SelectList(items, nameof(COMMPAYMENTREQUESTSDto.NID_COMMPAYREQ), "SCLIENAME_HOLDER");
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

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
