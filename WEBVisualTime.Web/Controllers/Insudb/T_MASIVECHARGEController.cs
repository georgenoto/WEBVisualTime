using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MASIVECHARGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5571;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_MASIVECHARGEController : Controller
{
    private readonly IT_MASIVECHARGEService _service;
    private readonly ITABLE5571Service _TABLE5571Service;

    public T_MASIVECHARGEController(IT_MASIVECHARGEService service
        , ITABLE5571Service TABLE5571Service
    )
    {
        _service = service;
        _TABLE5571Service = TABLE5571Service;
    }

    // GET: T_MASIVECHARGE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_MASIVECHARGE/Index.cshtml", result);
    }

    // GET: T_MASIVECHARGE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_MASIVECHARGE/Details.cshtml", result);
    }

    // GET: T_MASIVECHARGE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5571DropdownAsync();
        return View("~/Views/Insudb/T_MASIVECHARGE/Create.cshtml", new CreateT_MASIVECHARGEDto());
    }

    // POST: T_MASIVECHARGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_MASIVECHARGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5571DropdownAsync();
        return View("~/Views/Insudb/T_MASIVECHARGE/Create.cshtml", createDto);
    }

    // GET: T_MASIVECHARGE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_MASIVECHARGEDto
        {
            SKEY = result.SKEY,
            NROWS = result.NROWS,
            NCOLUMNS = result.NCOLUMNS,
            SFIELD = result.SFIELD,
            SVALUE = result.SVALUE,
            NSEARCH = result.NSEARCH,
            STABLE = result.STABLE,
            SVALUESLIST = result.SVALUESLIST,
        };
        await PopulateTABLE5571DropdownAsync();
        return View("~/Views/Insudb/T_MASIVECHARGE/Edit.cshtml", updateDto);
    }

    // POST: T_MASIVECHARGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_MASIVECHARGEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5571DropdownAsync();
        return View("~/Views/Insudb/T_MASIVECHARGE/Edit.cshtml", updateDto);
    }

    // GET: T_MASIVECHARGE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_MASIVECHARGE/Delete.cshtml", result);
    }

    // POST: T_MASIVECHARGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5571DropdownAsync()
    {
        var items = await _TABLE5571Service.GetAllAsync();
        ViewData["NSEARCH"] = new SelectList(items, nameof(TABLE5571Dto.NSEARCH), "SDESCRIPT");
    }

}
