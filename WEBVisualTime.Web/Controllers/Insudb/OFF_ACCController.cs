using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.OFF_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class OFF_ACCController : Controller
{
    private readonly IOFF_ACCService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly ITABLE9Service _TABLE9Service;

    public OFF_ACCController(IOFF_ACCService service
        , ISECUR_SCHEService SECUR_SCHEService
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _TABLE9Service = TABLE9Service;
    }

    // GET: OFF_ACC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/OFF_ACC/Index.cshtml");

    // GET: OFF_ACC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OFF_ACC/Details.cshtml", result);
    }

    // GET: OFF_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFF_ACC/Create.cshtml", new CreateOFF_ACCDto());
    }

    // POST: OFF_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOFF_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFF_ACC/Create.cshtml", createDto);
    }

    // GET: OFF_ACC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateOFF_ACCDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NOFFICE = result.NOFFICE,
            DCOMPDATE = result.DCOMPDATE,
            SIND_INQU = result.SIND_INQU,
            SIND_UPDA = result.SIND_UPDA,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFF_ACC/Edit.cshtml", updateDto);
    }

    // POST: OFF_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateOFF_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFF_ACC/Edit.cshtml", updateDto);
    }

    // GET: OFF_ACC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OFF_ACC/Delete.cshtml", result);
    }

    // POST: OFF_ACC/Delete/{id}
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

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
