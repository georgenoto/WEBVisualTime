using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WIN_MESSAG;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WIN_MESSAGController : Controller
{
    private readonly IWIN_MESSAGService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly IMESSAGEService _MESSAGEService;
    private readonly ITABLE153Service _TABLE153Service;

    public WIN_MESSAGController(IWIN_MESSAGService service
        , IWINDOWSService WINDOWSService
        , IMESSAGEService MESSAGEService
        , ITABLE153Service TABLE153Service
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _MESSAGEService = MESSAGEService;
        _TABLE153Service = TABLE153Service;
    }

    // GET: WIN_MESSAG
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/WIN_MESSAG/Index.cshtml");

    // GET: WIN_MESSAG/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_MESSAG/Details.cshtml", result);
    }

    // GET: WIN_MESSAG/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulateMESSAGEDropdownAsync();
        await PopulateTABLE153DropdownAsync();
        return View("~/Views/Insudb/WIN_MESSAG/Create.cshtml", new CreateWIN_MESSAGDto());
    }

    // POST: WIN_MESSAG/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWIN_MESSAGDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateMESSAGEDropdownAsync();
        await PopulateTABLE153DropdownAsync();
        return View("~/Views/Insudb/WIN_MESSAG/Create.cshtml", createDto);
    }

    // GET: WIN_MESSAG/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWIN_MESSAGDto
        {
            SCODISPL = result.SCODISPL,
            NERRORNUM = result.NERRORNUM,
            SACTION_ERR = result.SACTION_ERR,
            DCOMPDATE = result.DCOMPDATE,
            SERRORTYP = result.SERRORTYP,
            NLEVEL = result.NLEVEL,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulateMESSAGEDropdownAsync();
        await PopulateTABLE153DropdownAsync();
        return View("~/Views/Insudb/WIN_MESSAG/Edit.cshtml", updateDto);
    }

    // POST: WIN_MESSAG/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWIN_MESSAGDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODISPL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateMESSAGEDropdownAsync();
        await PopulateTABLE153DropdownAsync();
        return View("~/Views/Insudb/WIN_MESSAG/Edit.cshtml", updateDto);
    }

    // GET: WIN_MESSAG/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WIN_MESSAG/Delete.cshtml", result);
    }

    // POST: WIN_MESSAG/Delete/{id}
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

    private async Task PopulateMESSAGEDropdownAsync()
    {
        var items = await _MESSAGEService.GetAllAsync();
        ViewData["NERRORNUM"] = new SelectList(items, nameof(MESSAGEDto.NERRORNUM), "SMESSAGED");
    }

    private async Task PopulateTABLE153DropdownAsync()
    {
        var items = await _TABLE153Service.GetAllAsync();
        ViewData["SERRORTYP"] = new SelectList(items, nameof(TABLE153Dto.SERRORTYP), "SDESCRIPT");
    }

}
