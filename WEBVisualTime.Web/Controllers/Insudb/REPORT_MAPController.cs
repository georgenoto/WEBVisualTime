using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_MAP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REPORT_MAPController : Controller
{
    private readonly IREPORT_MAPService _service;

    public REPORT_MAPController(IREPORT_MAPService service
    )
    {
        _service = service;
    }

    // GET: REPORT_MAP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REPORT_MAP/Index.cshtml", result);
    }

    // GET: REPORT_MAP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORT_MAP/Details.cshtml", result);
    }

    // GET: REPORT_MAP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REPORT_MAP/Create.cshtml", new CreateREPORT_MAPDto());
    }

    // POST: REPORT_MAP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREPORT_MAPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORT_MAP/Create.cshtml", createDto);
    }

    // GET: REPORT_MAP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREPORT_MAPDto
        {
            NORDER = result.NORDER,
            NCODIG = result.NCODIG,
            NORIGIN = result.NORIGIN,
            NTYPE = result.NTYPE,
        };
        return View("~/Views/Insudb/REPORT_MAP/Edit.cshtml", updateDto);
    }

    // POST: REPORT_MAP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREPORT_MAPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NORDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REPORT_MAP/Edit.cshtml", updateDto);
    }

    // GET: REPORT_MAP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORT_MAP/Delete.cshtml", result);
    }

    // POST: REPORT_MAP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
