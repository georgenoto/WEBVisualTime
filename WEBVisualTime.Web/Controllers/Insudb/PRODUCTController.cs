using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODUCT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE161;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE45;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PRODUCTController : Controller
{
    private readonly IPRODUCTService _service;
    private readonly ITABLE50Service _TABLE50Service;
    private readonly ITABLE90Service _TABLE90Service;
    private readonly ITABLE79Service _TABLE79Service;
    private readonly ITABLE92Service _TABLE92Service;
    private readonly ITABLE36Service _TABLE36Service;
    private readonly ITABLE8Service _TABLE8Service;
    private readonly ITABLE154Service _TABLE154Service;
    private readonly ITABLE46Service _TABLE46Service;
    private readonly ITABLE161Service _TABLE161Service;
    private readonly ITABLE25Service _TABLE25Service;
    private readonly ITABLE45Service _TABLE45Service;
    private readonly ITABLE5002Service _TABLE5002Service;
    private readonly ITABLE5677Service _TABLE5677Service;
    private readonly ITABLE9223Service _TABLE9223Service;

    public PRODUCTController(IPRODUCTService service
        , ITABLE50Service TABLE50Service
        , ITABLE90Service TABLE90Service
        , ITABLE79Service TABLE79Service
        , ITABLE92Service TABLE92Service
        , ITABLE36Service TABLE36Service
        , ITABLE8Service TABLE8Service
        , ITABLE154Service TABLE154Service
        , ITABLE46Service TABLE46Service
        , ITABLE161Service TABLE161Service
        , ITABLE25Service TABLE25Service
        , ITABLE45Service TABLE45Service
        , ITABLE5002Service TABLE5002Service
        , ITABLE5677Service TABLE5677Service
        , ITABLE9223Service TABLE9223Service
    )
    {
        _service = service;
        _TABLE50Service = TABLE50Service;
        _TABLE90Service = TABLE90Service;
        _TABLE79Service = TABLE79Service;
        _TABLE92Service = TABLE92Service;
        _TABLE36Service = TABLE36Service;
        _TABLE8Service = TABLE8Service;
        _TABLE154Service = TABLE154Service;
        _TABLE46Service = TABLE46Service;
        _TABLE161Service = TABLE161Service;
        _TABLE25Service = TABLE25Service;
        _TABLE45Service = TABLE45Service;
        _TABLE5002Service = TABLE5002Service;
        _TABLE5677Service = TABLE5677Service;
        _TABLE9223Service = TABLE9223Service;
    }

    // GET: PRODUCT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PRODUCT/Index.cshtml");

    // GET: PRODUCT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODUCT/Details.cshtml", result);
    }

    // GET: PRODUCT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE8DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE161DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE45DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE9223DropdownAsync();
        return View("~/Views/Insudb/PRODUCT/Create.cshtml", new CreatePRODUCTDto());
    }

    // POST: PRODUCT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePRODUCTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE8DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE161DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE45DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE9223DropdownAsync();
        return View("~/Views/Insudb/PRODUCT/Create.cshtml", createDto);
    }

    // GET: PRODUCT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePRODUCTDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            NCANCNOTI = result.NCANCNOTI,
            SCOLINVOT = result.SCOLINVOT,
            NCLAIM_PRES = result.NCLAIM_PRES,
            DCOMPDATE = result.DCOMPDATE,
            NCOPIES = result.NCOPIES,
            SCUMREINT = result.SCUMREINT,
            NQ_CERTIF = result.NQ_CERTIF,
            SCUMULTYP = result.SCUMULTYP,
            SDECLAAUT = result.SDECLAAUT,
            STYP_CLAUSE = result.STYP_CLAUSE,
            STYP_DISCXP = result.STYP_DISCXP,
            STYP_MODULE = result.STYP_MODULE,
            NDURATION = result.NDURATION,
            SGROUPIND = result.SGROUPIND,
            SINDIVIND = result.SINDIVIND,
            SMULTIIND = result.SMULTIIND,
            DNULLDATE = result.DNULLDATE,
            NPAYFREQ = result.NPAYFREQ,
            SPOLITYPE = result.SPOLITYPE,
            NQMAXCURR = result.NQMAXCURR,
            SREINTYPE = result.SREINTYPE,
            SRENEWAL = result.SRENEWAL,
            SREVALAPL = result.SREVALAPL,
            NREVALRAT = result.NREVALRAT,
            SREVALTYP = result.SREVALTYP,
            SSTYLE_COMM = result.SSTYLE_COMM,
            SSTYLE_PREM = result.SSTYLE_PREM,
            SSTYLE_TAX = result.SSTYLE_TAX,
            NTARIFF = result.NTARIFF,
            STIMEREN = result.STIMEREN,
            NUSERCODE = result.NUSERCODE,
            SWIN_DECLAR = result.SWIN_DECLAR,
            NINSMAXIQ = result.NINSMAXIQ,
            NINSMINIQ = result.NINSMINIQ,
            SHOLDER = result.SHOLDER,
            NQDAYS_PRO = result.NQDAYS_PRO,
            NQUOTA = result.NQUOTA,
            SGROUPSI = result.SGROUPSI,
            NWAY_PAY = result.NWAY_PAY,
            NBILL_DAY = result.NBILL_DAY,
            NREHABPERIOD = result.NREHABPERIOD,
            STYP_DOM = result.STYP_DOM,
            SLEG = result.SLEG,
            NNOTCANCELDAY = result.NNOTCANCELDAY,
            SREINST = result.SREINST,
            SDATECOLL = result.SDATECOLL,
            NCLAIM_NOTICE = result.NCLAIM_NOTICE,
            NQDAYS_QUO = result.NQDAYS_QUO,
            NCLAIM_PAY = result.NCLAIM_PAY,
            NMONTH_SURR = result.NMONTH_SURR,
            SFIRST_PAY = result.SFIRST_PAY,
            SROUTAUT_R = result.SROUTAUT_R,
            SNUMPROP = result.SNUMPROP,
            SFRACRECEIP = result.SFRACRECEIP,
            SCONDSVS = result.SCONDSVS,
            SAUTO_SUSC = result.SAUTO_SUSC,
            NREPINSURED = result.NREPINSURED,
            NQDAYS_DIFQUO = result.NQDAYS_DIFQUO,
            NREHABPERIOD_AUT = result.NREHABPERIOD_AUT,
            SRECSEC = result.SRECSEC,
            SRETARIF = result.SRETARIF,
            NMONTH_SETPR = result.NMONTH_SETPR,
            SSETPREM = result.SSETPREM,
            SLETTER = result.SLETTER,
            SMASSIVE = result.SMASSIVE,
            STARQUO_IND = result.STARQUO_IND,
            NPAYABLE = result.NPAYABLE,
            NADVANCE = result.NADVANCE,
            NREACTPERIOD_AUT = result.NREACTPERIOD_AUT,
            SREACTIVATION = result.SREACTIVATION,
            NREACTPERIOD = result.NREACTPERIOD,
            SROUTREACT = result.SROUTREACT,
            NCHUSERLEV = result.NCHUSERLEV,
            SNAME_REPORT = result.SNAME_REPORT,
            SRATINGSERVICEUSING = result.SRATINGSERVICEUSING,
            SROU_WARNING_CHARG = result.SROU_WARNING_CHARG,
            SROU_COVER = result.SROU_COVER,
            NCURR_RECEIPT = result.NCURR_RECEIPT,
            SRESOLUTIONSBS = result.SRESOLUTIONSBS,
            SAUTOMATICBILL = result.SAUTOMATICBILL,
            NMODULEMIN = result.NMODULEMIN,
            NTYPEACCOUNT = result.NTYPEACCOUNT,
            NASSOCIATEDBRANCH = result.NASSOCIATEDBRANCH,
            SASSOCIATED_POLICY_REQUIRED = result.SASSOCIATED_POLICY_REQUIRED,
            NPERBASIC = result.NPERBASIC,
            SPREMIUMZEROIND = result.SPREMIUMZEROIND,
            SNOTGENRECEIPT = result.SNOTGENRECEIPT,
            SCOMERPRODUCT = result.SCOMERPRODUCT,
            SCLIENT = result.SCLIENT,
            NSELLCHANNEL = result.NSELLCHANNEL,
            SNATIONALS = result.SNATIONALS,
            NCLASSIFICATION = result.NCLASSIFICATION,
            SRESOLUTION = result.SRESOLUTION,
            SGOVAPRNAME = result.SGOVAPRNAME,
            DRESDATE = result.DRESDATE,
        };
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE8DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE161DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE45DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE9223DropdownAsync();
        return View("~/Views/Insudb/PRODUCT/Edit.cshtml", updateDto);
    }

    // POST: PRODUCT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdatePRODUCTDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE50DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE92DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        await PopulateTABLE8DropdownAsync();
        await PopulateTABLE154DropdownAsync();
        await PopulateTABLE46DropdownAsync();
        await PopulateTABLE161DropdownAsync();
        await PopulateTABLE25DropdownAsync();
        await PopulateTABLE45DropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5677DropdownAsync();
        await PopulateTABLE9223DropdownAsync();
        return View("~/Views/Insudb/PRODUCT/Edit.cshtml", updateDto);
    }

    // GET: PRODUCT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODUCT/Delete.cshtml", result);
    }

    // POST: PRODUCT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE50DropdownAsync()
    {
        var items = await _TABLE50Service.GetAllAsync();
        ViewData["SCOLINVOT"] = new SelectList(items, nameof(TABLE50Dto.SCOLINVOT), "SDESCRIPT");
    }

    private async Task PopulateTABLE90DropdownAsync()
    {
        var items = await _TABLE90Service.GetAllAsync();
        ViewData["SCUMREINT"] = new SelectList(items, nameof(TABLE90Dto.SCUMREINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE79DropdownAsync()
    {
        var items = await _TABLE79Service.GetAllAsync();
        ViewData["SCUMULTYP"] = new SelectList(items, nameof(TABLE79Dto.SCUMULTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE92DropdownAsync()
    {
        var items = await _TABLE92Service.GetAllAsync();
        ViewData["STYP_CLAUSE"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
        ViewData["STYP_DISCXP"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
        ViewData["STYP_MODULE"] = new SelectList(items, nameof(TABLE92Dto.STYP_VAR), "SDESCRIPT");
    }

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NPAYFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

    private async Task PopulateTABLE8DropdownAsync()
    {
        var items = await _TABLE8Service.GetAllAsync();
        ViewData["SREINTYPE"] = new SelectList(items, nameof(TABLE8Dto.SREINTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE154DropdownAsync()
    {
        var items = await _TABLE154Service.GetAllAsync();
        ViewData["SREVALAPL"] = new SelectList(items, nameof(TABLE154Dto.SREVALAPL), "SDESCRIPT");
    }

    private async Task PopulateTABLE46DropdownAsync()
    {
        var items = await _TABLE46Service.GetAllAsync();
        ViewData["SREVALTYP"] = new SelectList(items, nameof(TABLE46Dto.SREVALTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE161DropdownAsync()
    {
        var items = await _TABLE161Service.GetAllAsync();
        ViewData["SSTYLE_COMM"] = new SelectList(items, nameof(TABLE161Dto.SSTYLE_COMM), "SDESCRIPT");
        ViewData["SSTYLE_PREM"] = new SelectList(items, nameof(TABLE161Dto.SSTYLE_COMM), "SDESCRIPT");
        ViewData["SSTYLE_TAX"] = new SelectList(items, nameof(TABLE161Dto.SSTYLE_COMM), "SDESCRIPT");
    }

    private async Task PopulateTABLE25DropdownAsync()
    {
        var items = await _TABLE25Service.GetAllAsync();
        ViewData["STIMEREN"] = new SelectList(items, nameof(TABLE25Dto.STIMEREN), "SDESCRIPT");
    }

    private async Task PopulateTABLE45DropdownAsync()
    {
        var items = await _TABLE45Service.GetAllAsync();
        ViewData["SHOLDER"] = new SelectList(items, nameof(TABLE45Dto.SHOLDER), "SDESCRIPT");
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5677DropdownAsync()
    {
        var items = await _TABLE5677Service.GetAllAsync();
        ViewData["NREPINSURED"] = new SelectList(items, nameof(TABLE5677Dto.NREPINSURED), "SDESCRIPT");
    }

    private async Task PopulateTABLE9223DropdownAsync()
    {
        var items = await _TABLE9223Service.GetAllAsync();
        ViewData["NCLASSIFICATION"] = new SelectList(items, nameof(TABLE9223Dto.NCLASSIFICATION), "SDESCRIPT");
    }

}
