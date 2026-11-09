using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RETENTIONCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RETENTIONCOVController : Controller
{
    private readonly IRETENTIONCOVService _service;
    private readonly ITABLE5001Service _TABLE5001Service;

    public RETENTIONCOVController(IRETENTIONCOVService service
        , ITABLE5001Service TABLE5001Service
    )
    {
        _service = service;
        _TABLE5001Service = TABLE5001Service;
    }

    // GET: RETENTIONCOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/RETENTIONCOV/Index.cshtml");

    // GET: RETENTIONCOV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RETENTIONCOV/Details.cshtml", result);
    }

    // GET: RETENTIONCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/RETENTIONCOV/Create.cshtml", new CreateRETENTIONCOVDto());
    }

    // POST: RETENTIONCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRETENTIONCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/RETENTIONCOV/Create.cshtml", createDto);
    }

    // GET: RETENTIONCOV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRETENTIONCOVDto
        {
            NBRANCH_REI = result.NBRANCH_REI,
            DEFFECDATE = result.DEFFECDATE,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NINSUR_AREA = result.NINSUR_AREA,
            NCOVERGEN = result.NCOVERGEN,
            DNULLDATE = result.DNULLDATE,
            NRETENTION = result.NRETENTION,
            SROUTINE = result.SROUTINE,
            NCOVPROPOR = result.NCOVPROPOR,
            NCOMBLIM = result.NCOMBLIM,
            NCOVERCL = result.NCOVERCL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SEARTHQUAKE = result.SEARTHQUAKE,
            NMAXRETAMOUNT = result.NMAXRETAMOUNT,
        };
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/RETENTIONCOV/Edit.cshtml", updateDto);
    }

    // POST: RETENTIONCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateRETENTIONCOVDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/RETENTIONCOV/Edit.cshtml", updateDto);
    }

    // GET: RETENTIONCOV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RETENTIONCOV/Delete.cshtml", result);
    }

    // POST: RETENTIONCOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

}
