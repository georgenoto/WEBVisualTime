using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE78109Controller : Controller
{
    private readonly ITABLE78109Service _service;

    public TABLE78109Controller(ITABLE78109Service service
    )
    {
        _service = service;
    }

    // GET: TABLE78109
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE78109/Index.cshtml", result);
    }

    // GET: TABLE78109/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE78109/Details.cshtml", result);
    }

    // GET: TABLE78109/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE78109/Create.cshtml", new CreateTABLE78109Dto());
    }

    // POST: TABLE78109/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE78109Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE78109/Create.cshtml", createDto);
    }

    // GET: TABLE78109/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE78109Dto
        {
            NSOAP_VEHTYPE = result.NSOAP_VEHTYPE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SAACHCODE = result.SAACHCODE,
        };
        return View("~/Views/Insudb/TABLE78109/Edit.cshtml", updateDto);
    }

    // POST: TABLE78109/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE78109Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSOAP_VEHTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE78109/Edit.cshtml", updateDto);
    }

    // GET: TABLE78109/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE78109/Delete.cshtml", result);
    }

    // POST: TABLE78109/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
