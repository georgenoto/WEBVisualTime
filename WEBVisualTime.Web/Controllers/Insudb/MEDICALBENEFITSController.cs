using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALBENEFITS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8600;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE23;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICALBENEFITSController : Controller
{
    private readonly IMEDICALBENEFITSService _service;
    private readonly ITABLE8600Service _TABLE8600Service;
    private readonly ITABLE23Service _TABLE23Service;

    public MEDICALBENEFITSController(IMEDICALBENEFITSService service
        , ITABLE8600Service TABLE8600Service
        , ITABLE23Service TABLE23Service
    )
    {
        _service = service;
        _TABLE8600Service = TABLE8600Service;
        _TABLE23Service = TABLE23Service;
    }

    // GET: MEDICALBENEFITS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MEDICALBENEFITS/Index.cshtml", result);
    }

    // GET: MEDICALBENEFITS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALBENEFITS/Details.cshtml", result);
    }

    // GET: MEDICALBENEFITS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE23DropdownAsync();
        return View("~/Views/Insudb/MEDICALBENEFITS/Create.cshtml", new CreateMEDICALBENEFITSDto());
    }

    // POST: MEDICALBENEFITS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDICALBENEFITSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE23DropdownAsync();
        return View("~/Views/Insudb/MEDICALBENEFITS/Create.cshtml", createDto);
    }

    // GET: MEDICALBENEFITS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDICALBENEFITSDto
        {
            SBENEFIT = result.SBENEFIT,
            STYPEBENEFIT = result.STYPEBENEFIT,
            SBENEFITCLAS = result.SBENEFITCLAS,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NIND_PACKAGE = result.NIND_PACKAGE,
        };
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE23DropdownAsync();
        return View("~/Views/Insudb/MEDICALBENEFITS/Edit.cshtml", updateDto);
    }

    // POST: MEDICALBENEFITS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMEDICALBENEFITSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SBENEFIT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8600DropdownAsync();
        await PopulateTABLE23DropdownAsync();
        return View("~/Views/Insudb/MEDICALBENEFITS/Edit.cshtml", updateDto);
    }

    // GET: MEDICALBENEFITS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICALBENEFITS/Delete.cshtml", result);
    }

    // POST: MEDICALBENEFITS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8600DropdownAsync()
    {
        var items = await _TABLE8600Service.GetAllAsync();
        ViewData["STYPEBENEFIT"] = new SelectList(items, nameof(TABLE8600Dto.STYPEBENEFIT), "SDESCRIPT");
    }

    private async Task PopulateTABLE23DropdownAsync()
    {
        var items = await _TABLE23Service.GetAllAsync();
        ViewData["NIND_PACKAGE"] = new SelectList(items, nameof(TABLE23Dto.NCODIGINT), "SDESCRIPT");
    }

}
