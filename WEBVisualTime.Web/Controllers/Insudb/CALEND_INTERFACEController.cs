using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CALEND_INTERFACE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CALEND_INTERFACEController : Controller
{
    private readonly ICALEND_INTERFACEService _service;

    public CALEND_INTERFACEController(ICALEND_INTERFACEService service
    )
    {
        _service = service;
    }

    // GET: CALEND_INTERFACE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CALEND_INTERFACE/Index.cshtml", result);
    }

    // GET: CALEND_INTERFACE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CALEND_INTERFACE/Details.cshtml", result);
    }

    // GET: CALEND_INTERFACE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CALEND_INTERFACE/Create.cshtml", new CreateCALEND_INTERFACEDto());
    }

    // POST: CALEND_INTERFACE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCALEND_INTERFACEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CALEND_INTERFACE/Create.cshtml", createDto);
    }

    // GET: CALEND_INTERFACE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCALEND_INTERFACEDto
        {
            NSHEET = result.NSHEET,
            NID = result.NID,
            NDAY = result.NDAY,
            DDATEPROC = result.DDATEPROC,
            SHOUR = result.SHOUR,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/CALEND_INTERFACE/Edit.cshtml", updateDto);
    }

    // POST: CALEND_INTERFACE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCALEND_INTERFACEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSHEET, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CALEND_INTERFACE/Edit.cshtml", updateDto);
    }

    // GET: CALEND_INTERFACE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CALEND_INTERFACE/Delete.cshtml", result);
    }

    // POST: CALEND_INTERFACE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
