using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WORKSHEETController : Controller
{
    private readonly IWORKSHEETService _service;

    public WORKSHEETController(IWORKSHEETService service
    )
    {
        _service = service;
    }

    // GET: WORKSHEET
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/WORKSHEET/Index.cshtml", result);
    }

    // GET: WORKSHEET/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WORKSHEET/Details.cshtml", result);
    }

    // GET: WORKSHEET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/WORKSHEET/Create.cshtml", new CreateWORKSHEETDto());
    }

    // POST: WORKSHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWORKSHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/WORKSHEET/Create.cshtml", createDto);
    }

    // GET: WORKSHEET/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWORKSHEETDto
        {
            NBRANCH = result.NBRANCH,
            NID = result.NID,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            SVALUESLIST = result.SVALUESLIST,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDESCRIPT = result.SDESCRIPT,
        };
        return View("~/Views/Insudb/WORKSHEET/Edit.cshtml", updateDto);
    }

    // POST: WORKSHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWORKSHEETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/WORKSHEET/Edit.cshtml", updateDto);
    }

    // GET: WORKSHEET/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WORKSHEET/Delete.cshtml", result);
    }

    // POST: WORKSHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
