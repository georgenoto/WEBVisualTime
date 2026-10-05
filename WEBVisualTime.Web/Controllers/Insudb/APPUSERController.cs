using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class APPUSERController : Controller
{
    private readonly IAPPUSERService _service;

    public APPUSERController(IAPPUSERService service
    )
    {
        _service = service;
    }

    // GET: APPUSER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/APPUSER/Index.cshtml", result);
    }

    // GET: APPUSER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/APPUSER/Details.cshtml", result);
    }

    // GET: APPUSER/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/APPUSER/Create.cshtml", new CreateAPPUSERDto());
    }

    // POST: APPUSER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAPPUSERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/APPUSER/Create.cshtml", createDto);
    }

    // GET: APPUSER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateAPPUSERDto
        {
            NIDUSER = result.NIDUSER,
            SUSERNAME = result.SUSERNAME,
            SNAME = result.SNAME,
        };
        return View("~/Views/Insudb/APPUSER/Edit.cshtml", updateDto);
    }

    // POST: APPUSER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateAPPUSERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDUSER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/APPUSER/Edit.cshtml", updateDto);
    }

    // GET: APPUSER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/APPUSER/Delete.cshtml", result);
    }

    // POST: APPUSER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
