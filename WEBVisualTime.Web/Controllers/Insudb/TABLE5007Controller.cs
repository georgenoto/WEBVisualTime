using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5007Controller : Controller
{
    private readonly ITABLE5007Service _service;

    public TABLE5007Controller(ITABLE5007Service service
    )
    {
        _service = service;
    }

    // GET: TABLE5007
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE5007/Index.cshtml", result);
    }

    // GET: TABLE5007/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5007/Details.cshtml", result);
    }

    // GET: TABLE5007/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE5007/Create.cshtml", new CreateTABLE5007Dto());
    }

    // POST: TABLE5007/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE5007Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5007/Create.cshtml", createDto);
    }

    // GET: TABLE5007/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE5007Dto
        {
            SINDTYPTOT = result.SINDTYPTOT,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TABLE5007/Edit.cshtml", updateDto);
    }

    // POST: TABLE5007/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE5007Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SINDTYPTOT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5007/Edit.cshtml", updateDto);
    }

    // GET: TABLE5007/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5007/Delete.cshtml", result);
    }

    // POST: TABLE5007/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
