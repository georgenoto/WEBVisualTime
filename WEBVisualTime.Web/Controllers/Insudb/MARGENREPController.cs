using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MARGENREP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MARGENREPController : Controller
{
    private readonly IMARGENREPService _service;

    public MARGENREPController(IMARGENREPService service
    )
    {
        _service = service;
    }

    // GET: MARGENREP
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MARGENREP/Index.cshtml");

    // GET: MARGENREP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MARGENREP/Details.cshtml", result);
    }

    // GET: MARGENREP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MARGENREP/Create.cshtml", new CreateMARGENREPDto());
    }

    // POST: MARGENREP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMARGENREPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MARGENREP/Create.cshtml", createDto);
    }

    // GET: MARGENREP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMARGENREPDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NREPTYPE = result.NREPTYPE,
            SLOGO = result.SLOGO,
            SLOG = result.SLOG,
            X1 = result.X1,
            Y1 = result.Y1,
            NIMAGENX = result.NIMAGENX,
            NIMAGENY = result.NIMAGENY,
            NPOSIMGX = result.NPOSIMGX,
            NPOSIMGY = result.NPOSIMGY,
            NRADIOCURVA = result.NRADIOCURVA,
            NSPACE = result.NSPACE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/MARGENREP/Edit.cshtml", updateDto);
    }

    // POST: MARGENREP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateMARGENREPDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MARGENREP/Edit.cshtml", updateDto);
    }

    // GET: MARGENREP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MARGENREP/Delete.cshtml", result);
    }

    // POST: MARGENREP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
