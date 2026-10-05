using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MATRIX_RH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_MATRIX_RHController : Controller
{
    private readonly ITAB_MATRIX_RHService _service;

    public TAB_MATRIX_RHController(ITAB_MATRIX_RHService service
    )
    {
        _service = service;
    }

    // GET: TAB_MATRIX_RH
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_MATRIX_RH/Index.cshtml", result);
    }

    // GET: TAB_MATRIX_RH/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MATRIX_RH/Details.cshtml", result);
    }

    // GET: TAB_MATRIX_RH/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_MATRIX_RH/Create.cshtml", new CreateTAB_MATRIX_RHDto());
    }

    // POST: TAB_MATRIX_RH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_MATRIX_RHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MATRIX_RH/Create.cshtml", createDto);
    }

    // GET: TAB_MATRIX_RH/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_MATRIX_RHDto
        {
            NTYPE_MOVE = result.NTYPE_MOVE,
            NORIGIN = result.NORIGIN,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            NTRANSAC = result.NTRANSAC,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/TAB_MATRIX_RH/Edit.cshtml", updateDto);
    }

    // POST: TAB_MATRIX_RH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_MATRIX_RHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_MOVE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_MATRIX_RH/Edit.cshtml", updateDto);
    }

    // GET: TAB_MATRIX_RH/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MATRIX_RH/Delete.cshtml", result);
    }

    // POST: TAB_MATRIX_RH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
