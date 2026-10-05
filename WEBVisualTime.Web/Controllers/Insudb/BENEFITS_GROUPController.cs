using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_GROUP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BENEFITS_GROUPController : Controller
{
    private readonly IBENEFITS_GROUPService _service;
    private readonly ITABLE8606Service _TABLE8606Service;

    public BENEFITS_GROUPController(IBENEFITS_GROUPService service
        , ITABLE8606Service TABLE8606Service
    )
    {
        _service = service;
        _TABLE8606Service = TABLE8606Service;
    }

    // GET: BENEFITS_GROUP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BENEFITS_GROUP/Index.cshtml", result);
    }

    // GET: BENEFITS_GROUP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFITS_GROUP/Details.cshtml", result);
    }

    // GET: BENEFITS_GROUP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8606DropdownAsync();
        return View("~/Views/Insudb/BENEFITS_GROUP/Create.cshtml", new CreateBENEFITS_GROUPDto());
    }

    // POST: BENEFITS_GROUP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBENEFITS_GROUPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8606DropdownAsync();
        return View("~/Views/Insudb/BENEFITS_GROUP/Create.cshtml", createDto);
    }

    // GET: BENEFITS_GROUP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBENEFITS_GROUPDto
        {
            SBENEFITGROUP = result.SBENEFITGROUP,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTYPE_GROUP = result.NTYPE_GROUP,
            SCLARIFICACT = result.SCLARIFICACT,
        };
        await PopulateTABLE8606DropdownAsync();
        return View("~/Views/Insudb/BENEFITS_GROUP/Edit.cshtml", updateDto);
    }

    // POST: BENEFITS_GROUP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBENEFITS_GROUPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SBENEFITGROUP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8606DropdownAsync();
        return View("~/Views/Insudb/BENEFITS_GROUP/Edit.cshtml", updateDto);
    }

    // GET: BENEFITS_GROUP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFITS_GROUP/Delete.cshtml", result);
    }

    // POST: BENEFITS_GROUP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8606DropdownAsync()
    {
        var items = await _TABLE8606Service.GetAllAsync();
        ViewData["NTYPE_GROUP"] = new SelectList(items, nameof(TABLE8606Dto.NTYPE_GROUP), "SDESCRIPT");
    }

}
