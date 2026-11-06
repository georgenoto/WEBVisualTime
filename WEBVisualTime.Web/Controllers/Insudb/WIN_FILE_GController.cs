using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_FILE_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE634;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WIN_FILE_GController : Controller
{
    private readonly IWIN_FILE_GService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly ITABLE634Service _TABLE634Service;

    public WIN_FILE_GController(IWIN_FILE_GService service
        , IWINDOWSService WINDOWSService
        , ITABLE634Service TABLE634Service
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _TABLE634Service = TABLE634Service;
    }

    // GET: WIN_FILE_G
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/WIN_FILE_G/Index.cshtml");

    // GET: WIN_FILE_G/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_FILE_G/Details.cshtml", result);
    }

    // GET: WIN_FILE_G/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        return View("~/Views/Insudb/WIN_FILE_G/Create.cshtml", new CreateWIN_FILE_GDto());
    }

    // POST: WIN_FILE_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWIN_FILE_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        return View("~/Views/Insudb/WIN_FILE_G/Create.cshtml", createDto);
    }

    // GET: WIN_FILE_G/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWIN_FILE_GDto
        {
            SCODISPL = result.SCODISPL,
            NBRANCH_GEN = result.NBRANCH_GEN,
            DCOMPDATE = result.DCOMPDATE,
            STABNAME = result.STABNAME,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        return View("~/Views/Insudb/WIN_FILE_G/Edit.cshtml", updateDto);
    }

    // POST: WIN_FILE_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWIN_FILE_GDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODISPL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE634DropdownAsync();
        return View("~/Views/Insudb/WIN_FILE_G/Edit.cshtml", updateDto);
    }

    // GET: WIN_FILE_G/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_FILE_G/Delete.cshtml", result);
    }

    // POST: WIN_FILE_G/Delete/{id}
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

    private async Task PopulateTABLE634DropdownAsync()
    {
        var items = await _TABLE634Service.GetAllAsync();
        ViewData["NBRANCH_GEN"] = new SelectList(items, nameof(TABLE634Dto.NBRANCH_GEN), "SDESCRIPT");
    }

}
