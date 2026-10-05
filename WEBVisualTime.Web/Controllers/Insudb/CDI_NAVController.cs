using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_NAV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_NAVController : Controller
{
    private readonly ICDI_NAVService _service;

    public CDI_NAVController(ICDI_NAVService service
    )
    {
        _service = service;
    }

    // GET: CDI_NAV
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_NAV/Index.cshtml", result);
    }

    // GET: CDI_NAV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_NAV/Details.cshtml", result);
    }

    // GET: CDI_NAV/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_NAV/Create.cshtml", new CreateCDI_NAVDto());
    }

    // POST: CDI_NAV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_NAVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_NAV/Create.cshtml", createDto);
    }

    // GET: CDI_NAV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_NAVDto
        {
            NAV_TYPE = result.NAV_TYPE,
            NAV_FNAME = result.NAV_FNAME,
            NAV_NAME = result.NAV_NAME,
            NAV_BTNAME = result.NAV_BTNAME,
            NAV_CNAME = result.NAV_CNAME,
            NAV_REF_BTNAME = result.NAV_REF_BTNAME,
            NAV_REF_CNAME = result.NAV_REF_CNAME,
            NAV_SEQ = result.NAV_SEQ,
            NAV_ASSOC_END = result.NAV_ASSOC_END,
            NAV_DESCRIPTION = result.NAV_DESCRIPTION,
        };
        return View("~/Views/Insudb/CDI_NAV/Edit.cshtml", updateDto);
    }

    // POST: CDI_NAV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_NAVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NAV_TYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_NAV/Edit.cshtml", updateDto);
    }

    // GET: CDI_NAV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_NAV/Delete.cshtml", result);
    }

    // POST: CDI_NAV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
