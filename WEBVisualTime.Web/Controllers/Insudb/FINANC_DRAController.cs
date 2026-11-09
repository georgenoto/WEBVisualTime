using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_DRA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE253;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE282;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FINANC_DRAController : Controller
{
    private readonly IFINANC_DRAService _service;
    private readonly ITABLE253Service _TABLE253Service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE282Service _TABLE282Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly IUSERSService _USERSService;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE5566Service _TABLE5566Service;
    private readonly ITABLE5002Service _TABLE5002Service;

    public FINANC_DRAController(IFINANC_DRAService service
        , ITABLE253Service TABLE253Service
        , ICLAIMService CLAIMService
        , ITABLE282Service TABLE282Service
        , IINTERMEDIAService INTERMEDIAService
        , IUSERSService USERSService
        , ICOLFORMREFService COLFORMREFService
        , ITABLE5566Service TABLE5566Service
        , ITABLE5002Service TABLE5002Service
    )
    {
        _service = service;
        _TABLE253Service = TABLE253Service;
        _CLAIMService = CLAIMService;
        _TABLE282Service = TABLE282Service;
        _INTERMEDIAService = INTERMEDIAService;
        _USERSService = USERSService;
        _COLFORMREFService = COLFORMREFService;
        _TABLE5566Service = TABLE5566Service;
        _TABLE5002Service = TABLE5002Service;
    }

    // GET: FINANC_DRA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FINANC_DRA/Index.cshtml");

    // GET: FINANC_DRA/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_DRA/Details.cshtml", result);
    }

    // GET: FINANC_DRA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE253DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE282DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANC_DRA/Create.cshtml", new CreateFINANC_DRADto());
    }

    // POST: FINANC_DRA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFINANC_DRADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE253DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE282DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANC_DRA/Create.cshtml", createDto);
    }

    // GET: FINANC_DRA/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFINANC_DRADto
        {
            NAMOUNT = result.NAMOUNT,
            NSTAT_DRAFT = result.NSTAT_DRAFT,
            NAMOUNT_NET = result.NAMOUNT_NET,
            NCLAIM = result.NCLAIM,
            NCOMMISSION = result.NCOMMISSION,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            DEXPIRDAT = result.DEXPIRDAT,
            NINTAMMOU = result.NINTAMMOU,
            NSTATPRINT = result.NSTATPRINT,
            NINTERMED = result.NINTERMED,
            DSTAT_DATE = result.DSTAT_DATE,
            NUSERCODE = result.NUSERCODE,
            NBULLETINS = result.NBULLETINS,
            NAMO_AFEC = result.NAMO_AFEC,
            NAMO_EXEN = result.NAMO_EXEN,
            NIVA = result.NIVA,
            NCOM_AFEC = result.NCOM_AFEC,
            NCOM_EXEN = result.NCOM_EXEN,
            DLIMITDATE = result.DLIMITDATE,
            NBORDEREAUX = result.NBORDEREAUX,
            SINDCHEQUE = result.SINDCHEQUE,
            DCOLLSUS_INI = result.DCOLLSUS_INI,
            DCOLLSUS_END = result.DCOLLSUS_END,
            NSUS_REASON = result.NSUS_REASON,
            SSUS_ORIGI = result.SSUS_ORIGI,
            NCOLLECTOR = result.NCOLLECTOR,
            NBILLNUM = result.NBILLNUM,
            SBILLTYPE = result.SBILLTYPE,
            NWAY_PAY = result.NWAY_PAY,
            SDOCNUMBE = result.SDOCNUMBE,
            NRETENTIONTAXCODE = result.NRETENTIONTAXCODE,
            NRETENTIONCODE = result.NRETENTIONCODE,
            NRETENTIONSERIES = result.NRETENTIONSERIES,
            DAUTORIZATIONDATE = result.DAUTORIZATIONDATE,
            DENDINGDATE = result.DENDINGDATE,
            NRETENTION = result.NRETENTION,
            NTAXRETENTION = result.NTAXRETENTION,
            NRETENTIONBASE = result.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = result.NAUTORIZATIONNUMBER,
            NEMISRIGHT = result.NEMISRIGHT,
            NIVA_SSC = result.NIVA_SSC,
            NIVA_SBK = result.NIVA_SBK,
            NIVA_OTHER = result.NIVA_OTHER,
            NIVA_OTHER_DESC = result.NIVA_OTHER_DESC,
            NIVA_OTHER_DESCOMPEN = result.NIVA_OTHER_DESCOMPEN,
            NIVA_PERCENT = result.NIVA_PERCENT,
            NBORDEREAUX_ADV = result.NBORDEREAUX_ADV,
        };
        await PopulateTABLE253DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE282DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANC_DRA/Edit.cshtml", updateDto);
    }

    // POST: FINANC_DRA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateFINANC_DRADto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE253DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE282DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANC_DRA/Edit.cshtml", updateDto);
    }

    // GET: FINANC_DRA/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANC_DRA/Delete.cshtml", result);
    }

    // POST: FINANC_DRA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: FINANC_DRA/GetByNCLAIM?NCLAIM=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCLAIM(long NCLAIM)
    {
        var items = await _service.FindAsync(p => p.NCLAIM == NCLAIM);
        return Json(items.Select(i => new { value = i.NCONTRAT, text = i.SINDCHEQUE }));
    }

    private async Task PopulateTABLE253DropdownAsync()
    {
        var items = await _TABLE253Service.GetAllAsync();
        ViewData["NSTAT_DRAFT"] = new SelectList(items, nameof(TABLE253Dto.NSTAT_DRAFT), "SDESCRIPT");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE282DropdownAsync()
    {
        var items = await _TABLE282Service.GetAllAsync();
        ViewData["NSTATPRINT"] = new SelectList(items, nameof(TABLE282Dto.NSTATPRINT), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE5566DropdownAsync()
    {
        var items = await _TABLE5566Service.GetAllAsync();
        ViewData["NSUS_REASON"] = new SelectList(items, nameof(TABLE5566Dto.NSUS_REASON), "SDESCRIPT");
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

}
