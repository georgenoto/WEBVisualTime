using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7502;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COLFORMREFController : Controller
{
    private readonly ICOLFORMREFService _service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE7502Service _TABLE7502Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5554Service _TABLE5554Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ICOLLECTORService _COLLECTORService;

    public COLFORMREFController(ICOLFORMREFService service
        , ITABLE7Service TABLE7Service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE9Service TABLE9Service
        , ITABLE7502Service TABLE7502Service
        , ICLIENTService CLIENTService
        , ITABLE5554Service TABLE5554Service
        , ITABLE5001Service TABLE5001Service
        , ICOLLECTORService COLLECTORService
    )
    {
        _service = service;
        _TABLE7Service = TABLE7Service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE9Service = TABLE9Service;
        _TABLE7502Service = TABLE7502Service;
        _CLIENTService = CLIENTService;
        _TABLE5554Service = TABLE5554Service;
        _TABLE5001Service = TABLE5001Service;
        _COLLECTORService = COLLECTORService;
    }

    // GET: COLFORMREF
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COLFORMREF/Index.cshtml", result);
    }

    // GET: COLFORMREF/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLFORMREF/Details.cshtml", result);
    }

    // GET: COLFORMREF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE7502DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/COLFORMREF/Create.cshtml", new CreateCOLFORMREFDto());
    }

    // POST: COLFORMREF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOLFORMREFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE7502DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/COLFORMREF/Create.cshtml", createDto);
    }

    // GET: COLFORMREF/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOLFORMREFDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            STYPE = result.STYPE,
            NBANK = result.NBANK,
            NINTERMED = result.NINTERMED,
            NREL_AMOUN = result.NREL_AMOUN,
            NCURRENCY = result.NCURRENCY,
            NPOLICY = result.NPOLICY,
            DCOLLECT = result.DCOLLECT,
            NBRANCH = result.NBRANCH,
            NOFFICE = result.NOFFICE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NPRODUCT = result.NPRODUCT,
            SREL_TYPE = result.SREL_TYPE,
            SSTATUS = result.SSTATUS,
            NCERTIF = result.NCERTIF,
            SCONWIN = result.SCONWIN,
            SCLIENT = result.SCLIENT,
            NUSER_AMEND = result.NUSER_AMEND,
            NCASHNUM = result.NCASHNUM,
            NINPUTTYP = result.NINPUTTYP,
            NINSUR_AREA = result.NINSUR_AREA,
            NAGREEMENT = result.NAGREEMENT,
            DVALUEDATE = result.DVALUEDATE,
            SIND_ANNUITY = result.SIND_ANNUITY,
            DDATE_BENLAR = result.DDATE_BENLAR,
            NCOLLECTOR = result.NCOLLECTOR,
            SRELORIGI = result.SRELORIGI,
            DCOLLECTDATE = result.DCOLLECTDATE,
            NBILLNUM = result.NBILLNUM,
            NRETENTION = result.NRETENTION,
            NTAXRETENTION = result.NTAXRETENTION,
            NNULLCODE = result.NNULLCODE,
            NNOTENUM = result.NNOTENUM,
            NIMAGENUM = result.NIMAGENUM,
        };
        await PopulateTABLE7DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE7502DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/COLFORMREF/Edit.cshtml", updateDto);
    }

    // POST: COLFORMREF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOLFORMREFDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE7502DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/COLFORMREF/Edit.cshtml", updateDto);
    }

    // GET: COLFORMREF/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLFORMREF/Delete.cshtml", result);
    }

    // POST: COLFORMREF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: COLFORMREF/GetByNBANK?NBANK=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNBANK(long NBANK)
    {
        var items = await _service.FindAsync(p => p.NBANK == NBANK);
        return Json(items.Select(i => new { value = i.NBORDEREAUX, text = i.STYPE }));
    }

    // GET: COLFORMREF/GetByNINTERMED?NINTERMED=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNINTERMED(long NINTERMED)
    {
        var items = await _service.FindAsync(p => p.NINTERMED == NINTERMED);
        return Json(items.Select(i => new { value = i.NBORDEREAUX, text = i.STYPE }));
    }

    // GET: COLFORMREF/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NBORDEREAUX, text = i.STYPE }));
    }

    // GET: COLFORMREF/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NBORDEREAUX, text = i.STYPE }));
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE7502DropdownAsync()
    {
        var items = await _TABLE7502Service.GetAllAsync();
        ViewData["SREL_TYPE"] = new SelectList(items, nameof(TABLE7502Dto.SREL_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5554DropdownAsync()
    {
        var items = await _TABLE5554Service.GetAllAsync();
        ViewData["NINPUTTYP"] = new SelectList(items, nameof(TABLE5554Dto.NINPUTTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateCOLLECTORDropdownAsync()
    {
        var items = await _COLLECTORService.GetAllAsync();
        ViewData["NCOLLECTOR"] = new SelectList(items, nameof(COLLECTORDto.NCOLLECTOR), "NCOLLECTOR");
    }

}
