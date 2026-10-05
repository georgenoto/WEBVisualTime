using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCT_FLAVOURS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_PRODUCT_FLAVOURSController : Controller
{
    private readonly ICDI_PRODUCT_FLAVOURSService _service;

    public CDI_PRODUCT_FLAVOURSController(ICDI_PRODUCT_FLAVOURSService service
    )
    {
        _service = service;
    }

    // GET: CDI_PRODUCT_FLAVOURS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Index.cshtml", result);
    }

    // GET: CDI_PRODUCT_FLAVOURS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Details.cshtml", result);
    }

    // GET: CDI_PRODUCT_FLAVOURS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Create.cshtml", new CreateCDI_PRODUCT_FLAVOURSDto());
    }

    // POST: CDI_PRODUCT_FLAVOURS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_PRODUCT_FLAVOURSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Create.cshtml", createDto);
    }

    // GET: CDI_PRODUCT_FLAVOURS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_PRODUCT_FLAVOURSDto
        {
            P_SNAME = result.P_SNAME,
            P_CGVERSION = result.P_CGVERSION,
            SEQ = result.SEQ,
            DESCRIPTION = result.DESCRIPTION,
        };
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Edit.cshtml", updateDto);
    }

    // POST: CDI_PRODUCT_FLAVOURS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_PRODUCT_FLAVOURSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.P_SNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Edit.cshtml", updateDto);
    }

    // GET: CDI_PRODUCT_FLAVOURS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PRODUCT_FLAVOURS/Delete.cshtml", result);
    }

    // POST: CDI_PRODUCT_FLAVOURS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
