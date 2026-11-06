using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFGROUP_DETAIL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BENEFGROUP_DETAILController : Controller
{
    private readonly IBENEFGROUP_DETAILService _service;

    public BENEFGROUP_DETAILController(IBENEFGROUP_DETAILService service
    )
    {
        _service = service;
    }

    // GET: BENEFGROUP_DETAIL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BENEFGROUP_DETAIL/Index.cshtml");

    // GET: BENEFGROUP_DETAIL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Details.cshtml", result);
    }

    // GET: BENEFGROUP_DETAIL/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Create.cshtml", new CreateBENEFGROUP_DETAILDto());
    }

    // POST: BENEFGROUP_DETAIL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBENEFGROUP_DETAILDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Create.cshtml", createDto);
    }

    // GET: BENEFGROUP_DETAIL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBENEFGROUP_DETAILDto
        {
            SBENEFITGROUP = result.SBENEFITGROUP,
            SIDDETAIL = result.SIDDETAIL,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Edit.cshtml", updateDto);
    }

    // POST: BENEFGROUP_DETAIL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBENEFGROUP_DETAILDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SBENEFITGROUP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Edit.cshtml", updateDto);
    }

    // GET: BENEFGROUP_DETAIL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFGROUP_DETAIL/Delete.cshtml", result);
    }

    // POST: BENEFGROUP_DETAIL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
