using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODUCT_LI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE34;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE113;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE114;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE74;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE124;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5675;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5644;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8300;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PRODUCT_LIController : Controller
{
    private readonly IPRODUCT_LIService _service;
    private readonly ITABLE34Service _TABLE34Service;
    private readonly ITABLE113Service _TABLE113Service;
    private readonly ITABLE36Service _TABLE36Service;
    private readonly ITABLE114Service _TABLE114Service;
    private readonly ITABLE5589Service _TABLE5589Service;
    private readonly ITABLE74Service _TABLE74Service;
    private readonly ITABLE46Service _TABLE46Service;
    private readonly ITABLE124Service _TABLE124Service;
    private readonly ITABLE5675Service _TABLE5675Service;
    private readonly ITABLE5644Service _TABLE5644Service;
    private readonly ITABLE8300Service _TABLE8300Service;

    public PRODUCT_LIController(IPRODUCT_LIService service
        , ITABLE34Service TABLE34Service
        , ITABLE113Service TABLE113Service
        , ITABLE36Service TABLE36Service
        , ITABLE114Service TABLE114Service
        , ITABLE5589Service TABLE5589Service
        , ITABLE74Service TABLE74Service
        , ITABLE46Service TABLE46Service
        , ITABLE124Service TABLE124Service
        , ITABLE5675Service TABLE5675Service
        , ITABLE5644Service TABLE5644Service
        , ITABLE8300Service TABLE8300Service
    )
    {
        _service = service;
        _TABLE34Service = TABLE34Service;
        _TABLE113Service = TABLE113Service;
        _TABLE36Service = TABLE36Service;
        _TABLE114Service = TABLE114Service;
        _TABLE5589Service = TABLE5589Service;
        _TABLE74Service = TABLE74Service;
        _TABLE46Service = TABLE46Service;
        _TABLE124Service = TABLE124Service;
        _TABLE5675Service = TABLE5675Service;
        _TABLE5644Service = TABLE5644Service;
        _TABLE8300Service = TABLE8300Service;
    }

    // GET: PRODUCT_LI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PRODUCT_LI/Index.cshtml", result);
    }

    // GET: PRODUCT_LI/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODUCT_LI/Details.cshtml", result);
    }

    // GET: PRODUCT_LI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE34DropdownAsync();
        await PopulateTABLE113DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE114DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE74DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE124DropdownAsync();
        await PopulateTABLE5675DropdownAsync();
        await PopulateTABLE5644DropdownAsync();
        await PopulateTABLE8300DropdownAsync();
        return View("~/Views/Insudb/PRODUCT_LI/Create.cshtml", new CreatePRODUCT_LIDto());
    }

    // POST: PRODUCT_LI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePRODUCT_LIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE34DropdownAsync();
        await PopulateTABLE113DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE114DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE74DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE124DropdownAsync();
        await PopulateTABLE5675DropdownAsync();
        await PopulateTABLE5644DropdownAsync();
        await PopulateTABLE8300DropdownAsync();
        return View("~/Views/Insudb/PRODUCT_LI/Create.cshtml", createDto);
    }

    // GET: PRODUCT_LI/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePRODUCT_LIDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            SACCOUNTI = result.SACCOUNTI,
            NANLIFINT = result.NANLIFINT,
            NANNUALAP = result.NANNUALAP,
            SASSOCIAI = result.SASSOCIAI,
            NBENEFAPL = result.NBENEFAPL,
            NBENEFEXC = result.NBENEFEXC,
            NBENEFITR = result.NBENEFITR,
            NBENEXCRA = result.NBENEXCRA,
            NCHARGE = result.NCHARGE,
            SCLALLPRE = result.SCLALLPRE,
            SCLANNPEI = result.SCLANNPEI,
            SCLLIFEAI = result.SCLLIFEAI,
            SCLNOPREI = result.SCLNOPREI,
            SCLPAYPRI = result.SCLPAYPRI,
            SCLSIMPAI = result.SCLSIMPAI,
            SCLSURREI = result.SCLSURREI,
            SCLTRANSI = result.SCLTRANSI,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NDEDUFREQ = result.NDEDUFREQ,
            NENTRANCE = result.NENTRANCE,
            NSURRFREQ = result.NSURRFREQ,
            NIDURAFIX = result.NIDURAFIX,
            NTYPDURINS = result.NTYPDURINS,
            SIDURVARI = result.SIDURVARI,
            NINTEREST = result.NINTEREST,
            SMETHAGAV = result.SMETHAGAV,
            SMETHPRAV = result.SMETHPRAV,
            SMETHPRIN = result.SMETHPRIN,
            SMORCAPII = result.SMORCAPII,
            SNOPERIOD = result.SNOPERIOD,
            NNPEMULTI = result.NNPEMULTI,
            NNPENUMAI = result.NNPENUMAI,
            NNPENUNMI = result.NNPENUNMI,
            SNPEUNIFA = result.SNPEUNIFA,
            DNULLDATE = result.DNULLDATE,
            NPAYINITI = result.NPAYINITI,
            NPAYINTER = result.NPAYINTER,
            SPERIODIC = result.SPERIODIC,
            NPERMULTI = result.NPERMULTI,
            NPERNOPAY = result.NPERNOPAY,
            NPERNUMAI = result.NPERNUMAI,
            NPERNUNMI = result.NPERNUNMI,
            NPERREVFA = result.NPERREVFA,
            SREVALTYP = result.SREVALTYP,
            SPERUNIFA = result.SPERUNIFA,
            NPRODCLAS = result.NPRODCLAS,
            NQBONUSMA = result.NQBONUSMA,
            NQBONUSMI = result.NQBONUSMI,
            NREAGEMAX = result.NREAGEMAX,
            SROUADVAN = result.SROUADVAN,
            SROUREDDC = result.SROUREDDC,
            SROUREDUC = result.SROUREDUC,
            SROUSURRE = result.SROUSURRE,
            NSUAGEMAX = result.NSUAGEMAX,
            NSUAGEMIN = result.NSUAGEMIN,
            NSURCASHV = result.NSURCASHV,
            SSURRENPI = result.SSURRENPI,
            SSURRENTI = result.SSURRENTI,
            SULFCHANI = result.SULFCHANI,
            NULFMAXQU = result.NULFMAXQU,
            NULRCHARG = result.NULRCHARG,
            NULREDPER = result.NULREDPER,
            NULRMAXQU = result.NULRMAXQU,
            NULRSCHAR = result.NULRSCHAR,
            NULSCHARG = result.NULSCHARG,
            NULSMAXQU = result.NULSMAXQU,
            SASSOTOTAL = result.SASSOTOTAL,
            NULSSCHAR = result.NULSSCHAR,
            NULSWIPER = result.NULSWIPER,
            SBENRES = result.SBENRES,
            NUSERCODE = result.NUSERCODE,
            NVALUEBON = result.NVALUEBON,
            NYEARMINS = result.NYEARMINS,
            NYEARMINW = result.NYEARMINW,
            NYEARMORS = result.NYEARMORS,
            SPREMIUMTYPE = result.SPREMIUMTYPE,
            NTAXSMOKE = result.NTAXSMOKE,
            NTAXNSMOKE = result.NTAXNSMOKE,
            NCHARGEAMO = result.NCHARGEAMO,
            NMONTHAMO = result.NMONTHAMO,
            NADMINRATE = result.NADMINRATE,
            NQMEPLOANS = result.NQMEPLOANS,
            NQMMLOANS = result.NQMMLOANS,
            NQMYLOANS = result.NQMYLOANS,
            NAMINLOANS = result.NAMINLOANS,
            NAMAXLOANS = result.NAMAXLOANS,
            NPERVSLOANS = result.NPERVSLOANS,
            NPERCTOL = result.NPERCTOL,
            NQMEPSURR = result.NQMEPSURR,
            NQMMSURR = result.NQMMSURR,
            NQMYSURR = result.NQMYSURR,
            NAMINSURR = result.NAMINSURR,
            NAMAXSURR = result.NAMAXSURR,
            NPERVSSURR = result.NPERVSSURR,
            NCAPMINSURR = result.NCAPMINSURR,
            NTAXES = result.NTAXES,
            NPREMMIN = result.NPREMMIN,
            NQMONVPN = result.NQMONVPN,
            NQMONTOVPN = result.NQMONTOVPN,
            NRATEREH = result.NRATEREH,
            SROUINTEREST = result.SROUINTEREST,
            NBILL_ITEM = result.NBILL_ITEM,
            SROUTINSU = result.SROUTINSU,
            NMINRENT = result.NMINRENT,
            NMAXRENT = result.NMAXRENT,
            SROUTINE_C = result.SROUTINE_C,
            NPDURAFIX = result.NPDURAFIX,
            SPDURVARI = result.SPDURVARI,
            NTYPDURPAY = result.NTYPDURPAY,
            SROUTPAY = result.SROUTPAY,
            NSAVING_PCT = result.NSAVING_PCT,
            NINDEX_TABLE = result.NINDEX_TABLE,
            NWARRN_TABLE = result.NWARRN_TABLE,
            SS_ALLWCHNG = result.SS_ALLWCHNG,
            SIX_ALLWCHNG = result.SIX_ALLWCHNG,
            SW_ALLWCHNG = result.SW_ALLWCHNG,
            NINFTYPE = result.NINFTYPE,
            NDAY_BMG = result.NDAY_BMG,
            SAPV = result.SAPV,
            NULSMIN = result.NULSMIN,
            NCOSTRE = result.NCOSTRE,
            NYEAR_BMG = result.NYEAR_BMG,
            NAGE_BMG = result.NAGE_BMG,
            NPERCDEVOLU = result.NPERCDEVOLU,
            NDAYBUYUNIT = result.NDAYBUYUNIT,
            NMAXCHARGSURR = result.NMAXCHARGSURR,
            NORIGIN_SURR = result.NORIGIN_SURR,
            NORIGIN_LOAN = result.NORIGIN_LOAN,
            NULMMSW = result.NULMMSW,
            NULMMRD = result.NULMMRD,
            NULSWMAXPER = result.NULSWMAXPER,
            NULRDMAXPER = result.NULRDMAXPER,
            NULSWMQT = result.NULSWMQT,
            NULRDMQT = result.NULRDMQT,
            NULSWMQTPER = result.NULSWMQTPER,
            NULRDMQTPER = result.NULRDMQTPER,
            NULSWCHPERC = result.NULSWCHPERC,
            NULRDCHPERC = result.NULRDCHPERC,
            SINDCL_PAY = result.SINDCL_PAY,
            NDAYISSUE = result.NDAYISSUE,
            NPERC_SECUR = result.NPERC_SECUR,
            SROUTINESURR = result.SROUTINESURR,
            SAPPLYROUSURR = result.SAPPLYROUSURR,
            SACCOUNT_MIRROR = result.SACCOUNT_MIRROR,
            NWARRN_TABLE_MIRROR = result.NWARRN_TABLE_MIRROR,
            NQMMPSURR = result.NQMMPSURR,
            NBALMINSURR = result.NBALMINSURR,
            NBMG = result.NBMG,
            SROUTINEVPN = result.SROUTINEVPN,
            SPRORATE = result.SPRORATE,
            SNO_HOLIDAYS = result.SNO_HOLIDAYS,
            NTYPE_RATEPROY = result.NTYPE_RATEPROY,
            NAOF = result.NAOF,
            STYPPB = result.STYPPB,
            SLOANSGUARANT = result.SLOANSGUARANT,
            NSPECI_RANDOM = result.NSPECI_RANDOM,
            SROUTINEREQPREM = result.SROUTINEREQPREM,
            SPOSTEXPIRATION = result.SPOSTEXPIRATION,
            SROUTPR = result.SROUTPR,
            SROUMINBAL = result.SROUMINBAL,
            SREFINANCE_LOANS = result.SREFINANCE_LOANS,
            NQMONVPN_VIG = result.NQMONVPN_VIG,
            NPERMIN_TEC = result.NPERMIN_TEC,
            NDAYS_SELLS = result.NDAYS_SELLS,
            NCHARGFIXLOANS = result.NCHARGFIXLOANS,
            NBALMINPB = result.NBALMINPB,
            STYPESURRLOAN = result.STYPESURRLOAN,
            SAUTOLOANS = result.SAUTOLOANS,
            SROUTINE_RANDOM = result.SROUTINE_RANDOM,
            NSMOKING_RANDOM = result.NSMOKING_RANDOM,
            NASSIST_RANDOM = result.NASSIST_RANDOM,
        };
        await PopulateTABLE34DropdownAsync();
        await PopulateTABLE113DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE114DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE74DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE124DropdownAsync();
        await PopulateTABLE5675DropdownAsync();
        await PopulateTABLE5644DropdownAsync();
        await PopulateTABLE8300DropdownAsync();
        return View("~/Views/Insudb/PRODUCT_LI/Edit.cshtml", updateDto);
    }

    // POST: PRODUCT_LI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePRODUCT_LIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE34DropdownAsync();
        await PopulateTABLE113DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE114DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE74DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE124DropdownAsync();
        await PopulateTABLE5675DropdownAsync();
        await PopulateTABLE5644DropdownAsync();
        await PopulateTABLE8300DropdownAsync();
        return View("~/Views/Insudb/PRODUCT_LI/Edit.cshtml", updateDto);
    }

    // GET: PRODUCT_LI/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODUCT_LI/Delete.cshtml", result);
    }

    // POST: PRODUCT_LI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE34DropdownAsync()
    {
        var items = await _TABLE34Service.GetAllAsync();
        ViewData["NANLIFINT"] = new SelectList(items, nameof(TABLE34Dto.NANLIFINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE113DropdownAsync()
    {
        var items = await _TABLE113Service.GetAllAsync();
        ViewData["NBENEFAPL"] = new SelectList(items, nameof(TABLE113Dto.NBENEFAPL), "SDESCRIPT");
    }

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NDEDUFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
        ViewData["NULREDPER"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
        ViewData["NULSWIPER"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

    private async Task PopulateTABLE114DropdownAsync()
    {
        var items = await _TABLE114Service.GetAllAsync();
        ViewData["NSURRFREQ"] = new SelectList(items, nameof(TABLE114Dto.NSURRFREQ), "SDESCRIPT");
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

    private async Task PopulateTABLE74DropdownAsync()
    {
        var items = await _TABLE74Service.GetAllAsync();
        ViewData["NPAYINTER"] = new SelectList(items, nameof(TABLE74Dto.NPAYINTER), "SDESCRIPT");
    }

    private async Task PopulateTABLE46DropdownAsync()
    {
        var items = await _TABLE46Service.GetAllAsync();
        ViewData["SREVALTYP"] = new SelectList(items, nameof(TABLE46Dto.SREVALTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE124DropdownAsync()
    {
        var items = await _TABLE124Service.GetAllAsync();
        ViewData["NPRODCLAS"] = new SelectList(items, nameof(TABLE124Dto.NPRODCLAS), "SDESCRIPT");
    }

    private async Task PopulateTABLE5675DropdownAsync()
    {
        var items = await _TABLE5675Service.GetAllAsync();
        ViewData["NINFTYPE"] = new SelectList(items, nameof(TABLE5675Dto.NINFTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5644DropdownAsync()
    {
        var items = await _TABLE5644Service.GetAllAsync();
        ViewData["NULSWMAXPER"] = new SelectList(items, nameof(TABLE5644Dto.NTYPE_PERIOD), "SDESCRIPT");
        ViewData["NULRDMAXPER"] = new SelectList(items, nameof(TABLE5644Dto.NTYPE_PERIOD), "SDESCRIPT");
        ViewData["NULSWMQTPER"] = new SelectList(items, nameof(TABLE5644Dto.NTYPE_PERIOD), "SDESCRIPT");
        ViewData["NULRDMQTPER"] = new SelectList(items, nameof(TABLE5644Dto.NTYPE_PERIOD), "SDESCRIPT");
    }

    private async Task PopulateTABLE8300DropdownAsync()
    {
        var items = await _TABLE8300Service.GetAllAsync();
        ViewData["NTYPE_RATEPROY"] = new SelectList(items, nameof(TABLE8300Dto.NTYPE_RATEPROY), "SDESCRIPT");
    }

}
