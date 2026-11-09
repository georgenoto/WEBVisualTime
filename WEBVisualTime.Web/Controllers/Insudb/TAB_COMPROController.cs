using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMPRO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE532;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_COMPROController : Controller
{
    private readonly ITAB_COMPROService _service;
    private readonly ITABLE6Service _TABLE6Service;
    private readonly ITABLE532Service _TABLE532Service;

    public TAB_COMPROController(ITAB_COMPROService service
        , ITABLE6Service TABLE6Service
        , ITABLE532Service TABLE532Service
    )
    {
        _service = service;
        _TABLE6Service = TABLE6Service;
        _TABLE532Service = TABLE532Service;
    }

    // GET: TAB_COMPRO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_COMPRO/Index.cshtml");

    // GET: TAB_COMPRO/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COMPRO/Details.cshtml", result);
    }

    // GET: TAB_COMPRO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE6DropdownAsync();
        await PopulateTABLE532DropdownAsync();
        return View("~/Views/Insudb/TAB_COMPRO/Create.cshtml", new CreateTAB_COMPRODto());
    }

    // POST: TAB_COMPRO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_COMPRODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6DropdownAsync();
        await PopulateTABLE532DropdownAsync();
        return View("~/Views/Insudb/TAB_COMPRO/Create.cshtml", createDto);
    }

    // GET: TAB_COMPRO/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_COMPRODto
        {
            NTYPE_TRAN = result.NTYPE_TRAN,
            NLINE = result.NLINE,
            NTYP_ACCO = result.NTYP_ACCO,
            SDEBITSIDE = result.SDEBITSIDE,
            NTYP_AMOUNT = result.NTYP_AMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE6DropdownAsync();
        await PopulateTABLE532DropdownAsync();
        return View("~/Views/Insudb/TAB_COMPRO/Edit.cshtml", updateDto);
    }

    // POST: TAB_COMPRO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTAB_COMPRODto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6DropdownAsync();
        await PopulateTABLE532DropdownAsync();
        return View("~/Views/Insudb/TAB_COMPRO/Edit.cshtml", updateDto);
    }

    // GET: TAB_COMPRO/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COMPRO/Delete.cshtml", result);
    }

    // POST: TAB_COMPRO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE_TRAN"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

    private async Task PopulateTABLE532DropdownAsync()
    {
        var items = await _TABLE532Service.GetAllAsync();
        ViewData["NTYP_AMOUNT"] = new SelectList(items, nameof(TABLE532Dto.NTYP_AMOUNT), "SDESCRIPT");
    }

}
