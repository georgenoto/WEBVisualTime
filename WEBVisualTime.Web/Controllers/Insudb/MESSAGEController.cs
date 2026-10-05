using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MESSAGEController : Controller
{
    private readonly IMESSAGEService _service;

    public MESSAGEController(IMESSAGEService service
    )
    {
        _service = service;
    }

    // GET: MESSAGE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MESSAGE/Index.cshtml", result);
    }

    // GET: MESSAGE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MESSAGE/Details.cshtml", result);
    }

    // GET: MESSAGE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MESSAGE/Create.cshtml", new CreateMESSAGEDto());
    }

    // POST: MESSAGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMESSAGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MESSAGE/Create.cshtml", createDto);
    }

    // GET: MESSAGE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMESSAGEDto
        {
            NERRORNUM = result.NERRORNUM,
            DCOMPDATE = result.DCOMPDATE,
            SMESSAGED = result.SMESSAGED,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/MESSAGE/Edit.cshtml", updateDto);
    }

    // POST: MESSAGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMESSAGEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NERRORNUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MESSAGE/Edit.cshtml", updateDto);
    }

    // GET: MESSAGE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MESSAGE/Delete.cshtml", result);
    }

    // POST: MESSAGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
