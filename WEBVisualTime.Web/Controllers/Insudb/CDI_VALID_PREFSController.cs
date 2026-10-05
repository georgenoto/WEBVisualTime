using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_VALID_PREFS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_VALID_PREFSController : Controller
{
    private readonly ICDI_VALID_PREFSService _service;

    public CDI_VALID_PREFSController(ICDI_VALID_PREFSService service
    )
    {
        _service = service;
    }

    // GET: CDI_VALID_PREFS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_VALID_PREFS/Index.cshtml", result);
    }

    // GET: CDI_VALID_PREFS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_VALID_PREFS/Details.cshtml", result);
    }

    // GET: CDI_VALID_PREFS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_VALID_PREFS/Create.cshtml", new CreateCDI_VALID_PREFSDto());
    }

    // POST: CDI_VALID_PREFS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_VALID_PREFSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_VALID_PREFS/Create.cshtml", createDto);
    }

    // GET: CDI_VALID_PREFS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_VALID_PREFSDto
        {
            VP_DOMAIN = result.VP_DOMAIN,
            VP_VALUE = result.VP_VALUE,
            VP_MEANING = result.VP_MEANING,
            VP_ABBREVIATION = result.VP_ABBREVIATION,
            NLS_LANG = result.NLS_LANG,
        };
        return View("~/Views/Insudb/CDI_VALID_PREFS/Edit.cshtml", updateDto);
    }

    // POST: CDI_VALID_PREFS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_VALID_PREFSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.VP_DOMAIN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_VALID_PREFS/Edit.cshtml", updateDto);
    }

    // GET: CDI_VALID_PREFS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_VALID_PREFS/Delete.cshtml", result);
    }

    // POST: CDI_VALID_PREFS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
