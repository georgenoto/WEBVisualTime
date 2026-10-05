using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AUXILIAR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_AUXILIARController : Controller
{
    private readonly ITAB_AUXILIARService _service;

    public TAB_AUXILIARController(ITAB_AUXILIARService service
    )
    {
        _service = service;
    }

    // GET: TAB_AUXILIAR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_AUXILIAR/Index.cshtml", result);
    }

    // GET: TAB_AUXILIAR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AUXILIAR/Details.cshtml", result);
    }

    // GET: TAB_AUXILIAR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_AUXILIAR/Create.cshtml", new CreateTAB_AUXILIARDto());
    }

    // POST: TAB_AUXILIAR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_AUXILIARDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_AUXILIAR/Create.cshtml", createDto);
    }

    // GET: TAB_AUXILIAR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_AUXILIARDto
        {
            CARACTER = result.CARACTER,
            NUMERO = result.NUMERO,
            FECHA = result.FECHA,
        };
        return View("~/Views/Insudb/TAB_AUXILIAR/Edit.cshtml", updateDto);
    }

    // POST: TAB_AUXILIAR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_AUXILIARDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.CARACTER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_AUXILIAR/Edit.cshtml", updateDto);
    }

    // GET: TAB_AUXILIAR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AUXILIAR/Delete.cshtml", result);
    }

    // POST: TAB_AUXILIAR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
