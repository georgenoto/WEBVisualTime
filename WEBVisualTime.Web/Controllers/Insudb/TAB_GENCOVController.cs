using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GENCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE33;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_GENCOVController : Controller
{
    private readonly ITAB_GENCOVService _service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ITABLE634Service _TABLE634Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE33Service _TABLE33Service;
    private readonly ITABLE64Service _TABLE64Service;
    private readonly ICLIENTService _CLIENTService;

    public TAB_GENCOVController(ITAB_GENCOVService service
        , ITABLE75Service TABLE75Service
        , ITABLE71Service TABLE71Service
        , ITABLE634Service TABLE634Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE33Service TABLE33Service
        , ITABLE64Service TABLE64Service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _TABLE75Service = TABLE75Service;
        _TABLE71Service = TABLE71Service;
        _TABLE634Service = TABLE634Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE33Service = TABLE33Service;
        _TABLE64Service = TABLE64Service;
        _CLIENTService = CLIENTService;
    }

    // GET: TAB_GENCOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_GENCOV/Index.cshtml");

    // GET: TAB_GENCOV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_GENCOV/Details.cshtml", result);
    }

    // GET: TAB_GENCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_GENCOV/Create.cshtml", new CreateTAB_GENCOVDto());
    }

    // POST: TAB_GENCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_GENCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_GENCOV/Create.cshtml", createDto);
    }

    // GET: TAB_GENCOV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_GENCOVDto
        {
            NCOVERGEN = result.NCOVERGEN,
            SAUTOMREP = result.SAUTOMREP,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_GEN = result.NBRANCH_GEN,
            NBRANCH_REI = result.NBRANCH_REI,
            NCACALFIX = result.NCACALFIX,
            SCACALFRI = result.SCACALFRI,
            SCACALILI = result.SCACALILI,
            SCACALREI = result.SCACALREI,
            DCOMPDATE = result.DCOMPDATE,
            NCOVER_IN = result.NCOVER_IN,
            NCURRENCY = result.NCURRENCY,
            SDESCRIPT = result.SDESCRIPT,
            SFRANCAPL = result.SFRANCAPL,
            NFRANCFIX = result.NFRANCFIX,
            NFRANCMAX = result.NFRANCMAX,
            NFRANCMIN = result.NFRANCMIN,
            NFRANCRAT = result.NFRANCRAT,
            SFRANTYPE = result.SFRANTYPE,
            NMEDRESER = result.NMEDRESER,
            NPREMIFIX = result.NPREMIFIX,
            NPREMIMAX = result.NPREMIMAX,
            NPREMIMIN = result.NPREMIMIN,
            NPREMIRAT = result.NPREMIRAT,
            SROUCAPIT = result.SROUCAPIT,
            SROUFRANC = result.SROUFRANC,
            SROUPREMI = result.SROUPREMI,
            SROURESER = result.SROURESER,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SCONDSVS = result.SCONDSVS,
            SINFORPROV = result.SINFORPROV,
            SPROVIDER = result.SPROVIDER,
            SRISK = result.SRISK,
            NFRANCRATCLA = result.NFRANCRATCLA,
            NFRANCFIXCLA = result.NFRANCFIXCLA,
            NFRANXMINCLA = result.NFRANXMINCLA,
            NFRANXMAXCLA = result.NFRANXMAXCLA,
            SROUFRANCCLA = result.SROUFRANCCLA,
            STAXHEREDITY = result.STAXHEREDITY,
            DSTARTDATE = result.DSTARTDATE,
            DOCCURDAT = result.DOCCURDAT,
        };
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_GENCOV/Edit.cshtml", updateDto);
    }

    // POST: TAB_GENCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_GENCOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOVERGEN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE33DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_GENCOV/Edit.cshtml", updateDto);
    }

    // GET: TAB_GENCOV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_GENCOV/Delete.cshtml", result);
    }

    // POST: TAB_GENCOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateTABLE71DropdownAsync()
    {
        var items = await _TABLE71Service.GetAllAsync();
        ViewData["NBRANCH_EST"] = new SelectList(items, nameof(TABLE71Dto.NBRANCH_EST), "SDESCRIPT");
    }

    private async Task PopulateTABLE634DropdownAsync()
    {
        var items = await _TABLE634Service.GetAllAsync();
        ViewData["NBRANCH_GEN"] = new SelectList(items, nameof(TABLE634Dto.NBRANCH_GEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SPROVIDER"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
