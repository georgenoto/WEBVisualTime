using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9269;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE12Controller : Controller
{
    private readonly ITABLE12Service _service;
    private readonly ITABLE9269Service _TABLE9269Service;

    public TABLE12Controller(ITABLE12Service service
        , ITABLE9269Service TABLE9269Service
    )
    {
        _service = service;
        _TABLE9269Service = TABLE9269Service;
    }

    // GET: TABLE12
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TABLE12/Index.cshtml");

    // GET: TABLE12/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE12/Details.cshtml", result);
    }

    // GET: TABLE12/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9269DropdownAsync();
        return View("~/Views/Insudb/TABLE12/Create.cshtml", new CreateTABLE12Dto());
    }

    // POST: TABLE12/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE12Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9269DropdownAsync();
        return View("~/Views/Insudb/TABLE12/Create.cshtml", createDto);
    }

    // GET: TABLE12/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE12Dto
        {
            NROLE = result.NROLE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTABLE9269 = result.NTABLE9269,
        };
        await PopulateTABLE9269DropdownAsync();
        return View("~/Views/Insudb/TABLE12/Edit.cshtml", updateDto);
    }

    // POST: TABLE12/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE12Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NROLE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9269DropdownAsync();
        return View("~/Views/Insudb/TABLE12/Edit.cshtml", updateDto);
    }

    // GET: TABLE12/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE12/Delete.cshtml", result);
    }

    // POST: TABLE12/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9269DropdownAsync()
    {
        var items = await _TABLE9269Service.GetAllAsync();
        ViewData["NTABLE9269"] = new SelectList(items, nameof(TABLE9269Dto.NORDERBY), "SDESCRIPT");
    }

}
