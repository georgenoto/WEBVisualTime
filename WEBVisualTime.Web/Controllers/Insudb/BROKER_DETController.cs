using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BROKER_DET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BROKER_DETController : Controller
{
    private readonly IBROKER_DETService _service;

    public BROKER_DETController(IBROKER_DETService service
    )
    {
        _service = service;
    }

    // GET: BROKER_DET
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BROKER_DET/Index.cshtml");

    // GET: BROKER_DET/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BROKER_DET/Details.cshtml", result);
    }

    // GET: BROKER_DET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/BROKER_DET/Create.cshtml", new CreateBROKER_DETDto());
    }

    // POST: BROKER_DET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBROKER_DETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BROKER_DET/Create.cshtml", createDto);
    }

    // GET: BROKER_DET/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBROKER_DETDto
        {
            NCOMPANY_BR = result.NCOMPANY_BR,
            NCOMPANY = result.NCOMPANY,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NID = result.NID,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/BROKER_DET/Edit.cshtml", updateDto);
    }

    // POST: BROKER_DET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBROKER_DETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMPANY_BR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BROKER_DET/Edit.cshtml", updateDto);
    }

    // GET: BROKER_DET/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BROKER_DET/Delete.cshtml", result);
    }

    // POST: BROKER_DET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
