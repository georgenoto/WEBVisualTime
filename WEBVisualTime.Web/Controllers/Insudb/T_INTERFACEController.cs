using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_INTERFACE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_INTERFACEController : Controller
{
    private readonly IT_INTERFACEService _service;

    public T_INTERFACEController(IT_INTERFACEService service
    )
    {
        _service = service;
    }

    // GET: T_INTERFACE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_INTERFACE/Index.cshtml", result);
    }

    // GET: T_INTERFACE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_INTERFACE/Details.cshtml", result);
    }

    // GET: T_INTERFACE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/T_INTERFACE/Create.cshtml", new CreateT_INTERFACEDto());
    }

    // POST: T_INTERFACE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_INTERFACEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_INTERFACE/Create.cshtml", createDto);
    }

    // GET: T_INTERFACE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_INTERFACEDto
        {
            SKEY = result.SKEY,
            NROW = result.NROW,
            NCOLUMN = result.NCOLUMN,
            SVALUE = result.SVALUE,
            STABLE = result.STABLE,
            SPROCESS = result.SPROCESS,
            NFIELD = result.NFIELD,
            SVALUE_HOMO = result.SVALUE_HOMO,
            SFIELDDESC = result.SFIELDDESC,
            NDATATYPE = result.NDATATYPE,
        };
        return View("~/Views/Insudb/T_INTERFACE/Edit.cshtml", updateDto);
    }

    // POST: T_INTERFACE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_INTERFACEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_INTERFACE/Edit.cshtml", updateDto);
    }

    // GET: T_INTERFACE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_INTERFACE/Delete.cshtml", result);
    }

    // POST: T_INTERFACE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
