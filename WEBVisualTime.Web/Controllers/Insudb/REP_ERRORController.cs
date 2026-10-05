using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_ERROR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REP_ERRORController : Controller
{
    private readonly IREP_ERRORService _service;

    public REP_ERRORController(IREP_ERRORService service
    )
    {
        _service = service;
    }

    // GET: REP_ERROR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REP_ERROR/Index.cshtml", result);
    }

    // GET: REP_ERROR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_ERROR/Details.cshtml", result);
    }

    // GET: REP_ERROR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REP_ERROR/Create.cshtml", new CreateREP_ERRORDto());
    }

    // POST: REP_ERROR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREP_ERRORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_ERROR/Create.cshtml", createDto);
    }

    // GET: REP_ERROR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREP_ERRORDto
        {
            SPROCESS_NAME = result.SPROCESS_NAME,
            SSQLCODE = result.SSQLCODE,
            SSQLERRM = result.SSQLERRM,
            SDESCRIPTION = result.SDESCRIPTION,
            DCOMPDATE = result.DCOMPDATE,
            NORDER = result.NORDER,
        };
        return View("~/Views/Insudb/REP_ERROR/Edit.cshtml", updateDto);
    }

    // POST: REP_ERROR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREP_ERRORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SPROCESS_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_ERROR/Edit.cshtml", updateDto);
    }

    // GET: REP_ERROR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_ERROR/Delete.cshtml", result);
    }

    // POST: REP_ERROR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
