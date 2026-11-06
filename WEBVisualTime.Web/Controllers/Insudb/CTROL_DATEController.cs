using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CTROL_DATE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE526;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CTROL_DATEController : Controller
{
    private readonly ICTROL_DATEService _service;
    private readonly ITABLE526Service _TABLE526Service;

    public CTROL_DATEController(ICTROL_DATEService service
        , ITABLE526Service TABLE526Service
    )
    {
        _service = service;
        _TABLE526Service = TABLE526Service;
    }

    // GET: CTROL_DATE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CTROL_DATE/Index.cshtml");

    // GET: CTROL_DATE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CTROL_DATE/Details.cshtml", result);
    }

    // GET: CTROL_DATE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE526DropdownAsync();
        return View("~/Views/Insudb/CTROL_DATE/Create.cshtml", new CreateCTROL_DATEDto());
    }

    // POST: CTROL_DATE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCTROL_DATEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE526DropdownAsync();
        return View("~/Views/Insudb/CTROL_DATE/Create.cshtml", createDto);
    }

    // GET: CTROL_DATE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCTROL_DATEDto
        {
            NTYPE_PROCE = result.NTYPE_PROCE,
            DEFFECDATE = result.DEFFECDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            DNEXTDATEPROC = result.DNEXTDATEPROC,
        };
        await PopulateTABLE526DropdownAsync();
        return View("~/Views/Insudb/CTROL_DATE/Edit.cshtml", updateDto);
    }

    // POST: CTROL_DATE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCTROL_DATEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_PROCE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE526DropdownAsync();
        return View("~/Views/Insudb/CTROL_DATE/Edit.cshtml", updateDto);
    }

    // GET: CTROL_DATE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CTROL_DATE/Delete.cshtml", result);
    }

    // POST: CTROL_DATE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE526DropdownAsync()
    {
        var items = await _TABLE526Service.GetAllAsync();
        ViewData["NTYPE_PROCE"] = new SelectList(items, nameof(TABLE526Dto.NTYPE_PROCE), "SDESCRIPT");
    }

}
