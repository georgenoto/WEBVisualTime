using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCLASS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5650;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CASH_CONCLASSController : Controller
{
    private readonly ICASH_CONCLASSService _service;
    private readonly ITABLE5650Service _TABLE5650Service;
    private readonly ITABLE22Service _TABLE22Service;

    public CASH_CONCLASSController(ICASH_CONCLASSService service
        , ITABLE5650Service TABLE5650Service
        , ITABLE22Service TABLE22Service
    )
    {
        _service = service;
        _TABLE5650Service = TABLE5650Service;
        _TABLE22Service = TABLE22Service;
    }

    // GET: CASH_CONCLASS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CASH_CONCLASS/Index.cshtml");

    // GET: CASH_CONCLASS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_CONCLASS/Details.cshtml", result);
    }

    // GET: CASH_CONCLASS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5650DropdownAsync();
        await PopulateTABLE22DropdownAsync();
        return View("~/Views/Insudb/CASH_CONCLASS/Create.cshtml", new CreateCASH_CONCLASSDto());
    }

    // POST: CASH_CONCLASS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCASH_CONCLASSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5650DropdownAsync();
        await PopulateTABLE22DropdownAsync();
        return View("~/Views/Insudb/CASH_CONCLASS/Create.cshtml", createDto);
    }

    // GET: CASH_CONCLASS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCASH_CONCLASSDto
        {
            NCLASS_CONCEPT = result.NCLASS_CONCEPT,
            NCONCEPT = result.NCONCEPT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
        };
        await PopulateTABLE5650DropdownAsync();
        await PopulateTABLE22DropdownAsync();
        return View("~/Views/Insudb/CASH_CONCLASS/Edit.cshtml", updateDto);
    }

    // POST: CASH_CONCLASS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCASH_CONCLASSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONCEPT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5650DropdownAsync();
        await PopulateTABLE22DropdownAsync();
        return View("~/Views/Insudb/CASH_CONCLASS/Edit.cshtml", updateDto);
    }

    // GET: CASH_CONCLASS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_CONCLASS/Delete.cshtml", result);
    }

    // POST: CASH_CONCLASS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5650DropdownAsync()
    {
        var items = await _TABLE5650Service.GetAllAsync();
        ViewData["NCLASS_CONCEPT"] = new SelectList(items, nameof(TABLE5650Dto.NCLASS_CONCEPT), "SDESCRIPT");
    }

    private async Task PopulateTABLE22DropdownAsync()
    {
        var items = await _TABLE22Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE22Dto.NCONCEPT), "SDESCRIPT");
    }

}
