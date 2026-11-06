using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SHORT_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_SHORT_GController : Controller
{
    private readonly ITAB_SHORT_GService _service;

    public TAB_SHORT_GController(ITAB_SHORT_GService service
    )
    {
        _service = service;
    }

    // GET: TAB_SHORT_G
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_SHORT_G/Index.cshtml");

    // GET: TAB_SHORT_G/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_SHORT_G/Details.cshtml", result);
    }

    // GET: TAB_SHORT_G/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_SHORT_G/Create.cshtml", new CreateTAB_SHORT_GDto());
    }

    // POST: TAB_SHORT_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_SHORT_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_SHORT_G/Create.cshtml", createDto);
    }

    // GET: TAB_SHORT_G/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_SHORT_GDto
        {
            NMONTHMAX = result.NMONTHMAX,
            NDAYSMAX = result.NDAYSMAX,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NRATEDEVO = result.NRATEDEVO,
            NRATEPREM = result.NRATEPREM,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TAB_SHORT_G/Edit.cshtml", updateDto);
    }

    // POST: TAB_SHORT_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_SHORT_GDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMONTHMAX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_SHORT_G/Edit.cshtml", updateDto);
    }

    // GET: TAB_SHORT_G/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_SHORT_G/Delete.cshtml", result);
    }

    // POST: TAB_SHORT_G/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
