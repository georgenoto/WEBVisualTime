using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_PRODUCTSController : Controller
{
    private readonly ICDI_PRODUCTSService _service;

    public CDI_PRODUCTSController(ICDI_PRODUCTSService service
    )
    {
        _service = service;
    }

    // GET: CDI_PRODUCTS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_PRODUCTS/Index.cshtml", result);
    }

    // GET: CDI_PRODUCTS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PRODUCTS/Details.cshtml", result);
    }

    // GET: CDI_PRODUCTS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_PRODUCTS/Create.cshtml", new CreateCDI_PRODUCTSDto());
    }

    // POST: CDI_PRODUCTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_PRODUCTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PRODUCTS/Create.cshtml", createDto);
    }

    // GET: CDI_PRODUCTS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_PRODUCTSDto
        {
            SNAME = result.SNAME,
            NAME = result.NAME,
            VERSION = result.VERSION,
        };
        return View("~/Views/Insudb/CDI_PRODUCTS/Edit.cshtml", updateDto);
    }

    // POST: CDI_PRODUCTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_PRODUCTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PRODUCTS/Edit.cshtml", updateDto);
    }

    // GET: CDI_PRODUCTS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PRODUCTS/Delete.cshtml", result);
    }

    // POST: CDI_PRODUCTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
