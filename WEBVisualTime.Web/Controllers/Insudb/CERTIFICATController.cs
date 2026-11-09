using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WAITPO;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9781;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CERTIFICATController : Controller
{
    private readonly ICERTIFICATService _service;
    private readonly ISITUATIONService _SITUATIONService;
    private readonly ICLIENTService _CLIENTService;
    private readonly INOCONVERSService _NOCONVERSService;
    private readonly ITABLE13Service _TABLE13Service;
    private readonly ITABLE36Service _TABLE36Service;
    private readonly ITABLE181Service _TABLE181Service;
    private readonly ITAB_WAITPOService _TAB_WAITPOService;
    private readonly ITABLE5002Service _TABLE5002Service;
    private readonly ITABLE5532Service _TABLE5532Service;
    private readonly ITABLE5566Service _TABLE5566Service;
    private readonly ITABLE5526Service _TABLE5526Service;
    private readonly ICOLLECTORService _COLLECTORService;
    private readonly IAGREEMENTService _AGREEMENTService;
    private readonly ITABLE2Service _TABLE2Service;
    private readonly ITABLE9781Service _TABLE9781Service;

    public CERTIFICATController(ICERTIFICATService service
        , ISITUATIONService SITUATIONService
        , ICLIENTService CLIENTService
        , INOCONVERSService NOCONVERSService
        , ITABLE13Service TABLE13Service
        , ITABLE36Service TABLE36Service
        , ITABLE181Service TABLE181Service
        , ITAB_WAITPOService TAB_WAITPOService
        , ITABLE5002Service TABLE5002Service
        , ITABLE5532Service TABLE5532Service
        , ITABLE5566Service TABLE5566Service
        , ITABLE5526Service TABLE5526Service
        , ICOLLECTORService COLLECTORService
        , IAGREEMENTService AGREEMENTService
        , ITABLE2Service TABLE2Service
        , ITABLE9781Service TABLE9781Service
    )
    {
        _service = service;
        _SITUATIONService = SITUATIONService;
        _CLIENTService = CLIENTService;
        _NOCONVERSService = NOCONVERSService;
        _TABLE13Service = TABLE13Service;
        _TABLE36Service = TABLE36Service;
        _TABLE181Service = TABLE181Service;
        _TAB_WAITPOService = TAB_WAITPOService;
        _TABLE5002Service = TABLE5002Service;
        _TABLE5532Service = TABLE5532Service;
        _TABLE5566Service = TABLE5566Service;
        _TABLE5526Service = TABLE5526Service;
        _COLLECTORService = COLLECTORService;
        _AGREEMENTService = AGREEMENTService;
        _TABLE2Service = TABLE2Service;
        _TABLE9781Service = TABLE9781Service;
    }

    // GET: CERTIFICAT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CERTIFICAT/Index.cshtml");

    // GET: CERTIFICAT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CERTIFICAT/Details.cshtml", result);
    }

    // GET: CERTIFICAT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSITUATIONDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE2DropdownAsync();
        await PopulateTABLE9781DropdownAsync();
        return View("~/Views/Insudb/CERTIFICAT/Create.cshtml", new CreateCERTIFICATDto());
    }

    // POST: CERTIFICAT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCERTIFICATDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSITUATIONDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE2DropdownAsync();
        await PopulateTABLE9781DropdownAsync();
        return View("~/Views/Insudb/CERTIFICAT/Create.cshtml", createDto);
    }

    // GET: CERTIFICAT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCERTIFICATDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            NCAPITAL = result.NCAPITAL,
            DCOMPDATE = result.DCOMPDATE,
            SCUMUL_CODE = result.SCUMUL_CODE,
            DDAT_NO_CON = result.DDAT_NO_CON,
            DDATE_ORIGI = result.DDATE_ORIGI,
            DCHANGDAT = result.DCHANGDAT,
            DEXPIRDAT = result.DEXPIRDAT,
            NGROUP = result.NGROUP,
            DISSUEDAT = result.DISSUEDAT,
            DMAXIMUM_DA = result.DMAXIMUM_DA,
            NNO_CONVERS = result.NNO_CONVERS,
            NNOTE_BENEF = result.NNOTE_BENEF,
            NNOTE_DRISK = result.NNOTE_DRISK,
            NNULLCODE = result.NNULLCODE,
            DNULLDATE = result.DNULLDATE,
            NPAYFREQ = result.NPAYFREQ,
            NPREMIUM = result.NPREMIUM,
            DPROPODAT = result.DPROPODAT,
            SRENEWAL = result.SRENEWAL,
            NSITUATION = result.NSITUATION,
            DSTARTDATE = result.DSTARTDATE,
            SSTATUSVA = result.SSTATUSVA,
            NUSER_AMEND = result.NUSER_AMEND,
            NUSERCODE = result.NUSERCODE,
            NSUS_BRANCH = result.NSUS_BRANCH,
            NWAIT_CODE = result.NWAIT_CODE,
            NSUS_PRODUCT = result.NSUS_PRODUCT,
            NSUS_POLICY = result.NSUS_POLICY,
            NSUS_CERTIF = result.NSUS_CERTIF,
            DNEXTRECEIP = result.DNEXTRECEIP,
            NPROPONUM = result.NPROPONUM,
            NQUOTA = result.NQUOTA,
            NDAYSFQ = result.NDAYSFQ,
            SPRORSHORT = result.SPRORSHORT,
            NDAYSSQ = result.NDAYSSQ,
            SNUMFORM = result.SNUMFORM,
            SREINSURA = result.SREINSURA,
            SCLAIMIND = result.SCLAIMIND,
            SEXCEPTION = result.SEXCEPTION,
            NEXCCAUSE = result.NEXCCAUSE,
            SPROPERUSE = result.SPROPERUSE,
            SEXEMPTION = result.SEXEMPTION,
            NIMAGENUM = result.NIMAGENUM,
            SDIRIND = result.SDIRIND,
            NWAY_PAY = result.NWAY_PAY,
            NBILL_DAY = result.NBILL_DAY,
            NSENDADDR = result.NSENDADDR,
            SAUT_GUARVAL = result.SAUT_GUARVAL,
            NSELLCHANNEL = result.NSELLCHANNEL,
            DCOLLSUS_INI = result.DCOLLSUS_INI,
            DFER = result.DFER,
            DCOLLSUS_END = result.DCOLLSUS_END,
            NDAYS_QUOT = result.NDAYS_QUOT,
            NSUS_REASON = result.NSUS_REASON,
            NPOL_QUOT = result.NPOL_QUOT,
            SSUS_ORIGI = result.SSUS_ORIGI,
            DDATE_ACCEPT = result.DDATE_ACCEPT,
            SANULLETTER = result.SANULLETTER,
            SBILL_IND = result.SBILL_IND,
            SREFUNDPREM = result.SREFUNDPREM,
            NSTATQUOTA = result.NSTATQUOTA,
            SPENDINFO = result.SPENDINFO,
            NRENEWALNUM = result.NRENEWALNUM,
            NDIGIT = result.NDIGIT,
            NPROP_REG = result.NPROP_REG,
            NDAY_PAY = result.NDAY_PAY,
            NDURATION = result.NDURATION,
            NAFP_COMMISS = result.NAFP_COMMISS,
            NAFP_COMM_CURR = result.NAFP_COMM_CURR,
            NORIGIN = result.NORIGIN,
            NCOLLECTOR = result.NCOLLECTOR,
            SFRACRECEIP = result.SFRACRECEIP,
            NGROUP_AGREE = result.NGROUP_AGREE,
            NMAILINGPREF = result.NMAILINGPREF,
            SRETARIF = result.SRETARIF,
            DLAST_TARIF = result.DLAST_TARIF,
            SOPERATION = result.SOPERATION,
            DTARIFFDATE = result.DTARIFFDATE,
            DRECEPINT = result.DRECEPINT,
            DRECEPINT_COMP = result.DRECEPINT_COMP,
            DRECEPINSU = result.DRECEPINSU,
            DRECEPINSU_COMP = result.DRECEPINSU_COMP,
            SAPPLYCOSTFP = result.SAPPLYCOSTFP,
            SDETAILED_ENTRY_PRINTED = result.SDETAILED_ENTRY_PRINTED,
            DSALD_DATE = result.DSALD_DATE,
            NRATE_BASE = result.NRATE_BASE,
            NFOLIO = result.NFOLIO,
            SFACULTATIV = result.SFACULTATIV,
            SOFFICIALPOL = result.SOFFICIALPOL,
            SOFFICIALCER = result.SOFFICIALCER,
            NSUS_OFFICE = result.NSUS_OFFICE,
            NCOD_AGREE = result.NCOD_AGREE,
            NTYPEEXC = result.NTYPEEXC,
            SFILENUMBER = result.SFILENUMBER,
            NSYSTEM = result.NSYSTEM,
            NCOVERAGECERTIFICATE = result.NCOVERAGECERTIFICATE,
            NSTATUSCOVERAGECERTIFICATE = result.NSTATUSCOVERAGECERTIFICATE,
            DRISKACCEPTED = result.DRISKACCEPTED,
            SRECTYPE = result.SRECTYPE,
            SIND_MULTIANNUAL = result.SIND_MULTIANNUAL,
            NDEPRECIATIONTABLE = result.NDEPRECIATIONTABLE,
            NPROMISSORY_NOTE = result.NPROMISSORY_NOTE,
            NPHONEID = result.NPHONEID,
            NADDRESSID = result.NADDRESSID,
            SIND_IFI = result.SIND_IFI,
            NEXTRADAY = result.NEXTRADAY,
            NPOLICY_TRANSFER = result.NPOLICY_TRANSFER,
            NCERTIF_TRANSFER = result.NCERTIF_TRANSFER,
            SCODBRANCH_TRANSFER = result.SCODBRANCH_TRANSFER,
            NFORMPAY = result.NFORMPAY,
            SCONTROL = result.SCONTROL,
            DPREVIUS_EXPIRDATE = result.DPREVIUS_EXPIRDATE,
            SINDQSAMEVALUE = result.SINDQSAMEVALUE,
            NCERTIF_ASSOCIATED = result.NCERTIF_ASSOCIATED,
            NPOLICY_ASSOCIATED = result.NPOLICY_ASSOCIATED,
            NOFFICE_ASSOCIATED = result.NOFFICE_ASSOCIATED,
            NOFFICEAGEN_ASSOCIATED = result.NOFFICEAGEN_ASSOCIATED,
            NAGENCY_ASSOCIATED = result.NAGENCY_ASSOCIATED,
            NBRANCH_ASSOCIATED = result.NBRANCH_ASSOCIATED,
            NPRODUCT_ASSOCIATED = result.NPRODUCT_ASSOCIATED,
            NNOTCANCELDAY = result.NNOTCANCELDAY,
            SCLIENTSPONSOR = result.SCLIENTSPONSOR,
            SCOMERPRODUCT = result.SCOMERPRODUCT,
            NCOMBPOLICY = result.NCOMBPOLICY,
            NCAMP_RELEASE = result.NCAMP_RELEASE,
            NCAMPAIGN = result.NCAMPAIGN,
            SEXCEP_RANDOM = result.SEXCEP_RANDOM,
            NSPECI_RANDOM = result.NSPECI_RANDOM,
            DSUGGESTEDSTART = result.DSUGGESTEDSTART,
            SISUGSTART = result.SISUGSTART,
            SPREVPOLNUM = result.SPREVPOLNUM,
        };
        await PopulateSITUATIONDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE2DropdownAsync();
        await PopulateTABLE9781DropdownAsync();
        return View("~/Views/Insudb/CERTIFICAT/Edit.cshtml", updateDto);
    }

    // POST: CERTIFICAT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCERTIFICATDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSITUATIONDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE2DropdownAsync();
        await PopulateTABLE9781DropdownAsync();
        return View("~/Views/Insudb/CERTIFICAT/Edit.cshtml", updateDto);
    }

    // GET: CERTIFICAT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CERTIFICAT/Delete.cshtml", result);
    }

    // POST: CERTIFICAT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CERTIFICAT/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCUMUL_CODE }));
    }

    // GET: CERTIFICAT/GetByNNO_CONVERS?NNO_CONVERS=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNNO_CONVERS(int NNO_CONVERS)
    {
        var items = await _service.FindAsync(p => p.NNO_CONVERS == NNO_CONVERS);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCUMUL_CODE }));
    }

    // GET: CERTIFICAT/GetByNWAY_PAY?NWAY_PAY=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNWAY_PAY(int NWAY_PAY)
    {
        var items = await _service.FindAsync(p => p.NWAY_PAY == NWAY_PAY);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCUMUL_CODE }));
    }

    // GET: CERTIFICAT/GetByNTYPEEXC?NTYPEEXC=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNTYPEEXC(long NTYPEEXC)
    {
        var items = await _service.FindAsync(p => p.NTYPEEXC == NTYPEEXC);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCUMUL_CODE }));
    }

    private async Task PopulateSITUATIONDropdownAsync()
    {
        var items = await _SITUATIONService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(SITUATIONDto.SCERTYPE), "SDESCRIPT");
        ViewData["NBRANCH"] = new SelectList(items, nameof(SITUATIONDto.NBRANCH), "SDESCRIPT");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(SITUATIONDto.NPRODUCT), "SDESCRIPT");
        ViewData["NPOLICY"] = new SelectList(items, nameof(SITUATIONDto.NPOLICY), "SDESCRIPT");
        ViewData["NSITUATION"] = new SelectList(items, nameof(SITUATIONDto.NSITUATION), "SDESCRIPT");
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(SITUATIONDto.NCOD_AGREE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
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

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NPAYFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

    private async Task PopulateTABLE181DropdownAsync()
    {
        var items = await _TABLE181Service.GetAllAsync();
        ViewData["SSTATUSVA"] = new SelectList(items, nameof(TABLE181Dto.SSTATUSVA), "SDESCRIPT");
    }

    private async Task PopulateTAB_WAITPODropdownAsync()
    {
        var items = await _TAB_WAITPOService.GetAllAsync();
        ViewData["NWAIT_CODE"] = new SelectList(items, nameof(TAB_WAITPODto.NWAIT_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5532DropdownAsync()
    {
        var items = await _TABLE5532Service.GetAllAsync();
        ViewData["NSELLCHANNEL"] = new SelectList(items, nameof(TABLE5532Dto.NSELLCHANNEL), "SDESCRIPT");
    }

    private async Task PopulateTABLE5566DropdownAsync()
    {
        var items = await _TABLE5566Service.GetAllAsync();
        ViewData["NSUS_REASON"] = new SelectList(items, nameof(TABLE5566Dto.NSUS_REASON), "SDESCRIPT");
    }

    private async Task PopulateTABLE5526DropdownAsync()
    {
        var items = await _TABLE5526Service.GetAllAsync();
        ViewData["NSTATQUOTA"] = new SelectList(items, nameof(TABLE5526Dto.NSTATQUOTA), "SDESCRIPT");
    }

    private async Task PopulateCOLLECTORDropdownAsync()
    {
        var items = await _COLLECTORService.GetAllAsync();
        ViewData["NCOLLECTOR"] = new SelectList(items, nameof(COLLECTORDto.NCOLLECTOR), "NCOLLECTOR");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NGROUP_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

    private async Task PopulateTABLE2DropdownAsync()
    {
        var items = await _TABLE2Service.GetAllAsync();
        ViewData["NTYPEEXC"] = new SelectList(items, nameof(TABLE2Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9781DropdownAsync()
    {
        var items = await _TABLE9781Service.GetAllAsync();
        ViewData["NSYSTEM"] = new SelectList(items, nameof(TABLE9781Dto.NSYSTEM), "SDESCRIPT");
    }

}
