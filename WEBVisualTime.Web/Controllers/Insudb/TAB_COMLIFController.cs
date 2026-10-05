using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMLIF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_COMLIFController : Controller
{
    private readonly ITAB_COMLIFService _service;
    private readonly IINTERM_TYPService _INTERM_TYPService;

    public TAB_COMLIFController(ITAB_COMLIFService service
        , IINTERM_TYPService INTERM_TYPService
    )
    {
        _service = service;
        _INTERM_TYPService = INTERM_TYPService;
    }

    // GET: TAB_COMLIF
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_COMLIF/Index.cshtml", result);
    }

    // GET: TAB_COMLIF/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COMLIF/Details.cshtml", result);
    }

    // GET: TAB_COMLIF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/TAB_COMLIF/Create.cshtml", new CreateTAB_COMLIFDto());
    }

    // POST: TAB_COMLIF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_COMLIFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/TAB_COMLIF/Create.cshtml", createDto);
    }

    // GET: TAB_COMLIF/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_COMLIFDto
        {
            NCOMTABLI = result.NCOMTABLI,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NINTERTYP = result.NINTERTYP,
        };
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/TAB_COMLIF/Edit.cshtml", updateDto);
    }

    // POST: TAB_COMLIF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_COMLIFDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMTABLI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERM_TYPDropdownAsync();
        return View("~/Views/Insudb/TAB_COMLIF/Edit.cshtml", updateDto);
    }

    // GET: TAB_COMLIF/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_COMLIF/Delete.cshtml", result);
    }

    // POST: TAB_COMLIF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TAB_COMLIF/GetByNINTERTYP?NINTERTYP=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNINTERTYP(int NINTERTYP)
    {
        var items = await _service.FindAsync(p => p.NINTERTYP == NINTERTYP);
        return Json(items.Select(i => new { value = i.NCOMTABLI, text = i.SDESCRIPT }));
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

}
