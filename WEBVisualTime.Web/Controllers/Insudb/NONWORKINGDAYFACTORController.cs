using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NONWORKINGDAYFACTOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NONWORKINGDAYFACTORController : Controller
{
    private readonly INONWORKINGDAYFACTORService _service;
    private readonly IAPPUSERService _APPUSERService;

    public NONWORKINGDAYFACTORController(INONWORKINGDAYFACTORService service
        , IAPPUSERService APPUSERService
    )
    {
        _service = service;
        _APPUSERService = APPUSERService;
    }

    // GET: NONWORKINGDAYFACTOR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Index.cshtml", result);
    }

    // GET: NONWORKINGDAYFACTOR/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Details.cshtml", result);
    }

    // GET: NONWORKINGDAYFACTOR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateAPPUSERDropdownAsync();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Create.cshtml", new CreateNONWORKINGDAYFACTORDto());
    }

    // POST: NONWORKINGDAYFACTOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNONWORKINGDAYFACTORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateAPPUSERDropdownAsync();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Create.cshtml", createDto);
    }

    // GET: NONWORKINGDAYFACTOR/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNONWORKINGDAYFACTORDto
        {
            NIDFACTOR = result.NIDFACTOR,
            NIDUSER = result.NIDUSER,
            NFACTOR = result.NFACTOR,
            DCREATIONDATE = result.DCREATIONDATE,
        };
        await PopulateAPPUSERDropdownAsync();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Edit.cshtml", updateDto);
    }

    // POST: NONWORKINGDAYFACTOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNONWORKINGDAYFACTORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDFACTOR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateAPPUSERDropdownAsync();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Edit.cshtml", updateDto);
    }

    // GET: NONWORKINGDAYFACTOR/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NONWORKINGDAYFACTOR/Delete.cshtml", result);
    }

    // POST: NONWORKINGDAYFACTOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateAPPUSERDropdownAsync()
    {
        var items = await _APPUSERService.GetAllAsync();
        ViewData["NIDUSER"] = new SelectList(items, nameof(APPUSERDto.NIDUSER), "SUSERNAME");
    }

}
