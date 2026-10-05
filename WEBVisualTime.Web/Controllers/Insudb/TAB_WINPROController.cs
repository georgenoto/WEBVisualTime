using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPRO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WINPROController : Controller
{
    private readonly ITAB_WINPROService _service;
    private readonly ITABLE37Service _TABLE37Service;
    private readonly IWINDOWSService _WINDOWSService;

    public TAB_WINPROController(ITAB_WINPROService service
        , ITABLE37Service TABLE37Service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _TABLE37Service = TABLE37Service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: TAB_WINPRO
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_WINPRO/Index.cshtml", result);
    }

    // GET: TAB_WINPRO/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINPRO/Details.cshtml", result);
    }

    // GET: TAB_WINPRO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE37DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPRO/Create.cshtml", new CreateTAB_WINPRODto());
    }

    // POST: TAB_WINPRO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WINPRODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE37DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPRO/Create.cshtml", createDto);
    }

    // GET: TAB_WINPRO/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WINPRODto
        {
            SBRANCHT = result.SBRANCHT,
            NSEQUENCE = result.NSEQUENCE,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE37DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPRO/Edit.cshtml", updateDto);
    }

    // POST: TAB_WINPRO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WINPRODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SBRANCHT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE37DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPRO/Edit.cshtml", updateDto);
    }

    // GET: TAB_WINPRO/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINPRO/Delete.cshtml", result);
    }

    // POST: TAB_WINPRO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE37DropdownAsync()
    {
        var items = await _TABLE37Service.GetAllAsync();
        ViewData["SBRANCHT"] = new SelectList(items, nameof(TABLE37Dto.SBRANCHT), "SDESCRIPT");
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
