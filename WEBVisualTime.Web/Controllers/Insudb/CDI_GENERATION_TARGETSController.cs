using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_GENERATION_TARGETS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_GENERATION_TARGETSController : Controller
{
    private readonly ICDI_GENERATION_TARGETSService _service;

    public CDI_GENERATION_TARGETSController(ICDI_GENERATION_TARGETSService service
    )
    {
        _service = service;
    }

    // GET: CDI_GENERATION_TARGETS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Index.cshtml", result);
    }

    // GET: CDI_GENERATION_TARGETS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Details.cshtml", result);
    }

    // GET: CDI_GENERATION_TARGETS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Create.cshtml", new CreateCDI_GENERATION_TARGETSDto());
    }

    // POST: CDI_GENERATION_TARGETS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_GENERATION_TARGETSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Create.cshtml", createDto);
    }

    // GET: CDI_GENERATION_TARGETS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_GENERATION_TARGETSDto
        {
            NAME = result.NAME,
            SEQ = result.SEQ,
            LANGUAGE = result.LANGUAGE,
            REGISTRY_NAME = result.REGISTRY_NAME,
            MEMBER_BEGIN_MARKER = result.MEMBER_BEGIN_MARKER,
            CLOSE_MEMBER_MARKER = result.CLOSE_MEMBER_MARKER,
            MEMBER_END_MARKER = result.MEMBER_END_MARKER,
            NLS_LANG = result.NLS_LANG,
        };
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Edit.cshtml", updateDto);
    }

    // POST: CDI_GENERATION_TARGETS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_GENERATION_TARGETSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Edit.cshtml", updateDto);
    }

    // GET: CDI_GENERATION_TARGETS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_GENERATION_TARGETS/Delete.cshtml", result);
    }

    // POST: CDI_GENERATION_TARGETS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
