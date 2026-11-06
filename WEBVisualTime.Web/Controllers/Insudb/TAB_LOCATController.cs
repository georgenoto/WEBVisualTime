using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_LOCATController : Controller
{
    private readonly ITAB_LOCATService _service;
    private readonly IPROVINCEService _PROVINCEService;

    public TAB_LOCATController(ITAB_LOCATService service
        , IPROVINCEService PROVINCEService
    )
    {
        _service = service;
        _PROVINCEService = PROVINCEService;
    }

    // GET: TAB_LOCAT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_LOCAT/Index.cshtml");

    // GET: TAB_LOCAT/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_LOCAT/Details.cshtml", result);
    }

    // GET: TAB_LOCAT/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePROVINCEDropdownAsync();
        return View("~/Views/Insudb/TAB_LOCAT/Create.cshtml", new CreateTAB_LOCATDto());
    }

    // POST: TAB_LOCAT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_LOCATDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePROVINCEDropdownAsync();
        return View("~/Views/Insudb/TAB_LOCAT/Create.cshtml", createDto);
    }

    // GET: TAB_LOCAT/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_LOCATDto
        {
            NLOCAL = result.NLOCAL,
            SDESCRIPT = result.SDESCRIPT,
            NPROVINCE = result.NPROVINCE,
            SSHORT_DES = result.SSHORT_DES,
            SLEGAL_LOC = result.SLEGAL_LOC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulatePROVINCEDropdownAsync();
        return View("~/Views/Insudb/TAB_LOCAT/Edit.cshtml", updateDto);
    }

    // POST: TAB_LOCAT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_LOCATDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NLOCAL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePROVINCEDropdownAsync();
        return View("~/Views/Insudb/TAB_LOCAT/Edit.cshtml", updateDto);
    }

    // GET: TAB_LOCAT/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_LOCAT/Delete.cshtml", result);
    }

    // POST: TAB_LOCAT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TAB_LOCAT/GetByNPROVINCE?NPROVINCE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNPROVINCE(int NPROVINCE)
    {
        var items = await _service.FindAsync(p => p.NPROVINCE == NPROVINCE);
        return Json(items.Select(i => new { value = i.NLOCAL, text = i.SDESCRIPT }));
    }

    private async Task PopulatePROVINCEDropdownAsync()
    {
        var items = await _PROVINCEService.GetAllAsync();
        ViewData["NPROVINCE"] = new SelectList(items, nameof(PROVINCEDto.NPROVINCE), "SDESCRIPT");
    }

}
