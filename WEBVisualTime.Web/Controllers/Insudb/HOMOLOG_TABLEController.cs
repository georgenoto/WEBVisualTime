using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.HOMOLOG_TABLE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class HOMOLOG_TABLEController : Controller
{
    private readonly IHOMOLOG_TABLEService _service;

    public HOMOLOG_TABLEController(IHOMOLOG_TABLEService service
    )
    {
        _service = service;
    }

    // GET: HOMOLOG_TABLE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/HOMOLOG_TABLE/Index.cshtml", result);
    }

    // GET: HOMOLOG_TABLE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOMOLOG_TABLE/Details.cshtml", result);
    }

    // GET: HOMOLOG_TABLE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/HOMOLOG_TABLE/Create.cshtml", new CreateHOMOLOG_TABLEDto());
    }

    // POST: HOMOLOG_TABLE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateHOMOLOG_TABLEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/HOMOLOG_TABLE/Create.cshtml", createDto);
    }

    // GET: HOMOLOG_TABLE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateHOMOLOG_TABLEDto
        {
            NSYSTEM = result.NSYSTEM,
            NTABLE = result.NTABLE,
            NID = result.NID,
            SCOLUMNNAME_VT = result.SCOLUMNNAME_VT,
            SCODVALUE_VT = result.SCODVALUE_VT,
            SVALUE_VT = result.SVALUE_VT,
            STABLENAME = result.STABLENAME,
            SCOLUMNNAME = result.SCOLUMNNAME,
            SCODVALUE = result.SCODVALUE,
            SPREDOM = result.SPREDOM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/HOMOLOG_TABLE/Edit.cshtml", updateDto);
    }

    // POST: HOMOLOG_TABLE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHOMOLOG_TABLEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSYSTEM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/HOMOLOG_TABLE/Edit.cshtml", updateDto);
    }

    // GET: HOMOLOG_TABLE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOMOLOG_TABLE/Delete.cshtml", result);
    }

    // POST: HOMOLOG_TABLE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
