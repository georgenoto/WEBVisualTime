using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BK_AGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_BK_AGEController : Controller
{
    private readonly ITAB_BK_AGEService _service;
    private readonly ITABLE7Service _TABLE7Service;

    public TAB_BK_AGEController(ITAB_BK_AGEService service
        , ITABLE7Service TABLE7Service
    )
    {
        _service = service;
        _TABLE7Service = TABLE7Service;
    }

    // GET: TAB_BK_AGE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_BK_AGE/Index.cshtml");

    // GET: TAB_BK_AGE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_BK_AGE/Details.cshtml", result);
    }

    // GET: TAB_BK_AGE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/TAB_BK_AGE/Create.cshtml", new CreateTAB_BK_AGEDto());
    }

    // POST: TAB_BK_AGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_BK_AGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/TAB_BK_AGE/Create.cshtml", createDto);
    }

    // GET: TAB_BK_AGE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_BK_AGEDto
        {
            NBANK_CODE = result.NBANK_CODE,
            NBK_AGENCY = result.NBK_AGENCY,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SN_ABA = result.SN_ABA,
        };
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/TAB_BK_AGE/Edit.cshtml", updateDto);
    }

    // POST: TAB_BK_AGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_BK_AGEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBANK_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/TAB_BK_AGE/Edit.cshtml", updateDto);
    }

    // GET: TAB_BK_AGE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_BK_AGE/Delete.cshtml", result);
    }

    // POST: TAB_BK_AGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

}
