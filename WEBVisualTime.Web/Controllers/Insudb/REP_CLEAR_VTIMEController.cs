using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_CLEAR_VTIME;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REP_CLEAR_VTIMEController : Controller
{
    private readonly IREP_CLEAR_VTIMEService _service;

    public REP_CLEAR_VTIMEController(IREP_CLEAR_VTIMEService service
    )
    {
        _service = service;
    }

    // GET: REP_CLEAR_VTIME
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Index.cshtml", result);
    }

    // GET: REP_CLEAR_VTIME/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Details.cshtml", result);
    }

    // GET: REP_CLEAR_VTIME/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Create.cshtml", new CreateREP_CLEAR_VTIMEDto());
    }

    // POST: REP_CLEAR_VTIME/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREP_CLEAR_VTIMEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Create.cshtml", createDto);
    }

    // GET: REP_CLEAR_VTIME/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREP_CLEAR_VTIMEDto
        {
            STABLE = result.STABLE,
            NCOUNT = result.NCOUNT,
            NCOUNT_BD = result.NCOUNT_BD,
            NCOUNT_DEP = result.NCOUNT_DEP,
            NERASE = result.NERASE,
            NDROP = result.NDROP,
            SCOMMENTS = result.SCOMMENTS,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Edit.cshtml", updateDto);
    }

    // POST: REP_CLEAR_VTIME/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREP_CLEAR_VTIMEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STABLE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Edit.cshtml", updateDto);
    }

    // GET: REP_CLEAR_VTIME/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_CLEAR_VTIME/Delete.cshtml", result);
    }

    // POST: REP_CLEAR_VTIME/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
