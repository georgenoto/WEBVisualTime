using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_PRESCRIPTION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_PRESCRIPTIONController : Controller
{
    private readonly ICLAIM_PRESCRIPTIONService _service;

    public CLAIM_PRESCRIPTIONController(ICLAIM_PRESCRIPTIONService service
    )
    {
        _service = service;
    }

    // GET: CLAIM_PRESCRIPTION
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_PRESCRIPTION/Index.cshtml");

    // GET: CLAIM_PRESCRIPTION/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Details.cshtml", result);
    }

    // GET: CLAIM_PRESCRIPTION/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Create.cshtml", new CreateCLAIM_PRESCRIPTIONDto());
    }

    // POST: CLAIM_PRESCRIPTION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_PRESCRIPTIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Create.cshtml", createDto);
    }

    // GET: CLAIM_PRESCRIPTION/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_PRESCRIPTIONDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMONTHS = result.NMONTHS,
            NDAYS = result.NDAYS,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NCLA_LI_TYP = result.NCLA_LI_TYP,
        };
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_PRESCRIPTION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_PRESCRIPTIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_PRESCRIPTION/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_PRESCRIPTION/Delete.cshtml", result);
    }

    // POST: CLAIM_PRESCRIPTION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
