using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOCLA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIALLOCLAController : Controller
{
    private readonly ICLIALLOCLAService _service;
    private readonly ITABLE12Service _TABLE12Service;

    public CLIALLOCLAController(ICLIALLOCLAService service
        , ITABLE12Service TABLE12Service
    )
    {
        _service = service;
        _TABLE12Service = TABLE12Service;
    }

    // GET: CLIALLOCLA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIALLOCLA/Index.cshtml");

    // GET: CLIALLOCLA/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIALLOCLA/Details.cshtml", result);
    }

    // GET: CLIALLOCLA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIALLOCLA/Create.cshtml", new CreateCLIALLOCLADto());
    }

    // POST: CLIALLOCLA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIALLOCLADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIALLOCLA/Create.cshtml", createDto);
    }

    // GET: CLIALLOCLA/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIALLOCLADto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NROLE = result.NROLE,
            DCOMPDATE = result.DCOMPDATE,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
            NMAXNUM_ROL = result.NMAXNUM_ROL,
            SIND_CRECLI = result.SIND_CRECLI,
            SDEFAULT_CLA_IND = result.SDEFAULT_CLA_IND,
        };
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIALLOCLA/Edit.cshtml", updateDto);
    }

    // POST: CLIALLOCLA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLIALLOCLADto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIALLOCLA/Edit.cshtml", updateDto);
    }

    // GET: CLIALLOCLA/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIALLOCLA/Delete.cshtml", result);
    }

    // POST: CLIALLOCLA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

}
