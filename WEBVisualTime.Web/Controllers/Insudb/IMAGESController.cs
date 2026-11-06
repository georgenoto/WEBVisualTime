using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.IMAGES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class IMAGESController : Controller
{
    private readonly IIMAGESService _service;

    public IMAGESController(IIMAGESService service
    )
    {
        _service = service;
    }

    // GET: IMAGES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/IMAGES/Index.cshtml");

    // GET: IMAGES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/IMAGES/Details.cshtml", result);
    }

    // GET: IMAGES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/IMAGES/Create.cshtml", new CreateIMAGESDto());
    }

    // POST: IMAGES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateIMAGESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/IMAGES/Create.cshtml", createDto);
    }

    // GET: IMAGES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateIMAGESDto
        {
            NIMAGENUM = result.NIMAGENUM,
            DCOMPDATE = result.DCOMPDATE,
            NCONSEC = result.NCONSEC,
            SDESCRIPT = result.SDESCRIPT,
            IIMAGE = result.IIMAGE,
            DNULLDATE = result.DNULLDATE,
            NRECTYPE = result.NRECTYPE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/IMAGES/Edit.cshtml", updateDto);
    }

    // POST: IMAGES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateIMAGESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIMAGENUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/IMAGES/Edit.cshtml", updateDto);
    }

    // GET: IMAGES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/IMAGES/Delete.cshtml", result);
    }

    // POST: IMAGES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
