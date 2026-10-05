using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERCL_ORDERController : Controller
{
    private readonly IMASTERCL_ORDERService _service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE9264Service _TABLE9264Service;
    private readonly ITABLE9265Service _TABLE9265Service;
    private readonly ITABLE9212Service _TABLE9212Service;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ITABLE8605Service _TABLE8605Service;
    private readonly ITABLE9263Service _TABLE9263Service;
    private readonly ITABLE210Service _TABLE210Service;

    public MASTERCL_ORDERController(IMASTERCL_ORDERService service
        , ITABLE9Service TABLE9Service
        , ITABLE9264Service TABLE9264Service
        , ITABLE9265Service TABLE9265Service
        , ITABLE9212Service TABLE9212Service
        , ITABLE8604Service TABLE8604Service
        , ITABLE8605Service TABLE8605Service
        , ITABLE9263Service TABLE9263Service
        , ITABLE210Service TABLE210Service
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
        _TABLE9264Service = TABLE9264Service;
        _TABLE9265Service = TABLE9265Service;
        _TABLE9212Service = TABLE9212Service;
        _TABLE8604Service = TABLE8604Service;
        _TABLE8605Service = TABLE8605Service;
        _TABLE9263Service = TABLE9263Service;
        _TABLE210Service = TABLE210Service;
    }

    // GET: MASTERCL_ORDER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASTERCL_ORDER/Index.cshtml", result);
    }

    // GET: MASTERCL_ORDER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_ORDER/Details.cshtml", result);
    }

    // GET: MASTERCL_ORDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_ORDER/Create.cshtml", new CreateMASTERCL_ORDERDto());
    }

    // POST: MASTERCL_ORDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERCL_ORDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_ORDER/Create.cshtml", createDto);
    }

    // GET: MASTERCL_ORDER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERCL_ORDERDto
        {
            NMASTERORDER = result.NMASTERORDER,
            NOFFICE = result.NOFFICE,
            SNAMECLIENT = result.SNAMECLIENT,
            NPROVIDER = result.NPROVIDER,
            NATTENTCHANNEL = result.NATTENTCHANNEL,
            DACCOUNTDOC = result.DACCOUNTDOC,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NSTATORDER_MAST = result.NSTATORDER_MAST,
            NNOTENUM = result.NNOTENUM,
            DORDERDATE = result.DORDERDATE,
            NUSER_AMEND = result.NUSER_AMEND,
            NUSER_AUDITDOC = result.NUSER_AUDITDOC,
            NUSER_DERIVEDBY = result.NUSER_DERIVEDBY,
            NMASTERORDERTYPE = result.NMASTERORDERTYPE,
            SPREAUTHORIZATION = result.SPREAUTHORIZATION,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            NREVALIDATIONS = result.NREVALIDATIONS,
            DORIGINALPREAUTH = result.DORIGINALPREAUTH,
            DLASTPREAUTH = result.DLASTPREAUTH,
            STYPECARE = result.STYPECARE,
            SCARECLASS = result.SCARECLASS,
            NCURREN_DOC = result.NCURREN_DOC,
            NCURREN_ORDER = result.NCURREN_ORDER,
            SCALLCENTER = result.SCALLCENTER,
            NEXCHANGE = result.NEXCHANGE,
            DPRESENTDATE = result.DPRESENTDATE,
            NCLAIM = result.NCLAIM,
            NNULLCODE = result.NNULLCODE,
            DLEDGERDAT = result.DLEDGERDAT,
            NCLA_LI_TYP = result.NCLA_LI_TYP,
            NIND_REOPENCL = result.NIND_REOPENCL,
            NCAUSEREOPENCL = result.NCAUSEREOPENCL,
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            NMASTERORDER_NUM_ORIG = result.NMASTERORDER_NUM_ORIG,
            NMASTERORDEN_NUM_GEN = result.NMASTERORDEN_NUM_GEN,
            SHISTORICAL_CLAIM = result.SHISTORICAL_CLAIM,
            NCOUNTRY = result.NCOUNTRY,
            NSEQUENCE_ID = result.NSEQUENCE_ID,
        };
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_ORDER/Edit.cshtml", updateDto);
    }

    // POST: MASTERCL_ORDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTERCL_ORDERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMASTERORDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9265DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE8605DropdownAsync();
        await PopulateTABLE9263DropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_ORDER/Edit.cshtml", updateDto);
    }

    // GET: MASTERCL_ORDER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_ORDER/Delete.cshtml", result);
    }

    // POST: MASTERCL_ORDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: MASTERCL_ORDER/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NMASTERORDER, text = i.SNAMECLIENT }));
    }

    // GET: MASTERCL_ORDER/GetByNMASTERORDERTYPE?NMASTERORDERTYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNMASTERORDERTYPE(int NMASTERORDERTYPE)
    {
        var items = await _service.FindAsync(p => p.NMASTERORDERTYPE == NMASTERORDERTYPE);
        return Json(items.Select(i => new { value = i.NMASTERORDER, text = i.SNAMECLIENT }));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9264DropdownAsync()
    {
        var items = await _TABLE9264Service.GetAllAsync();
        ViewData["NSTATORDER_MAST"] = new SelectList(items, nameof(TABLE9264Dto.NSTATORDER_MAST), "SDESCRIPT");
    }

    private async Task PopulateTABLE9265DropdownAsync()
    {
        var items = await _TABLE9265Service.GetAllAsync();
        ViewData["NMASTERORDERTYPE"] = new SelectList(items, nameof(TABLE9265Dto.NMASTERORDERTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9212DropdownAsync()
    {
        var items = await _TABLE9212Service.GetAllAsync();
        ViewData["NCLAIMANTTYPE"] = new SelectList(items, nameof(TABLE9212Dto.NCLAIMANTTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateTABLE8605DropdownAsync()
    {
        var items = await _TABLE8605Service.GetAllAsync();
        ViewData["SCARECLASS"] = new SelectList(items, nameof(TABLE8605Dto.SCARECLASS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9263DropdownAsync()
    {
        var items = await _TABLE9263Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE9263Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE210DropdownAsync()
    {
        var items = await _TABLE210Service.GetAllAsync();
        ViewData["NCLA_LI_TYP"] = new SelectList(items, nameof(TABLE210Dto.NCLA_LI_TYP), "SDESCRIPT");
    }

}
