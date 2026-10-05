using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICAL_SURCHARGEController : Controller
{
    private readonly IMEDICAL_SURCHARGEService _service;

    public MEDICAL_SURCHARGEController(IMEDICAL_SURCHARGEService service
    )
    {
        _service = service;
    }

    // GET: MEDICAL_SURCHARGE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Index.cshtml", result);
    }

    // GET: MEDICAL_SURCHARGE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Details.cshtml", result);
    }

    // GET: MEDICAL_SURCHARGE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Create.cshtml", new CreateMEDICAL_SURCHARGEDto());
    }

    // POST: MEDICAL_SURCHARGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDICAL_SURCHARGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Create.cshtml", createDto);
    }

    // GET: MEDICAL_SURCHARGE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDICAL_SURCHARGEDto
        {
            NSURCHAR_MED = result.NSURCHAR_MED,
            NPERC_SURCHAR = result.NPERC_SURCHAR,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Edit.cshtml", updateDto);
    }

    // POST: MEDICAL_SURCHARGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMEDICAL_SURCHARGEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSURCHAR_MED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Edit.cshtml", updateDto);
    }

    // GET: MEDICAL_SURCHARGE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICAL_SURCHARGE/Delete.cshtml", result);
    }

    // POST: MEDICAL_SURCHARGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
