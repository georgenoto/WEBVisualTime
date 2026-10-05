using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_RULES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8204;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASSIVE_RULESController : Controller
{
    private readonly IMASSIVE_RULESService _service;
    private readonly ITABLE153Service _TABLE153Service;
    private readonly ITABLE8204Service _TABLE8204Service;
    private readonly ITABLE8205Service _TABLE8205Service;

    public MASSIVE_RULESController(IMASSIVE_RULESService service
        , ITABLE153Service TABLE153Service
        , ITABLE8204Service TABLE8204Service
        , ITABLE8205Service TABLE8205Service
    )
    {
        _service = service;
        _TABLE153Service = TABLE153Service;
        _TABLE8204Service = TABLE8204Service;
        _TABLE8205Service = TABLE8205Service;
    }

    // GET: MASSIVE_RULES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASSIVE_RULES/Index.cshtml", result);
    }

    // GET: MASSIVE_RULES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_RULES/Details.cshtml", result);
    }

    // GET: MASSIVE_RULES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE153DropdownAsync();
        await PopulateTABLE8204DropdownAsync();
        await PopulateTABLE8205DropdownAsync();
        return View("~/Views/Insudb/MASSIVE_RULES/Create.cshtml", new CreateMASSIVE_RULESDto());
    }

    // POST: MASSIVE_RULES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASSIVE_RULESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE153DropdownAsync();
        await PopulateTABLE8204DropdownAsync();
        await PopulateTABLE8205DropdownAsync();
        return View("~/Views/Insudb/MASSIVE_RULES/Create.cshtml", createDto);
    }

    // GET: MASSIVE_RULES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASSIVE_RULESDto
        {
            NIDRULE = result.NIDRULE,
            NERRORNUM = result.NERRORNUM,
            SERRORTYP = result.SERRORTYP,
            SDESCRIPT = result.SDESCRIPT,
            SBREAK = result.SBREAK,
            SENABLED = result.SENABLED,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NACTIONPROC = result.NACTIONPROC,
            SVIP = result.SVIP,
            STYP_CONDI = result.STYP_CONDI,
            NSECTION = result.NSECTION,
        };
        await PopulateTABLE153DropdownAsync();
        await PopulateTABLE8204DropdownAsync();
        await PopulateTABLE8205DropdownAsync();
        return View("~/Views/Insudb/MASSIVE_RULES/Edit.cshtml", updateDto);
    }

    // POST: MASSIVE_RULES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASSIVE_RULESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDRULE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE153DropdownAsync();
        await PopulateTABLE8204DropdownAsync();
        await PopulateTABLE8205DropdownAsync();
        return View("~/Views/Insudb/MASSIVE_RULES/Edit.cshtml", updateDto);
    }

    // GET: MASSIVE_RULES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_RULES/Delete.cshtml", result);
    }

    // POST: MASSIVE_RULES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE153DropdownAsync()
    {
        var items = await _TABLE153Service.GetAllAsync();
        ViewData["SERRORTYP"] = new SelectList(items, nameof(TABLE153Dto.SERRORTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE8204DropdownAsync()
    {
        var items = await _TABLE8204Service.GetAllAsync();
        ViewData["STYP_CONDI"] = new SelectList(items, nameof(TABLE8204Dto.STYP_CONDI), "SDESCRIPT");
    }

    private async Task PopulateTABLE8205DropdownAsync()
    {
        var items = await _TABLE8205Service.GetAllAsync();
        ViewData["NSECTION"] = new SelectList(items, nameof(TABLE8205Dto.NSECTION), "SDESCRIPT");
    }

}
