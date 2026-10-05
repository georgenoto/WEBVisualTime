using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFITS_CATEGORY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BENEFITS_CATEGORYController : Controller
{
    private readonly IBENEFITS_CATEGORYService _service;

    public BENEFITS_CATEGORYController(IBENEFITS_CATEGORYService service
    )
    {
        _service = service;
    }

    // GET: BENEFITS_CATEGORY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Index.cshtml", result);
    }

    // GET: BENEFITS_CATEGORY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Details.cshtml", result);
    }

    // GET: BENEFITS_CATEGORY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Create.cshtml", new CreateBENEFITS_CATEGORYDto());
    }

    // POST: BENEFITS_CATEGORY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBENEFITS_CATEGORYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Create.cshtml", createDto);
    }

    // GET: BENEFITS_CATEGORY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBENEFITS_CATEGORYDto
        {
            NBENEFCATEG = result.NBENEFCATEG,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            STABLEASOC = result.STABLEASOC,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Edit.cshtml", updateDto);
    }

    // POST: BENEFITS_CATEGORY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBENEFITS_CATEGORYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBENEFCATEG, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Edit.cshtml", updateDto);
    }

    // GET: BENEFITS_CATEGORY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFITS_CATEGORY/Delete.cshtml", result);
    }

    // POST: BENEFITS_CATEGORY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
