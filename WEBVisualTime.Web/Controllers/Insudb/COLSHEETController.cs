using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COLSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COLSHEETController : Controller
{
    private readonly ICOLSHEETService _service;

    public COLSHEETController(ICOLSHEETService service
    )
    {
        _service = service;
    }

    // GET: COLSHEET
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COLSHEET/Index.cshtml", result);
    }

    // GET: COLSHEET/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLSHEET/Details.cshtml", result);
    }

    // GET: COLSHEET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/COLSHEET/Create.cshtml", new CreateCOLSHEETDto());
    }

    // POST: COLSHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOLSHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COLSHEET/Create.cshtml", createDto);
    }

    // GET: COLSHEET/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOLSHEETDto
        {
            NID = result.NID,
            NIDREC = result.NIDREC,
            SCOLUMNNAME = result.SCOLUMNNAME,
            NORDER = result.NORDER,
            SSELECTED = result.SSELECTED,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SVALUE = result.SVALUE,
        };
        return View("~/Views/Insudb/COLSHEET/Edit.cshtml", updateDto);
    }

    // POST: COLSHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOLSHEETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COLSHEET/Edit.cshtml", updateDto);
    }

    // GET: COLSHEET/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLSHEET/Delete.cshtml", result);
    }

    // POST: COLSHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
