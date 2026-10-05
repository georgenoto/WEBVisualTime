using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECT_CAUSE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REJECT_CAUSEController : Controller
{
    private readonly IREJECT_CAUSEService _service;
    private readonly ITABLE5002Service _TABLE5002Service;

    public REJECT_CAUSEController(IREJECT_CAUSEService service
        , ITABLE5002Service TABLE5002Service
    )
    {
        _service = service;
        _TABLE5002Service = TABLE5002Service;
    }

    // GET: REJECT_CAUSE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REJECT_CAUSE/Index.cshtml", result);
    }

    // GET: REJECT_CAUSE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REJECT_CAUSE/Details.cshtml", result);
    }

    // GET: REJECT_CAUSE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/REJECT_CAUSE/Create.cshtml", new CreateREJECT_CAUSEDto());
    }

    // POST: REJECT_CAUSE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREJECT_CAUSEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/REJECT_CAUSE/Create.cshtml", createDto);
    }

    // GET: REJECT_CAUSE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREJECT_CAUSEDto
        {
            NREJECTCAUSE = result.NREJECTCAUSE,
            NBANK_CODE = result.NBANK_CODE,
            NWAY_PAY = result.NWAY_PAY,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SNO_ENDEAVOUR = result.SNO_ENDEAVOUR,
        };
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/REJECT_CAUSE/Edit.cshtml", updateDto);
    }

    // POST: REJECT_CAUSE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREJECT_CAUSEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NREJECTCAUSE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/REJECT_CAUSE/Edit.cshtml", updateDto);
    }

    // GET: REJECT_CAUSE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REJECT_CAUSE/Delete.cshtml", result);
    }

    // POST: REJECT_CAUSE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

}
