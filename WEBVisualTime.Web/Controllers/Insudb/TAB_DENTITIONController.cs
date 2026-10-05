using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DENTITION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_DENTITIONController : Controller
{
    private readonly ITAB_DENTITIONService _service;

    public TAB_DENTITIONController(ITAB_DENTITIONService service
    )
    {
        _service = service;
    }

    // GET: TAB_DENTITION
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_DENTITION/Index.cshtml", result);
    }

    // GET: TAB_DENTITION/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_DENTITION/Details.cshtml", result);
    }

    // GET: TAB_DENTITION/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_DENTITION/Create.cshtml", new CreateTAB_DENTITIONDto());
    }

    // POST: TAB_DENTITION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_DENTITIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_DENTITION/Create.cshtml", createDto);
    }

    // GET: TAB_DENTITION/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_DENTITIONDto
        {
            NIDDENTITION = result.NIDDENTITION,
            SADA = result.SADA,
            SFDI = result.SFDI,
            NTHETH = result.NTHETH,
            NQUADRANT = result.NQUADRANT,
            NARCADE = result.NARCADE,
            STOOTHNAM = result.STOOTHNAM,
            SPALATINE = result.SPALATINE,
            SLINGUAL = result.SLINGUAL,
            SVESTIBULAR = result.SVESTIBULAR,
            SMESIAL = result.SMESIAL,
            SDISTAL = result.SDISTAL,
            SINCISAL = result.SINCISAL,
            SOCLUSAL = result.SOCLUSAL,
            SLABIAL = result.SLABIAL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TAB_DENTITION/Edit.cshtml", updateDto);
    }

    // POST: TAB_DENTITION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_DENTITIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDDENTITION, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_DENTITION/Edit.cshtml", updateDto);
    }

    // GET: TAB_DENTITION/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_DENTITION/Delete.cshtml", result);
    }

    // POST: TAB_DENTITION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
