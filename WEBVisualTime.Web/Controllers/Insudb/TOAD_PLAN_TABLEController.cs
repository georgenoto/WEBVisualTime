using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_TABLE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TOAD_PLAN_TABLEController : Controller
{
    private readonly ITOAD_PLAN_TABLEService _service;

    public TOAD_PLAN_TABLEController(ITOAD_PLAN_TABLEService service
    )
    {
        _service = service;
    }

    // GET: TOAD_PLAN_TABLE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Index.cshtml", result);
    }

    // GET: TOAD_PLAN_TABLE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Details.cshtml", result);
    }

    // GET: TOAD_PLAN_TABLE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Create.cshtml", new CreateTOAD_PLAN_TABLEDto());
    }

    // POST: TOAD_PLAN_TABLE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTOAD_PLAN_TABLEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Create.cshtml", createDto);
    }

    // GET: TOAD_PLAN_TABLE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTOAD_PLAN_TABLEDto
        {
            STATEMENT_ID = result.STATEMENT_ID,
            TIMESTAMP = result.TIMESTAMP,
            REMARKS = result.REMARKS,
            OPERATION = result.OPERATION,
            OPTIONS = result.OPTIONS,
            OBJECT_NODE = result.OBJECT_NODE,
            OBJECT_OWNER = result.OBJECT_OWNER,
            OBJECT_NAME = result.OBJECT_NAME,
            OBJECT_INSTANCE = result.OBJECT_INSTANCE,
            OBJECT_TYPE = result.OBJECT_TYPE,
            SEARCH_COLUMNS = result.SEARCH_COLUMNS,
            ID = result.ID,
            COST = result.COST,
            PARENT_ID = result.PARENT_ID,
            POSITION = result.POSITION,
            CARDINALITY = result.CARDINALITY,
            OPTIMIZER = result.OPTIMIZER,
            BYTES = result.BYTES,
            OTHER_TAG = result.OTHER_TAG,
            PARTITION_ID = result.PARTITION_ID,
            PARTITION_START = result.PARTITION_START,
            PARTITION_STOP = result.PARTITION_STOP,
            DISTRIBUTION = result.DISTRIBUTION,
            OTHER = result.OTHER,
        };
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Edit.cshtml", updateDto);
    }

    // POST: TOAD_PLAN_TABLE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTOAD_PLAN_TABLEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Edit.cshtml", updateDto);
    }

    // GET: TOAD_PLAN_TABLE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOAD_PLAN_TABLE/Delete.cshtml", result);
    }

    // POST: TOAD_PLAN_TABLE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
