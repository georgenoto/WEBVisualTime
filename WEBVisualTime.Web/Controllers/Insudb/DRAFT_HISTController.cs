using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DRAFT_HIST;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE260;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DRAFT_HISTController : Controller
{
    private readonly IDRAFT_HISTService _service;
    private readonly ITABLE260Service _TABLE260Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE182Service _TABLE182Service;
    private readonly ICOLLECTORService _COLLECTORService;

    public DRAFT_HISTController(IDRAFT_HISTService service
        , ITABLE260Service TABLE260Service
        , IUSERSService USERSService
        , ITABLE7Service TABLE7Service
        , ITABLE182Service TABLE182Service
        , ICOLLECTORService COLLECTORService
    )
    {
        _service = service;
        _TABLE260Service = TABLE260Service;
        _USERSService = USERSService;
        _TABLE7Service = TABLE7Service;
        _TABLE182Service = TABLE182Service;
        _COLLECTORService = COLLECTORService;
    }

    // GET: DRAFT_HIST
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DRAFT_HIST/Index.cshtml");

    // GET: DRAFT_HIST/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DRAFT_HIST/Details.cshtml", result);
    }

    // GET: DRAFT_HIST/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE260DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/DRAFT_HIST/Create.cshtml", new CreateDRAFT_HISTDto());
    }

    // POST: DRAFT_HIST/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDRAFT_HISTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE260DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/DRAFT_HIST/Create.cshtml", createDto);
    }

    // GET: DRAFT_HIST/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDRAFT_HISTDto
        {
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NTRANSAC = result.NTRANSAC,
            NCURRENCY = result.NCURRENCY,
            NDRAFT = result.NDRAFT,
            NDSCTO_PAG = result.NDSCTO_PAG,
            NEXPENSIVE = result.NEXPENSIVE,
            NINTEREST = result.NINTEREST,
            SINTERMEI = result.SINTERMEI,
            DSTAT_DATE = result.DSTAT_DATE,
            NTYPE = result.NTYPE,
            NUSERCODE = result.NUSERCODE,
            NBANK_CODE = result.NBANK_CODE,
            SDOCNUMBE = result.SDOCNUMBE,
            SPAY_FORM = result.SPAY_FORM,
            SCHANGE_ACC = result.SCHANGE_ACC,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            NCASHNUM = result.NCASHNUM,
            NPAYREJECT = result.NPAYREJECT,
            NCOLLECTOR = result.NCOLLECTOR,
            DLEDGERDAT = result.DLEDGERDAT,
            DPOSTED = result.DPOSTED,
            SCESSICOI = result.SCESSICOI,
            NBILLNUM = result.NBILLNUM,
            SIND_REVER = result.SIND_REVER,
        };
        await PopulateTABLE260DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/DRAFT_HIST/Edit.cshtml", updateDto);
    }

    // POST: DRAFT_HIST/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDRAFT_HISTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONTRAT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE260DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/DRAFT_HIST/Edit.cshtml", updateDto);
    }

    // GET: DRAFT_HIST/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DRAFT_HIST/Delete.cshtml", result);
    }

    // POST: DRAFT_HIST/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE260DropdownAsync()
    {
        var items = await _TABLE260Service.GetAllAsync();
        ViewData["NTYPE"] = new SelectList(items, nameof(TABLE260Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE182DropdownAsync()
    {
        var items = await _TABLE182Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE182Dto.SPAY_FORM), "SDESCRIPT");
    }

    private async Task PopulateCOLLECTORDropdownAsync()
    {
        var items = await _COLLECTORService.GetAllAsync();
        ViewData["NCOLLECTOR"] = new SelectList(items, nameof(COLLECTORDto.NCOLLECTOR), "NCOLLECTOR");
    }

}
