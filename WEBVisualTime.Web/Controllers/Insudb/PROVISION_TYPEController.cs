using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROVISION_TYPEController : Controller
{
    private readonly IPROVISION_TYPEService _service;

    public PROVISION_TYPEController(IPROVISION_TYPEService service
    )
    {
        _service = service;
    }

    // GET: PROVISION_TYPE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PROVISION_TYPE/Index.cshtml", result);
    }

    // GET: PROVISION_TYPE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROVISION_TYPE/Details.cshtml", result);
    }

    // GET: PROVISION_TYPE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PROVISION_TYPE/Create.cshtml", new CreatePROVISION_TYPEDto());
    }

    // POST: PROVISION_TYPE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROVISION_TYPEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROVISION_TYPE/Create.cshtml", createDto);
    }

    // GET: PROVISION_TYPE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROVISION_TYPEDto
        {
            NIDPROVISIONTYPE = result.NIDPROVISIONTYPE,
            SNAME = result.SNAME,
            SENABLE = result.SENABLE,
            SMANEJAUF = result.SMANEJAUF,
        };
        return View("~/Views/Insudb/PROVISION_TYPE/Edit.cshtml", updateDto);
    }

    // POST: PROVISION_TYPE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROVISION_TYPEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPROVISIONTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROVISION_TYPE/Edit.cshtml", updateDto);
    }

    // GET: PROVISION_TYPE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROVISION_TYPE/Delete.cshtml", result);
    }

    // POST: PROVISION_TYPE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
