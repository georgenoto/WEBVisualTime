using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PLAN_TABLE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PLAN_TABLEController : Controller
{
    private readonly IPLAN_TABLEService _service;

    public PLAN_TABLEController(IPLAN_TABLEService service
    )
    {
        _service = service;
    }

    // GET: PLAN_TABLE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PLAN_TABLE/Index.cshtml", result);
    }

    // GET: PLAN_TABLE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PLAN_TABLE/Details.cshtml", result);
    }

    // GET: PLAN_TABLE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PLAN_TABLE/Create.cshtml", new CreatePLAN_TABLEDto());
    }

    // POST: PLAN_TABLE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePLAN_TABLEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PLAN_TABLE/Create.cshtml", createDto);
    }

    // GET: PLAN_TABLE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePLAN_TABLEDto
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
            OPTIMIZER = result.OPTIMIZER,
            SEARCH_COLUMNS = result.SEARCH_COLUMNS,
            ID = result.ID,
            PARENT_ID = result.PARENT_ID,
            POSITION = result.POSITION,
            COST = result.COST,
            CARDINALITY = result.CARDINALITY,
            BYTES = result.BYTES,
            OTHER_TAG = result.OTHER_TAG,
            PARTITION_START = result.PARTITION_START,
            PARTITION_STOP = result.PARTITION_STOP,
            PARTITION_ID = result.PARTITION_ID,
            OTHER = result.OTHER,
            DISTRIBUTION = result.DISTRIBUTION,
        };
        return View("~/Views/Insudb/PLAN_TABLE/Edit.cshtml", updateDto);
    }

    // POST: PLAN_TABLE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePLAN_TABLEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PLAN_TABLE/Edit.cshtml", updateDto);
    }

    // GET: PLAN_TABLE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PLAN_TABLE/Delete.cshtml", result);
    }

    // POST: PLAN_TABLE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
