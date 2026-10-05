using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISEX_INT_MController : Controller
{
    private readonly IDISEX_INT_MService _service;

    public DISEX_INT_MController(IDISEX_INT_MService service
    )
    {
        _service = service;
    }

    // GET: DISEX_INT_M
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/DISEX_INT_M/Index.cshtml", result);
    }

    // GET: DISEX_INT_M/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISEX_INT_M/Details.cshtml", result);
    }

    // GET: DISEX_INT_M/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/DISEX_INT_M/Create.cshtml", new CreateDISEX_INT_MDto());
    }

    // POST: DISEX_INT_M/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDISEX_INT_MDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DISEX_INT_M/Create.cshtml", createDto);
    }

    // GET: DISEX_INT_M/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDISEX_INT_MDto
        {
            NECO_SCHE = result.NECO_SCHE,
            SDESCRIPT = result.SDESCRIPT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/DISEX_INT_M/Edit.cshtml", updateDto);
    }

    // POST: DISEX_INT_M/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDISEX_INT_MDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NECO_SCHE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DISEX_INT_M/Edit.cshtml", updateDto);
    }

    // GET: DISEX_INT_M/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISEX_INT_M/Delete.cshtml", result);
    }

    // POST: DISEX_INT_M/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
