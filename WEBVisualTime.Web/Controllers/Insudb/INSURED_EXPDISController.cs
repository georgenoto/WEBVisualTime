using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INSURED_EXPDIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INSURED_EXPDISController : Controller
{
    private readonly IINSURED_EXPDISService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLIENTService _CLIENTService;
    private readonly IUSERSService _USERSService;

    public INSURED_EXPDISController(IINSURED_EXPDISService service
        , ICERTIFICATService CERTIFICATService
        , ICLIENTService CLIENTService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLIENTService = CLIENTService;
        _USERSService = USERSService;
    }

    // GET: INSURED_EXPDIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INSURED_EXPDIS/Index.cshtml");

    // GET: INSURED_EXPDIS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INSURED_EXPDIS/Details.cshtml", result);
    }

    // GET: INSURED_EXPDIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/INSURED_EXPDIS/Create.cshtml", new CreateINSURED_EXPDISDto());
    }

    // POST: INSURED_EXPDIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINSURED_EXPDISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/INSURED_EXPDIS/Create.cshtml", createDto);
    }

    // GET: INSURED_EXPDIS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINSURED_EXPDISDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NGROUP_INSU = result.NGROUP_INSU,
            SCLIENT = result.SCLIENT,
            NDISEXPRC = result.NDISEXPRC,
            SDISEXPRI = result.SDISEXPRI,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            DEFFECDATE = result.DEFFECDATE,
            SUNIT = result.SUNIT,
            NRATE = result.NRATE,
            NAMOUNT = result.NAMOUNT,
            DNULLDATE = result.DNULLDATE,
            SPERM_TEMP = result.SPERM_TEMP,
            DDATE_FR = result.DDATE_FR,
            DDATE_TO = result.DDATE_TO,
            NAGE = result.NAGE,
            NNOTENUM = result.NNOTENUM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCAUSE = result.NCAUSE,
            SAGREE = result.SAGREE,
            SINITDATE_CALC = result.SINITDATE_CALC,
            NACTIVITY = result.NACTIVITY,
            NSPORT = result.NSPORT,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/INSURED_EXPDIS/Edit.cshtml", updateDto);
    }

    // POST: INSURED_EXPDIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINSURED_EXPDISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/INSURED_EXPDIS/Edit.cshtml", updateDto);
    }

    // GET: INSURED_EXPDIS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INSURED_EXPDIS/Delete.cshtml", result);
    }

    // POST: INSURED_EXPDIS/Delete/{id}
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

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
