using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_RESERVED_NAMES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SDD_RESERVED_NAMESController : Controller
{
    private readonly ISDD_RESERVED_NAMESService _service;

    public SDD_RESERVED_NAMESController(ISDD_RESERVED_NAMESService service
    )
    {
        _service = service;
    }

    // GET: SDD_RESERVED_NAMES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Index.cshtml", result);
    }

    // GET: SDD_RESERVED_NAMES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Details.cshtml", result);
    }

    // GET: SDD_RESERVED_NAMES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Create.cshtml", new CreateSDD_RESERVED_NAMESDto());
    }

    // POST: SDD_RESERVED_NAMES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSDD_RESERVED_NAMESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Create.cshtml", createDto);
    }

    // GET: SDD_RESERVED_NAMES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSDD_RESERVED_NAMESDto
        {
            RN_RES_NAME = result.RN_RES_NAME,
            RN_TYPE = result.RN_TYPE,
            RN_COMMENT = result.RN_COMMENT,
            RN_GLOBAL = result.RN_GLOBAL,
            RN_TEMPORARY = result.RN_TEMPORARY,
            RN_ENABLED = result.RN_ENABLED,
            RN_USR_ACCESS = result.RN_USR_ACCESS,
            RN_CDAPI = result.RN_CDAPI,
            RN_OBJECT_IRID = result.RN_OBJECT_IRID,
            RN_OBJECT_IVID = result.RN_OBJECT_IVID,
        };
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Edit.cshtml", updateDto);
    }

    // POST: SDD_RESERVED_NAMES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSDD_RESERVED_NAMESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.RN_RES_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Edit.cshtml", updateDto);
    }

    // GET: SDD_RESERVED_NAMES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SDD_RESERVED_NAMES/Delete.cshtml", result);
    }

    // POST: SDD_RESERVED_NAMES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
