using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_SYS_EXE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_SYS_EXEController : Controller
{
    private readonly ITAB_SYS_EXEService _service;

    public TAB_SYS_EXEController(ITAB_SYS_EXEService service
    )
    {
        _service = service;
    }

    // GET: TAB_SYS_EXE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_SYS_EXE/Index.cshtml", result);
    }

    // GET: TAB_SYS_EXE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_SYS_EXE/Details.cshtml", result);
    }

    // GET: TAB_SYS_EXE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_SYS_EXE/Create.cshtml", new CreateTAB_SYS_EXEDto());
    }

    // POST: TAB_SYS_EXE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_SYS_EXEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_SYS_EXE/Create.cshtml", createDto);
    }

    // GET: TAB_SYS_EXE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_SYS_EXEDto
        {
            NEXE_CODE = result.NEXE_CODE,
            DCOMPDATE = result.DCOMPDATE,
            SEXE_NAME = result.SEXE_NAME,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            SFOLDERNAME = result.SFOLDERNAME,
        };
        return View("~/Views/Insudb/TAB_SYS_EXE/Edit.cshtml", updateDto);
    }

    // POST: TAB_SYS_EXE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_SYS_EXEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NEXE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_SYS_EXE/Edit.cshtml", updateDto);
    }

    // GET: TAB_SYS_EXE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_SYS_EXE/Delete.cshtml", result);
    }

    // POST: TAB_SYS_EXE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
