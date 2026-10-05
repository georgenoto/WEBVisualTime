using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_TIMES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REP_TIMESController : Controller
{
    private readonly IREP_TIMESService _service;

    public REP_TIMESController(IREP_TIMESService service
    )
    {
        _service = service;
    }

    // GET: REP_TIMES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REP_TIMES/Index.cshtml", result);
    }

    // GET: REP_TIMES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_TIMES/Details.cshtml", result);
    }

    // GET: REP_TIMES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REP_TIMES/Create.cshtml", new CreateREP_TIMESDto());
    }

    // POST: REP_TIMES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREP_TIMESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_TIMES/Create.cshtml", createDto);
    }

    // GET: REP_TIMES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREP_TIMESDto
        {
            SPROCESS_NAME = result.SPROCESS_NAME,
            SDESC = result.SDESC,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/REP_TIMES/Edit.cshtml", updateDto);
    }

    // POST: REP_TIMES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREP_TIMESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SPROCESS_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_TIMES/Edit.cshtml", updateDto);
    }

    // GET: REP_TIMES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_TIMES/Delete.cshtml", result);
    }

    // POST: REP_TIMES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
