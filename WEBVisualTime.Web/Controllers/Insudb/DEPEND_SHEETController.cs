using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DEPEND_SHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DEPEND_SHEETController : Controller
{
    private readonly IDEPEND_SHEETService _service;

    public DEPEND_SHEETController(IDEPEND_SHEETService service
    )
    {
        _service = service;
    }

    // GET: DEPEND_SHEET
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DEPEND_SHEET/Index.cshtml");

    // GET: DEPEND_SHEET/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DEPEND_SHEET/Details.cshtml", result);
    }

    // GET: DEPEND_SHEET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/DEPEND_SHEET/Create.cshtml", new CreateDEPEND_SHEETDto());
    }

    // POST: DEPEND_SHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDEPEND_SHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DEPEND_SHEET/Create.cshtml", createDto);
    }

    // GET: DEPEND_SHEET/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDEPEND_SHEETDto
        {
            NSHEET_FATHER = result.NSHEET_FATHER,
            NSHEET_CHILD = result.NSHEET_CHILD,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/DEPEND_SHEET/Edit.cshtml", updateDto);
    }

    // POST: DEPEND_SHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDEPEND_SHEETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSHEET_FATHER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DEPEND_SHEET/Edit.cshtml", updateDto);
    }

    // GET: DEPEND_SHEET/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DEPEND_SHEET/Delete.cshtml", result);
    }

    // POST: DEPEND_SHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
