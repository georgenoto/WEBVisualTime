using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_NLS_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_NLS_GLOBAL_NAME_DOMAINSController : Controller
{
    private readonly ISDD_NLS_GLOBAL_NAME_DOMAINSService _service;
    private readonly ISDD_GLOBAL_NAME_DOMAINSService _SDD_GLOBAL_NAME_DOMAINSService;

    public SDD_NLS_GLOBAL_NAME_DOMAINSController(ISDD_NLS_GLOBAL_NAME_DOMAINSService service
        , ISDD_GLOBAL_NAME_DOMAINSService SDD_GLOBAL_NAME_DOMAINSService
    )
    {
        _service = service;
        _SDD_GLOBAL_NAME_DOMAINSService = SDD_GLOBAL_NAME_DOMAINSService;
    }

    // GET: SDD_NLS_GLOBAL_NAME_DOMAINS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Index.cshtml");

    // GET: SDD_NLS_GLOBAL_NAME_DOMAINS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Details.cshtml", result);
    }

    // GET: SDD_NLS_GLOBAL_NAME_DOMAINS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateSDD_GLOBAL_NAME_DOMAINSDropdownAsync();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Create.cshtml", new CreateSDD_NLS_GLOBAL_NAME_DOMAINSDto());
    }

    // POST: SDD_NLS_GLOBAL_NAME_DOMAINS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSDD_NLS_GLOBAL_NAME_DOMAINSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateSDD_GLOBAL_NAME_DOMAINSDropdownAsync();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Create.cshtml", createDto);
    }

    // GET: SDD_NLS_GLOBAL_NAME_DOMAINS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSDD_NLS_GLOBAL_NAME_DOMAINSDto
        {
            IRID = result.IRID,
            IVID = result.IVID,
            NLS_NAME = result.NLS_NAME,
            NLS_PLURAL_NAME = result.NLS_PLURAL_NAME,
            NLS_LANG = result.NLS_LANG,
            GND_IRID = result.GND_IRID,
            NUMBER_OF_TIMES_MODIFIED = result.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = result.DATE_CREATED,
            CREATED_BY = result.CREATED_BY,
            DATE_CHANGED = result.DATE_CHANGED,
            CHANGED_BY = result.CHANGED_BY,
        };
        await PopulateSDD_GLOBAL_NAME_DOMAINSDropdownAsync();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Edit.cshtml", updateDto);
    }

    // POST: SDD_NLS_GLOBAL_NAME_DOMAINS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSDD_NLS_GLOBAL_NAME_DOMAINSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.IRID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateSDD_GLOBAL_NAME_DOMAINSDropdownAsync();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Edit.cshtml", updateDto);
    }

    // GET: SDD_NLS_GLOBAL_NAME_DOMAINS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_NLS_GLOBAL_NAME_DOMAINS/Delete.cshtml", result);
    }

    // POST: SDD_NLS_GLOBAL_NAME_DOMAINS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateSDD_GLOBAL_NAME_DOMAINSDropdownAsync()
    {
        var items = await _SDD_GLOBAL_NAME_DOMAINSService.GetAllAsync();
        ViewData["GND_IRID"] = new SelectList(items, nameof(SDD_GLOBAL_NAME_DOMAINSDto.IRID), "NAME");
    }

}
