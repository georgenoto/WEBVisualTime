using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WINCLAController : Controller
{
    private readonly ITAB_WINCLAService _service;
    private readonly IWINDOWSService _WINDOWSService;

    public TAB_WINCLAController(ITAB_WINCLAService service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: TAB_WINCLA
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_WINCLA/Index.cshtml");

    // GET: TAB_WINCLA/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINCLA/Details.cshtml", result);
    }

    // GET: TAB_WINCLA/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLA/Create.cshtml", new CreateTAB_WINCLADto());
    }

    // POST: TAB_WINCLA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WINCLADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLA/Create.cshtml", createDto);
    }

    // GET: TAB_WINCLA/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WINCLADto
        {
            NTRATYPEC = result.NTRATYPEC,
            SBRANCHT = result.SBRANCHT,
            SBUSSITYP = result.SBUSSITYP,
            NSEQUENCE = result.NSEQUENCE,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLA/Edit.cshtml", updateDto);
    }

    // POST: TAB_WINCLA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WINCLADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTRATYPEC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLA/Edit.cshtml", updateDto);
    }

    // GET: TAB_WINCLA/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINCLA/Delete.cshtml", result);
    }

    // POST: TAB_WINCLA/Delete/{id}
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
