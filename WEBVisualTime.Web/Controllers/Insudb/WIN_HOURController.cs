using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_HOUR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WIN_HOURController : Controller
{
    private readonly IWIN_HOURService _service;
    private readonly IWINDOWSService _WINDOWSService;

    public WIN_HOURController(IWIN_HOURService service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: WIN_HOUR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/WIN_HOUR/Index.cshtml");

    // GET: WIN_HOUR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_HOUR/Details.cshtml", result);
    }

    // GET: WIN_HOUR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/WIN_HOUR/Create.cshtml", new CreateWIN_HOURDto());
    }

    // POST: WIN_HOUR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWIN_HOURDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/WIN_HOUR/Create.cshtml", createDto);
    }

    // GET: WIN_HOUR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWIN_HOURDto
        {
            SCODISPL = result.SCODISPL,
            SHOUR_START = result.SHOUR_START,
            SHOUR_END = result.SHOUR_END,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/WIN_HOUR/Edit.cshtml", updateDto);
    }

    // POST: WIN_HOUR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateWIN_HOURDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/WIN_HOUR/Edit.cshtml", updateDto);
    }

    // GET: WIN_HOUR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_HOUR/Delete.cshtml", result);
    }

    // POST: WIN_HOUR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
