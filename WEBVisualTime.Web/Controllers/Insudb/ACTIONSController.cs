using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ACTIONSController : Controller
{
    private readonly IACTIONSService _service;

    public ACTIONSController(IACTIONSService service
    )
    {
        _service = service;
    }

    // GET: ACTIONS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ACTIONS/Index.cshtml", result);
    }

    // GET: ACTIONS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ACTIONS/Details.cshtml", result);
    }

    // GET: ACTIONS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ACTIONS/Create.cshtml", new CreateACTIONSDto());
    }

    // POST: ACTIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateACTIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ACTIONS/Create.cshtml", createDto);
    }

    // GET: ACTIONS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateACTIONSDto
        {
            NACTION = result.NACTION,
            SCONTROLKEY = result.SCONTROLKEY,
            SDESCRIPT = result.SDESCRIPT,
            SHEL_ACTIO = result.SHEL_ACTIO,
            SSHORT_ACTI = result.SSHORT_ACTI,
            SSTATREGT = result.SSTATREGT,
            STYPE_ACTIO = result.STYPE_ACTIO,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SPATHIMAGE = result.SPATHIMAGE,
        };
        return View("~/Views/Insudb/ACTIONS/Edit.cshtml", updateDto);
    }

    // POST: ACTIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateACTIONSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NACTION, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ACTIONS/Edit.cshtml", updateDto);
    }

    // GET: ACTIONS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ACTIONS/Delete.cshtml", result);
    }

    // POST: ACTIONS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
