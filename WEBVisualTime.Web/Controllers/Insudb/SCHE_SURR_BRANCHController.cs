using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_BRANCH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHE_SURR_BRANCHController : Controller
{
    private readonly ISCHE_SURR_BRANCHService _service;

    public SCHE_SURR_BRANCHController(ISCHE_SURR_BRANCHService service
    )
    {
        _service = service;
    }

    // GET: SCHE_SURR_BRANCH
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Index.cshtml", result);
    }

    // GET: SCHE_SURR_BRANCH/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Details.cshtml", result);
    }

    // GET: SCHE_SURR_BRANCH/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Create.cshtml", new CreateSCHE_SURR_BRANCHDto());
    }

    // POST: SCHE_SURR_BRANCH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHE_SURR_BRANCHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Create.cshtml", createDto);
    }

    // GET: SCHE_SURR_BRANCH/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHE_SURR_BRANCHDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NBRANCH = result.NBRANCH,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SLIFE = result.SLIFE,
        };
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Edit.cshtml", updateDto);
    }

    // POST: SCHE_SURR_BRANCH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHE_SURR_BRANCHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Edit.cshtml", updateDto);
    }

    // GET: SCHE_SURR_BRANCH/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_BRANCH/Delete.cshtml", result);
    }

    // POST: SCHE_SURR_BRANCH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
