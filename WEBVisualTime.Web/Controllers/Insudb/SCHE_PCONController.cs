using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_PCON;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHE_PCONController : Controller
{
    private readonly ISCHE_PCONService _service;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly ITABLE293Service _TABLE293Service;

    public SCHE_PCONController(ISCHE_PCONService service
        , ISECUR_SCHEService SECUR_SCHEService
        , ITABLE293Service TABLE293Service
    )
    {
        _service = service;
        _SECUR_SCHEService = SECUR_SCHEService;
        _TABLE293Service = TABLE293Service;
    }

    // GET: SCHE_PCON
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SCHE_PCON/Index.cshtml", result);
    }

    // GET: SCHE_PCON/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_PCON/Details.cshtml", result);
    }

    // GET: SCHE_PCON/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/SCHE_PCON/Create.cshtml", new CreateSCHE_PCONDto());
    }

    // POST: SCHE_PCON/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHE_PCONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/SCHE_PCON/Create.cshtml", createDto);
    }

    // GET: SCHE_PCON/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHE_PCONDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NCONCEPT = result.NCONCEPT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
        };
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/SCHE_PCON/Edit.cshtml", updateDto);
    }

    // POST: SCHE_PCON/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHE_PCONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/SCHE_PCON/Edit.cshtml", updateDto);
    }

    // GET: SCHE_PCON/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_PCON/Delete.cshtml", result);
    }

    // POST: SCHE_PCON/Delete/{id}
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

    private async Task PopulateTABLE293DropdownAsync()
    {
        var items = await _TABLE293Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE293Dto.NCONCEPT), "SDESCRIPT");
    }

}
