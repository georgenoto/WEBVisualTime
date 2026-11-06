using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LIMITS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LIMITSController : Controller
{
    private readonly ILIMITSService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly ITABLE10Service _TABLE10Service;

    public LIMITSController(ILIMITSService service
        , ISECUR_SCHEService SECUR_SCHEService
        , ITABLE10Service TABLE10Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _TABLE10Service = TABLE10Service;
    }

    // GET: LIMITS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LIMITS/Index.cshtml");

    // GET: LIMITS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIMITS/Details.cshtml", result);
    }

    // GET: LIMITS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/LIMITS/Create.cshtml", new CreateLIMITSDto());
    }

    // POST: LIMITS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLIMITSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/LIMITS/Create.cshtml", createDto);
    }

    // GET: LIMITS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLIMITSDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NCURRENCY = result.NCURRENCY,
            NBRANCH = result.NBRANCH,
            NCLAIM_D = result.NCLAIM_D,
            NPRODUCT = result.NPRODUCT,
            NCLAIM_P = result.NCLAIM_P,
            DCOMPDATE = result.DCOMPDATE,
            NISSUELIM = result.NISSUELIM,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/LIMITS/Edit.cshtml", updateDto);
    }

    // POST: LIMITS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLIMITSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        return View("~/Views/Insudb/LIMITS/Edit.cshtml", updateDto);
    }

    // GET: LIMITS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIMITS/Delete.cshtml", result);
    }

    // POST: LIMITS/Delete/{id}
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

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

}
