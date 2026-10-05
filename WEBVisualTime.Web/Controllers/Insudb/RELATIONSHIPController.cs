using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONSHIP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RELATIONSHIPController : Controller
{
    private readonly IRELATIONSHIPService _service;

    public RELATIONSHIPController(IRELATIONSHIPService service
    )
    {
        _service = service;
    }

    // GET: RELATIONSHIP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/RELATIONSHIP/Index.cshtml", result);
    }

    // GET: RELATIONSHIP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELATIONSHIP/Details.cshtml", result);
    }

    // GET: RELATIONSHIP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/RELATIONSHIP/Create.cshtml", new CreateRELATIONSHIPDto());
    }

    // POST: RELATIONSHIP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRELATIONSHIPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RELATIONSHIP/Create.cshtml", createDto);
    }

    // GET: RELATIONSHIP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRELATIONSHIPDto
        {
            NIDRELATIONSHIP = result.NIDRELATIONSHIP,
            SNAME = result.SNAME,
            SENABLE = result.SENABLE,
        };
        return View("~/Views/Insudb/RELATIONSHIP/Edit.cshtml", updateDto);
    }

    // POST: RELATIONSHIP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateRELATIONSHIPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDRELATIONSHIP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RELATIONSHIP/Edit.cshtml", updateDto);
    }

    // GET: RELATIONSHIP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELATIONSHIP/Delete.cshtml", result);
    }

    // POST: RELATIONSHIP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
