using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5632;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE49;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5770;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9233;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9235;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class POLICYController : Controller
{
    private readonly IPOLICYService _service;
    private readonly ITABLE5632Service _TABLE5632Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE50Service _TABLE50Service;
    private readonly ITABLE49Service _TABLE49Service;
    private readonly ITABLE25Service _TABLE25Service;
    private readonly ITABLE47Service _TABLE47Service;
    private readonly ITABLE46Service _TABLE46Service;
    private readonly ITABLE154Service _TABLE154Service;
    private readonly ITABLE181Service _TABLE181Service;
    private readonly ITABLE92Service _TABLE92Service;
    private readonly ITABLE36Service _TABLE36Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ICOMPANYService _COMPANYService;
    private readonly INOCONVERSService _NOCONVERSService;
    private readonly ITABLE13Service _TABLE13Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly IAGREEMENTService _AGREEMENTService;
    private readonly ITABLE5555Service _TABLE5555Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly ITABLE5677Service _TABLE5677Service;
    private readonly ITABLE5770Service _TABLE5770Service;
    private readonly ITABLE9233Service _TABLE9233Service;
    private readonly ITABLE9235Service _TABLE9235Service;

    public POLICYController(IPOLICYService service
        , ITABLE5632Service TABLE5632Service
        , ICLIENTService CLIENTService
        , ITABLE50Service TABLE50Service
        , ITABLE49Service TABLE49Service
        , ITABLE25Service TABLE25Service
        , ITABLE47Service TABLE47Service
        , ITABLE46Service TABLE46Service
        , ITABLE154Service TABLE154Service
        , ITABLE181Service TABLE181Service
        , ITABLE92Service TABLE92Service
        , ITABLE36Service TABLE36Service
        , IINTERMEDIAService INTERMEDIAService
        , ICOMPANYService COMPANYService
        , INOCONVERSService NOCONVERSService
        , ITABLE13Service TABLE13Service
        , ITABLE9Service TABLE9Service
        , IAGREEMENTService AGREEMENTService
        , ITABLE5555Service TABLE5555Service
        , ITABLE5556Service TABLE5556Service
        , ITABLE5677Service TABLE5677Service
        , ITABLE5770Service TABLE5770Service
        , ITABLE9233Service TABLE9233Service
        , ITABLE9235Service TABLE9235Service
    )
    {
        _service = service;
        _TABLE5632Service = TABLE5632Service;
        _CLIENTService = CLIENTService;
        _TABLE50Service = TABLE50Service;
        _TABLE49Service = TABLE49Service;
        _TABLE25Service = TABLE25Service;
        _TABLE47Service = TABLE47Service;
        _TABLE46Service = TABLE46Service;
        _TABLE154Service = TABLE154Service;
        _TABLE181Service = TABLE181Service;
        _TABLE92Service = TABLE92Service;
        _TABLE36Service = TABLE36Service;
        _INTERMEDIAService = INTERMEDIAService;
        _COMPANYService = COMPANYService;
        _NOCONVERSService = NOCONVERSService;
        _TABLE13Service = TABLE13Service;
        _TABLE9Service = TABLE9Service;
        _AGREEMENTService = AGREEMENTService;
        _TABLE5555Service = TABLE5555Service;
        _TABLE5556Service = TABLE5556Service;
        _TABLE5677Service = TABLE5677Service;
        _TABLE5770Service = TABLE5770Service;
        _TABLE9233Service = TABLE9233Service;
        _TABLE9235Service = TABLE9235Service;
    }

    // GET: POLICY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/POLICY/Index.cshtml");

    // GET: POLICY/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY/Details.cshtml", result);
    }

    // GET: POLICY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5632DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE49DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE5770DropdownAsync();
        await PopulateTABLE9233DropdownAsync();
        await PopulateTABLE9235DropdownAsync();
        return View("~/Views/Insudb/POLICY/Create.cshtml", new CreatePOLICYDto());
    }

    // POST: POLICY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePOLICYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5632DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE49DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE5770DropdownAsync();
        await PopulateTABLE9233DropdownAsync();
        await PopulateTABLE9235DropdownAsync();
        return View("~/Views/Insudb/POLICY/Create.cshtml", createDto);
    }

    // GET: POLICY/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePOLICYDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            SCLIENT = result.SCLIENT,
            SACCOUNTI = result.SACCOUNTI,
            SBUSSITYP = result.SBUSSITYP,
            SCOINSURI = result.SCOINSURI,
            SCOLINVOT = result.SCOLINVOT,
            SCOLREINT = result.SCOLREINT,
            SCOLTIMRE = result.SCOLTIMRE,
            SCOMMITYP = result.SCOMMITYP,
            SDECLARI = result.SDECLARI,
            SDIRDEBIT = result.SDIRDEBIT,
            SINDEXTYP = result.SINDEXTYP,
            SLEADINVO = result.SLEADINVO,
            SLEADNOTI = result.SLEADNOTI,
            SLEADPOLI = result.SLEADPOLI,
            SPOLITYPE = result.SPOLITYPE,
            SPROPO_CERT = result.SPROPO_CERT,
            SRENEWAL = result.SRENEWAL,
            SREVALAPL = result.SREVALAPL,
            SSTATUS_POL = result.SSTATUS_POL,
            SSUBSTITI = result.SSUBSTITI,
            STYP_CLAUSE = result.STYP_CLAUSE,
            STYP_DISCXP = result.STYP_DISCXP,
            STYP_MODULE = result.STYP_MODULE,
            SNONULL = result.SNONULL,
            SCONCOLL = result.SCONCOLL,
            SNUMFORM = result.SNUMFORM,
            DCHANGDAT = result.DCHANGDAT,
            DCOMPDATE = result.DCOMPDATE,
            DDAT_NO_CON = result.DDAT_NO_CON,
            DDATE_ORIGI = result.DDATE_ORIGI,
            DSTARTDATE = result.DSTARTDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            DISSUEDAT = result.DISSUEDAT,
            DMAXIMUM_DA = result.DMAXIMUM_DA,
            DNULLDATE = result.DNULLDATE,
            DPROPODAT = result.DPROPODAT,
            DNEXTRECEIP = result.DNEXTRECEIP,
            NAMOUCOMM = result.NAMOUCOMM,
            NCAPITAL = result.NCAPITAL,
            NCOLCLADI = result.NCOLCLADI,
            NCOMMISSI = result.NCOMMISSI,
            NINDEXFAC = result.NINDEXFAC,
            NLEADCOMI = result.NLEADCOMI,
            NLEADEXPE = result.NLEADEXPE,
            NLEADSHARE = result.NLEADSHARE,
            NPARTICIP = result.NPARTICIP,
            NPREMIUM = result.NPREMIUM,
            NSHARE = result.NSHARE,
            NPAYFREQ = result.NPAYFREQ,
            NINTERMED = result.NINTERMED,
            NLAST_CERTI = result.NLAST_CERTI,
            NNOTE_ADEND = result.NNOTE_ADEND,
            NNOTE_BENEF = result.NNOTE_BENEF,
            NNOTE_COMME = result.NNOTE_COMME,
            NNOTE_CONDI = result.NNOTE_CONDI,
            NNOTE_COVER = result.NNOTE_COVER,
            NPROPONUM = result.NPROPONUM,
            NQ_CERTIF = result.NQ_CERTIF,
            NTRANSACTIO = result.NTRANSACTIO,
            NMOV_HISTOR = result.NMOV_HISTOR,
            NOFICIAL_P = result.NOFICIAL_P,
            NCOPIES = result.NCOPIES,
            NLEADCOMP = result.NLEADCOMP,
            NNO_CONVERS = result.NNO_CONVERS,
            NNOTICE = result.NNOTICE,
            NNULLCODE = result.NNULLCODE,
            NOFFICE = result.NOFFICE,
            NOFFICE_OWN = result.NOFFICE_OWN,
            NTARIFF = result.NTARIFF,
            NUSER_AMEND = result.NUSER_AMEND,
            NUSERCODE = result.NUSERCODE,
            NQUOTA = result.NQUOTA,
            STYPE_PROP = result.STYPE_PROP,
            SPRORSHORT = result.SPRORSHORT,
            NDAYSFQ = result.NDAYSFQ,
            NDAYSSQ = result.NDAYSSQ,
            NCOMPANY = result.NCOMPANY,
            NOFFICEINS = result.NOFFICEINS,
            SORIGINAL = result.SORIGINAL,
            NCOD_AGREE = result.NCOD_AGREE,
            STYPENOM = result.STYPENOM,
            SNOPAYROLL = result.SNOPAYROLL,
            SINSUBANK = result.SINSUBANK,
            NLEGAMOUNT = result.NLEGAMOUNT,
            SLEG = result.SLEG,
            NAGENCY = result.NAGENCY,
            NOFFICEAGEN = result.NOFFICEAGEN,
            SCOLTPRES = result.SCOLTPRES,
            SIND_COMM = result.SIND_COMM,
            SCURRACC = result.SCURRACC,
            NREPINSURED = result.NREPINSURED,
            NLOCAL = result.NLOCAL,
            DDATERENOVA = result.DDATERENOVA,
            NCLAIM_NOTICE = result.NCLAIM_NOTICE,
            SMASSIVE = result.SMASSIVE,
            SREPPRINTCOV = result.SREPPRINTCOV,
            SRECEIPT_IND = result.SRECEIPT_IND,
            SDOCUTYP = result.SDOCUTYP,
            NTERM_GRACE = result.NTERM_GRACE,
            NPRODCLAS = result.NPRODCLAS,
            NAGREEMENT = result.NAGREEMENT,
            SACCHSEND_IND = result.SACCHSEND_IND,
            NTYPEACCOUNT = result.NTYPEACCOUNT,
            DPREVIUS_EXPIRDATE = result.DPREVIUS_EXPIRDATE,
            NSPECIALBUSINESS = result.NSPECIALBUSINESS,
            NLEADYM = result.NLEADYM,
            DEXPIRDATANT = result.DEXPIRDATANT,
            STYPCALC_FLATPREM = result.STYPCALC_FLATPREM,
            STYPDIS_PAYPERCEN = result.STYPDIS_PAYPERCEN,
            NPARTICIP_POLEMP = result.NPARTICIP_POLEMP,
            NPARTICIP_POLCO = result.NPARTICIP_POLCO,
            SPREVPOLNUM = result.SPREVPOLNUM,
        };
        await PopulateTABLE5632DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE49DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE5770DropdownAsync();
        await PopulateTABLE9233DropdownAsync();
        await PopulateTABLE9235DropdownAsync();
        return View("~/Views/Insudb/POLICY/Edit.cshtml", updateDto);
    }

    // POST: POLICY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePOLICYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5632DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE49DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE47DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE5770DropdownAsync();
        await PopulateTABLE9233DropdownAsync();
        await PopulateTABLE9235DropdownAsync();
        return View("~/Views/Insudb/POLICY/Edit.cshtml", updateDto);
    }

    // GET: POLICY/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY/Delete.cshtml", result);
    }

    // POST: POLICY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: POLICY/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SACCOUNTI }));
    }

    // GET: POLICY/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SACCOUNTI }));
    }

    private async Task PopulateTABLE5632DropdownAsync()
    {
        var items = await _TABLE5632Service.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(TABLE5632Dto.SCERTYPE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE50DropdownAsync()
    {
        var items = await _TABLE50Service.GetAllAsync();
        ViewData["SCOLINVOT"] = new SelectList(items, nameof(TABLE50Dto.SCOLINVOT), "SDESCRIPT");
    }

    private async Task PopulateTABLE49DropdownAsync()
    {
        var items = await _TABLE49Service.GetAllAsync();
        ViewData["SCOLREINT"] = new SelectList(items, nameof(TABLE49Dto.SCOLREINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE25DropdownAsync()
    {
        var items = await _TABLE25Service.GetAllAsync();
        ViewData["SCOLTIMRE"] = new SelectList(items, nameof(TABLE25Dto.STIMEREN), "SDESCRIPT");
    }

    private async Task PopulateTABLE47DropdownAsync()
    {
        var items = await _TABLE47Service.GetAllAsync();
        ViewData["SCOMMITYP"] = new SelectList(items, nameof(TABLE47Dto.SCOMMITYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE46DropdownAsync()
    {
        var items = await _TABLE46Service.GetAllAsync();
        ViewData["SINDEXTYP"] = new SelectList(items, nameof(TABLE46Dto.SREVALTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE154DropdownAsync()
    {
        var items = await _TABLE154Service.GetAllAsync();
        ViewData["SREVALAPL"] = new SelectList(items, nameof(TABLE154Dto.SREVALAPL), "SDESCRIPT");
    }

    private async Task PopulateTABLE181DropdownAsync()
    {
        var items = await _TABLE181Service.GetAllAsync();
        ViewData["SSTATUS_POL"] = new SelectList(items, nameof(TABLE181Dto.SSTATUSVA), "SDESCRIPT");
    }

    private async Task PopulateTABLE92DropdownAsync()
    {
        var items = await _TABLE92Service.GetAllAsync();
        ViewData["STYP_CLAUSE"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
        ViewData["STYP_DISCXP"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
        ViewData["STYP_MODULE"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
        ViewData["SCOLTPRES"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
    }

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NPAYFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NLEADCOMP"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateNOCONVERSDropdownAsync()
    {
        var items = await _NOCONVERSService.GetAllAsync();
        ViewData["NNO_CONVERS"] = new SelectList(items, nameof(NOCONVERSDto.NNO_CONVERS), "SDESCRIPT");
    }

    private async Task PopulateTABLE13DropdownAsync()
    {
        var items = await _TABLE13Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE13Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE5677DropdownAsync()
    {
        var items = await _TABLE5677Service.GetAllAsync();
        ViewData["NREPINSURED"] = new SelectList(items, nameof(TABLE5677Dto.NREPINSURED), "SDESCRIPT");
    }

    private async Task PopulateTABLE5770DropdownAsync()
    {
        var items = await _TABLE5770Service.GetAllAsync();
        ViewData["NSPECIALBUSINESS"] = new SelectList(items, nameof(TABLE5770Dto.NSPECIALBUSINES), "SDESCRIPT");
    }

    private async Task PopulateTABLE9233DropdownAsync()
    {
        var items = await _TABLE9233Service.GetAllAsync();
        ViewData["STYPCALC_FLATPREM"] = new SelectList(items, nameof(TABLE9233Dto.STYPCALC_FLATPREM), "SDESCRIPT");
    }

    private async Task PopulateTABLE9235DropdownAsync()
    {
        var items = await _TABLE9235Service.GetAllAsync();
        ViewData["STYPDIS_PAYPERCEN"] = new SelectList(items, nameof(TABLE9235Dto.STYPDIS_PAYPERCEN), "SDESCRIPT");
    }

}
