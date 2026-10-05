using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9219;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9219Controller : Controller
{
    private readonly ITABLE9219Service _service;
    private readonly IUSERSService _USERSService;

    public TABLE9219Controller(ITABLE9219Service service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _USERSService = USERSService;
    }

    // GET: TABLE9219
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE9219/Index.cshtml", result);
    }

    // GET: TABLE9219/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9219/Details.cshtml", result);
    }

    // GET: TABLE9219/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9219/Create.cshtml", new CreateTABLE9219Dto());
    }

    // POST: TABLE9219/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE9219Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9219/Create.cshtml", createDto);
    }

    // GET: TABLE9219/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE9219Dto
        {
            NCLASS_DOC = result.NCLASS_DOC,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9219/Edit.cshtml", updateDto);
    }

    // POST: TABLE9219/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE9219Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLASS_DOC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/TABLE9219/Edit.cshtml", updateDto);
    }

    // GET: TABLE9219/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9219/Delete.cshtml", result);
    }

    // POST: TABLE9219/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TABLE9219/GetByNUSERCODE?NUSERCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNUSERCODE(int NUSERCODE)
    {
        var items = await _service.FindAsync(p => p.NUSERCODE == NUSERCODE);
        return Json(items.Select(i => new { value = i.NCLASS_DOC, text = i.SDESCRIPT }));
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
