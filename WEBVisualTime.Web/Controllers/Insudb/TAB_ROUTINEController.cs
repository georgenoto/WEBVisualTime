using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_ROUTINE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_ROUTINEController : Controller
{
    private readonly ITAB_ROUTINEService _service;
    private readonly ITABLE9105Service _TABLE9105Service;

    public TAB_ROUTINEController(ITAB_ROUTINEService service
        , ITABLE9105Service TABLE9105Service
    )
    {
        _service = service;
        _TABLE9105Service = TABLE9105Service;
    }

    // GET: TAB_ROUTINE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_ROUTINE/Index.cshtml", result);
    }

    // GET: TAB_ROUTINE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_ROUTINE/Details.cshtml", result);
    }

    // GET: TAB_ROUTINE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9105DropdownAsync();
        return View("~/Views/Insudb/TAB_ROUTINE/Create.cshtml", new CreateTAB_ROUTINEDto());
    }

    // POST: TAB_ROUTINE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_ROUTINEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9105DropdownAsync();
        return View("~/Views/Insudb/TAB_ROUTINE/Create.cshtml", createDto);
    }

    // GET: TAB_ROUTINE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_ROUTINEDto
        {
            SROUTINE = result.SROUTINE,
            NROUTINETYPE = result.NROUTINETYPE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE9105DropdownAsync();
        return View("~/Views/Insudb/TAB_ROUTINE/Edit.cshtml", updateDto);
    }

    // POST: TAB_ROUTINE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_ROUTINEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SROUTINE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9105DropdownAsync();
        return View("~/Views/Insudb/TAB_ROUTINE/Edit.cshtml", updateDto);
    }

    // GET: TAB_ROUTINE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_ROUTINE/Delete.cshtml", result);
    }

    // POST: TAB_ROUTINE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TAB_ROUTINE/GetByNROUTINETYPE?NROUTINETYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNROUTINETYPE(int NROUTINETYPE)
    {
        var items = await _service.FindAsync(p => p.NROUTINETYPE == NROUTINETYPE);
        return Json(items.Select(i => new { value = i.SROUTINE, text = i.SDESCRIPT }));
    }

    private async Task PopulateTABLE9105DropdownAsync()
    {
        var items = await _TABLE9105Service.GetAllAsync();
        ViewData["NROUTINETYPE"] = new SelectList(items, nameof(TABLE9105Dto.NROUTINETYPE), "SDESCRIPT");
    }

}
