using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALTEAMS_FEES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICALTEAMS_FEESController : Controller
{
    private readonly IMEDICALTEAMS_FEESService _service;

    public MEDICALTEAMS_FEESController(IMEDICALTEAMS_FEESService service
    )
    {
        _service = service;
    }

    // GET: MEDICALTEAMS_FEES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MEDICALTEAMS_FEES/Index.cshtml");

    // GET: MEDICALTEAMS_FEES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Details.cshtml", result);
    }

    // GET: MEDICALTEAMS_FEES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Create.cshtml", new CreateMEDICALTEAMS_FEESDto());
    }

    // POST: MEDICALTEAMS_FEES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDICALTEAMS_FEESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Create.cshtml", createDto);
    }

    // GET: MEDICALTEAMS_FEES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDICALTEAMS_FEESDto
        {
            NOFFICE = result.NOFFICE,
            NDOCTORROL = result.NDOCTORROL,
            NORD_PROCEDURE = result.NORD_PROCEDURE,
            DEFFECDATE = result.DEFFECDATE,
            NPERCENTAGE = result.NPERCENTAGE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Edit.cshtml", updateDto);
    }

    // POST: MEDICALTEAMS_FEES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateMEDICALTEAMS_FEESDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Edit.cshtml", updateDto);
    }

    // GET: MEDICALTEAMS_FEES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALTEAMS_FEES/Delete.cshtml", result);
    }

    // POST: MEDICALTEAMS_FEES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
