using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDBENEFITS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_MEDBENEFITSController : Controller
{
    private readonly ITAB_MEDBENEFITSService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE269Service _TABLE269Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE52Service _TABLE52Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE18Service _TABLE18Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE9215Service _TABLE9215Service;
    private readonly ITABLE9221Service _TABLE9221Service;
    private readonly ITAB_AM_ILLService _TAB_AM_ILLService;

    public TAB_MEDBENEFITSController(ITAB_MEDBENEFITSService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE269Service TABLE269Service
        , IUSERSService USERSService
        , ITABLE52Service TABLE52Service
        , ITABLE9Service TABLE9Service
        , ITABLE18Service TABLE18Service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE9215Service TABLE9215Service
        , ITABLE9221Service TABLE9221Service
        , ITAB_AM_ILLService TAB_AM_ILLService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE269Service = TABLE269Service;
        _USERSService = USERSService;
        _TABLE52Service = TABLE52Service;
        _TABLE9Service = TABLE9Service;
        _TABLE18Service = TABLE18Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE9215Service = TABLE9215Service;
        _TABLE9221Service = TABLE9221Service;
        _TAB_AM_ILLService = TAB_AM_ILLService;
    }

    // GET: TAB_MEDBENEFITS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_MEDBENEFITS/Index.cshtml");

    // GET: TAB_MEDBENEFITS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Details.cshtml", result);
    }

    // GET: TAB_MEDBENEFITS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Create.cshtml", new CreateTAB_MEDBENEFITSDto());
    }

    // POST: TAB_MEDBENEFITS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_MEDBENEFITSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Create.cshtml", createDto);
    }

    // GET: TAB_MEDBENEFITS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_MEDBENEFITSDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NID = result.NID,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            DEFFECDATE = result.DEFFECDATE,
            SCLIENT = result.SCLIENT,
            NGROUP_INSU = result.NGROUP_INSU,
            NROLE = result.NROLE,
            NQUANTITY = result.NQUANTITY,
            NAMOUNT_BENE = result.NAMOUNT_BENE,
            NPERCEN_HOSPITAL = result.NPERCEN_HOSPITAL,
            NPERCEN_AMBULATORY = result.NPERCEN_AMBULATORY,
            NDED_TYPE = result.NDED_TYPE,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
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
            NBENEFCATEG = result.NBENEFCATEG,
            SBENEFCATEG_CODE = result.SBENEFCATEG_CODE,
            SPRINT_DES = result.SPRINT_DES,
            NIDMEDBENEF = result.NIDMEDBENEF,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Edit.cshtml", updateDto);
    }

    // POST: TAB_MEDBENEFITS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_MEDBENEFITSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE269DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE52DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9221DropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Edit.cshtml", updateDto);
    }

    // GET: TAB_MEDBENEFITS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MEDBENEFITS/Delete.cshtml", result);
    }

    // POST: TAB_MEDBENEFITS/Delete/{id}
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

}
