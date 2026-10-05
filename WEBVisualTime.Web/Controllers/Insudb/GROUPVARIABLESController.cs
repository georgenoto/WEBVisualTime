using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPVARIABLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class GROUPVARIABLESController : Controller
{
    private readonly IGROUPVARIABLESService _service;
    private readonly IGROUPPARAMSService _GROUPPARAMSService;

    public GROUPVARIABLESController(IGROUPVARIABLESService service
        , IGROUPPARAMSService GROUPPARAMSService
    )
    {
        _service = service;
        _GROUPPARAMSService = GROUPPARAMSService;
    }

    // GET: GROUPVARIABLES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/GROUPVARIABLES/Index.cshtml", result);
    }

    // GET: GROUPVARIABLES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPVARIABLES/Details.cshtml", result);
    }

    // GET: GROUPVARIABLES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateGROUPPARAMSDropdownAsync();
        return View("~/Views/Insudb/GROUPVARIABLES/Create.cshtml", new CreateGROUPVARIABLESDto());
    }

    // POST: GROUPVARIABLES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateGROUPVARIABLESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateGROUPPARAMSDropdownAsync();
        return View("~/Views/Insudb/GROUPVARIABLES/Create.cshtml", createDto);
    }

    // GET: GROUPVARIABLES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateGROUPVARIABLESDto
        {
            NLETT_GROUP = result.NLETT_GROUP,
            SVARIABLE = result.SVARIABLE,
            SDESCRIPT = result.SDESCRIPT,
            STABLENAME = result.STABLENAME,
            SCOLUMNAME = result.SCOLUMNAME,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTYPVARIABLE = result.NTYPVARIABLE,
            STABVALUE = result.STABVALUE,
            SALIASTABLE = result.SALIASTABLE,
            SALIASCOLUMN = result.SALIASCOLUMN,
        };
        await PopulateGROUPPARAMSDropdownAsync();
        return View("~/Views/Insudb/GROUPVARIABLES/Edit.cshtml", updateDto);
    }

    // POST: GROUPVARIABLES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateGROUPVARIABLESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NLETT_GROUP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateGROUPPARAMSDropdownAsync();
        return View("~/Views/Insudb/GROUPVARIABLES/Edit.cshtml", updateDto);
    }

    // GET: GROUPVARIABLES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPVARIABLES/Delete.cshtml", result);
    }

    // POST: GROUPVARIABLES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateGROUPPARAMSDropdownAsync()
    {
        var items = await _GROUPPARAMSService.GetAllAsync();
        ViewData["NLETT_GROUP"] = new SelectList(items, nameof(GROUPPARAMSDto.NLETT_GROUP), "SDESCRIPT");
    }

}
