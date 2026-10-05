using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORTMASTER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REPORTMASTERController : Controller
{
    private readonly IREPORTMASTERService _service;

    public REPORTMASTERController(IREPORTMASTERService service
    )
    {
        _service = service;
    }

    // GET: REPORTMASTER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REPORTMASTER/Index.cshtml", result);
    }

    // GET: REPORTMASTER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORTMASTER/Details.cshtml", result);
    }

    // GET: REPORTMASTER/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REPORTMASTER/Create.cshtml", new CreateREPORTMASTERDto());
    }

    // POST: REPORTMASTER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREPORTMASTERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORTMASTER/Create.cshtml", createDto);
    }

    // GET: REPORTMASTER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREPORTMASTERDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCOD_AGREE = result.NCOD_AGREE,
            SCODE_REPORT = result.SCODE_REPORT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/REPORTMASTER/Edit.cshtml", updateDto);
    }

    // POST: REPORTMASTER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREPORTMASTERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORTMASTER/Edit.cshtml", updateDto);
    }

    // GET: REPORTMASTER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORTMASTER/Delete.cshtml", result);
    }

    // POST: REPORTMASTER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
