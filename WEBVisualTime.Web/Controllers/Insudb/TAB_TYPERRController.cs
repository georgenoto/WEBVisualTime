using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TYPERR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TYPERR;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_TYPERRController : Controller
{
    private readonly ITAB_TYPERRService _service;
    private readonly ITAB_TYPERRService _TAB_TYPERRService;

    public TAB_TYPERRController(ITAB_TYPERRService service
        , ITAB_TYPERRService TAB_TYPERRService
    )
    {
        _service = service;
        _TAB_TYPERRService = TAB_TYPERRService;
    }

    // GET: TAB_TYPERR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_TYPERR/Index.cshtml");

    // GET: TAB_TYPERR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_TYPERR/Details.cshtml", result);
    }

    // GET: TAB_TYPERR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_TYPERRDropdownAsync();
        return View("~/Views/Insudb/TAB_TYPERR/Create.cshtml", new CreateTAB_TYPERRDto());
    }

    // POST: TAB_TYPERR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_TYPERRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_TYPERRDropdownAsync();
        return View("~/Views/Insudb/TAB_TYPERR/Create.cshtml", createDto);
    }

    // GET: TAB_TYPERR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_TYPERRDto
        {
            NTYPE_ERR = result.NTYPE_ERR,
            NTYPEERR_PA = result.NTYPEERR_PA,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            STRANSITI = result.STRANSITI,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_TYPERRDropdownAsync();
        return View("~/Views/Insudb/TAB_TYPERR/Edit.cshtml", updateDto);
    }

    // POST: TAB_TYPERR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_TYPERRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_ERR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_TYPERRDropdownAsync();
        return View("~/Views/Insudb/TAB_TYPERR/Edit.cshtml", updateDto);
    }

    // GET: TAB_TYPERR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_TYPERR/Delete.cshtml", result);
    }

    // POST: TAB_TYPERR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_TYPERRDropdownAsync()
    {
        var items = await _TAB_TYPERRService.GetAllAsync();
        ViewData["NTYPEERR_PA"] = new SelectList(items, nameof(TAB_TYPERRDto.NTYPE_ERR), "SDESCRIPT");
    }

}
