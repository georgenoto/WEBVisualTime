using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8607;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_ORDERController : Controller
{
    private readonly ICLAIM_ORDERService _service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;
    private readonly ITABLE692Service _TABLE692Service;
    private readonly ITABLE9212Service _TABLE9212Service;
    private readonly ITABLE9237Service _TABLE9237Service;
    private readonly ITABLE9242Service _TABLE9242Service;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ITABLE9241Service _TABLE9241Service;
    private readonly ITABLE9238Service _TABLE9238Service;
    private readonly ITABLE9263Service _TABLE9263Service;
    private readonly IMASTERCL_ORDERService _MASTERCL_ORDERService;
    private readonly ITABLE8607Service _TABLE8607Service;
    private readonly ITABLE210Service _TABLE210Service;
    private readonly ICL_COMMERTYPEPAYService _CL_COMMERTYPEPAYService;
    private readonly ITABLE9Service _TABLE9Service;

    public CLAIM_ORDERController(ICLAIM_ORDERService service
        , ICLAIMService CLAIMService
        , ICLAIM_CASEService CLAIM_CASEService
        , ITABLE692Service TABLE692Service
        , ITABLE9212Service TABLE9212Service
        , ITABLE9237Service TABLE9237Service
        , ITABLE9242Service TABLE9242Service
        , ITABLE11Service TABLE11Service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE8604Service TABLE8604Service
        , ITABLE9241Service TABLE9241Service
        , ITABLE9238Service TABLE9238Service
        , ITABLE9263Service TABLE9263Service
        , IMASTERCL_ORDERService MASTERCL_ORDERService
        , ITABLE8607Service TABLE8607Service
        , ITABLE210Service TABLE210Service
        , ICL_COMMERTYPEPAYService CL_COMMERTYPEPAYService
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _CLAIMService = CLAIMService;
        _CLAIM_CASEService = CLAIM_CASEService;
        _TABLE692Service = TABLE692Service;
        _TABLE9212Service = TABLE9212Service;
        _TABLE9237Service = TABLE9237Service;
        _TABLE9242Service = TABLE9242Service;
        _TABLE11Service = TABLE11Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE8604Service = TABLE8604Service;
        _TABLE9241Service = TABLE9241Service;
        _TABLE9238Service = TABLE9238Service;
        _TABLE9263Service = TABLE9263Service;
        _MASTERCL_ORDERService = MASTERCL_ORDERService;
        _TABLE8607Service = TABLE8607Service;
        _TABLE210Service = TABLE210Service;
        _CL_COMMERTYPEPAYService = CL_COMMERTYPEPAYService;
        _TABLE9Service = TABLE9Service;
    }

    // GET: CLAIM_ORDER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_ORDER/Index.cshtml", result);
    }

    // GET: CLAIM_ORDER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ORDER/Details.cshtml", result);
    }

    // GET: CLAIM_ORDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIMDropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE8607DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        await PopulateCL_COMMERTYPEPAYDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ORDER/Create.cshtml", new CreateCLAIM_ORDERDto());
    }

    // POST: CLAIM_ORDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_ORDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE8607DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        await PopulateCL_COMMERTYPEPAYDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ORDER/Create.cshtml", createDto);
    }

    // GET: CLAIM_ORDER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_ORDERDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NORDER_NUM = result.NORDER_NUM,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            NATTENTCHANNEL = result.NATTENTCHANNEL,
            DORDERDATE = result.DORDERDATE,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            DACCOUNTDOC = result.DACCOUNTDOC,
            NCURREN_DOC = result.NCURREN_DOC,
            NPROVIDER = result.NPROVIDER,
            STYPECARE = result.STYPECARE,
            NCURREN_ORDER = result.NCURREN_ORDER,
            NSTATUS_ORDER = result.NSTATUS_ORDER,
            NORDERTYPE = result.NORDERTYPE,
            SPREAUTHORIZATION = result.SPREAUTHORIZATION,
            NNOTENUM = result.NNOTENUM,
            NMOVEMENT = result.NMOVEMENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCARECLASS = result.SCARECLASS,
            NUSER_AMEND = result.NUSER_AMEND,
            NUSER_AUDITDOC = result.NUSER_AUDITDOC,
            NEXCHANGE = result.NEXCHANGE,
            NNULLCODE = result.NNULLCODE,
            NUSER_DERIVEDBY = result.NUSER_DERIVEDBY,
            NMASTERORDER = result.NMASTERORDER,
            NPHYSICIAN = result.NPHYSICIAN,
            NMEDICALINSTITUTE = result.NMEDICALINSTITUTE,
            NREVALIDATIONS = result.NREVALIDATIONS,
            SPROLTREATMENT = result.SPROLTREATMENT,
            DPROLTREATFROM = result.DPROLTREATFROM,
            DPROLTREATTO = result.DPROLTREATTO,
            DORIGINALPREAUTH = result.DORIGINALPREAUTH,
            DLASTPREAUTH = result.DLASTPREAUTH,
            NIDMEDICALFEE = result.NIDMEDICALFEE,
            NCASE_NUM_ORIG = result.NCASE_NUM_ORIG,
            NDEMAN_TYPE_ORIG = result.NDEMAN_TYPE_ORIG,
            NORDER_NUM_ORIG = result.NORDER_NUM_ORIG,
            NAUDITDOCTOR = result.NAUDITDOCTOR,
            SCALLCENTER = result.SCALLCENTER,
            NDOCTORROL = result.NDOCTORROL,
            SFASTMEDICALEVAL = result.SFASTMEDICALEVAL,
            SOBSV_AUDITDOC = result.SOBSV_AUDITDOC,
            DLEDGERDAT = result.DLEDGERDAT,
            SCLIENT_BENEF = result.SCLIENT_BENEF,
            SCLIENT_REP = result.SCLIENT_REP,
            NCLA_LI_TYP = result.NCLA_LI_TYP,
            NIND_REOPENCL = result.NIND_REOPENCL,
            NCAUSEREOPENCL = result.NCAUSEREOPENCL,
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            NORDER_NUM_GEN = result.NORDER_NUM_GEN,
            NCOMMERCIALPAYASSOC = result.NCOMMERCIALPAYASSOC,
            SHISTORICAL_CLAIM = result.SHISTORICAL_CLAIM,
            NCOUNTRY = result.NCOUNTRY,
            NOFFICE = result.NOFFICE,
        };
        await PopulateCLAIMDropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE8607DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        await PopulateCL_COMMERTYPEPAYDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ORDER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_ORDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_ORDERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE8607DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        await PopulateCL_COMMERTYPEPAYDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ORDER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_ORDER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ORDER/Delete.cshtml", result);
    }

    // POST: CLAIM_ORDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLAIM_ORDER/GetByNDEMAN_TYPE?NDEMAN_TYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNDEMAN_TYPE(int NDEMAN_TYPE)
    {
        var items = await _service.FindAsync(p => p.NDEMAN_TYPE == NDEMAN_TYPE);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SPREAUTHORIZATION }));
    }

    // GET: CLAIM_ORDER/GetByNCURREN_DOC?NCURREN_DOC=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCURREN_DOC(long NCURREN_DOC)
    {
        var items = await _service.FindAsync(p => p.NCURREN_DOC == NCURREN_DOC);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SPREAUTHORIZATION }));
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateCLAIM_CASEDropdownAsync()
    {
        var items = await _CLAIM_CASEService.GetAllAsync();
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCASE_NUM), "SSTACASE");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9212DropdownAsync()
    {
        var items = await _TABLE9212Service.GetAllAsync();
        ViewData["NCLAIMANTTYPE"] = new SelectList(items, nameof(TABLE9212Dto.NCLAIMANTTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9237DropdownAsync()
    {
        var items = await _TABLE9237Service.GetAllAsync();
        ViewData["NATTENTCHANNEL"] = new SelectList(items, nameof(TABLE9237Dto.NATTENTCHANNEL), "SDESCRIPT");
    }

    private async Task PopulateTABLE9242DropdownAsync()
    {
        var items = await _TABLE9242Service.GetAllAsync();
        ViewData["NTYPEDOC_PAY"] = new SelectList(items, nameof(TABLE9242Dto.NTYPEDOC_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURREN_DOC"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
        ViewData["NCURREN_ORDER"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9241DropdownAsync()
    {
        var items = await _TABLE9241Service.GetAllAsync();
        ViewData["NSTATUS_ORDER"] = new SelectList(items, nameof(TABLE9241Dto.NSTATUS_ORDER), "SDESCRIPT");
    }

    private async Task PopulateTABLE9238DropdownAsync()
    {
        var items = await _TABLE9238Service.GetAllAsync();
        ViewData["NORDERTYPE"] = new SelectList(items, nameof(TABLE9238Dto.NORDERTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9263DropdownAsync()
    {
        var items = await _TABLE9263Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE9263Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateMASTERCL_ORDERDropdownAsync()
    {
        var items = await _MASTERCL_ORDERService.GetAllAsync();
        ViewData["NMASTERORDER"] = new SelectList(items, nameof(MASTERCL_ORDERDto.NMASTERORDER), "SNAMECLIENT");
    }

    private async Task PopulateTABLE8607DropdownAsync()
    {
        var items = await _TABLE8607Service.GetAllAsync();
        ViewData["NDOCTORROL"] = new SelectList(items, nameof(TABLE8607Dto.NDOCTORROL), "SDESCRIPT");
    }

    private async Task PopulateTABLE210DropdownAsync()
    {
        var items = await _TABLE210Service.GetAllAsync();
        ViewData["NCLA_LI_TYP"] = new SelectList(items, nameof(TABLE210Dto.NCLA_LI_TYP), "SDESCRIPT");
    }

    private async Task PopulateCL_COMMERTYPEPAYDropdownAsync()
    {
        var items = await _CL_COMMERTYPEPAYService.GetAllAsync();
        ViewData["NCOMMERCIALPAYASSOC"] = new SelectList(items, nameof(CL_COMMERTYPEPAYDto.NTYPE_COMMPAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
