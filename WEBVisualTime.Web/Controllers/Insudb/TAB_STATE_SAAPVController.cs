using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_STATE_SAAPV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_STATE_SAAPVController : Controller
{
    private readonly ITAB_STATE_SAAPVService _service;

    public TAB_STATE_SAAPVController(ITAB_STATE_SAAPVService service
    )
    {
        _service = service;
    }

    // GET: TAB_STATE_SAAPV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_STATE_SAAPV/Index.cshtml");

    // GET: TAB_STATE_SAAPV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Details.cshtml", result);
    }

    // GET: TAB_STATE_SAAPV/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Create.cshtml", new CreateTAB_STATE_SAAPVDto());
    }

    // POST: TAB_STATE_SAAPV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_STATE_SAAPVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Create.cshtml", createDto);
    }

    // GET: TAB_STATE_SAAPV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_STATE_SAAPVDto
        {
            NTYPE_SAAPV = result.NTYPE_SAAPV,
            NTYPE_STATE_ORIGI = result.NTYPE_STATE_ORIGI,
            NTYPE_STATE_END = result.NTYPE_STATE_END,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Edit.cshtml", updateDto);
    }

    // POST: TAB_STATE_SAAPV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_STATE_SAAPVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_SAAPV, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Edit.cshtml", updateDto);
    }

    // GET: TAB_STATE_SAAPV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_STATE_SAAPV/Delete.cshtml", result);
    }

    // POST: TAB_STATE_SAAPV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
