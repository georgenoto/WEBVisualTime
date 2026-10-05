using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ACTIONS_STATE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_ACTIONS_STATEController : Controller
{
    private readonly ICLAIM_ACTIONS_STATEService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly ITABLE9262Service _TABLE9262Service;

    public CLAIM_ACTIONS_STATEController(ICLAIM_ACTIONS_STATEService service
        , ISECUR_SCHEService SECUR_SCHEService
        , IWINDOWSService WINDOWSService
        , ITABLE9262Service TABLE9262Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _WINDOWSService = WINDOWSService;
        _TABLE9262Service = TABLE9262Service;
    }

    // GET: CLAIM_ACTIONS_STATE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Index.cshtml", result);
    }

    // GET: CLAIM_ACTIONS_STATE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Details.cshtml", result);
    }

    // GET: CLAIM_ACTIONS_STATE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9262DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Create.cshtml", new CreateCLAIM_ACTIONS_STATEDto());
    }

    // POST: CLAIM_ACTIONS_STATE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_ACTIONS_STATEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9262DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Create.cshtml", createDto);
    }

    // GET: CLAIM_ACTIONS_STATE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_ACTIONS_STATEDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            SCODISPL = result.SCODISPL,
            NSTATUS = result.NSTATUS,
            SIND_CHANGE = result.SIND_CHANGE,
            SIND_QUERY = result.SIND_QUERY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCLAIM_ENTITY = result.NCLAIM_ENTITY,
            NACTIONCLAIM = result.NACTIONCLAIM,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9262DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_ACTIONS_STATE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_ACTIONS_STATEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE9262DropdownAsync();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_ACTIONS_STATE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_ACTIONS_STATE/Delete.cshtml", result);
    }

    // POST: CLAIM_ACTIONS_STATE/Delete/{id}
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

    private async Task PopulateTABLE9262DropdownAsync()
    {
        var items = await _TABLE9262Service.GetAllAsync();
        ViewData["NCLAIM_ENTITY"] = new SelectList(items, nameof(TABLE9262Dto.NCLAIM_ENTITY), "SDESCRIPT");
    }

}
