using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5708Controller : Controller
{
    private readonly ITABLE5708Service _service;

    public TABLE5708Controller(ITABLE5708Service service
    )
    {
        _service = service;
    }

    // GET: TABLE5708
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE5708/Index.cshtml", result);
    }

    // GET: TABLE5708/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5708/Details.cshtml", result);
    }

    // GET: TABLE5708/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE5708/Create.cshtml", new CreateTABLE5708Dto());
    }

    // POST: TABLE5708/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE5708Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5708/Create.cshtml", createDto);
    }

    // GET: TABLE5708/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE5708Dto
        {
            NTYPE_MOVE = result.NTYPE_MOVE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTYPE = result.NTYPE,
            SPB_BMG = result.SPB_BMG,
            NLOAD_TYPE = result.NLOAD_TYPE,
        };
        return View("~/Views/Insudb/TABLE5708/Edit.cshtml", updateDto);
    }

    // POST: TABLE5708/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE5708Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_MOVE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE5708/Edit.cshtml", updateDto);
    }

    // GET: TABLE5708/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE5708/Delete.cshtml", result);
    }

    // POST: TABLE5708/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
