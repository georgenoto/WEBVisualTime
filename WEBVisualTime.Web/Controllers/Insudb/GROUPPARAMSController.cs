using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class GROUPPARAMSController : Controller
{
    private readonly IGROUPPARAMSService _service;

    public GROUPPARAMSController(IGROUPPARAMSService service
    )
    {
        _service = service;
    }

    // GET: GROUPPARAMS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/GROUPPARAMS/Index.cshtml", result);
    }

    // GET: GROUPPARAMS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPPARAMS/Details.cshtml", result);
    }

    // GET: GROUPPARAMS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/GROUPPARAMS/Create.cshtml", new CreateGROUPPARAMSDto());
    }

    // POST: GROUPPARAMS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateGROUPPARAMSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/GROUPPARAMS/Create.cshtml", createDto);
    }

    // GET: GROUPPARAMS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateGROUPPARAMSDto
        {
            NLETT_GROUP = result.NLETT_GROUP,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            SPARAMETERS = result.SPARAMETERS,
        };
        return View("~/Views/Insudb/GROUPPARAMS/Edit.cshtml", updateDto);
    }

    // POST: GROUPPARAMS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateGROUPPARAMSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NLETT_GROUP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/GROUPPARAMS/Edit.cshtml", updateDto);
    }

    // GET: GROUPPARAMS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPPARAMS/Delete.cshtml", result);
    }

    // POST: GROUPPARAMS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
