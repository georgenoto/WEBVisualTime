using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_FORMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_FORMSController : Controller
{
    private readonly ICDI_FORMSService _service;

    public CDI_FORMSController(ICDI_FORMSService service
    )
    {
        _service = service;
    }

    // GET: CDI_FORMS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_FORMS/Index.cshtml", result);
    }

    // GET: CDI_FORMS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_FORMS/Details.cshtml", result);
    }

    // GET: CDI_FORMS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_FORMS/Create.cshtml", new CreateCDI_FORMSDto());
    }

    // POST: CDI_FORMS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_FORMSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_FORMS/Create.cshtml", createDto);
    }

    // GET: CDI_FORMS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_FORMSDto
        {
            FRM_FNAME = result.FRM_FNAME,
            FRM_SEQ = result.FRM_SEQ,
            FRM_DISP_NAME = result.FRM_DISP_NAME,
            FRM_DESC = result.FRM_DESC,
        };
        return View("~/Views/Insudb/CDI_FORMS/Edit.cshtml", updateDto);
    }

    // POST: CDI_FORMS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_FORMSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.FRM_FNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_FORMS/Edit.cshtml", updateDto);
    }

    // GET: CDI_FORMS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_FORMS/Delete.cshtml", result);
    }

    // POST: CDI_FORMS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
