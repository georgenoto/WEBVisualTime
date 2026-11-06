using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MOVE_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE401;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE137;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MOVE_ACCController : Controller
{
    private readonly IMOVE_ACCService _service;
    private readonly ICURR_ACCService _CURR_ACCService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE401Service _TABLE401Service;
    private readonly ITABLE137Service _TABLE137Service;
    private readonly ITABLE6Service _TABLE6Service;
    private readonly IPROVINCEService _PROVINCEService;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE182Service _TABLE182Service;

    public MOVE_ACCController(IMOVE_ACCService service
        , ICURR_ACCService CURR_ACCService
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE7Service TABLE7Service
        , ICLAIMService CLAIMService
        , ITABLE401Service TABLE401Service
        , ITABLE137Service TABLE137Service
        , ITABLE6Service TABLE6Service
        , IPROVINCEService PROVINCEService
        , ICOLFORMREFService COLFORMREFService
        , ITABLE182Service TABLE182Service
    )
    {
        _service = service;
        _CURR_ACCService = CURR_ACCService;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE7Service = TABLE7Service;
        _CLAIMService = CLAIMService;
        _TABLE401Service = TABLE401Service;
        _TABLE137Service = TABLE137Service;
        _TABLE6Service = TABLE6Service;
        _PROVINCEService = PROVINCEService;
        _COLFORMREFService = COLFORMREFService;
        _TABLE182Service = TABLE182Service;
    }

    // GET: MOVE_ACC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MOVE_ACC/Index.cshtml");

    // GET: MOVE_ACC/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MOVE_ACC/Details.cshtml", result);
    }

    // GET: MOVE_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCURR_ACCDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE401DropdownAsync();
        await PopulateTABLE137DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        return View("~/Views/Insudb/MOVE_ACC/Create.cshtml", new CreateMOVE_ACCDto());
    }

    // POST: MOVE_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMOVE_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCURR_ACCDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE401DropdownAsync();
        await PopulateTABLE137DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        return View("~/Views/Insudb/MOVE_ACC/Create.cshtml", createDto);
    }

    // GET: MOVE_ACC/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMOVE_ACCDto
        {
            NTYP_ACCO = result.NTYP_ACCO,
            STYPE_ACC = result.STYPE_ACC,
            SCLIENT = result.SCLIENT,
            NCURRENCY = result.NCURRENCY,
            DOPERDATE = result.DOPERDATE,
            NIDCONSEC = result.NIDCONSEC,
            NINTERMED = result.NINTERMED,
            NAMOUNT = result.NAMOUNT,
            NBANKEXT = result.NBANKEXT,
            NBRANCH = result.NBRANCH,
            NCERTIF = result.NCERTIF,
            SCHEQUE = result.SCHEQUE,
            NCLAIM = result.NCLAIM,
            NCREDIT = result.NCREDIT,
            NDEBIT = result.NDEBIT,
            SDESCRIPT = result.SDESCRIPT,
            SMANUALMOV = result.SMANUALMOV,
            NPAYNUMBE = result.NPAYNUMBE,
            NPOLICY = result.NPOLICY,
            NRECEIPT = result.NRECEIPT,
            SSTATREGT = result.SSTATREGT,
            NTRANSAC = result.NTRANSAC,
            NTRANSACTIO = result.NTRANSACTIO,
            NTYPE_MOVE = result.NTYPE_MOVE,
            NTYPE_PAY = result.NTYPE_PAY,
            NTYPE_TRAN = result.NTYPE_TRAN,
            NUSERCODE = result.NUSERCODE,
            NPROVINCE = result.NPROVINCE,
            DCOMPDATE = result.DCOMPDATE,
            NIDDOCUMENT = result.NIDDOCUMENT,
            NREQUEST_NU = result.NREQUEST_NU,
            NBORDEREAUX = result.NBORDEREAUX,
            SPROCESS = result.SPROCESS,
            SNUMFORM = result.SNUMFORM,
            NORIGCURR = result.NORIGCURR,
            NEXCHANGE = result.NEXCHANGE,
            SAUTORIZA = result.SAUTORIZA,
            DVALUEDATE = result.DVALUEDATE,
            NPRODUCT = result.NPRODUCT,
            SNULL_RECOR = result.SNULL_RECOR,
            NCASHNUM = result.NCASHNUM,
            NAMOAFECT = result.NAMOAFECT,
            NAMOEXEN = result.NAMOEXEN,
            NPAY_COMM = result.NPAY_COMM,
            NCURR_ACC = result.NCURR_ACC,
            DPOSTED = result.DPOSTED,
            SPROCESS_IND = result.SPROCESS_IND,
            NPROPONUM = result.NPROPONUM,
            NBULLETINS = result.NBULLETINS,
            NNOTENUM = result.NNOTENUM,
            NID = result.NID,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NOBLIGATION = result.NOBLIGATION,
            NSERV_ORDER = result.NSERV_ORDER,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NDOCUMENT = result.NDOCUMENT,
            NAMOUNT_LOC = result.NAMOUNT_LOC,
            NBALANCE = result.NBALANCE,
            SCLIENT_REL = result.SCLIENT_REL,
            SPAY_FORM = result.SPAY_FORM,
            NCOD_AGREE = result.NCOD_AGREE,
            NBILLNUM = result.NBILLNUM,
            SDEP_NUMBER = result.SDEP_NUMBER,
            NTODAYSDEPOSIT = result.NTODAYSDEPOSIT,
            NRETENTIONTAXCODE = result.NRETENTIONTAXCODE,
            NRETENTIONCODE = result.NRETENTIONCODE,
            NRETENTIONSERIES = result.NRETENTIONSERIES,
            DENDINGDATE = result.DENDINGDATE,
            NRETENTION = result.NRETENTION,
            NTAXRETENTION = result.NTAXRETENTION,
            NRETENTIONBASE = result.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = result.NAUTORIZATIONNUMBER,
            DAUTORIZATIONDATE = result.DAUTORIZATIONDATE,
            DCTB_DATE = result.DCTB_DATE,
            SPOSTEDSEQUENCE = result.SPOSTEDSEQUENCE,
            NORI_AMOUNT = result.NORI_AMOUNT,
            SSCAB = result.SSCAB,
            DDATE_SCAB = result.DDATE_SCAB,
            NSEQ = result.NSEQ,
        };
        await PopulateCURR_ACCDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE401DropdownAsync();
        await PopulateTABLE137DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        return View("~/Views/Insudb/MOVE_ACC/Edit.cshtml", updateDto);
    }

    // POST: MOVE_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMOVE_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYP_ACCO, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCURR_ACCDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE401DropdownAsync();
        await PopulateTABLE137DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        return View("~/Views/Insudb/MOVE_ACC/Edit.cshtml", updateDto);
    }

    // GET: MOVE_ACC/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MOVE_ACC/Delete.cshtml", result);
    }

    // POST: MOVE_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCURR_ACCDropdownAsync()
    {
        var items = await _CURR_ACCService.GetAllAsync();
        ViewData["NTYP_ACCO"] = new SelectList(items, nameof(CURR_ACCDto.NTYP_ACCO), "SSTATREGT");
        ViewData["STYPE_ACC"] = new SelectList(items, nameof(CURR_ACCDto.STYPE_ACC), "SSTATREGT");
        ViewData["SCLIENT"] = new SelectList(items, nameof(CURR_ACCDto.SCLIENT), "SSTATREGT");
        ViewData["NCURRENCY"] = new SelectList(items, nameof(CURR_ACCDto.NCURRENCY), "SSTATREGT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE401DropdownAsync()
    {
        var items = await _TABLE401Service.GetAllAsync();
        ViewData["NTYPE_MOVE"] = new SelectList(items, nameof(TABLE401Dto.NTYPE_MOVE), "SDESCRIPT");
    }

    private async Task PopulateTABLE137DropdownAsync()
    {
        var items = await _TABLE137Service.GetAllAsync();
        ViewData["NTYPE_PAY"] = new SelectList(items, nameof(TABLE137Dto.NTYPE_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE_TRAN"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

    private async Task PopulatePROVINCEDropdownAsync()
    {
        var items = await _PROVINCEService.GetAllAsync();
        ViewData["NPROVINCE"] = new SelectList(items, nameof(PROVINCEDto.NPROVINCE), "SDESCRIPT");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE182DropdownAsync()
    {
        var items = await _TABLE182Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE182Dto.SPAY_FORM), "SDESCRIPT");
    }

}
