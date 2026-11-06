using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5547;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COVERController : Controller
{
    private readonly ICOVERService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly ITABLE64Service _TABLE64Service;
    private readonly ITABLE52Service _TABLE52Service;
    private readonly ITABLE33Service _TABLE33Service;
    private readonly ITABLE5589Service _TABLE5589Service;
    private readonly ITABLE5547Service _TABLE5547Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE5559Service _TABLE5559Service;
    private readonly ITABLE340Service _TABLE340Service;

    public COVERController(ICOVERService service
        , ICERTIFICATService CERTIFICATService
        , ICLIENTService CLIENTService
        , ITABLE12Service TABLE12Service
        , ITABLE64Service TABLE64Service
        , ITABLE52Service TABLE52Service
        , ITABLE33Service TABLE33Service
        , ITABLE5589Service TABLE5589Service
        , ITABLE5547Service TABLE5547Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE5559Service TABLE5559Service
        , ITABLE340Service TABLE340Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLIENTService = CLIENTService;
        _TABLE12Service = TABLE12Service;
        _TABLE64Service = TABLE64Service;
        _TABLE52Service = TABLE52Service;
        _TABLE33Service = TABLE33Service;
        _TABLE5589Service = TABLE5589Service;
        _TABLE5547Service = TABLE5547Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE5559Service = TABLE5559Service;
        _TABLE340Service = TABLE340Service;
    }

    // GET: COVER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COVER/Index.cshtml");

    // GET: COVER/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER/Details.cshtml", result);
    }

    // GET: COVER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5547DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER/Create.cshtml", new CreateCOVERDto());
    }

    // POST: COVER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOVERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5547DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER/Create.cshtml", createDto);
    }

    // GET: COVER/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOVERDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            DEFFECDATE = result.DEFFECDATE,
            SCLIENT = result.SCLIENT,
            NROLE = result.NROLE,
            NCAPITAL = result.NCAPITAL,
            NCAPITALI = result.NCAPITALI,
            SCHANGE = result.SCHANGE,
            DCOMPDATE = result.DCOMPDATE,
            SFRANDEDI = result.SFRANDEDI,
            NCURRENCY = result.NCURRENCY,
            NDISCOUNT = result.NDISCOUNT,
            NFIXAMOUNT = result.NFIXAMOUNT,
            NMAXAMOUNT = result.NMAXAMOUNT,
            SFREE_PREMI = result.SFREE_PREMI,
            NMINAMOUNT = result.NMINAMOUNT,
            DNULLDATE = result.DNULLDATE,
            NPREMIUM = result.NPREMIUM,
            NRATE = result.NRATE,
            NWAIT_QUAN = result.NWAIT_QUAN,
            NRATECOVE = result.NRATECOVE,
            NUSERCODE = result.NUSERCODE,
            SWAIT_TYPE = result.SWAIT_TYPE,
            SFRANCAPL = result.SFRANCAPL,
            NDISC_AMOUN = result.NDISC_AMOUN,
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
            NRETARIF = result.NRETARIF,
            NCAPITAL_O = result.NCAPITAL_O,
            NPREMIUM_O = result.NPREMIUM_O,
            NRATECOVE_O = result.NRATECOVE_O,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NCOMMI_AN = result.NCOMMI_AN,
            NRATECOVE_B = result.NRATECOVE_B,
            NCAPITAL_REQ = result.NCAPITAL_REQ,
            NRATECLA = result.NRATECLA,
            NFIXAMOCLA = result.NFIXAMOCLA,
            NMINAMOCLA = result.NMINAMOCLA,
            NMAXAMOCLA = result.NMAXAMOCLA,
            NDISCCLA = result.NDISCCLA,
            NDISC_AMOCLA = result.NDISC_AMOCLA,
            NFRANCDAYS = result.NFRANCDAYS,
            NFREQMAXEVEN = result.NFREQMAXEVEN,
            SROUTMAX_EVEN = result.SROUTMAX_EVEN,
            NFREQUEN = result.NFREQUEN,
            NMAXEVEN_QUAN = result.NMAXEVEN_QUAN,
            SREDUCCAPITAL = result.SREDUCCAPITAL,
            NREDUCAPAGE = result.NREDUCAPAGE,
            NAGELIMITCAP = result.NAGELIMITCAP,
            NPERCCOAS = result.NPERCCOAS,
            DFREE_PREM_IN = result.DFREE_PREM_IN,
            DFREE_PREM_LIM = result.DFREE_PREM_LIM,
            DANTIDATE = result.DANTIDATE,
            NANTI_AMOUNT = result.NANTI_AMOUNT,
            NCLAIMRAT = result.NCLAIMRAT,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
            SCOVERCHANGE = result.SCOVERCHANGE,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5547DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER/Edit.cshtml", updateDto);
    }

    // POST: COVER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOVERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE5589DropdownAsync();
        await PopulateTABLE5547DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        await PopulateTABLE340DropdownAsync();
        return View("~/Views/Insudb/COVER/Edit.cshtml", updateDto);
    }

    // GET: COVER/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER/Delete.cshtml", result);
    }

    // POST: COVER/Delete/{id}
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
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
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

    private async Task PopulateTABLE5547DropdownAsync()
    {
        var items = await _TABLE5547Service.GetAllAsync();
        ViewData["NCAUSEUPD"] = new SelectList(items, nameof(TABLE5547Dto.NCAUSEUPD), "SDESCRIPT");
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
