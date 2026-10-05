using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_SQL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TOAD_PLAN_SQLController : Controller
{
    private readonly ITOAD_PLAN_SQLService _service;

    public TOAD_PLAN_SQLController(ITOAD_PLAN_SQLService service
    )
    {
        _service = service;
    }

    // GET: TOAD_PLAN_SQL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Index.cshtml", result);
    }

    // GET: TOAD_PLAN_SQL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Details.cshtml", result);
    }

    // GET: TOAD_PLAN_SQL/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Create.cshtml", new CreateTOAD_PLAN_SQLDto());
    }

    // POST: TOAD_PLAN_SQL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTOAD_PLAN_SQLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Create.cshtml", createDto);
    }

    // GET: TOAD_PLAN_SQL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTOAD_PLAN_SQLDto
        {
            USERNAME = result.USERNAME,
            STATEMENT_ID = result.STATEMENT_ID,
            TIMESTAMP = result.TIMESTAMP,
            STATEMENT = result.STATEMENT,
        };
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Edit.cshtml", updateDto);
    }

    // POST: TOAD_PLAN_SQL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTOAD_PLAN_SQLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.USERNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Edit.cshtml", updateDto);
    }

    // GET: TOAD_PLAN_SQL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOAD_PLAN_SQL/Delete.cshtml", result);
    }

    // POST: TOAD_PLAN_SQL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
