using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TARIF_COLUMNController : Controller
{
    private readonly ITARIF_COLUMNService _service;

    public TARIF_COLUMNController(ITARIF_COLUMNService service
    )
    {
        _service = service;
    }

    // GET: TARIF_COLUMN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TARIF_COLUMN/Index.cshtml", result);
    }

    // GET: TARIF_COLUMN/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TARIF_COLUMN/Details.cshtml", result);
    }

    // GET: TARIF_COLUMN/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TARIF_COLUMN/Create.cshtml", new CreateTARIF_COLUMNDto());
    }

    // POST: TARIF_COLUMN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTARIF_COLUMNDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TARIF_COLUMN/Create.cshtml", createDto);
    }

    // GET: TARIF_COLUMN/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTARIF_COLUMNDto
        {
            NID_COLUMN = result.NID_COLUMN,
            STABLE = result.STABLE,
            SCOLUMN = result.SCOLUMN,
            SNAME_COL = result.SNAME_COL,
            NDATA_TYPE = result.NDATA_TYPE,
            NSIZE = result.NSIZE,
            NDECIMAL = result.NDECIMAL,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            STABLEFK = result.STABLEFK,
        };
        return View("~/Views/Insudb/TARIF_COLUMN/Edit.cshtml", updateDto);
    }

    // POST: TARIF_COLUMN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTARIF_COLUMNDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_COLUMN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TARIF_COLUMN/Edit.cshtml", updateDto);
    }

    // GET: TARIF_COLUMN/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TARIF_COLUMN/Delete.cshtml", result);
    }

    // POST: TARIF_COLUMN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
