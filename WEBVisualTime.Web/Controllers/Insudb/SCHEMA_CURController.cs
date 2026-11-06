using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHEMA_CUR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHEMA_CURController : Controller
{
    private readonly ISCHEMA_CURService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;

    public SCHEMA_CURController(ISCHEMA_CURService service
        , ISECUR_SCHEService SECUR_SCHEService
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
    }

    // GET: SCHEMA_CUR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SCHEMA_CUR/Index.cshtml");

    // GET: SCHEMA_CUR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHEMA_CUR/Details.cshtml", result);
    }

    // GET: SCHEMA_CUR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        return View("~/Views/Insudb/SCHEMA_CUR/Create.cshtml", new CreateSCHEMA_CURDto());
    }

    // POST: SCHEMA_CUR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHEMA_CURDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        return View("~/Views/Insudb/SCHEMA_CUR/Create.cshtml", createDto);
    }

    // GET: SCHEMA_CUR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHEMA_CURDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NCURRENCY = result.NCURRENCY,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        return View("~/Views/Insudb/SCHEMA_CUR/Edit.cshtml", updateDto);
    }

    // POST: SCHEMA_CUR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHEMA_CURDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        return View("~/Views/Insudb/SCHEMA_CUR/Edit.cshtml", updateDto);
    }

    // GET: SCHEMA_CUR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHEMA_CUR/Delete.cshtml", result);
    }

    // POST: SCHEMA_CUR/Delete/{id}
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

}
