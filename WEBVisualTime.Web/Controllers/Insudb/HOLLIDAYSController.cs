using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.HOLLIDAYS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7013;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class HOLLIDAYSController : Controller
{
    private readonly IHOLLIDAYSService _service;
    private readonly ITABLE7013Service _TABLE7013Service;

    public HOLLIDAYSController(IHOLLIDAYSService service
        , ITABLE7013Service TABLE7013Service
    )
    {
        _service = service;
        _TABLE7013Service = TABLE7013Service;
    }

    // GET: HOLLIDAYS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/HOLLIDAYS/Index.cshtml", result);
    }

    // GET: HOLLIDAYS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOLLIDAYS/Details.cshtml", result);
    }

    // GET: HOLLIDAYS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7013DropdownAsync();
        return View("~/Views/Insudb/HOLLIDAYS/Create.cshtml", new CreateHOLLIDAYSDto());
    }

    // POST: HOLLIDAYS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateHOLLIDAYSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7013DropdownAsync();
        return View("~/Views/Insudb/HOLLIDAYS/Create.cshtml", createDto);
    }

    // GET: HOLLIDAYS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateHOLLIDAYSDto
        {
            NMONTH = result.NMONTH,
            NDAY = result.NDAY,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NCOUNTRY = result.NCOUNTRY,
            NYEAR = result.NYEAR,
        };
        await PopulateTABLE7013DropdownAsync();
        return View("~/Views/Insudb/HOLLIDAYS/Edit.cshtml", updateDto);
    }

    // POST: HOLLIDAYS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHOLLIDAYSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMONTH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7013DropdownAsync();
        return View("~/Views/Insudb/HOLLIDAYS/Edit.cshtml", updateDto);
    }

    // GET: HOLLIDAYS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOLLIDAYS/Delete.cshtml", result);
    }

    // POST: HOLLIDAYS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE7013DropdownAsync()
    {
        var items = await _TABLE7013Service.GetAllAsync();
        ViewData["NMONTH"] = new SelectList(items, nameof(TABLE7013Dto.NCODIGINT), "SDESCRIPT");
    }

}
