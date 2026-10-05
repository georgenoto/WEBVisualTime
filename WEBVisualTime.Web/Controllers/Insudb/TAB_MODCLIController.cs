using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODCLI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_MODCLIController : Controller
{
    private readonly ITAB_MODCLIService _service;

    public TAB_MODCLIController(ITAB_MODCLIService service
    )
    {
        _service = service;
    }

    // GET: TAB_MODCLI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_MODCLI/Index.cshtml", result);
    }

    // GET: TAB_MODCLI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MODCLI/Details.cshtml", result);
    }

    // GET: TAB_MODCLI/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_MODCLI/Create.cshtml", new CreateTAB_MODCLIDto());
    }

    // POST: TAB_MODCLI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_MODCLIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MODCLI/Create.cshtml", createDto);
    }

    // GET: TAB_MODCLI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_MODCLIDto
        {
            SITEM = result.SITEM,
            STABNAME = result.STABNAME,
            SINDPK = result.SINDPK,
        };
        return View("~/Views/Insudb/TAB_MODCLI/Edit.cshtml", updateDto);
    }

    // POST: TAB_MODCLI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_MODCLIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SITEM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MODCLI/Edit.cshtml", updateDto);
    }

    // GET: TAB_MODCLI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MODCLI/Delete.cshtml", result);
    }

    // POST: TAB_MODCLI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
