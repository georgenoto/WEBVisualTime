using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_TRANSAC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHE_TRANSACController : Controller
{
    private readonly ISCHE_TRANSACService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE182Service _TABLE182Service;
    private readonly ITABLE6059Service _TABLE6059Service;

    public SCHE_TRANSACController(ISCHE_TRANSACService service
        , ISECUR_SCHEService SECUR_SCHEService
        , IWINDOWSService WINDOWSService
        , IUSERSService USERSService
        , ITABLE182Service TABLE182Service
        , ITABLE6059Service TABLE6059Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _WINDOWSService = WINDOWSService;
        _USERSService = USERSService;
        _TABLE182Service = TABLE182Service;
        _TABLE6059Service = TABLE6059Service;
    }

    // GET: SCHE_TRANSAC
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SCHE_TRANSAC/Index.cshtml", result);
    }

    // GET: SCHE_TRANSAC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_TRANSAC/Details.cshtml", result);
    }

    // GET: SCHE_TRANSAC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        return View("~/Views/Insudb/SCHE_TRANSAC/Create.cshtml", new CreateSCHE_TRANSACDto());
    }

    // POST: SCHE_TRANSAC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHE_TRANSACDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        return View("~/Views/Insudb/SCHE_TRANSAC/Create.cshtml", createDto);
    }

    // GET: SCHE_TRANSAC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHE_TRANSACDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            SCODISPL = result.SCODISPL,
            NTRANSAC = result.NTRANSAC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SPAY_FORM = result.SPAY_FORM,
            NTYPE_AMEND = result.NTYPE_AMEND,
            NID = result.NID,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        return View("~/Views/Insudb/SCHE_TRANSAC/Edit.cshtml", updateDto);
    }

    // POST: SCHE_TRANSAC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHE_TRANSACDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        return View("~/Views/Insudb/SCHE_TRANSAC/Edit.cshtml", updateDto);
    }

    // GET: SCHE_TRANSAC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_TRANSAC/Delete.cshtml", result);
    }

    // POST: SCHE_TRANSAC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateSECUR_SCHEDropdownAsync()
    {
        var items = await _SECUR_SCHEService.GetAllAsync();
        ViewData["SSCHE_CODE"] = new SelectList(items, nameof(SECUR_SCHEDto.SSCHE_CODE), "SLONGDESC");
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE182DropdownAsync()
    {
        var items = await _TABLE182Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE182Dto.SPAY_FORM), "SDESCRIPT");
    }

    private async Task PopulateTABLE6059DropdownAsync()
    {
        var items = await _TABLE6059Service.GetAllAsync();
        ViewData["NTYPE_AMEND"] = new SelectList(items, nameof(TABLE6059Dto.NTYPE_AMEND), "SDESCRIPT");
    }

}
