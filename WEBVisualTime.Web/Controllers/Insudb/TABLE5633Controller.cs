using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5633;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6071;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5633Controller : Controller
{
    private readonly ITABLE5633Service _service;
    private readonly ITABLE6071Service _TABLE6071Service;

    public TABLE5633Controller(ITABLE5633Service service
        , ITABLE6071Service TABLE6071Service
    )
    {
        _service = service;
        _TABLE6071Service = TABLE6071Service;
    }

    // GET: TABLE5633
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TABLE5633/Index.cshtml");

    // GET: TABLE5633/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5633/Details.cshtml", result);
    }

    // GET: TABLE5633/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE6071DropdownAsync();
        return View("~/Views/Insudb/TABLE5633/Create.cshtml", new CreateTABLE5633Dto());
    }

    // POST: TABLE5633/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE5633Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6071DropdownAsync();
        return View("~/Views/Insudb/TABLE5633/Create.cshtml", createDto);
    }

    // GET: TABLE5633/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE5633Dto
        {
            NORIGIN = result.NORIGIN,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTABLE6071 = result.NTABLE6071,
        };
        await PopulateTABLE6071DropdownAsync();
        return View("~/Views/Insudb/TABLE5633/Edit.cshtml", updateDto);
    }

    // POST: TABLE5633/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE5633Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NORIGIN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6071DropdownAsync();
        return View("~/Views/Insudb/TABLE5633/Edit.cshtml", updateDto);
    }

    // GET: TABLE5633/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5633/Delete.cshtml", result);
    }

    // POST: TABLE5633/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE6071DropdownAsync()
    {
        var items = await _TABLE6071Service.GetAllAsync();
        ViewData["NTABLE6071"] = new SelectList(items, nameof(TABLE6071Dto.NTYPE_ACC), "SDESCRIPT");
    }

}
