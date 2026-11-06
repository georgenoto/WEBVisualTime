using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PROCESS;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BATCH_PARAMController : Controller
{
    private readonly IBATCH_PARAMService _service;
    private readonly IBATCH_PROCESSService _BATCH_PROCESSService;
    private readonly IUSERSService _USERSService;

    public BATCH_PARAMController(IBATCH_PARAMService service
        , IBATCH_PROCESSService BATCH_PROCESSService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _BATCH_PROCESSService = BATCH_PROCESSService;
        _USERSService = USERSService;
    }

    // GET: BATCH_PARAM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BATCH_PARAM/Index.cshtml");

    // GET: BATCH_PARAM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PARAM/Details.cshtml", result);
    }

    // GET: BATCH_PARAM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM/Create.cshtml", new CreateBATCH_PARAMDto());
    }

    // POST: BATCH_PARAM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBATCH_PARAMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM/Create.cshtml", createDto);
    }

    // GET: BATCH_PARAM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBATCH_PARAMDto
        {
            NBATCH = result.NBATCH,
            NAREA = result.NAREA,
            NSEQ = result.NSEQ,
            SNAME = result.SNAME,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM/Edit.cshtml", updateDto);
    }

    // POST: BATCH_PARAM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBATCH_PARAMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBATCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM/Edit.cshtml", updateDto);
    }

    // GET: BATCH_PARAM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PARAM/Delete.cshtml", result);
    }

    // POST: BATCH_PARAM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateBATCH_PROCESSDropdownAsync()
    {
        var items = await _BATCH_PROCESSService.GetAllAsync();
        ViewData["NBATCH"] = new SelectList(items, nameof(BATCH_PROCESSDto.NBATCH), "SCODISPL");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
