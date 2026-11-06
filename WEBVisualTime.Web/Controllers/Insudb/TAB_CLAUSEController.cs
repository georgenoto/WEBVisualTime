using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CLAUSE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7509;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_CLAUSEController : Controller
{
    private readonly ITAB_CLAUSEService _service;
    private readonly ITABLE7509Service _TABLE7509Service;

    public TAB_CLAUSEController(ITAB_CLAUSEService service
        , ITABLE7509Service TABLE7509Service
    )
    {
        _service = service;
        _TABLE7509Service = TABLE7509Service;
    }

    // GET: TAB_CLAUSE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_CLAUSE/Index.cshtml");

    // GET: TAB_CLAUSE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_CLAUSE/Details.cshtml", result);
    }

    // GET: TAB_CLAUSE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7509DropdownAsync();
        return View("~/Views/Insudb/TAB_CLAUSE/Create.cshtml", new CreateTAB_CLAUSEDto());
    }

    // POST: TAB_CLAUSE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_CLAUSEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7509DropdownAsync();
        return View("~/Views/Insudb/TAB_CLAUSE/Create.cshtml", createDto);
    }

    // GET: TAB_CLAUSE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_CLAUSEDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCLAUSE = result.NCLAUSE,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SDESCRIPT = result.SDESCRIPT,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            SMODIFIED = result.SMODIFIED,
            NTYPE = result.NTYPE,
            STYPE_CLAUSE = result.STYPE_CLAUSE,
            SDOC_ATTACH = result.SDOC_ATTACH,
            NORDEN = result.NORDEN,
            STITCLAUSE = result.STITCLAUSE,
        };
        await PopulateTABLE7509DropdownAsync();
        return View("~/Views/Insudb/TAB_CLAUSE/Edit.cshtml", updateDto);
    }

    // POST: TAB_CLAUSE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_CLAUSEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7509DropdownAsync();
        return View("~/Views/Insudb/TAB_CLAUSE/Edit.cshtml", updateDto);
    }

    // GET: TAB_CLAUSE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_CLAUSE/Delete.cshtml", result);
    }

    // POST: TAB_CLAUSE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE7509DropdownAsync()
    {
        var items = await _TABLE7509Service.GetAllAsync();
        ViewData["NTYPE"] = new SelectList(items, nameof(TABLE7509Dto.NCODIGINT), "SDESCRIPT");
    }

}
