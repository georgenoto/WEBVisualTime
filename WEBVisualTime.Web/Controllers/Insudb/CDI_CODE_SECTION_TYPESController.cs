using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_CODE_SECTION_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_CODE_SECTION_TYPESController : Controller
{
    private readonly ICDI_CODE_SECTION_TYPESService _service;

    public CDI_CODE_SECTION_TYPESController(ICDI_CODE_SECTION_TYPESService service
    )
    {
        _service = service;
    }

    // GET: CDI_CODE_SECTION_TYPES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Index.cshtml", result);
    }

    // GET: CDI_CODE_SECTION_TYPES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Details.cshtml", result);
    }

    // GET: CDI_CODE_SECTION_TYPES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Create.cshtml", new CreateCDI_CODE_SECTION_TYPESDto());
    }

    // POST: CDI_CODE_SECTION_TYPES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_CODE_SECTION_TYPESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Create.cshtml", createDto);
    }

    // GET: CDI_CODE_SECTION_TYPES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_CODE_SECTION_TYPESDto
        {
            LANGUAGE_NAME = result.LANGUAGE_NAME,
            TYPE_NAME = result.TYPE_NAME,
            GEN_TEMPLATE_FILE = result.GEN_TEMPLATE_FILE,
            REGEN_TEMPLATE_FILE = result.REGEN_TEMPLATE_FILE,
            OPEN_BEGIN_MARKER = result.OPEN_BEGIN_MARKER,
            CLOSE_BEGIN_MARKER = result.CLOSE_BEGIN_MARKER,
            END_MARKER = result.END_MARKER,
            FILE_FILTER = result.FILE_FILTER,
            SEQ = result.SEQ,
            REGISTRY_NAME = result.REGISTRY_NAME,
            DEFAULT_FILE_NAME = result.DEFAULT_FILE_NAME,
            CLOSE_END_MARKER = result.CLOSE_END_MARKER,
            SECTION_TYPE = result.SECTION_TYPE,
            FILE_TYPE = result.FILE_TYPE,
            NLS_LANG = result.NLS_LANG,
        };
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Edit.cshtml", updateDto);
    }

    // POST: CDI_CODE_SECTION_TYPES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_CODE_SECTION_TYPESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.LANGUAGE_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Edit.cshtml", updateDto);
    }

    // GET: CDI_CODE_SECTION_TYPES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_CODE_SECTION_TYPES/Delete.cshtml", result);
    }

    // POST: CDI_CODE_SECTION_TYPES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
