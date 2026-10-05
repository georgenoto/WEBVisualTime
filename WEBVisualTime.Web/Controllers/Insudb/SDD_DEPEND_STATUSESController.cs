using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_DEPEND_STATUSES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_DEPEND_STATUSESController : Controller
{
    private readonly ISDD_DEPEND_STATUSESService _service;

    public SDD_DEPEND_STATUSESController(ISDD_DEPEND_STATUSESService service
    )
    {
        _service = service;
    }

    // GET: SDD_DEPEND_STATUSES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Index.cshtml", result);
    }

    // GET: SDD_DEPEND_STATUSES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Details.cshtml", result);
    }

    // GET: SDD_DEPEND_STATUSES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Create.cshtml", new CreateSDD_DEPEND_STATUSESDto());
    }

    // POST: SDD_DEPEND_STATUSES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSDD_DEPEND_STATUSESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Create.cshtml", createDto);
    }

    // GET: SDD_DEPEND_STATUSES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSDD_DEPEND_STATUSESDto
        {
            STATUS = result.STATUS,
            DESCRIPTION = result.DESCRIPTION,
            SYSTEM_FLAG = result.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = result.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = result.DATE_CREATED,
            CREATED_BY = result.CREATED_BY,
            DATE_CHANGED = result.DATE_CHANGED,
            CHANGED_BY = result.CHANGED_BY,
        };
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Edit.cshtml", updateDto);
    }

    // POST: SDD_DEPEND_STATUSES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSDD_DEPEND_STATUSESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STATUS, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Edit.cshtml", updateDto);
    }

    // GET: SDD_DEPEND_STATUSES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_DEPEND_STATUSES/Delete.cshtml", result);
    }

    // POST: SDD_DEPEND_STATUSES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
