using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDBENEFITS_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9220;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDBENEFITS_PRODController : Controller
{
    private readonly IMEDBENEFITS_PRODService _service;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly ITABLE269Service _TABLE269Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE52Service _TABLE52Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE18Service _TABLE18Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE9215Service _TABLE9215Service;
    private readonly ITABLE9221Service _TABLE9221Service;
    private readonly ITAB_AM_ILLService _TAB_AM_ILLService;
    private readonly ITABLE9220Service _TABLE9220Service;

    public MEDBENEFITS_PRODController(IMEDBENEFITS_PRODService service
        , ITABLE12Service TABLE12Service
        , ITABLE269Service TABLE269Service
        , IUSERSService USERSService
        , ITABLE52Service TABLE52Service
        , ITABLE9Service TABLE9Service
        , ITABLE18Service TABLE18Service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE9215Service TABLE9215Service
        , ITABLE9221Service TABLE9221Service
        , ITAB_AM_ILLService TAB_AM_ILLService
        , ITABLE9220Service TABLE9220Service
    )
    {
        _service = service;
        _TABLE12Service = TABLE12Service;
        _TABLE269Service = TABLE269Service;
        _USERSService = USERSService;
        _TABLE52Service = TABLE52Service;
        _TABLE9Service = TABLE9Service;
        _TABLE18Service = TABLE18Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE9215Service = TABLE9215Service;
        _TABLE9221Service = TABLE9221Service;
        _TAB_AM_ILLService = TAB_AM_ILLService;
        _TABLE9220Service = TABLE9220Service;
    }

    // GET: MEDBENEFITS_PROD
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MEDBENEFITS_PROD/Index.cshtml");

    // GET: MEDBENEFITS_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Details.cshtml", result);
    }

    // GET: MEDBENEFITS_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE9220DropdownAsync();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Create.cshtml", new CreateMEDBENEFITS_PRODDto());
    }

    // POST: MEDBENEFITS_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDBENEFITS_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE9220DropdownAsync();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Create.cshtml", createDto);
    }

    // GET: MEDBENEFITS_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDBENEFITS_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            DEFFECDATE = result.DEFFECDATE,
            NCOVER = result.NCOVER,
            NROLE = result.NROLE,
            NDED_TYPE = result.NDED_TYPE,
            NQUANTITY = result.NQUANTITY,
            NAMOUNT_BENE = result.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = result.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = result.NPERCEN_AMBULATORY,
            SCHANALLO = result.SCHANALLO,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCAREN_TYPE = result.SCAREN_TYPE,
            NCAREN_QUANT = result.NCAREN_QUANT,
            NOFFICE_PROD = result.NOFFICE_PROD,
            NAMOUNT_COPAY = result.NAMOUNT_COPAY,
            NFRANCFIX = result.NFRANCFIX,
            NAGESTART = result.NAGESTART,
            NAGEEND = result.NAGEEND,
            SSEXCLIEN = result.SSEXCLIEN,
            NPROVIDER = result.NPROVIDER,
            NATTENSYSTEM = result.NATTENSYSTEM,
            NTYPEEXHAUS = result.NTYPEEXHAUS,
            SILLNESS = result.SILLNESS,
            SCLARIFICACT = result.SCLARIFICACT,
            NINDPRINT = result.NINDPRINT,
            NBENEFCATEG = result.NBENEFCATEG,
            NIDMEDBENEF = result.NIDMEDBENEF,
            SBENEFCATEG_CODE = result.SBENEFCATEG_CODE,
            SPRINT_DES = result.SPRINT_DES,
            NORDER = result.NORDER,
        };
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE9220DropdownAsync();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Edit.cshtml", updateDto);
    }

    // POST: MEDBENEFITS_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMEDBENEFITS_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE9220DropdownAsync();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Edit.cshtml", updateDto);
    }

    // GET: MEDBENEFITS_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDBENEFITS_PROD/Delete.cshtml", result);
    }

    // POST: MEDBENEFITS_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateTABLE269DropdownAsync()
    {
        var items = await _TABLE269Service.GetAllAsync();
        ViewData["NDED_TYPE"] = new SelectList(items, nameof(TABLE269Dto.NDED_TYPE), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE52DropdownAsync()
    {
        var items = await _TABLE52Service.GetAllAsync();
        ViewData["SCAREN_TYPE"] = new SelectList(items, nameof(TABLE52Dto.SCAREN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE_PROD"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE18DropdownAsync()
    {
        var items = await _TABLE18Service.GetAllAsync();
        ViewData["SSEXCLIEN"] = new SelectList(items, nameof(TABLE18Dto.SSEXCLIEN), "SDESCRIPT");
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE9215DropdownAsync()
    {
        var items = await _TABLE9215Service.GetAllAsync();
        ViewData["NATTENSYSTEM"] = new SelectList(items, nameof(TABLE9215Dto.NATTENSYSTEM), "SDESCRIPT");
    }

    private async Task PopulateTABLE9221DropdownAsync()
    {
        var items = await _TABLE9221Service.GetAllAsync();
        ViewData["NTYPEEXHAUS"] = new SelectList(items, nameof(TABLE9221Dto.NTYPEEXHAUS), "SDESCRIPT");
    }

    private async Task PopulateTAB_AM_ILLDropdownAsync()
    {
        var items = await _TAB_AM_ILLService.GetAllAsync();
        ViewData["SILLNESS"] = new SelectList(items, nameof(TAB_AM_ILLDto.SILLNESS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9220DropdownAsync()
    {
        var items = await _TABLE9220Service.GetAllAsync();
        ViewData["NINDPRINT"] = new SelectList(items, nameof(TABLE9220Dto.NINDPRINT), "SDESCRIPT");
    }

}
