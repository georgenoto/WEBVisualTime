using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5525;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5633;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FN_INSTITUTION;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_DOCTYPController : Controller
{
    private readonly IT_DOCTYPService _service;
    private readonly ITABLE5587Service _TABLE5587Service;
    private readonly ITABLE5525Service _TABLE5525Service;
    private readonly ITABLE24Service _TABLE24Service;
    private readonly ITABLE5633Service _TABLE5633Service;
    private readonly ITAB_FN_INSTITUTIONService _TAB_FN_INSTITUTIONService;

    public T_DOCTYPController(IT_DOCTYPService service
        , ITABLE5587Service TABLE5587Service
        , ITABLE5525Service TABLE5525Service
        , ITABLE24Service TABLE24Service
        , ITABLE5633Service TABLE5633Service
        , ITAB_FN_INSTITUTIONService TAB_FN_INSTITUTIONService
    )
    {
        _service = service;
        _TABLE5587Service = TABLE5587Service;
        _TABLE5525Service = TABLE5525Service;
        _TABLE24Service = TABLE24Service;
        _TABLE5633Service = TABLE5633Service;
        _TAB_FN_INSTITUTIONService = TAB_FN_INSTITUTIONService;
    }

    // GET: T_DOCTYP
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/T_DOCTYP/Index.cshtml");

    // GET: T_DOCTYP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_DOCTYP/Details.cshtml", result);
    }

    // GET: T_DOCTYP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5587DropdownAsync();
        await PopulateTABLE5525DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE5633DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/T_DOCTYP/Create.cshtml", new CreateT_DOCTYPDto());
    }

    // POST: T_DOCTYP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_DOCTYPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5587DropdownAsync();
        await PopulateTABLE5525DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE5633DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/T_DOCTYP/Create.cshtml", createDto);
    }

    // GET: T_DOCTYP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_DOCTYPDto
        {
            SSEL = result.SSEL,
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NCOLLECDOCTYP = result.NCOLLECDOCTYP,
            NDOCUMENT = result.NDOCUMENT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            SCLIENT = result.SCLIENT,
            NBULLETINS = result.NBULLETINS,
            NPROPONUM = result.NPROPONUM,
            NTYPEMOVE = result.NTYPEMOVE,
            DMOVDATE = result.DMOVDATE,
            NTYPE = result.NTYPE,
            NTRATYPEI = result.NTRATYPEI,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            NAMOUNTCOL = result.NAMOUNTCOL,
            NAMOUNTPAY = result.NAMOUNTPAY,
            NPAYSOONDISC = result.NPAYSOONDISC,
            NINTEREST_RATE = result.NINTEREST_RATE,
            DEXPIRDAT = result.DEXPIRDAT,
            SMANAUTI = result.SMANAUTI,
            NSTATUS_PRE = result.NSTATUS_PRE,
            NCOMAMOU = result.NCOMAMOU,
            NPARTICIP = result.NPARTICIP,
            NPREMIUM = result.NPREMIUM,
            NINTERMED = result.NINTERMED,
            NUSERCODE = result.NUSERCODE,
            NCASH_MOV = result.NCASH_MOV,
            DPOSTED = result.DPOSTED,
            STYPE_DETAI = result.STYPE_DETAI,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NINTERTYP = result.NINTERTYP,
            NRATE_DISC = result.NRATE_DISC,
            NNOM_VALBON = result.NNOM_VALBON,
            DISSUEDATBON = result.DISSUEDATBON,
            DEXPIRDATBON = result.DEXPIRDATBON,
            NTAX = result.NTAX,
            NORIGIN = result.NORIGIN,
            DDATE_ORIGIN = result.DDATE_ORIGIN,
            NINSTITUTION = result.NINSTITUTION,
            NCHANGESDAT = result.NCHANGESDAT,
            DVALUEDATE = result.DVALUEDATE,
            NCOLLECTOR = result.NCOLLECTOR,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NLOANS = result.NLOANS,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            SNEWRECEIPT = result.SNEWRECEIPT,
            NCOD_SAAPV = result.NCOD_SAAPV,
            SFOLIONUMBER = result.SFOLIONUMBER,
            SBILLADVANCE = result.SBILLADVANCE,
            DLIMITDATE = result.DLIMITDATE,
        };
        await PopulateTABLE5587DropdownAsync();
        await PopulateTABLE5525DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE5633DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/T_DOCTYP/Edit.cshtml", updateDto);
    }

    // POST: T_DOCTYP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateT_DOCTYPDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5587DropdownAsync();
        await PopulateTABLE5525DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE5633DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/T_DOCTYP/Edit.cshtml", updateDto);
    }

    // GET: T_DOCTYP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_DOCTYP/Delete.cshtml", result);
    }

    // POST: T_DOCTYP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5587DropdownAsync()
    {
        var items = await _TABLE5587Service.GetAllAsync();
        ViewData["NCOLLECDOCTYP"] = new SelectList(items, nameof(TABLE5587Dto.NCOLLECDOCTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5525DropdownAsync()
    {
        var items = await _TABLE5525Service.GetAllAsync();
        ViewData["NTYPEMOVE"] = new SelectList(items, nameof(TABLE5525Dto.NTYPEMOVE), "SDESCRIPT");
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
    }

    private async Task PopulateTABLE5633DropdownAsync()
    {
        var items = await _TABLE5633Service.GetAllAsync();
        ViewData["NORIGIN"] = new SelectList(items, nameof(TABLE5633Dto.NORIGIN), "SDESCRIPT");
    }

    private async Task PopulateTAB_FN_INSTITUTIONDropdownAsync()
    {
        var items = await _TAB_FN_INSTITUTIONService.GetAllAsync();
        ViewData["NINSTITUTION"] = new SelectList(items, nameof(TAB_FN_INSTITUTIONDto.NINSTITUTION), "SNAME");
    }

}
