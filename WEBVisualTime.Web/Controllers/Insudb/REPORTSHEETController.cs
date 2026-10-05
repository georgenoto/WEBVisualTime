using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REPORTSHEETController : Controller
{
    private readonly IREPORTSHEETService _service;

    public REPORTSHEETController(IREPORTSHEETService service
    )
    {
        _service = service;
    }

    // GET: REPORTSHEET
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REPORTSHEET/Index.cshtml", result);
    }

    // GET: REPORTSHEET/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORTSHEET/Details.cshtml", result);
    }

    // GET: REPORTSHEET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REPORTSHEET/Create.cshtml", new CreateREPORTSHEETDto());
    }

    // POST: REPORTSHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREPORTSHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORTSHEET/Create.cshtml", createDto);
    }

    // GET: REPORTSHEET/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREPORTSHEETDto
        {
            SCODE_REPORT = result.SCODE_REPORT,
            NBOX = result.NBOX,
            NCOLUMN = result.NCOLUMN,
            NROW = result.NROW,
            DEFFECDATE = result.DEFFECDATE,
            NTYP_SECTION = result.NTYP_SECTION,
            SCONTENT = result.SCONTENT,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
        };
        return View("~/Views/Insudb/REPORTSHEET/Edit.cshtml", updateDto);
    }

    // POST: REPORTSHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREPORTSHEETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODE_REPORT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORTSHEET/Edit.cshtml", updateDto);
    }

    // GET: REPORTSHEET/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORTSHEET/Delete.cshtml", result);
    }

    // POST: REPORTSHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
