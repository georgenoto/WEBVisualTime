using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALFEES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICALFEESController : Controller
{
    private readonly IMEDICALFEESService _service;

    public MEDICALFEESController(IMEDICALFEESService service
    )
    {
        _service = service;
    }

    // GET: MEDICALFEES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MEDICALFEES/Index.cshtml", result);
    }

    // GET: MEDICALFEES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALFEES/Details.cshtml", result);
    }

    // GET: MEDICALFEES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MEDICALFEES/Create.cshtml", new CreateMEDICALFEESDto());
    }

    // POST: MEDICALFEES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDICALFEESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICALFEES/Create.cshtml", createDto);
    }

    // GET: MEDICALFEES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDICALFEESDto
        {
            NIDMEDICALFEE = result.NIDMEDICALFEE,
            SBENEFITCODE = result.SBENEFITCODE,
            DEFFECDATE = result.DEFFECDATE,
            NVALUE = result.NVALUE,
            NCURRENCY = result.NCURRENCY,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SHOMOLOG_BENEFIT = result.SHOMOLOG_BENEFIT,
        };
        return View("~/Views/Insudb/MEDICALFEES/Edit.cshtml", updateDto);
    }

    // POST: MEDICALFEES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMEDICALFEESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDMEDICALFEE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICALFEES/Edit.cshtml", updateDto);
    }

    // GET: MEDICALFEES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALFEES/Delete.cshtml", result);
    }

    // POST: MEDICALFEES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
