using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_LIFCOVController : Controller
{
    private readonly ITAB_LIFCOVService _service;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE634Service _TABLE634Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE210Service _TABLE210Service;

    public TAB_LIFCOVController(ITAB_LIFCOVService service
        , ITABLE71Service TABLE71Service
        , ITABLE75Service TABLE75Service
        , ITABLE634Service TABLE634Service
        , ITABLE5000Service TABLE5000Service
        , ICLIENTService CLIENTService
        , ITABLE210Service TABLE210Service
    )
    {
        _service = service;
        _TABLE71Service = TABLE71Service;
        _TABLE75Service = TABLE75Service;
        _TABLE634Service = TABLE634Service;
        _TABLE5000Service = TABLE5000Service;
        _CLIENTService = CLIENTService;
        _TABLE210Service = TABLE210Service;
    }

    // GET: TAB_LIFCOV
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_LIFCOV/Index.cshtml", result);
    }

    // GET: TAB_LIFCOV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_LIFCOV/Details.cshtml", result);
    }

    // GET: TAB_LIFCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/TAB_LIFCOV/Create.cshtml", new CreateTAB_LIFCOVDto());
    }

    // POST: TAB_LIFCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_LIFCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/TAB_LIFCOV/Create.cshtml", createDto);
    }

    // GET: TAB_LIFCOV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_LIFCOVDto
        {
            NCOVERGEN = result.NCOVERGEN,
            NAGEMAXI = result.NAGEMAXI,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_GEN = result.NBRANCH_GEN,
            NBRANCH_REI = result.NBRANCH_REI,
            NCACALFIX = result.NCACALFIX,
            SCACALFRI = result.SCACALFRI,
            SCAPIPREM = result.SCAPIPREM,
            SCLACCIDI = result.SCLACCIDI,
            SCLDEATHI = result.SCLDEATHI,
            SCLINCAPI = result.SCLINCAPI,
            SCLINVALI = result.SCLINVALI,
            SCLSURVII = result.SCLSURVII,
            SCLVEHACI = result.SCLVEHACI,
            DCOMPDATE = result.DCOMPDATE,
            SCOVERUSE = result.SCOVERUSE,
            NCURRENCY = result.NCURRENCY,
            SDESCRIPT = result.SDESCRIPT,
            SIDURAAGE = result.SIDURAAGE,
            SIDURAYEAR = result.SIDURAYEAR,
            SIDUROPEI = result.SIDUROPEI,
            SINSURINI = result.SINSURINI,
            NCOVER_IN = result.NCOVER_IN,
            NPREMIRAT = result.NPREMIRAT,
            SPDURAAGE = result.SPDURAAGE,
            NDURATIND = result.NDURATIND,
            NDURATPAY = result.NDURATPAY,
            SREVINDEX = result.SREVINDEX,
            SPDUROPEI = result.SPDUROPEI,
            SPDURYEAR = result.SPDURYEAR,
            SPREMCAPI = result.SPREMCAPI,
            SRECHAPRI = result.SRECHAPRI,
            SRENEWALI = result.SRENEWALI,
            SROUCHACA = result.SROUCHACA,
            SROUCHAPR = result.SROUCHAPR,
            SROUPRCAL = result.SROUPRCAL,
            SROURESER = result.SROURESER,
            SROUSURRE = result.SROUSURRE,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SCLILLNESS = result.SCLILLNESS,
            SCONDSVS = result.SCONDSVS,
            SINFORPROV = result.SINFORPROV,
            SPROVIDER = result.SPROVIDER,
            NCLA_LI_TYP = result.NCLA_LI_TYP,
            SDESCOVER = result.SDESCOVER,
            STAXHEREDITY = result.STAXHEREDITY,
            DSTARTDATE = result.DSTARTDATE,
            DOCCURDAT = result.DOCCURDAT,
        };
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/TAB_LIFCOV/Edit.cshtml", updateDto);
    }

    // POST: TAB_LIFCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_LIFCOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOVERGEN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE634DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/TAB_LIFCOV/Edit.cshtml", updateDto);
    }

    // GET: TAB_LIFCOV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_LIFCOV/Delete.cshtml", result);
    }

    // POST: TAB_LIFCOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TAB_LIFCOV/GetByNBRANCH_EST?NBRANCH_EST=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNBRANCH_EST(int NBRANCH_EST)
    {
        var items = await _service.FindAsync(p => p.NBRANCH_EST == NBRANCH_EST);
        return Json(items.Select(i => new { value = i.NCOVERGEN, text = i.SCACALFRI }));
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SPROVIDER"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE210DropdownAsync()
    {
        var items = await _TABLE210Service.GetAllAsync();
        ViewData["NCLA_LI_TYP"] = new SelectList(items, nameof(TABLE210Dto.NCLA_LI_TYP), "SDESCRIPT");
    }

}
