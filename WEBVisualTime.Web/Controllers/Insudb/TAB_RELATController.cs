using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_RELAT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_RELATController : Controller
{
    private readonly ITAB_RELATService _service;
    private readonly ITABLE15Service _TABLE15Service;

    public TAB_RELATController(ITAB_RELATService service
        , ITABLE15Service TABLE15Service
    )
    {
        _service = service;
        _TABLE15Service = TABLE15Service;
    }

    // GET: TAB_RELAT
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_RELAT/Index.cshtml", result);
    }

    // GET: TAB_RELAT/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_RELAT/Details.cshtml", result);
    }

    // GET: TAB_RELAT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/TAB_RELAT/Create.cshtml", new CreateTAB_RELATDto());
    }

    // POST: TAB_RELAT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_RELATDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/TAB_RELAT/Create.cshtml", createDto);
    }

    // GET: TAB_RELAT/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_RELATDto
        {
            NRELASHIP = result.NRELASHIP,
            DCOMPDATE = result.DCOMPDATE,
            NREL_TARGET = result.NREL_TARGET,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/TAB_RELAT/Edit.cshtml", updateDto);
    }

    // POST: TAB_RELAT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_RELATDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRELASHIP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/TAB_RELAT/Edit.cshtml", updateDto);
    }

    // GET: TAB_RELAT/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_RELAT/Delete.cshtml", result);
    }

    // POST: TAB_RELAT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE15DropdownAsync()
    {
        var items = await _TABLE15Service.GetAllAsync();
        ViewData["NRELASHIP"] = new SelectList(items, nameof(TABLE15Dto.NRELASHIP), "SDESCRIPT");
        ViewData["NREL_TARGET"] = new SelectList(items, nameof(TABLE15Dto.NRELASHIP), "SDESCRIPT");
    }

}
