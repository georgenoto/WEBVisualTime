using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.H_ASSIGNMENT_PART;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class H_ASSIGNMENT_PARTController : Controller
{
    private readonly IH_ASSIGNMENT_PARTService _service;

    public H_ASSIGNMENT_PARTController(IH_ASSIGNMENT_PARTService service
    )
    {
        _service = service;
    }

    // GET: H_ASSIGNMENT_PART
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Index.cshtml", result);
    }

    // GET: H_ASSIGNMENT_PART/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Details.cshtml", result);
    }

    // GET: H_ASSIGNMENT_PART/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Create.cshtml", new CreateH_ASSIGNMENT_PARTDto());
    }

    // POST: H_ASSIGNMENT_PART/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateH_ASSIGNMENT_PARTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Create.cshtml", createDto);
    }

    // GET: H_ASSIGNMENT_PART/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateH_ASSIGNMENT_PARTDto
        {
            NID_NUMREG = result.NID_NUMREG,
            NINSUR_AREA = result.NINSUR_AREA,
            NINTERTYP = result.NINTERTYP,
            NTYPE_ASSIGN = result.NTYPE_ASSIGN,
            DATE_ASSIG_INI = result.DATE_ASSIG_INI,
            DATE_ASSIG_END = result.DATE_ASSIG_END,
            NINTERMED = result.NINTERMED,
            NTEMPASSI = result.NTEMPASSI,
            STEMPASSI = result.STEMPASSI,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Edit.cshtml", updateDto);
    }

    // POST: H_ASSIGNMENT_PART/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateH_ASSIGNMENT_PARTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_NUMREG, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Edit.cshtml", updateDto);
    }

    // GET: H_ASSIGNMENT_PART/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/H_ASSIGNMENT_PART/Delete.cshtml", result);
    }

    // POST: H_ASSIGNMENT_PART/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
