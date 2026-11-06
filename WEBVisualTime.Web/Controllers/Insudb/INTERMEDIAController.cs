using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMLIF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5500;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9211;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INTERMEDIAController : Controller
{
    private readonly IINTERMEDIAService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITAB_COMLIFService _TAB_COMLIFService;
    private readonly ITABLE200Service _TABLE200Service;
    private readonly IINTERM_TYPService _INTERM_TYPService;
    private readonly ITABLE163Service _TABLE163Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly IDISEX_INT_MService _DISEX_INT_MService;
    private readonly ITABLE5500Service _TABLE5500Service;
    private readonly ITABLE5501Service _TABLE5501Service;
    private readonly ITABLE5555Service _TABLE5555Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly ITABLE9211Service _TABLE9211Service;

    public INTERMEDIAController(IINTERMEDIAService service
        , ICLIENTService CLIENTService
        , ITAB_COMLIFService TAB_COMLIFService
        , ITABLE200Service TABLE200Service
        , IINTERM_TYPService INTERM_TYPService
        , ITABLE163Service TABLE163Service
        , ITABLE9Service TABLE9Service
        , IDISEX_INT_MService DISEX_INT_MService
        , ITABLE5500Service TABLE5500Service
        , ITABLE5501Service TABLE5501Service
        , ITABLE5555Service TABLE5555Service
        , ITABLE5556Service TABLE5556Service
        , ITABLE9211Service TABLE9211Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TAB_COMLIFService = TAB_COMLIFService;
        _TABLE200Service = TABLE200Service;
        _INTERM_TYPService = INTERM_TYPService;
        _TABLE163Service = TABLE163Service;
        _TABLE9Service = TABLE9Service;
        _DISEX_INT_MService = DISEX_INT_MService;
        _TABLE5500Service = TABLE5500Service;
        _TABLE5501Service = TABLE5501Service;
        _TABLE5555Service = TABLE5555Service;
        _TABLE5556Service = TABLE5556Service;
        _TABLE9211Service = TABLE9211Service;
    }

    // GET: INTERMEDIA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INTERMEDIA/Index.cshtml");

    // GET: INTERMEDIA/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMEDIA/Details.cshtml", result);
    }

    // GET: INTERMEDIA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE200DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateDISEX_INT_MDropdownAsync();
        await PopulateTABLE5500DropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9211DropdownAsync();
        return View("~/Views/Insudb/INTERMEDIA/Create.cshtml", new CreateINTERMEDIADto());
    }

    // POST: INTERMEDIA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINTERMEDIADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE200DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateDISEX_INT_MDropdownAsync();
        await PopulateTABLE5500DropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9211DropdownAsync();
        return View("~/Views/Insudb/INTERMEDIA/Create.cshtml", createDto);
    }

    // GET: INTERMEDIA/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINTERMEDIADto
        {
            NINTERMED = result.NINTERMED,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NCOMTABGE = result.NCOMTABGE,
            NCOMTABLI = result.NCOMTABLI,
            DINPDATE = result.DINPDATE,
            NINT_STATUS = result.NINT_STATUS,
            NINTERTYP = result.NINTERTYP,
            NNULLCODE = result.NNULLCODE,
            DNULLDATE = result.DNULLDATE,
            NOFFICE = result.NOFFICE,
            NSUPERVIS = result.NSUPERVIS,
            NTABLE_COD = result.NTABLE_COD,
            NTAX = result.NTAX,
            NUSERCODE = result.NUSERCODE,
            SCOL_AGREE = result.SCOL_AGREE,
            NNOTENUM = result.NNOTENUM,
            NECO_SCHE = result.NECO_SCHE,
            SINTER_ID = result.SINTER_ID,
            SAGREEINT = result.SAGREEINT,
            SLIFE = result.SLIFE,
            SNONLIFE = result.SNONLIFE,
            NLIFE_SCHE = result.NLIFE_SCHE,
            NGEN_SCHE = result.NGEN_SCHE,
            NLEGAL_SCH = result.NLEGAL_SCH,
            NSUP_GEN = result.NSUP_GEN,
            NINSU_ASSIST = result.NINSU_ASSIST,
            NGOAL_GEN = result.NGOAL_GEN,
            NGOAL_LIFE = result.NGOAL_LIFE,
            NINSU_ASSISTLIF = result.NINSU_ASSISTLIF,
            NAGENCY = result.NAGENCY,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NSLC_TAB_NR = result.NSLC_TAB_NR,
            DCOMMIDATE = result.DCOMMIDATE,
            SVALID = result.SVALID,
            NCONTRAT = result.NCONTRAT,
            NRECEPTYP = result.NRECEPTYP,
            NCOM_CHANNEL = result.NCOM_CHANNEL,
            SPERSIS = result.SPERSIS,
            NUSER_RETENC = result.NUSER_RETENC,
            DDATE_RETENC = result.DDATE_RETENC,
            NUSER_LIBRET = result.NUSER_LIBRET,
            DDATE_LIBRET = result.DDATE_LIBRET,
            SCODAGENT_SCAB = result.SCODAGENT_SCAB,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE200DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateDISEX_INT_MDropdownAsync();
        await PopulateTABLE5500DropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9211DropdownAsync();
        return View("~/Views/Insudb/INTERMEDIA/Edit.cshtml", updateDto);
    }

    // POST: INTERMEDIA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINTERMEDIADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERMED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE200DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateDISEX_INT_MDropdownAsync();
        await PopulateTABLE5500DropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9211DropdownAsync();
        return View("~/Views/Insudb/INTERMEDIA/Edit.cshtml", updateDto);
    }

    // GET: INTERMEDIA/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMEDIA/Delete.cshtml", result);
    }

    // POST: INTERMEDIA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: INTERMEDIA/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NINTERMED, text = i.SCOL_AGREE }));
    }

    // GET: INTERMEDIA/GetByNINT_STATUS?NINT_STATUS=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNINT_STATUS(int NINT_STATUS)
    {
        var items = await _service.FindAsync(p => p.NINT_STATUS == NINT_STATUS);
        return Json(items.Select(i => new { value = i.NINTERMED, text = i.SCOL_AGREE }));
    }

    // GET: INTERMEDIA/GetByNINTERTYP?NINTERTYP=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNINTERTYP(int NINTERTYP)
    {
        var items = await _service.FindAsync(p => p.NINTERTYP == NINTERTYP);
        return Json(items.Select(i => new { value = i.NINTERMED, text = i.SCOL_AGREE }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTAB_COMLIFDropdownAsync()
    {
        var items = await _TAB_COMLIFService.GetAllAsync();
        ViewData["NCOMTABLI"] = new SelectList(items, nameof(TAB_COMLIFDto.NCOMTABLI), "SDESCRIPT");
    }

    private async Task PopulateTABLE200DropdownAsync()
    {
        var items = await _TABLE200Service.GetAllAsync();
        ViewData["NINT_STATUS"] = new SelectList(items, nameof(TABLE200Dto.NINT_STATUS), "SDESCRIPT");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE163DropdownAsync()
    {
        var items = await _TABLE163Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE163Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateDISEX_INT_MDropdownAsync()
    {
        var items = await _DISEX_INT_MService.GetAllAsync();
        ViewData["NECO_SCHE"] = new SelectList(items, nameof(DISEX_INT_MDto.NECO_SCHE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5500DropdownAsync()
    {
        var items = await _TABLE5500Service.GetAllAsync();
        ViewData["NLIFE_SCHE"] = new SelectList(items, nameof(TABLE5500Dto.NSCHE_CODE), "SDESCRIPT");
        ViewData["NGEN_SCHE"] = new SelectList(items, nameof(TABLE5500Dto.NSCHE_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5501DropdownAsync()
    {
        var items = await _TABLE5501Service.GetAllAsync();
        ViewData["NLEGAL_SCH"] = new SelectList(items, nameof(TABLE5501Dto.NLEGAL_SCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE9211DropdownAsync()
    {
        var items = await _TABLE9211Service.GetAllAsync();
        ViewData["NRECEPTYP"] = new SelectList(items, nameof(TABLE9211Dto.NRETENTION), "SDESCRIPT");
    }

}
