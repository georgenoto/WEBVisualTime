using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class STATUS_CLAIMController : Controller
{
    private readonly ISTATUS_CLAIMService _service;

    public STATUS_CLAIMController(ISTATUS_CLAIMService service
    )
    {
        _service = service;
    }

    // GET: STATUS_CLAIM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/STATUS_CLAIM/Index.cshtml", result);
    }

    // GET: STATUS_CLAIM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/STATUS_CLAIM/Details.cshtml", result);
    }

    // GET: STATUS_CLAIM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/STATUS_CLAIM/Create.cshtml", new CreateSTATUS_CLAIMDto());
    }

    // POST: STATUS_CLAIM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSTATUS_CLAIMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/STATUS_CLAIM/Create.cshtml", createDto);
    }

    // GET: STATUS_CLAIM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSTATUS_CLAIMDto
        {
            NIDSTATUSCLAIM = result.NIDSTATUSCLAIM,
            SNAME = result.SNAME,
            SENABLE = result.SENABLE,
        };
        return View("~/Views/Insudb/STATUS_CLAIM/Edit.cshtml", updateDto);
    }

    // POST: STATUS_CLAIM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSTATUS_CLAIMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDSTATUSCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/STATUS_CLAIM/Edit.cshtml", updateDto);
    }

    // GET: STATUS_CLAIM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/STATUS_CLAIM/Delete.cshtml", result);
    }

    // POST: STATUS_CLAIM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
