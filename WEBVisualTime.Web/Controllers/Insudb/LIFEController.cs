using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5560;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE268;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LIFEController : Controller
{
    private readonly ILIFEService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5589Service _TABLE5589Service;
    private readonly ITABLE5560Service _TABLE5560Service;
    private readonly ITABLE268Service _TABLE268Service;
    private readonly ITABLE2Service _TABLE2Service;

    public LIFEController(ILIFEService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE5589Service TABLE5589Service
        , ITABLE5560Service TABLE5560Service
        , ITABLE268Service TABLE268Service
        , ITABLE2Service TABLE2Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5589Service = TABLE5589Service;
        _TABLE5560Service = TABLE5560Service;
        _TABLE268Service = TABLE268Service;
        _TABLE2Service = TABLE2Service;
    }

    // GET: LIFE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LIFE/Index.cshtml");

    // GET: LIFE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE/Details.cshtml", result);
    }

    // GET: LIFE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5560DropdownAsync();
        await PopulateTABLE268DropdownAsync();
        await PopulateTABLE2DropdownAsync();
        return View("~/Views/Insudb/LIFE/Create.cshtml", new CreateLIFEDto());
    }

    // POST: LIFE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLIFEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5560DropdownAsync();
        await PopulateTABLE268DropdownAsync();
        await PopulateTABLE2DropdownAsync();
        return View("~/Views/Insudb/LIFE/Create.cshtml", createDto);
    }

    // GET: LIFE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLIFEDto
        {
            SCERTYPE = result.SCERTYPE,
            NPRODUCT = result.NPRODUCT,
            NBRANCH = result.NBRANCH,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            NAGE = result.NAGE,
            SCLIENT = result.SCLIENT,
            NAGE_LIMIT = result.NAGE_LIMIT,
            NAGE_REINSU = result.NAGE_REINSU,
            SAMORTI_WAY = result.SAMORTI_WAY,
            NCAPITAL = result.NCAPITAL,
            NCAPITAL_CA = result.NCAPITAL_CA,
            DCOMPDATE = result.DCOMPDATE,
            NEND_NUM = result.NEND_NUM,
            NENT_RIGHT = result.NENT_RIGHT,
            NEXA_AMOUNT = result.NEXA_AMOUNT,
            NEXAM_TYPE = result.NEXAM_TYPE,
            DEXPIRDAT = result.DEXPIRDAT,
            NTYPDURINS = result.NTYPDURINS,
            NINIT_NUM = result.NINIT_NUM,
            NINSUR_TIME = result.NINSUR_TIME,
            DISSUEDAT = result.DISSUEDAT,
            SLOAN_NUMBE = result.SLOAN_NUMBE,
            NNULLCODE = result.NNULLCODE,
            DNULLDATE = result.DNULLDATE,
            NPAY_TIME = result.NPAY_TIME,
            SPDURAIND = result.SPDURAIND,
            NPERMULTI = result.NPERMULTI,
            NPERNUMAI = result.NPERNUMAI,
            NPERNUNMI = result.NPERNUNMI,
            NPREMIUM = result.NPREMIUM,
            NPREMIUM_CA = result.NPREMIUM_CA,
            NRECEIPT = result.NRECEIPT,
            NSALD_AMOUN = result.NSALD_AMOUN,
            SSALD_PROG = result.SSALD_PROG,
            DSTARTDATE = result.DSTARTDATE,
            NTITLES_SUB = result.NTITLES_SUB,
            NUSERCODE = result.NUSERCODE,
            NWAR_INT_EX = result.NWAR_INT_EX,
            NWAR_INTERE = result.NWAR_INTERE,
            NXPREM_TIME = result.NXPREM_TIME,
            NYEARS_OLD = result.NYEARS_OLD,
            NTRANSACTIO = result.NTRANSACTIO,
            DPROG_DATE = result.DPROG_DATE,
            NRENTAMOUNT = result.NRENTAMOUNT,
            NCURRRENT = result.NCURRRENT,
            SCREDITNUM = result.SCREDITNUM,
            NCRED_PRO = result.NCRED_PRO,
            DINIT_CRE = result.DINIT_CRE,
            DEND_CRE = result.DEND_CRE,
            NCURREN_CRE = result.NCURREN_CRE,
            NAMOUNT_CRE = result.NAMOUNT_CRE,
            NAMOUNT_ACT = result.NAMOUNT_ACT,
            NCALCAPITAL = result.NCALCAPITAL,
            NTYPPREMIUM = result.NTYPPREMIUM,
            NCOUNT_INSU = result.NCOUNT_INSU,
            NGROUP_COMP = result.NGROUP_COMP,
            NTARIFF = result.NTARIFF,
            NGROUP = result.NGROUP,
            NSITUATION = result.NSITUATION,
            SACCNUM = result.SACCNUM,
            NCAPITALMAX = result.NCAPITALMAX,
            NPERC_CAP = result.NPERC_CAP,
            NLEGAMOUNT = result.NLEGAMOUNT,
            NTYPDURPAY = result.NTYPDURPAY,
            DDATE_PAY = result.DDATE_PAY,
            NRATEDESG = result.NRATEDESG,
            SIDURAIND = result.SIDURAIND,
            NQ_QUOT = result.NQ_QUOT,
            NSAVING_PCT = result.NSAVING_PCT,
            NDISC_SAVE_PCT = result.NDISC_SAVE_PCT,
            NDISC_UNIT_PCT = result.NDISC_UNIT_PCT,
            NINDEX_TABLE = result.NINDEX_TABLE,
            NWARRN_TABLE = result.NWARRN_TABLE,
            NOPTION = result.NOPTION,
            NPREMIUMBAS = result.NPREMIUMBAS,
            NMODULEC = result.NMODULEC,
            NPREMDEAL = result.NPREMDEAL,
            NPREMDEAL_ANU = result.NPREMDEAL_ANU,
            NPREMMIN = result.NPREMMIN,
            NINTWARR = result.NINTWARR,
            SPRINTCOV = result.SPRINTCOV,
            SFOLIONUMBER = result.SFOLIONUMBER,
            NYEARMONTH_FPAY = result.NYEARMONTH_FPAY,
            NTAXREGIME = result.NTAXREGIME,
            NCOD_SAAPV = result.NCOD_SAAPV,
            NINSTITUTION = result.NINSTITUTION,
            NTYPEEXC = result.NTYPEEXC,
            NNOTCANCELDAY = result.NNOTCANCELDAY,
            NPARTICIP_POLEMP = result.NPARTICIP_POLEMP,
            NPARTICIP_POLCO = result.NPARTICIP_POLCO,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5560DropdownAsync();
        await PopulateTABLE268DropdownAsync();
        await PopulateTABLE2DropdownAsync();
        return View("~/Views/Insudb/LIFE/Edit.cshtml", updateDto);
    }

    // POST: LIFE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLIFEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5560DropdownAsync();
        await PopulateTABLE268DropdownAsync();
        await PopulateTABLE2DropdownAsync();
        return View("~/Views/Insudb/LIFE/Edit.cshtml", updateDto);
    }

    // GET: LIFE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE/Delete.cshtml", result);
    }

    // POST: LIFE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

    private async Task PopulateTABLE5560DropdownAsync()
    {
        var items = await _TABLE5560Service.GetAllAsync();
        ViewData["NCALCAPITAL"] = new SelectList(items, nameof(TABLE5560Dto.NCALCAPITAL), "SDESCRIPT");
        ViewData["NTYPPREMIUM"] = new SelectList(items, nameof(TABLE5560Dto.NCALCAPITAL), "SDESCRIPT");
    }

    private async Task PopulateTABLE268DropdownAsync()
    {
        var items = await _TABLE268Service.GetAllAsync();
        ViewData["NGROUP_COMP"] = new SelectList(items, nameof(TABLE268Dto.NGROUP_COMP), "SDESCRIPT");
    }

    private async Task PopulateTABLE2DropdownAsync()
    {
        var items = await _TABLE2Service.GetAllAsync();
        ViewData["NTYPEEXC"] = new SelectList(items, nameof(TABLE2Dto.NCODIGINT), "SDESCRIPT");
    }

}
