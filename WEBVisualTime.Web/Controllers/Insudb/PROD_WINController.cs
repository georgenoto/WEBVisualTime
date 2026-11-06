using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_WIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROD_WINController : Controller
{
    private readonly IPROD_WINService _service;

    public PROD_WINController(IPROD_WINService service
    )
    {
        _service = service;
    }

    // GET: PROD_WIN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PROD_WIN/Index.cshtml");

    // GET: PROD_WIN/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_WIN/Details.cshtml", result);
    }

    // GET: PROD_WIN/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PROD_WIN/Create.cshtml", new CreatePROD_WINDto());
    }

    // POST: PROD_WIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROD_WINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROD_WIN/Create.cshtml", createDto);
    }

    // GET: PROD_WIN/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROD_WINDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SV_CONPRODU = result.SV_CONPRODU,
            SV_WINPRODU = result.SV_WINPRODU,
            SV_WINPRODU1 = result.SV_WINPRODU1,
        };
        return View("~/Views/Insudb/PROD_WIN/Edit.cshtml", updateDto);
    }

    // POST: PROD_WIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROD_WINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROD_WIN/Edit.cshtml", updateDto);
    }

    // GET: PROD_WIN/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_WIN/Delete.cshtml", result);
    }

    // POST: PROD_WIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
