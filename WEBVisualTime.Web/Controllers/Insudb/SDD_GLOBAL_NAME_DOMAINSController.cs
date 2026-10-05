using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_GLOBAL_NAME_DOMAINSController : Controller
{
    private readonly ISDD_GLOBAL_NAME_DOMAINSService _service;

    public SDD_GLOBAL_NAME_DOMAINSController(ISDD_GLOBAL_NAME_DOMAINSService service
    )
    {
        _service = service;
    }

    // GET: SDD_GLOBAL_NAME_DOMAINS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Index.cshtml", result);
    }

    // GET: SDD_GLOBAL_NAME_DOMAINS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Details.cshtml", result);
    }

    // GET: SDD_GLOBAL_NAME_DOMAINS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Create.cshtml", new CreateSDD_GLOBAL_NAME_DOMAINSDto());
    }

    // POST: SDD_GLOBAL_NAME_DOMAINS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSDD_GLOBAL_NAME_DOMAINSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Create.cshtml", createDto);
    }

    // GET: SDD_GLOBAL_NAME_DOMAINS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSDD_GLOBAL_NAME_DOMAINSDto
        {
            IRID = result.IRID,
            IVID = result.IVID,
            NAME = result.NAME,
            SYSTEM_FLAG = result.SYSTEM_FLAG,
            NUMBER_OF_TIMES_MODIFIED = result.NUMBER_OF_TIMES_MODIFIED,
            DATE_CREATED = result.DATE_CREATED,
            CREATED_BY = result.CREATED_BY,
            DATE_CHANGED = result.DATE_CHANGED,
            CHANGED_BY = result.CHANGED_BY,
        };
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Edit.cshtml", updateDto);
    }

    // POST: SDD_GLOBAL_NAME_DOMAINS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSDD_GLOBAL_NAME_DOMAINSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.IRID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Edit.cshtml", updateDto);
    }

    // GET: SDD_GLOBAL_NAME_DOMAINS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_GLOBAL_NAME_DOMAINS/Delete.cshtml", result);
    }

    // POST: SDD_GLOBAL_NAME_DOMAINS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
