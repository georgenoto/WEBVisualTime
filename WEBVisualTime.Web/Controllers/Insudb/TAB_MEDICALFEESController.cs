using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MEDICALFEES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_MEDICALFEESController : Controller
{
    private readonly ITAB_MEDICALFEESService _service;

    public TAB_MEDICALFEESController(ITAB_MEDICALFEESService service
    )
    {
        _service = service;
    }

    // GET: TAB_MEDICALFEES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_MEDICALFEES/Index.cshtml", result);
    }

    // GET: TAB_MEDICALFEES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MEDICALFEES/Details.cshtml", result);
    }

    // GET: TAB_MEDICALFEES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_MEDICALFEES/Create.cshtml", new CreateTAB_MEDICALFEESDto());
    }

    // POST: TAB_MEDICALFEES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_MEDICALFEESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MEDICALFEES/Create.cshtml", createDto);
    }

    // GET: TAB_MEDICALFEES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_MEDICALFEESDto
        {
            NIDMEDICALFEE = result.NIDMEDICALFEE,
            NOFFICE = result.NOFFICE,
            NPROVIDER = result.NPROVIDER,
            NCENTPROVIDER = result.NCENTPROVIDER,
            SDESCRIPT = result.SDESCRIPT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
        };
        return View("~/Views/Insudb/TAB_MEDICALFEES/Edit.cshtml", updateDto);
    }

    // POST: TAB_MEDICALFEES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_MEDICALFEESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDMEDICALFEE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MEDICALFEES/Edit.cshtml", updateDto);
    }

    // GET: TAB_MEDICALFEES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MEDICALFEES/Delete.cshtml", result);
    }

    // POST: TAB_MEDICALFEES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
