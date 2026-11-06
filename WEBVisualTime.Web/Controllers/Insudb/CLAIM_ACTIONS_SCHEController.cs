using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_SCHE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_ACTIONS_SCHEController : Controller
{
    private readonly ICLAIM_ACTIONS_SCHEService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly ITABLE9244Service _TABLE9244Service;
    private readonly ITABLE9245Service _TABLE9245Service;

    public CLAIM_ACTIONS_SCHEController(ICLAIM_ACTIONS_SCHEService service
        , ISECUR_SCHEService SECUR_SCHEService
        , IWINDOWSService WINDOWSService
        , ITABLE9244Service TABLE9244Service
        , ITABLE9245Service TABLE9245Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _WINDOWSService = WINDOWSService;
        _TABLE9244Service = TABLE9244Service;
        _TABLE9245Service = TABLE9245Service;
    }

    // GET: CLAIM_ACTIONS_SCHE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_ACTIONS_SCHE/Index.cshtml");

    // GET: CLAIM_ACTIONS_SCHE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Details.cshtml", result);
    }

    // GET: CLAIM_ACTIONS_SCHE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9244DropdownAsync();
        await PopulateTABLE9245DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Create.cshtml", new CreateCLAIM_ACTIONS_SCHEDto());
    }

    // POST: CLAIM_ACTIONS_SCHE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_ACTIONS_SCHEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9244DropdownAsync();
        await PopulateTABLE9245DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Create.cshtml", createDto);
    }

    // GET: CLAIM_ACTIONS_SCHE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_ACTIONS_SCHEDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            SCODISPL = result.SCODISPL,
            NACTIONCLAIM = result.NACTIONCLAIM,
            NACTIONTYPE = result.NACTIONTYPE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9244DropdownAsync();
        await PopulateTABLE9245DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_ACTIONS_SCHE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_ACTIONS_SCHEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9244DropdownAsync();
        await PopulateTABLE9245DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_ACTIONS_SCHE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ACTIONS_SCHE/Delete.cshtml", result);
    }

    // POST: CLAIM_ACTIONS_SCHE/Delete/{id}
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

    private async Task PopulateTABLE9244DropdownAsync()
    {
        var items = await _TABLE9244Service.GetAllAsync();
        ViewData["NACTIONCLAIM"] = new SelectList(items, nameof(TABLE9244Dto.NACTIONCLAIM), "SDESCRIPT");
    }

    private async Task PopulateTABLE9245DropdownAsync()
    {
        var items = await _TABLE9245Service.GetAllAsync();
        ViewData["NACTIONTYPE"] = new SelectList(items, nameof(TABLE9245Dto.NACTIONTYPE), "SDESCRIPT");
    }

}
