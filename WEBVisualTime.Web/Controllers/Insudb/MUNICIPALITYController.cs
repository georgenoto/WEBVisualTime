using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MUNICIPALITY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MUNICIPALITYController : Controller
{
    private readonly IMUNICIPALITYService _service;
    private readonly ITAB_LOCATService _TAB_LOCATService;

    public MUNICIPALITYController(IMUNICIPALITYService service
        , ITAB_LOCATService TAB_LOCATService
    )
    {
        _service = service;
        _TAB_LOCATService = TAB_LOCATService;
    }

    // GET: MUNICIPALITY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MUNICIPALITY/Index.cshtml");

    // GET: MUNICIPALITY/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MUNICIPALITY/Details.cshtml", result);
    }

    // GET: MUNICIPALITY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/MUNICIPALITY/Create.cshtml", new CreateMUNICIPALITYDto());
    }

    // POST: MUNICIPALITY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMUNICIPALITYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/MUNICIPALITY/Create.cshtml", createDto);
    }

    // GET: MUNICIPALITY/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMUNICIPALITYDto
        {
            NMUNICIPALITY = result.NMUNICIPALITY,
            NLOCAL = result.NLOCAL,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/MUNICIPALITY/Edit.cshtml", updateDto);
    }

    // POST: MUNICIPALITY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMUNICIPALITYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMUNICIPALITY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/MUNICIPALITY/Edit.cshtml", updateDto);
    }

    // GET: MUNICIPALITY/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MUNICIPALITY/Delete.cshtml", result);
    }

    // POST: MUNICIPALITY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: MUNICIPALITY/GetByNLOCAL?NLOCAL=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNLOCAL(int NLOCAL)
    {
        var items = await _service.FindAsync(p => p.NLOCAL == NLOCAL);
        return Json(items.Select(i => new { value = i.NMUNICIPALITY, text = i.SDESCRIPT }));
    }

    private async Task PopulateTAB_LOCATDropdownAsync()
    {
        var items = await _TAB_LOCATService.GetAllAsync();
        ViewData["NLOCAL"] = new SelectList(items, nameof(TAB_LOCATDto.NLOCAL), "SDESCRIPT");
    }

}
