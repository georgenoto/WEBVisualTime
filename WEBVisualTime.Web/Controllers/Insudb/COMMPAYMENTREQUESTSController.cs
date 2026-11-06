using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMPAYMENTREQUESTSController : Controller
{
    private readonly ICOMMPAYMENTREQUESTSService _service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly IPRECLAIMService _PRECLAIMService;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9275Service _TABLE9275Service;

    public COMMPAYMENTREQUESTSController(ICOMMPAYMENTREQUESTSService service
        , ITABLE9Service TABLE9Service
        , ICLIENTService CLIENTService
        , ITABLE12Service TABLE12Service
        , IPRECLAIMService PRECLAIMService
        , ITABLE8604Service TABLE8604Service
        , ICLAIMService CLAIMService
        , ITABLE11Service TABLE11Service
        , IUSERSService USERSService
        , ITABLE9275Service TABLE9275Service
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
        _CLIENTService = CLIENTService;
        _TABLE12Service = TABLE12Service;
        _PRECLAIMService = PRECLAIMService;
        _TABLE8604Service = TABLE8604Service;
        _CLAIMService = CLAIMService;
        _TABLE11Service = TABLE11Service;
        _USERSService = USERSService;
        _TABLE9275Service = TABLE9275Service;
    }

    // GET: COMMPAYMENTREQUESTS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Index.cshtml", result);
    }

    // GET: COMMPAYMENTREQUESTS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Details.cshtml", result);
    }

    // GET: COMMPAYMENTREQUESTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Create.cshtml", new CreateCOMMPAYMENTREQUESTSDto());
    }

    // POST: COMMPAYMENTREQUESTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMPAYMENTREQUESTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Create.cshtml", createDto);
    }

    // GET: COMMPAYMENTREQUESTS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMPAYMENTREQUESTSDto
        {
            NID_COMMPAYREQ = result.NID_COMMPAYREQ,
            DREGISTRATIONDATE = result.DREGISTRATIONDATE,
            NOFFICE = result.NOFFICE,
            SCLIENT_HOLDER = result.SCLIENT_HOLDER,
            SCLIENAME_HOLDER = result.SCLIENAME_HOLDER,
            SCLIENT_INSURED = result.SCLIENT_INSURED,
            SCLIENAME_INSURED = result.SCLIENAME_INSURED,
            SCLIENT_AFFECT = result.SCLIENT_AFFECT,
            SCLIENAME_AFFECT = result.SCLIENAME_AFFECT,
            NAGE_AFFECT = result.NAGE_AFFECT,
            NROLE = result.NROLE,
            DINSURENTRYDATE = result.DINSURENTRYDATE,
            DOCCURDAT = result.DOCCURDAT,
            NIDPRECLAIM = result.NIDPRECLAIM,
            STYPECARE_PRECLAIM = result.STYPECARE_PRECLAIM,
            NCLAIM = result.NCLAIM,
            DREJECTEDDATE = result.DREJECTEDDATE,
            NAMOUNTREJECTED_PRECLAIM = result.NAMOUNTREJECTED_PRECLAIM,
            NCURRENCY = result.NCURRENCY,
            DIAGNOSIS_PRECLAIM = result.DIAGNOSIS_PRECLAIM,
            REASONREJECT_PRECLAIM = result.REASONREJECT_PRECLAIM,
            SCLARIFICATIONREQUESTED = result.SCLARIFICATIONREQUESTED,
            SJUSTIFICATIONREQUESTED = result.SJUSTIFICATIONREQUESTED,
            NUSERCODE_RESPONSIBLE = result.NUSERCODE_RESPONSIBLE,
            DRESULTDATE = result.DRESULTDATE,
            SIND_RESULT = result.SIND_RESULT,
            SIND_ASSUMEIVA = result.SIND_ASSUMEIVA,
            NCURRENCY_PAY = result.NCURRENCY_PAY,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NPERCENTPAY = result.NPERCENTPAY,
            SOBSERVATIONSRESULT = result.SOBSERVATIONSRESULT,
            SCLIENAME_AUTHORIZER1 = result.SCLIENAME_AUTHORIZER1,
            SPOSITION_AUTHORIZER1 = result.SPOSITION_AUTHORIZER1,
            SCLIENAME_AUTHORIZER2 = result.SCLIENAME_AUTHORIZER2,
            SPOSITION_AUTHORIZER2 = result.SPOSITION_AUTHORIZER2,
            DLETTERDATE = result.DLETTERDATE,
            NNUMBERLETTER = result.NNUMBERLETTER,
            SADDRESSEDTO = result.SADDRESSEDTO,
            NSTATUS = result.NSTATUS,
            NNOTENUM = result.NNOTENUM,
            NMOVEMENT = result.NMOVEMENT,
            NUSER_AMEND = result.NUSER_AMEND,
            NUSER_DERIVEDBY = result.NUSER_DERIVEDBY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
            NNULLCODE = result.NNULLCODE,
        };
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Edit.cshtml", updateDto);
    }

    // POST: COMMPAYMENTREQUESTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMMPAYMENTREQUESTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_COMMPAYREQ, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Edit.cshtml", updateDto);
    }

    // GET: COMMPAYMENTREQUESTS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYMENTREQUESTS/Delete.cshtml", result);
    }

    // POST: COMMPAYMENTREQUESTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: COMMPAYMENTREQUESTS/GetBySTYPECARE_PRECLAIM?STYPECARE_PRECLAIM=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySTYPECARE_PRECLAIM(string? STYPECARE_PRECLAIM)
    {
        var items = await _service.FindAsync(p => p.STYPECARE_PRECLAIM == STYPECARE_PRECLAIM);
        return Json(items.Select(i => new { value = i.NID_COMMPAYREQ, text = i.SCLIENAME_HOLDER }));
    }

    // GET: COMMPAYMENTREQUESTS/GetByNCURRENCY?NCURRENCY=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCURRENCY(long NCURRENCY)
    {
        var items = await _service.FindAsync(p => p.NCURRENCY == NCURRENCY);
        return Json(items.Select(i => new { value = i.NID_COMMPAYREQ, text = i.SCLIENAME_HOLDER }));
    }

    // GET: COMMPAYMENTREQUESTS/GetByNSTATUS?NSTATUS=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNSTATUS(int NSTATUS)
    {
        var items = await _service.FindAsync(p => p.NSTATUS == NSTATUS);
        return Json(items.Select(i => new { value = i.NID_COMMPAYREQ, text = i.SCLIENAME_HOLDER }));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT_HOLDER"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENT_INSURED"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENT_AFFECT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulatePRECLAIMDropdownAsync()
    {
        var items = await _PRECLAIMService.GetAllAsync();
        ViewData["NIDPRECLAIM"] = new SelectList(items, nameof(PRECLAIMDto.NIDPRECLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE_PRECLAIM"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
        ViewData["NCURRENCY_PAY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE_RESPONSIBLE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSER_AMEND"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSER_DERIVEDBY"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE9275DropdownAsync()
    {
        var items = await _TABLE9275Service.GetAllAsync();
        ViewData["NSTATUS"] = new SelectList(items, nameof(TABLE9275Dto.NSTATUS), "SDESCRIPT");
    }

}
