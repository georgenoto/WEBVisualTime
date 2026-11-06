using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINFIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WINFINController : Controller
{
    private readonly ITAB_WINFINService _service;
    private readonly IWINDOWSService _WINDOWSService;

    public TAB_WINFINController(ITAB_WINFINService service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: TAB_WINFIN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_WINFIN/Index.cshtml");

    // GET: TAB_WINFIN/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINFIN/Details.cshtml", result);
    }

    // GET: TAB_WINFIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINFIN/Create.cshtml", new CreateTAB_WINFINDto());
    }

    // POST: TAB_WINFIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WINFINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINFIN/Create.cshtml", createDto);
    }

    // GET: TAB_WINFIN/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WINFINDto
        {
            NTRATYPEC = result.NTRATYPEC,
            NSEQUENCE = result.NSEQUENCE,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINFIN/Edit.cshtml", updateDto);
    }

    // POST: TAB_WINFIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WINFINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTRATYPEC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINFIN/Edit.cshtml", updateDto);
    }

    // GET: TAB_WINFIN/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINFIN/Delete.cshtml", result);
    }

    // POST: TAB_WINFIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
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
