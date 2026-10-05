using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_SUBTYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7027;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_SUBTYPESController : Controller
{
    private readonly ITAB_PROV_SUBTYPESService _service;
    private readonly ITABLE7027Service _TABLE7027Service;

    public TAB_PROV_SUBTYPESController(ITAB_PROV_SUBTYPESService service
        , ITABLE7027Service TABLE7027Service
    )
    {
        _service = service;
        _TABLE7027Service = TABLE7027Service;
    }

    // GET: TAB_PROV_SUBTYPES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Index.cshtml", result);
    }

    // GET: TAB_PROV_SUBTYPES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Details.cshtml", result);
    }

    // GET: TAB_PROV_SUBTYPES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7027DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Create.cshtml", new CreateTAB_PROV_SUBTYPESDto());
    }

    // POST: TAB_PROV_SUBTYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_SUBTYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7027DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_SUBTYPES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_SUBTYPESDto
        {
            NTYPEPROV = result.NTYPEPROV,
            NSUBTYPEPROV = result.NSUBTYPEPROV,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE7027DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_SUBTYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_SUBTYPESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPEPROV, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7027DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_SUBTYPES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_SUBTYPES/Delete.cshtml", result);
    }

    // POST: TAB_PROV_SUBTYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE7027DropdownAsync()
    {
        var items = await _TABLE7027Service.GetAllAsync();
        ViewData["NTYPEPROV"] = new SelectList(items, nameof(TABLE7027Dto.NTYPEPROV), "SDESCRIPT");
    }

}
