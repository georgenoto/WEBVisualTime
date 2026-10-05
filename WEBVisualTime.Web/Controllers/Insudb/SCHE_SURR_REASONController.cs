using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_REASON;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHE_SURR_REASONController : Controller
{
    private readonly ISCHE_SURR_REASONService _service;

    public SCHE_SURR_REASONController(ISCHE_SURR_REASONService service
    )
    {
        _service = service;
    }

    // GET: SCHE_SURR_REASON
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SCHE_SURR_REASON/Index.cshtml", result);
    }

    // GET: SCHE_SURR_REASON/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_REASON/Details.cshtml", result);
    }

    // GET: SCHE_SURR_REASON/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SCHE_SURR_REASON/Create.cshtml", new CreateSCHE_SURR_REASONDto());
    }

    // POST: SCHE_SURR_REASON/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHE_SURR_REASONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_REASON/Create.cshtml", createDto);
    }

    // GET: SCHE_SURR_REASON/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHE_SURR_REASONDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NSURR_REASON = result.NSURR_REASON,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/SCHE_SURR_REASON/Edit.cshtml", updateDto);
    }

    // POST: SCHE_SURR_REASON/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHE_SURR_REASONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_REASON/Edit.cshtml", updateDto);
    }

    // GET: SCHE_SURR_REASON/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_REASON/Delete.cshtml", result);
    }

    // POST: SCHE_SURR_REASON/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
