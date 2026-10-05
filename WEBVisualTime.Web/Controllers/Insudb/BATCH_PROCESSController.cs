using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PROCESS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BATCH_PROCESSController : Controller
{
    private readonly IBATCH_PROCESSService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly IUSERSService _USERSService;

    public BATCH_PROCESSController(IBATCH_PROCESSService service
        , IWINDOWSService WINDOWSService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _USERSService = USERSService;
    }

    // GET: BATCH_PROCESS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BATCH_PROCESS/Index.cshtml", result);
    }

    // GET: BATCH_PROCESS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PROCESS/Details.cshtml", result);
    }

    // GET: BATCH_PROCESS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PROCESS/Create.cshtml", new CreateBATCH_PROCESSDto());
    }

    // POST: BATCH_PROCESS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBATCH_PROCESSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PROCESS/Create.cshtml", createDto);
    }

    // GET: BATCH_PROCESS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBATCH_PROCESSDto
        {
            NBATCH = result.NBATCH,
            SCODISPL = result.SCODISPL,
            SPROC = result.SPROC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDESCRIPT = result.SDESCRIPT,
            SSTATREGT = result.SSTATREGT,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PROCESS/Edit.cshtml", updateDto);
    }

    // POST: BATCH_PROCESS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBATCH_PROCESSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBATCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PROCESS/Edit.cshtml", updateDto);
    }

    // GET: BATCH_PROCESS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PROCESS/Delete.cshtml", result);
    }

    // POST: BATCH_PROCESS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: BATCH_PROCESS/GetByNUSERCODE?NUSERCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNUSERCODE(int NUSERCODE)
    {
        var items = await _service.FindAsync(p => p.NUSERCODE == NUSERCODE);
        return Json(items.Select(i => new { value = i.NBATCH, text = i.SPROC }));
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

}
