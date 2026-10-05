using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINCLI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WINCLIController : Controller
{
    private readonly ITAB_WINCLIService _service;
    private readonly IWINDOWSService _WINDOWSService;

    public TAB_WINCLIController(ITAB_WINCLIService service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: TAB_WINCLI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_WINCLI/Index.cshtml", result);
    }

    // GET: TAB_WINCLI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINCLI/Details.cshtml", result);
    }

    // GET: TAB_WINCLI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLI/Create.cshtml", new CreateTAB_WINCLIDto());
    }

    // POST: TAB_WINCLI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WINCLIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLI/Create.cshtml", createDto);
    }

    // GET: TAB_WINCLI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WINCLIDto
        {
            STYPE_CLIE = result.STYPE_CLIE,
            STYPE_SEQ = result.STYPE_SEQ,
            NSEQUENCE = result.NSEQUENCE,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLI/Edit.cshtml", updateDto);
    }

    // POST: TAB_WINCLI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WINCLIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STYPE_CLIE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINCLI/Edit.cshtml", updateDto);
    }

    // GET: TAB_WINCLI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINCLI/Delete.cshtml", result);
    }

    // POST: TAB_WINCLI/Delete/{id}
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
