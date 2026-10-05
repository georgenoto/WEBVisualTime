using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_ACTIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WIN_ACTIONSController : Controller
{
    private readonly IWIN_ACTIONSService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly IACTIONSService _ACTIONSService;

    public WIN_ACTIONSController(IWIN_ACTIONSService service
        , IWINDOWSService WINDOWSService
        , IACTIONSService ACTIONSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _ACTIONSService = ACTIONSService;
    }

    // GET: WIN_ACTIONS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/WIN_ACTIONS/Index.cshtml", result);
    }

    // GET: WIN_ACTIONS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_ACTIONS/Details.cshtml", result);
    }

    // GET: WIN_ACTIONS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulateACTIONSDropdownAsync();
        return View("~/Views/Insudb/WIN_ACTIONS/Create.cshtml", new CreateWIN_ACTIONSDto());
    }

    // POST: WIN_ACTIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWIN_ACTIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateACTIONSDropdownAsync();
        return View("~/Views/Insudb/WIN_ACTIONS/Create.cshtml", createDto);
    }

    // GET: WIN_ACTIONS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWIN_ACTIONSDto
        {
            SCODISPL = result.SCODISPL,
            NACTION = result.NACTION,
            NSEQUENCE = result.NSEQUENCE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulateACTIONSDropdownAsync();
        return View("~/Views/Insudb/WIN_ACTIONS/Edit.cshtml", updateDto);
    }

    // POST: WIN_ACTIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWIN_ACTIONSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODISPL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateACTIONSDropdownAsync();
        return View("~/Views/Insudb/WIN_ACTIONS/Edit.cshtml", updateDto);
    }

    // GET: WIN_ACTIONS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_ACTIONS/Delete.cshtml", result);
    }

    // POST: WIN_ACTIONS/Delete/{id}
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

    private async Task PopulateACTIONSDropdownAsync()
    {
        var items = await _ACTIONSService.GetAllAsync();
        ViewData["NACTION"] = new SelectList(items, nameof(ACTIONSDto.NACTION), "SCONTROLKEY");
    }

}
