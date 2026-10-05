using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCOVER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCOVERController : Controller
{
    private readonly ITCOVERService _service;

    public TCOVERController(ITCOVERService service
    )
    {
        _service = service;
    }

    // GET: TCOVER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TCOVER/Index.cshtml", result);
    }

    // GET: TCOVER/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCOVER/Details.cshtml", result);
    }

    // GET: TCOVER/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCOVER/Create.cshtml", new CreateTCOVERDto());
    }

    // POST: TCOVER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCOVERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCOVER/Create.cshtml", createDto);
    }

    // GET: TCOVER/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCOVERDto
        {
            SCERTYPE = result.SCERTYPE,
            SCHANGE = result.SCHANGE,
            SFRANDEDI = result.SFRANDEDI,
            SWAIT_TYPE = result.SWAIT_TYPE,
            SFRANCAPL = result.SFRANCAPL,
            SFREE_PREMI = result.SFREE_PREMI,
            SDESCRIPT = result.SDESCRIPT,
            SEXIST = result.SEXIST,
            SREQUIRE = result.SREQUIRE,
            SDEFAULTI = result.SDEFAULTI,
            SCACALILI = result.SCACALILI,
            SCH_TYP_CAP = result.SCH_TYP_CAP,
            SCHANGE_TYP = result.SCHANGE_TYP,
            SFDREQUIRE = result.SFDREQUIRE,
            SROUPREMI = result.SROUPREMI,
            DEFFECDATE = result.DEFFECDATE,
            NCAPITAL = result.NCAPITAL,
            NDISCOUNT = result.NDISCOUNT,
            NFIXAMOUNT = result.NFIXAMOUNT,
            NMAXAMOUNT = result.NMAXAMOUNT,
            NRATE = result.NRATE,
            NMINAMOUNT = result.NMINAMOUNT,
            NPREMIUM = result.NPREMIUM,
            NRATECOVE = result.NRATECOVE,
            NCAPITALI = result.NCAPITALI,
            NRATECAPADD = result.NRATECAPADD,
            NRATECAPSUB = result.NRATECAPSUB,
            NRATEPREADD = result.NRATEPREADD,
            NRATEPRESUB = result.NRATEPRESUB,
            NDISC_AMOUN = result.NDISC_AMOUN,
            NPREMIRAT = result.NPREMIRAT,
            NPREMIMIN = result.NPREMIMIN,
            NPREMIMAX = result.NPREMIMAX,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NGROUP = result.NGROUP,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCURRENCY = result.NCURRENCY,
            NWAIT_QUAN = result.NWAIT_QUAN,
            NGROUP_INSU = result.NGROUP_INSU,
            NCOVER_IN = result.NCOVER_IN,
            NCOVERAPL = result.NCOVERAPL,
            SKEY = result.SKEY,
            NPREMIFIX = result.NPREMIFIX,
            SCACALFRI = result.SCACALFRI,
            NCHCAPLEV = result.NCHCAPLEV,
            NCHPRELEV = result.NCHPRELEV,
            NFDUSERLEV = result.NFDUSERLEV,
            SFDCHANTYP = result.SFDCHANTYP,
            NFDRATEADD = result.NFDRATEADD,
            NFDRATESUB = result.NFDRATESUB,
            NCACALCOV = result.NCACALCOV,
            NCACALPER = result.NCACALPER,
            SPFRANDEDI = result.SPFRANDEDI,
            NCACALMAX = result.NCACALMAX,
            NCACALMIN = result.NCACALMIN,
            SADDSUINI = result.SADDSUINI,
            NTARIFCURR = result.NTARIFCURR,
            SROUCHACA = result.SROUCHACA,
            NCACALFIX = result.NCACALFIX,
            SCLIENT = result.SCLIENT,
            NTYPDURINS = result.NTYPDURINS,
            NDURINSUR = result.NDURINSUR,
            NAGEMININS = result.NAGEMININS,
            NAGEMAXINS = result.NAGEMAXINS,
            NAGEMAXPER = result.NAGEMAXPER,
            NTYPDURPAY = result.NTYPDURPAY,
            NDURPAY = result.NDURPAY,
            NCAUSEUPD = result.NCAUSEUPD,
            NCAPITAL_WAIT = result.NCAPITAL_WAIT,
            NAGELIMIT = result.NAGELIMIT,
            NAGE_PER = result.NAGE_PER,
            DANIVERSARY = result.DANIVERSARY,
            DSEEKTAR = result.DSEEKTAR,
            DFER = result.DFER,
            NBRANCH_REI = result.NBRANCH_REI,
            NROLE = result.NROLE,
            NROLCAP = result.NROLCAP,
            NROLPREM = result.NROLPREM,
            NRETARIF = result.NRETARIF,
            NAGEMININSF = result.NAGEMININSF,
            NAGEMAXINSF = result.NAGEMAXINSF,
            NAGEMAXPERF = result.NAGEMAXPERF,
            SDEFAULTIC = result.SDEFAULTIC,
            SREQUIREC = result.SREQUIREC,
            SDEPEND = result.SDEPEND,
            NACTIONCOV = result.NACTIONCOV,
            NAPPLY_PERC = result.NAPPLY_PERC,
            SBAS_SUMINS = result.SBAS_SUMINS,
            NCAPITAL_O = result.NCAPITAL_O,
            NPREMIUM_O = result.NPREMIUM_O,
            NRATECOVE_O = result.NRATECOVE_O,
            SROUCAPIT = result.SROUCAPIT,
            NCAMAXCOV = result.NCAMAXCOV,
            NCAMAXPER = result.NCAMAXPER,
            NCAMAXROL = result.NCAMAXROL,
            NCACALMUL = result.NCACALMUL,
            NGENCURRENCY = result.NGENCURRENCY,
            SCONDSVS = result.SCONDSVS,
            NTYP_AGEMINM = result.NTYP_AGEMINM,
            NTYP_AGEMINF = result.NTYP_AGEMINF,
            NCAPITAL_REQ = result.NCAPITAL_REQ,
            SINHERIT = result.SINHERIT,
            NFIXAMOCLA = result.NFIXAMOCLA,
            NMINAMOCLA = result.NMINAMOCLA,
            NMAXAMOCLA = result.NMAXAMOCLA,
            NDISCCLA = result.NDISCCLA,
            NDISC_AMOCLA = result.NDISC_AMOCLA,
            NFRANCDAYS = result.NFRANCDAYS,
            NRATECLA = result.NRATECLA,
            NMAXEVEN_FREQ = result.NMAXEVEN_FREQ,
            NMAXEVEN_QUAN = result.NMAXEVEN_QUAN,
            SROUTMAX_EVEN = result.SROUTMAX_EVEN,
            SREDUCCAPITAL = result.SREDUCCAPITAL,
            NREDUCAPAGE = result.NREDUCAPAGE,
            NAGELIMITCAP = result.NAGELIMITCAP,
            NPERCCOAS = result.NPERCCOAS,
            DFREE_PREM_IN = result.DFREE_PREM_IN,
            DFREE_PREM_LIM = result.DFREE_PREM_LIM,
            DANTIDATE = result.DANTIDATE,
            NANTI_AMOUNT = result.NANTI_AMOUNT,
            NCLAIMRAT = result.NCLAIMRAT,
            NPREMIUM_CM = result.NPREMIUM_CM,
            NPREMIUM_SM = result.NPREMIUM_SM,
            SCOVERCHANGE = result.SCOVERCHANGE,
        };
        return View("~/Views/Insudb/TCOVER/Edit.cshtml", updateDto);
    }

    // POST: TCOVER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTCOVERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCOVER/Edit.cshtml", updateDto);
    }

    // GET: TCOVER/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCOVER/Delete.cshtml", result);
    }

    // POST: TCOVER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
