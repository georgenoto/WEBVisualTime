using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_CO_P;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COVER_CO_PController : Controller
{
    private readonly ICOVER_CO_PService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly ITABLE64Service _TABLE64Service;
    private readonly ITABLE52Service _TABLE52Service;
    private readonly ITABLE33Service _TABLE33Service;
    private readonly ITABLE5589Service _TABLE5589Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE5559Service _TABLE5559Service;
    private readonly ITABLE340Service _TABLE340Service;

    public COVER_CO_PController(ICOVER_CO_PService service
        , IPOLICYService POLICYService
        , ITABLE12Service TABLE12Service
        , ITABLE64Service TABLE64Service
        , ITABLE52Service TABLE52Service
        , ITABLE33Service TABLE33Service
        , ITABLE5589Service TABLE5589Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE5559Service TABLE5559Service
        , ITABLE340Service TABLE340Service
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _TABLE12Service = TABLE12Service;
        _TABLE64Service = TABLE64Service;
        _TABLE52Service = TABLE52Service;
        _TABLE33Service = TABLE33Service;
        _TABLE5589Service = TABLE5589Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE5559Service = TABLE5559Service;
        _TABLE340Service = TABLE340Service;
    }

    // GET: COVER_CO_P
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COVER_CO_P/Index.cshtml", result);
    }

    // GET: COVER_CO_P/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_CO_P/Details.cshtml", result);
    }

    // GET: COVER_CO_P/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER_CO_P/Create.cshtml", new CreateCOVER_CO_PDto());
    }

    // POST: COVER_CO_P/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOVER_CO_PDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER_CO_P/Create.cshtml", createDto);
    }

    // GET: COVER_CO_P/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOVER_CO_PDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            DEFFECDATE = result.DEFFECDATE,
            NROLE = result.NROLE,
            NCAPITAL = result.NCAPITAL,
            SCHANGE = result.SCHANGE,
            DCOMPDATE = result.DCOMPDATE,
            SFRANDEDI = result.SFRANDEDI,
            NCURRENCY = result.NCURRENCY,
            NDISCOUNT = result.NDISCOUNT,
            NFIXAMOUNT = result.NFIXAMOUNT,
            NMAXAMOUNT = result.NMAXAMOUNT,
            DNULLDATE = result.DNULLDATE,
            NMINAMOUNT = result.NMINAMOUNT,
            NWAIT_QUAN = result.NWAIT_QUAN,
            SWAIT_TYPE = result.SWAIT_TYPE,
            NRATE = result.NRATE,
            NUSERCODE = result.NUSERCODE,
            SFRANCAPL = result.SFRANCAPL,
            NDISC_AMOUN = result.NDISC_AMOUN,
            NDURINSUR = result.NDURINSUR,
            NTYPDURINS = result.NTYPDURINS,
            NAGEMININSM = result.NAGEMININSM,
            NAGEMAXINSM = result.NAGEMAXINSM,
            NAGEMAXPERM = result.NAGEMAXPERM,
            NAGEMININSF = result.NAGEMININSF,
            NAGEMAXINSF = result.NAGEMAXINSF,
            NAGEMAXPERF = result.NAGEMAXPERF,
            NDURPAY = result.NDURPAY,
            NTYPDURPAY = result.NTYPDURPAY,
            NRATECOVE = result.NRATECOVE,
            NPREMIUM = result.NPREMIUM,
            NBRANCH_REI = result.NBRANCH_REI,
            NRETARIF = result.NRETARIF,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRED = result.SREQUIRED,
            NCAPITAL_O = result.NCAPITAL_O,
            NPREMIUM_O = result.NPREMIUM_O,
            NRATECOVE_O = result.NRATECOVE_O,
            NCAPITALTOT = result.NCAPITALTOT,
            NCAPITALWAITTOT = result.NCAPITALWAITTOT,
            NPREMIUMTOT = result.NPREMIUMTOT,
            NRATEAVG_N = result.NRATEAVG_N,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NCOMMI_AN = result.NCOMMI_AN,
            NRATECOVE_B = result.NRATECOVE_B,
            NCAPMAX = result.NCAPMAX,
            NCAPMIN = result.NCAPMIN,
            NPREMAX = result.NPREMAX,
            NPREMIN = result.NPREMIN,
            NTYP_AGEMINM = result.NTYP_AGEMINM,
            NTYP_AGEMINF = result.NTYP_AGEMINF,
            NPERCENT = result.NPERCENT,
            NFREQMAXEVEN = result.NFREQMAXEVEN,
            NMAXEVEN_QUAN = result.NMAXEVEN_QUAN,
            NFREQUEN = result.NFREQUEN,
            SROUTMAX_EVEN = result.SROUTMAX_EVEN,
            NMOVEMENT = result.NMOVEMENT,
            NPREMIUM_SM = result.NPREMIUM_SM,
            NPREMIUM_CM = result.NPREMIUM_CM,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER_CO_P/Edit.cshtml", updateDto);
    }

    // POST: COVER_CO_P/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOVER_CO_PDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER_CO_P/Edit.cshtml", updateDto);
    }

    // GET: COVER_CO_P/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_CO_P/Delete.cshtml", result);
    }

    // POST: COVER_CO_P/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateTABLE64DropdownAsync()
    {
        var items = await _TABLE64Service.GetAllAsync();
        ViewData["SFRANDEDI"] = new SelectList(items, nameof(TABLE64Dto.SFRANTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE52DropdownAsync()
    {
        var items = await _TABLE52Service.GetAllAsync();
        ViewData["SWAIT_TYPE"] = new SelectList(items, nameof(TABLE52Dto.SCAREN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE33DropdownAsync()
    {
        var items = await _TABLE33Service.GetAllAsync();
        ViewData["SFRANCAPL"] = new SelectList(items, nameof(TABLE33Dto.SFRANCAPL), "SDESCRIPT");
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
        ViewData["NTYPDURPAY"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE5559DropdownAsync()
    {
        var items = await _TABLE5559Service.GetAllAsync();
        ViewData["NRETARIF"] = new SelectList(items, nameof(TABLE5559Dto.NRETARIF), "SDESCRIPT");
    }

    private async Task PopulateTABLE340DropdownAsync()
    {
        var items = await _TABLE340Service.GetAllAsync();
        ViewData["NFREQMAXEVEN"] = new SelectList(items, nameof(TABLE340Dto.NFREQMAXEVEN), "SDESCRIPT");
    }

}
