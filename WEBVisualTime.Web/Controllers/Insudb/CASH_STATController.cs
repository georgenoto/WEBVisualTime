using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_STAT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5562;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CASH_STATController : Controller
{
    private readonly ICASH_STATService _service;
    private readonly ITABLE5562Service _TABLE5562Service;

    public CASH_STATController(ICASH_STATService service
        , ITABLE5562Service TABLE5562Service
    )
    {
        _service = service;
        _TABLE5562Service = TABLE5562Service;
    }

    // GET: CASH_STAT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CASH_STAT/Index.cshtml");

    // GET: CASH_STAT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_STAT/Details.cshtml", result);
    }

    // GET: CASH_STAT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5562DropdownAsync();
        return View("~/Views/Insudb/CASH_STAT/Create.cshtml", new CreateCASH_STATDto());
    }

    // POST: CASH_STAT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCASH_STATDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5562DropdownAsync();
        return View("~/Views/Insudb/CASH_STAT/Create.cshtml", createDto);
    }

    // GET: CASH_STAT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCASH_STATDto
        {
            NCASHNUM = result.NCASHNUM,
            DSTATDATE = result.DSTATDATE,
            NSTATUS = result.NSTATUS,
            NID = result.NID,
            NCASH_ID = result.NCASH_ID,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE5562DropdownAsync();
        return View("~/Views/Insudb/CASH_STAT/Edit.cshtml", updateDto);
    }

    // POST: CASH_STAT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCASH_STATDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5562DropdownAsync();
        return View("~/Views/Insudb/CASH_STAT/Edit.cshtml", updateDto);
    }

    // GET: CASH_STAT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_STAT/Delete.cshtml", result);
    }

    // POST: CASH_STAT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5562DropdownAsync()
    {
        var items = await _TABLE5562Service.GetAllAsync();
        ViewData["NSTATUS"] = new SelectList(items, nameof(TABLE5562Dto.NCASH_OPERTYP), "SDESCRIPT");
    }

}
