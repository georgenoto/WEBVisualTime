using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREFS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_DFLT_USER_PREFSController : Controller
{
    private readonly ICDI_DFLT_USER_PREFSService _service;

    public CDI_DFLT_USER_PREFSController(ICDI_DFLT_USER_PREFSService service
    )
    {
        _service = service;
    }

    // GET: CDI_DFLT_USER_PREFS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Index.cshtml", result);
    }

    // GET: CDI_DFLT_USER_PREFS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Details.cshtml", result);
    }

    // GET: CDI_DFLT_USER_PREFS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Create.cshtml", new CreateCDI_DFLT_USER_PREFSDto());
    }

    // POST: CDI_DFLT_USER_PREFS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_DFLT_USER_PREFSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Create.cshtml", createDto);
    }

    // GET: CDI_DFLT_USER_PREFS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_DFLT_USER_PREFSDto
        {
            P_SNAME = result.P_SNAME,
            P_CGVERSION = result.P_CGVERSION,
            SNAME = result.SNAME,
            NAME = result.NAME,
            VALUE = result.VALUE,
            INTERNAL = result.INTERNAL,
            TYPE = result.TYPE,
            DESCRIPTION = result.DESCRIPTION,
        };
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Edit.cshtml", updateDto);
    }

    // POST: CDI_DFLT_USER_PREFS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_DFLT_USER_PREFSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.P_SNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Edit.cshtml", updateDto);
    }

    // GET: CDI_DFLT_USER_PREFS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREFS/Delete.cshtml", result);
    }

    // POST: CDI_DFLT_USER_PREFS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
