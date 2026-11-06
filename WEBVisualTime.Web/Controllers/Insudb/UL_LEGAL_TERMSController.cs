using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.UL_LEGAL_TERMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class UL_LEGAL_TERMSController : Controller
{
    private readonly IUL_LEGAL_TERMSService _service;

    public UL_LEGAL_TERMSController(IUL_LEGAL_TERMSService service
    )
    {
        _service = service;
    }

    // GET: UL_LEGAL_TERMS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/UL_LEGAL_TERMS/Index.cshtml");

    // GET: UL_LEGAL_TERMS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Details.cshtml", result);
    }

    // GET: UL_LEGAL_TERMS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Create.cshtml", new CreateUL_LEGAL_TERMSDto());
    }

    // POST: UL_LEGAL_TERMS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateUL_LEGAL_TERMSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Create.cshtml", createDto);
    }

    // GET: UL_LEGAL_TERMS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateUL_LEGAL_TERMSDto
        {
            NTYPE_SAAPV = result.NTYPE_SAAPV,
            DEFFECDATE = result.DEFFECDATE,
            NVALUESTY = result.NVALUESTY,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NVALUESMO = result.NVALUESMO,
            NDAYADD = result.NDAYADD,
        };
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Edit.cshtml", updateDto);
    }

    // POST: UL_LEGAL_TERMS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateUL_LEGAL_TERMSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_SAAPV, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Edit.cshtml", updateDto);
    }

    // GET: UL_LEGAL_TERMS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/UL_LEGAL_TERMS/Delete.cshtml", result);
    }

    // POST: UL_LEGAL_TERMS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
