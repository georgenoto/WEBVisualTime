using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SCHE_SURR_ROLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SCHE_SURR_ROLESController : Controller
{
    private readonly ISCHE_SURR_ROLESService _service;

    public SCHE_SURR_ROLESController(ISCHE_SURR_ROLESService service
    )
    {
        _service = service;
    }

    // GET: SCHE_SURR_ROLES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Index.cshtml", result);
    }

    // GET: SCHE_SURR_ROLES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Details.cshtml", result);
    }

    // GET: SCHE_SURR_ROLES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Create.cshtml", new CreateSCHE_SURR_ROLESDto());
    }

    // POST: SCHE_SURR_ROLES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSCHE_SURR_ROLESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Create.cshtml", createDto);
    }

    // GET: SCHE_SURR_ROLES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSCHE_SURR_ROLESDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NROLE = result.NROLE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Edit.cshtml", updateDto);
    }

    // POST: SCHE_SURR_ROLES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSCHE_SURR_ROLESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Edit.cshtml", updateDto);
    }

    // GET: SCHE_SURR_ROLES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SCHE_SURR_ROLES/Delete.cshtml", result);
    }

    // POST: SCHE_SURR_ROLES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
