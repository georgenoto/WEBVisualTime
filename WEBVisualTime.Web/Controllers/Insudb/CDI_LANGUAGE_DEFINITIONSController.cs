using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_LANGUAGE_DEFINITIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_LANGUAGE_DEFINITIONSController : Controller
{
    private readonly ICDI_LANGUAGE_DEFINITIONSService _service;

    public CDI_LANGUAGE_DEFINITIONSController(ICDI_LANGUAGE_DEFINITIONSService service
    )
    {
        _service = service;
    }

    // GET: CDI_LANGUAGE_DEFINITIONS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Index.cshtml", result);
    }

    // GET: CDI_LANGUAGE_DEFINITIONS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Details.cshtml", result);
    }

    // GET: CDI_LANGUAGE_DEFINITIONS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Create.cshtml", new CreateCDI_LANGUAGE_DEFINITIONSDto());
    }

    // POST: CDI_LANGUAGE_DEFINITIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_LANGUAGE_DEFINITIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Create.cshtml", createDto);
    }

    // GET: CDI_LANGUAGE_DEFINITIONS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_LANGUAGE_DEFINITIONSDto
        {
            LAN_IRID = result.LAN_IRID,
            LAN_IVID = result.LAN_IVID,
            LAN_NAME = result.LAN_NAME,
            LAN_SOURCE_DIRECTORY = result.LAN_SOURCE_DIRECTORY,
            LAN_RUNTIME_DIRECTORY = result.LAN_RUNTIME_DIRECTORY,
            LAN_PROGRAMATICAL = result.LAN_PROGRAMATICAL,
            LAN_TYPE = result.LAN_TYPE,
            LAN_COMMAND_LINE = result.LAN_COMMAND_LINE,
            LAN_GENERATABLE_FLAG = result.LAN_GENERATABLE_FLAG,
            LAN_INTERNAL_NAME = result.LAN_INTERNAL_NAME,
            LAN_OBM_FLAG = result.LAN_OBM_FLAG,
        };
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Edit.cshtml", updateDto);
    }

    // POST: CDI_LANGUAGE_DEFINITIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_LANGUAGE_DEFINITIONSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.LAN_IRID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Edit.cshtml", updateDto);
    }

    // GET: CDI_LANGUAGE_DEFINITIONS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_LANGUAGE_DEFINITIONS/Delete.cshtml", result);
    }

    // POST: CDI_LANGUAGE_DEFINITIONS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
