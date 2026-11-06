using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REJECTCAUSE_PRECLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9239;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REJECTCAUSE_PRECLAIMController : Controller
{
    private readonly IREJECTCAUSE_PRECLAIMService _service;
    private readonly IPRECLAIMService _PRECLAIMService;
    private readonly ITABLE9239Service _TABLE9239Service;

    public REJECTCAUSE_PRECLAIMController(IREJECTCAUSE_PRECLAIMService service
        , IPRECLAIMService PRECLAIMService
        , ITABLE9239Service TABLE9239Service
    )
    {
        _service = service;
        _PRECLAIMService = PRECLAIMService;
        _TABLE9239Service = TABLE9239Service;
    }

    // GET: REJECTCAUSE_PRECLAIM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REJECTCAUSE_PRECLAIM/Index.cshtml");

    // GET: REJECTCAUSE_PRECLAIM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Details.cshtml", result);
    }

    // GET: REJECTCAUSE_PRECLAIM/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9239DropdownAsync();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Create.cshtml", new CreateREJECTCAUSE_PRECLAIMDto());
    }

    // POST: REJECTCAUSE_PRECLAIM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREJECTCAUSE_PRECLAIMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9239DropdownAsync();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Create.cshtml", createDto);
    }

    // GET: REJECTCAUSE_PRECLAIM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREJECTCAUSE_PRECLAIMDto
        {
            NIDPRECLAIM = result.NIDPRECLAIM,
            NREJECT_CAUSE = result.NREJECT_CAUSE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SMESSAGE_REJECT = result.SMESSAGE_REJECT,
        };
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9239DropdownAsync();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Edit.cshtml", updateDto);
    }

    // POST: REJECTCAUSE_PRECLAIM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREJECTCAUSE_PRECLAIMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPRECLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9239DropdownAsync();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Edit.cshtml", updateDto);
    }

    // GET: REJECTCAUSE_PRECLAIM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REJECTCAUSE_PRECLAIM/Delete.cshtml", result);
    }

    // POST: REJECTCAUSE_PRECLAIM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePRECLAIMDropdownAsync()
    {
        var items = await _PRECLAIMService.GetAllAsync();
        ViewData["NIDPRECLAIM"] = new SelectList(items, nameof(PRECLAIMDto.NIDPRECLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE9239DropdownAsync()
    {
        var items = await _TABLE9239Service.GetAllAsync();
        ViewData["NREJECT_CAUSE"] = new SelectList(items, nameof(TABLE9239Dto.NREJECT_CAUSE), "SDESCRIPT");
    }

}
