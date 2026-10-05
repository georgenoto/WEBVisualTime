using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.OFFICE_ALLOW_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class OFFICE_ALLOW_PRODController : Controller
{
    private readonly IOFFICE_ALLOW_PRODService _service;
    private readonly ITABLE9Service _TABLE9Service;

    public OFFICE_ALLOW_PRODController(IOFFICE_ALLOW_PRODService service
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
    }

    // GET: OFFICE_ALLOW_PROD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Index.cshtml", result);
    }

    // GET: OFFICE_ALLOW_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Details.cshtml", result);
    }

    // GET: OFFICE_ALLOW_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Create.cshtml", new CreateOFFICE_ALLOW_PRODDto());
    }

    // POST: OFFICE_ALLOW_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOFFICE_ALLOW_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Create.cshtml", createDto);
    }

    // GET: OFFICE_ALLOW_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateOFFICE_ALLOW_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NOFFICE_PROD = result.NOFFICE_PROD,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
        };
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Edit.cshtml", updateDto);
    }

    // POST: OFFICE_ALLOW_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateOFFICE_ALLOW_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Edit.cshtml", updateDto);
    }

    // GET: OFFICE_ALLOW_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OFFICE_ALLOW_PROD/Delete.cshtml", result);
    }

    // POST: OFFICE_ALLOW_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE_PROD"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
