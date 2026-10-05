using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ATTCHAMENTFORMController : Controller
{
    private readonly IATTCHAMENTFORMService _service;

    public ATTCHAMENTFORMController(IATTCHAMENTFORMService service
    )
    {
        _service = service;
    }

    // GET: ATTCHAMENTFORM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ATTCHAMENTFORM/Index.cshtml", result);
    }

    // GET: ATTCHAMENTFORM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ATTCHAMENTFORM/Details.cshtml", result);
    }

    // GET: ATTCHAMENTFORM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ATTCHAMENTFORM/Create.cshtml", new CreateATTCHAMENTFORMDto());
    }

    // POST: ATTCHAMENTFORM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateATTCHAMENTFORMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ATTCHAMENTFORM/Create.cshtml", createDto);
    }

    // GET: ATTCHAMENTFORM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateATTCHAMENTFORMDto
        {
            NSEQUENCEATT = result.NSEQUENCEATT,
            SFORMID = result.SFORMID,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/ATTCHAMENTFORM/Edit.cshtml", updateDto);
    }

    // POST: ATTCHAMENTFORM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateATTCHAMENTFORMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSEQUENCEATT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ATTCHAMENTFORM/Edit.cshtml", updateDto);
    }

    // GET: ATTCHAMENTFORM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ATTCHAMENTFORM/Delete.cshtml", result);
    }

    // POST: ATTCHAMENTFORM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
