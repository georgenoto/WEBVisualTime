using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COVROL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5800;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8106;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_COVROLController : Controller
{
    private readonly ITAB_COVROLService _service;
    private readonly IPRODMASTERService _PRODMASTERService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE33Service _TABLE33Service;
    private readonly ITABLE64Service _TABLE64Service;
    private readonly ITABLE5589Service _TABLE5589Service;
    private readonly ITABLE52Service _TABLE52Service;
    private readonly ITABLE5800Service _TABLE5800Service;
    private readonly ITABLE8106Service _TABLE8106Service;

    public TAB_COVROLController(ITAB_COVROLService service
        , IPRODMASTERService PRODMASTERService
        , ITABLE12Service TABLE12Service
        , IUSERSService USERSService
        , ITABLE33Service TABLE33Service
        , ITABLE64Service TABLE64Service
        , ITABLE5589Service TABLE5589Service
        , ITABLE52Service TABLE52Service
        , ITABLE5800Service TABLE5800Service
        , ITABLE8106Service TABLE8106Service
    )
    {
        _service = service;
        _PRODMASTERService = PRODMASTERService;
        _TABLE12Service = TABLE12Service;
        _USERSService = USERSService;
        _TABLE33Service = TABLE33Service;
        _TABLE64Service = TABLE64Service;
        _TABLE5589Service = TABLE5589Service;
        _TABLE52Service = TABLE52Service;
        _TABLE5800Service = TABLE5800Service;
        _TABLE8106Service = TABLE8106Service;
    }

    // GET: TAB_COVROL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_COVROL/Index.cshtml", result);
    }

    // GET: TAB_COVROL/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COVROL/Details.cshtml", result);
    }

    // GET: TAB_COVROL/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE5800DropdownAsync();
        await PopulateTABLE8106DropdownAsync();
        return View("~/Views/Insudb/TAB_COVROL/Create.cshtml", new CreateTAB_COVROLDto());
    }

    // POST: TAB_COVROL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_COVROLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE5800DropdownAsync();
        await PopulateTABLE8106DropdownAsync();
        return View("~/Views/Insudb/TAB_COVROL/Create.cshtml", createDto);
    }

    // GET: TAB_COVROL/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_COVROLDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NROLCAP = result.NROLCAP,
            NROLE = result.NROLE,
            DEFFECDATE = result.DEFFECDATE,
            SREQUIRED = result.SREQUIRED,
            SDEFAULTI = result.SDEFAULTI,
            SROUPREMI = result.SROUPREMI,
            NAGEMININSM = result.NAGEMININSM,
            NAGEMAXINSM = result.NAGEMAXINSM,
            NAGEMAXPERM = result.NAGEMAXPERM,
            NAGEMININSF = result.NAGEMININSF,
            NAGEMAXINSF = result.NAGEMAXINSF,
            NAGEMAXPERF = result.NAGEMAXPERF,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NCACALCOV = result.NCACALCOV,
            NCACALFIX = result.NCACALFIX,
            NCACALMUL = result.NCACALMUL,
            NCAPBASPE = result.NCAPBASPE,
            NCAPMAXIM = result.NCAPMAXIM,
            NCAPMINIM = result.NCAPMINIM,
            NCOVER_IN = result.NCOVER_IN,
            NROLPREM = result.NROLPREM,
            NPREMIRAT = result.NPREMIRAT,
            NNOTENUM = result.NNOTENUM,
            NDURATIND = result.NDURATIND,
            SRECHAPRI = result.SRECHAPRI,
            SRENEWALI = result.SRENEWALI,
            SROUCHACA = result.SROUCHACA,
            SROUCHAPR = result.SROUCHAPR,
            NDURATPAY = result.NDURATPAY,
            SREVINDEX = result.SREVINDEX,
            SROUPRCAL = result.SROUPRCAL,
            NFRANCFIX = result.NFRANCFIX,
            SFRANCAPL = result.SFRANCAPL,
            NFRANCMAX = result.NFRANCMAX,
            NFRANCMIN = result.NFRANCMIN,
            NFRANCRAT = result.NFRANCRAT,
            SROUFRANC = result.SROUFRANC,
            SFRANTYPE = result.SFRANTYPE,
            SFDREQUIRE = result.SFDREQUIRE,
            SFDCHANTYP = result.SFDCHANTYP,
            NFDUSERLEV = result.NFDUSERLEV,
            NFDRATEADD = result.NFDRATEADD,
            NFDRATESUB = result.NFDRATESUB,
            NCAMAXPER = result.NCAMAXPER,
            NCAMAXCOV = result.NCAMAXCOV,
            SROUTINECC = result.SROUTINECC,
            NRATECC = result.NRATECC,
            NAMOUNTCC = result.NAMOUNTCC,
            SAPPLYCC = result.SAPPLYCC,
            NCHPRELEV = result.NCHPRELEV,
            NCHCAPLEV = result.NCHCAPLEV,
            NRATECAPADD = result.NRATECAPADD,
            NRATECAPSUB = result.NRATECAPSUB,
            SCHTYPCAP = result.SCHTYPCAP,
            NRATEPREADD = result.NRATEPREADD,
            NRATEPRESUB = result.NRATEPRESUB,
            SCHANGETYP = result.SCHANGETYP,
            SSTATREGT = result.SSTATREGT,
            SROUT_PAY = result.SROUT_PAY,
            NTYPDURPAY = result.NTYPDURPAY,
            SCAREN_TYPE = result.SCAREN_TYPE,
            NTYPDURINS = result.NTYPDURINS,
            NCAREN_QUAN = result.NCAREN_QUAN,
            SCLACCIDI = result.SCLACCIDI,
            SCLDEATHI = result.SCLDEATHI,
            SCLINCAPI = result.SCLINCAPI,
            SCLINVALI = result.SCLINVALI,
            SCLVEHACI = result.SCLVEHACI,
            SCLIILLNESS = result.SCLIILLNESS,
            SCACALTYP = result.SCACALTYP,
            SCLSURVII = result.SCLSURVII,
            NCAMAXROL = result.NCAMAXROL,
            NMAX_ROLE = result.NMAX_ROLE,
            NMAXRENT = result.NMAXRENT,
            NPREMIFIX = result.NPREMIFIX,
            NCOVACTIV_REL = result.NCOVACTIV_REL,
            NROLACTIV_REL = result.NROLACTIV_REL,
            NPREMIMAX = result.NPREMIMAX,
            SLEG = result.SLEG,
            NUNITM = result.NUNITM,
            NUNITF = result.NUNITF,
            NID_TABLE = result.NID_TABLE,
            NQMONTH_VIG = result.NQMONTH_VIG,
            NQBETWEENMOD = result.NQBETWEENMOD,
            NQMAX_MOD = result.NQMAX_MOD,
            NPREMIMIN = result.NPREMIMIN,
            NTYP_AGEMINM = result.NTYP_AGEMINM,
            NTYP_AGEMINF = result.NTYP_AGEMINF,
            SROU_COND_CAP = result.SROU_COND_CAP,
            NPERCCOSTFP = result.NPERCCOSTFP,
            NRECCOSTFP = result.NRECCOSTFP,
            NTYPEAGE = result.NTYPEAGE,
            SROURATE = result.SROURATE,
            NFIELDDATE = result.NFIELDDATE,
            SDEVPRIMEXCESS = result.SDEVPRIMEXCESS,
            SPROVCOV = result.SPROVCOV,
            NMAXCAP_PROVCOV = result.NMAXCAP_PROVCOV,
            NDURDAY = result.NDURDAY,
            NAMOUNTMIN_INCAP = result.NAMOUNTMIN_INCAP,
            NAMOUNTMIN_DECAP = result.NAMOUNTMIN_DECAP,
            NFREQUEN = result.NFREQUEN,
            NMAXEVEN_QUAN = result.NMAXEVEN_QUAN,
            SMAX_EVEN = result.SMAX_EVEN,
            SROUTMAX_EVEN = result.SROUTMAX_EVEN,
            NREDUCAPAGE = result.NREDUCAPAGE,
            NAGELIMITCAP = result.NAGELIMITCAP,
            NPERCCOAS = result.NPERCCOAS,
            SROUT_REDUCTCAP = result.SROUT_REDUCTCAP,
            SEXEMPTION = result.SEXEMPTION,
            NTYPE_DUREXEMP = result.NTYPE_DUREXEMP,
            NEXEMPDUR = result.NEXEMPDUR,
            NTYPE_SEX = result.NTYPE_SEX,
        };
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE5800DropdownAsync();
        await PopulateTABLE8106DropdownAsync();
        return View("~/Views/Insudb/TAB_COVROL/Edit.cshtml", updateDto);
    }

    // POST: TAB_COVROL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_COVROLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE5800DropdownAsync();
        await PopulateTABLE8106DropdownAsync();
        return View("~/Views/Insudb/TAB_COVROL/Edit.cshtml", updateDto);
    }

    // GET: TAB_COVROL/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COVROL/Delete.cshtml", result);
    }

    // POST: TAB_COVROL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePRODMASTERDropdownAsync()
    {
        var items = await _PRODMASTERService.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(PRODMASTERDto.NBRANCH), "SDESCRIPT");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PRODMASTERDto.NPRODUCT), "SDESCRIPT");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLCAP"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
        ViewData["NROLPREM"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
        ViewData["NCAMAXROL"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
        ViewData["NROLACTIV_REL"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE33DropdownAsync()
    {
        var items = await _TABLE33Service.GetAllAsync();
        ViewData["SFRANCAPL"] = new SelectList(items, nameof(TABLE33Dto.SFRANCAPL), "SDESCRIPT");
    }

    private async Task PopulateTABLE64DropdownAsync()
    {
        var items = await _TABLE64Service.GetAllAsync();
        ViewData["SFRANTYPE"] = new SelectList(items, nameof(TABLE64Dto.SFRANTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURPAY"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
        ViewData["NTYPE_DUREXEMP"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

    private async Task PopulateTABLE52DropdownAsync()
    {
        var items = await _TABLE52Service.GetAllAsync();
        ViewData["SCAREN_TYPE"] = new SelectList(items, nameof(TABLE52Dto.SCAREN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5800DropdownAsync()
    {
        var items = await _TABLE5800Service.GetAllAsync();
        ViewData["NID_TABLE"] = new SelectList(items, nameof(TABLE5800Dto.NID_TABLE), "SDESCRIPT");
    }

    private async Task PopulateTABLE8106DropdownAsync()
    {
        var items = await _TABLE8106Service.GetAllAsync();
        ViewData["NFIELDDATE"] = new SelectList(items, nameof(TABLE8106Dto.NFIELDDATE), "SDESCRIPT");
    }

}
