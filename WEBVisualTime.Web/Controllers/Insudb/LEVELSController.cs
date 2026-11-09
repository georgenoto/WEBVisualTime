using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LEVELS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE511;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LEVELSController : Controller
{
    private readonly ILEVELSService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly ITABLE511Service _TABLE511Service;

    public LEVELSController(ILEVELSService service
        , ISECUR_SCHEService SECUR_SCHEService
        , ITABLE511Service TABLE511Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _TABLE511Service = TABLE511Service;
    }

    // GET: LEVELS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LEVELS/Index.cshtml");

    // GET: LEVELS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEVELS/Details.cshtml", result);
    }

    // GET: LEVELS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE511DropdownAsync();
        return View("~/Views/Insudb/LEVELS/Create.cshtml", new CreateLEVELSDto());
    }

    // POST: LEVELS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLEVELSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE511DropdownAsync();
        return View("~/Views/Insudb/LEVELS/Create.cshtml", createDto);
    }

    // GET: LEVELS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLEVELSDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            SIND_TYPE = result.SIND_TYPE,
            SCODE_MT = result.SCODE_MT,
            NAMELEVEL = result.NAMELEVEL,
            DCOMPDATE = result.DCOMPDATE,
            NINQLEVEL = result.NINQLEVEL,
            SSUPERVIS = result.SSUPERVIS,
            NUSERCODE = result.NUSERCODE,
            SPERMITTED = result.SPERMITTED,
            SENCRYPTED = result.SENCRYPTED,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE511DropdownAsync();
        return View("~/Views/Insudb/LEVELS/Edit.cshtml", updateDto);
    }

    // POST: LEVELS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateLEVELSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE511DropdownAsync();
        return View("~/Views/Insudb/LEVELS/Edit.cshtml", updateDto);
    }

    // GET: LEVELS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEVELS/Delete.cshtml", result);
    }

    // POST: LEVELS/Delete/{id}
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

    private async Task PopulateTABLE511DropdownAsync()
    {
        var items = await _TABLE511Service.GetAllAsync();
        ViewData["SIND_TYPE"] = new SelectList(items, nameof(TABLE511Dto.SIND_TYPE), "SDESCRIPT");
    }

}
