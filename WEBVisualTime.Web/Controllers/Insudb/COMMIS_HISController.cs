using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMIS_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7504;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMIS_HISController : Controller
{
    private readonly ICOMMIS_HISService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE7504Service _TABLE7504Service;

    public COMMIS_HISController(ICOMMIS_HISService service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE7504Service TABLE7504Service
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE7504Service = TABLE7504Service;
    }

    // GET: COMMIS_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMMIS_HIS/Index.cshtml");

    // GET: COMMIS_HIS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMIS_HIS/Details.cshtml", result);
    }

    // GET: COMMIS_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7504DropdownAsync();
        return View("~/Views/Insudb/COMMIS_HIS/Create.cshtml", new CreateCOMMIS_HISDto());
    }

    // POST: COMMIS_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMIS_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7504DropdownAsync();
        return View("~/Views/Insudb/COMMIS_HIS/Create.cshtml", createDto);
    }

    // GET: COMMIS_HIS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMIS_HISDto
        {
            NINTERMED = result.NINTERMED,
            STYP_COMISS = result.STYP_COMISS,
            DEFFECDATE = result.DEFFECDATE,
            NCOMTAB = result.NCOMTAB,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7504DropdownAsync();
        return View("~/Views/Insudb/COMMIS_HIS/Edit.cshtml", updateDto);
    }

    // POST: COMMIS_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCOMMIS_HISDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE7504DropdownAsync();
        return View("~/Views/Insudb/COMMIS_HIS/Edit.cshtml", updateDto);
    }

    // GET: COMMIS_HIS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMIS_HIS/Delete.cshtml", result);
    }

    // POST: COMMIS_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE7504DropdownAsync()
    {
        var items = await _TABLE7504Service.GetAllAsync();
        ViewData["STYP_COMISS"] = new SelectList(items, nameof(TABLE7504Dto.STYP_COMISS), "SDESCRIPT");
    }

}
