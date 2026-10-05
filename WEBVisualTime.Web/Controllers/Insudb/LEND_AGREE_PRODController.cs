using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LEND_AGREE_PRODController : Controller
{
    private readonly ILEND_AGREE_PRODService _service;

    public LEND_AGREE_PRODController(ILEND_AGREE_PRODService service
    )
    {
        _service = service;
    }

    // GET: LEND_AGREE_PROD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/LEND_AGREE_PROD/Index.cshtml", result);
    }

    // GET: LEND_AGREE_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEND_AGREE_PROD/Details.cshtml", result);
    }

    // GET: LEND_AGREE_PROD/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/LEND_AGREE_PROD/Create.cshtml", new CreateLEND_AGREE_PRODDto());
    }

    // POST: LEND_AGREE_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLEND_AGREE_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LEND_AGREE_PROD/Create.cshtml", createDto);
    }

    // GET: LEND_AGREE_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLEND_AGREE_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCOD_AGREE = result.NCOD_AGREE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/LEND_AGREE_PROD/Edit.cshtml", updateDto);
    }

    // POST: LEND_AGREE_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLEND_AGREE_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LEND_AGREE_PROD/Edit.cshtml", updateDto);
    }

    // GET: LEND_AGREE_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEND_AGREE_PROD/Delete.cshtml", result);
    }

    // POST: LEND_AGREE_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
