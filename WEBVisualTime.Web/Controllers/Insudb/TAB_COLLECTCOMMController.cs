using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_COLLECTCOMMController : Controller
{
    private readonly ITAB_COLLECTCOMMService _service;

    public TAB_COLLECTCOMMController(ITAB_COLLECTCOMMService service
    )
    {
        _service = service;
    }

    // GET: TAB_COLLECTCOMM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Index.cshtml", result);
    }

    // GET: TAB_COLLECTCOMM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Details.cshtml", result);
    }

    // GET: TAB_COLLECTCOMM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Create.cshtml", new CreateTAB_COLLECTCOMMDto());
    }

    // POST: TAB_COLLECTCOMM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_COLLECTCOMMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Create.cshtml", createDto);
    }

    // GET: TAB_COLLECTCOMM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_COLLECTCOMMDto
        {
            NCODE = result.NCODE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Edit.cshtml", updateDto);
    }

    // POST: TAB_COLLECTCOMM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_COLLECTCOMMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Edit.cshtml", updateDto);
    }

    // GET: TAB_COLLECTCOMM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COLLECTCOMM/Delete.cshtml", result);
    }

    // POST: TAB_COLLECTCOMM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
