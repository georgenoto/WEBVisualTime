using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PERSON_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PERSON_TYPEController : Controller
{
    private readonly IPERSON_TYPEService _service;

    public PERSON_TYPEController(IPERSON_TYPEService service
    )
    {
        _service = service;
    }

    // GET: PERSON_TYPE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PERSON_TYPE/Index.cshtml", result);
    }

    // GET: PERSON_TYPE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PERSON_TYPE/Details.cshtml", result);
    }

    // GET: PERSON_TYPE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PERSON_TYPE/Create.cshtml", new CreatePERSON_TYPEDto());
    }

    // POST: PERSON_TYPE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePERSON_TYPEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PERSON_TYPE/Create.cshtml", createDto);
    }

    // GET: PERSON_TYPE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePERSON_TYPEDto
        {
            NIDPERSONTYPE = result.NIDPERSONTYPE,
            SNAME = result.SNAME,
            SENABLE = result.SENABLE,
        };
        return View("~/Views/Insudb/PERSON_TYPE/Edit.cshtml", updateDto);
    }

    // POST: PERSON_TYPE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePERSON_TYPEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPERSONTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PERSON_TYPE/Edit.cshtml", updateDto);
    }

    // GET: PERSON_TYPE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PERSON_TYPE/Delete.cshtml", result);
    }

    // POST: PERSON_TYPE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
