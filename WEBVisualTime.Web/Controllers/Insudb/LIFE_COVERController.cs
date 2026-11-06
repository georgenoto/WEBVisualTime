using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_COVER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LIFE_COVERController : Controller
{
    private readonly ILIFE_COVERService _service;
    private readonly ITAB_LIFCOVService _TAB_LIFCOVService;
    private readonly ITABLE634Service _TABLE634Service;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE5559Service _TABLE5559Service;

    public LIFE_COVERController(ILIFE_COVERService service
        , ITAB_LIFCOVService TAB_LIFCOVService
        , ITABLE634Service TABLE634Service
        , ITABLE71Service TABLE71Service
        , ITABLE75Service TABLE75Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE5559Service TABLE5559Service
    )
    {
        _service = service;
        _TAB_LIFCOVService = TAB_LIFCOVService;
        _TABLE634Service = TABLE634Service;
        _TABLE71Service = TABLE71Service;
        _TABLE75Service = TABLE75Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE5559Service = TABLE5559Service;
    }

    // GET: LIFE_COVER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LIFE_COVER/Index.cshtml");

    // GET: LIFE_COVER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_COVER/Details.cshtml", result);
    }

    // GET: LIFE_COVER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        return View("~/Views/Insudb/LIFE_COVER/Create.cshtml", new CreateLIFE_COVERDto());
    }

    // POST: LIFE_COVER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLIFE_COVERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        return View("~/Views/Insudb/LIFE_COVER/Create.cshtml", createDto);
    }

    // GET: LIFE_COVER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLIFE_COVERDto
        {
            NBRANCH = result.NBRANCH,
            NCOVER = result.NCOVER,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            DEFFECDATE = result.DEFFECDATE,
            SADDSUINI = result.SADDSUINI,
            SADDREINI = result.SADDREINI,
            SADDTAXIN = result.SADDTAXIN,
            NCOVERGEN = result.NCOVERGEN,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_GEN = result.NBRANCH_GEN,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            NCAEXTEXP = result.NCAEXTEXP,
            SMORTACOF = result.SMORTACOF,
            NCAINTEXP = result.NCAINTEXP,
            SMORTACOM = result.SMORTACOM,
            NRETARIF = result.NRETARIF,
            DCOMPDATE = result.DCOMPDATE,
            SCOVERUSE = result.SCOVERUSE,
            NCURRENCY = result.NCURRENCY,
            NINTEREST = result.NINTEREST,
            DNULLDATE = result.DNULLDATE,
            NNOTENUM = result.NNOTENUM,
            NPREXTEXP = result.NPREXTEXP,
            NPRINTEXP = result.NPRINTEXP,
            SROURESER = result.SROURESER,
            SROUSURRE = result.SROUSURRE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SCONTROL = result.SCONTROL,
            NPER_TABMOR = result.NPER_TABMOR,
            SCALREIN = result.SCALREIN,
            SDEPEND = result.SDEPEND,
            SSURV = result.SSURV,
            SREINORIGCOND = result.SREINORIGCOND,
            SCONDSVS = result.SCONDSVS,
            SROUCLATEC = result.SROUCLATEC,
            SROUTRESRISK = result.SROUTRESRISK,
            NRATECLA = result.NRATECLA,
            NFIXAMOCLA = result.NFIXAMOCLA,
            NMINAMOCLA = result.NMINAMOCLA,
            NMAXAMOCLA = result.NMAXAMOCLA,
            NDISCCLA = result.NDISCCLA,
            NDISC_AMOCLA = result.NDISC_AMOCLA,
            NFRANCDAYS = result.NFRANCDAYS,
            SRESOLUTION = result.SRESOLUTION,
            SGOVAPRNAME = result.SGOVAPRNAME,
            DRESDATE = result.DRESDATE,
            STECPREMIND = result.STECPREMIND,
            SRISPREMIND = result.SRISPREMIND,
        };
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        return View("~/Views/Insudb/LIFE_COVER/Edit.cshtml", updateDto);
    }

    // POST: LIFE_COVER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLIFE_COVERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE5559DropdownAsync();
        return View("~/Views/Insudb/LIFE_COVER/Edit.cshtml", updateDto);
    }

    // GET: LIFE_COVER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_COVER/Delete.cshtml", result);
    }

    // POST: LIFE_COVER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_LIFCOVDropdownAsync()
    {
        var items = await _TAB_LIFCOVService.GetAllAsync();
        ViewData["NCOVERGEN"] = new SelectList(items, nameof(TAB_LIFCOVDto.NCOVERGEN), "SCACALFRI");
    }

    private async Task PopulateTABLE634DropdownAsync()
    {
        var items = await _TABLE634Service.GetAllAsync();
        ViewData["NBRANCH_GEN"] = new SelectList(items, nameof(TABLE634Dto.NBRANCH_GEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE71DropdownAsync()
    {
        var items = await _TABLE71Service.GetAllAsync();
        ViewData["NBRANCH_EST"] = new SelectList(items, nameof(TABLE71Dto.NBRANCH_EST), "SDESCRIPT");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
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

}
