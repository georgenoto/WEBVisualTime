using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUP_COLUMNS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE697;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class GROUP_COLUMNSController : Controller
{
    private readonly IGROUP_COLUMNSService _service;
    private readonly ITABLE697Service _TABLE697Service;

    public GROUP_COLUMNSController(IGROUP_COLUMNSService service
        , ITABLE697Service TABLE697Service
    )
    {
        _service = service;
        _TABLE697Service = TABLE697Service;
    }

    // GET: GROUP_COLUMNS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/GROUP_COLUMNS/Index.cshtml", result);
    }

    // GET: GROUP_COLUMNS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUP_COLUMNS/Details.cshtml", result);
    }

    // GET: GROUP_COLUMNS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE697DropdownAsync();
        return View("~/Views/Insudb/GROUP_COLUMNS/Create.cshtml", new CreateGROUP_COLUMNSDto());
    }

    // POST: GROUP_COLUMNS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateGROUP_COLUMNSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE697DropdownAsync();
        return View("~/Views/Insudb/GROUP_COLUMNS/Create.cshtml", createDto);
    }

    // GET: GROUP_COLUMNS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateGROUP_COLUMNSDto
        {
            NSHEET = result.NSHEET,
            NIDREC = result.NIDREC,
            SFIELD = result.SFIELD,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCOLUMNNAME = result.SCOLUMNNAME,
            NORDER = result.NORDER,
            SVALUESLIST = result.SVALUESLIST,
            STABLE = result.STABLE,
            SREQUIRE = result.SREQUIRE,
            SCOMMENT = result.SCOMMENT,
            SUPDATEIND = result.SUPDATEIND,
        };
        await PopulateTABLE697DropdownAsync();
        return View("~/Views/Insudb/GROUP_COLUMNS/Edit.cshtml", updateDto);
    }

    // POST: GROUP_COLUMNS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateGROUP_COLUMNSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDREC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE697DropdownAsync();
        return View("~/Views/Insudb/GROUP_COLUMNS/Edit.cshtml", updateDto);
    }

    // GET: GROUP_COLUMNS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUP_COLUMNS/Delete.cshtml", result);
    }

    // POST: GROUP_COLUMNS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE697DropdownAsync()
    {
        var items = await _TABLE697Service.GetAllAsync();
        ViewData["NSHEET"] = new SelectList(items, nameof(TABLE697Dto.NSHEET), "SDESCRIPT");
    }

}
