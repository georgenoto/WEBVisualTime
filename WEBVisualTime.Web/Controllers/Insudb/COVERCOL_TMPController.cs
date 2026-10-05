using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COVERCOL_TMP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COVERCOL_TMPController : Controller
{
    private readonly ICOVERCOL_TMPService _service;

    public COVERCOL_TMPController(ICOVERCOL_TMPService service
    )
    {
        _service = service;
    }

    // GET: COVERCOL_TMP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COVERCOL_TMP/Index.cshtml", result);
    }

    // GET: COVERCOL_TMP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVERCOL_TMP/Details.cshtml", result);
    }

    // GET: COVERCOL_TMP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/COVERCOL_TMP/Create.cshtml", new CreateCOVERCOL_TMPDto());
    }

    // POST: COVERCOL_TMP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOVERCOL_TMPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COVERCOL_TMP/Create.cshtml", createDto);
    }

    // GET: COVERCOL_TMP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOVERCOL_TMPDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NIDCONSEC = result.NIDCONSEC,
            NROW = result.NROW,
            NCOLUMN = result.NCOLUMN,
            STITTLE = result.STITTLE,
            SVALUE = result.SVALUE,
            SVALUE1 = result.SVALUE1,
            SVALUE2 = result.SVALUE2,
            SVALUE3 = result.SVALUE3,
            SVALUE4 = result.SVALUE4,
            SVALUE5 = result.SVALUE5,
            SVALUE6 = result.SVALUE6,
            SVALUE7 = result.SVALUE7,
            SVALUE8 = result.SVALUE8,
            SVALUE9 = result.SVALUE9,
            STYPE = result.STYPE,
            SDATATYPE = result.SDATATYPE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SMATERNITY = result.SMATERNITY,
        };
        return View("~/Views/Insudb/COVERCOL_TMP/Edit.cshtml", updateDto);
    }

    // POST: COVERCOL_TMP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOVERCOL_TMPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COVERCOL_TMP/Edit.cshtml", updateDto);
    }

    // GET: COVERCOL_TMP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVERCOL_TMP/Delete.cshtml", result);
    }

    // POST: COVERCOL_TMP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
