using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_HELP_NODESController : Controller
{
    private readonly IODWA_HELP_NODESService _service;

    public ODWA_HELP_NODESController(IODWA_HELP_NODESService service
    )
    {
        _service = service;
    }

    // GET: ODWA_HELP_NODES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ODWA_HELP_NODES/Index.cshtml", result);
    }

    // GET: ODWA_HELP_NODES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_NODES/Details.cshtml", result);
    }

    // GET: ODWA_HELP_NODES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ODWA_HELP_NODES/Create.cshtml", new CreateODWA_HELP_NODESDto());
    }

    // POST: ODWA_HELP_NODES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateODWA_HELP_NODESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_HELP_NODES/Create.cshtml", createDto);
    }

    // GET: ODWA_HELP_NODES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateODWA_HELP_NODESDto
        {
            ID = result.ID,
            PARENT_NODE = result.PARENT_NODE,
            SEQ_IN_PARENT = result.SEQ_IN_PARENT,
            TREE_LEVEL = result.TREE_LEVEL,
            DISPLAY_LABEL = result.DISPLAY_LABEL,
            HIM_ID = result.HIM_ID,
        };
        return View("~/Views/Insudb/ODWA_HELP_NODES/Edit.cshtml", updateDto);
    }

    // POST: ODWA_HELP_NODES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateODWA_HELP_NODESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ODWA_HELP_NODES/Edit.cshtml", updateDto);
    }

    // GET: ODWA_HELP_NODES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ODWA_HELP_NODES/Delete.cshtml", result);
    }

    // POST: ODWA_HELP_NODES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
