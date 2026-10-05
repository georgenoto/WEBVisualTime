using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9279Controller : Controller
{
    private readonly ITABLE9279Service _service;

    public TABLE9279Controller(ITABLE9279Service service
    )
    {
        _service = service;
    }

    // GET: TABLE9279
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TABLE9279/Index.cshtml", result);
    }

    // GET: TABLE9279/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9279/Details.cshtml", result);
    }

    // GET: TABLE9279/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TABLE9279/Create.cshtml", new CreateTABLE9279Dto());
    }

    // POST: TABLE9279/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTABLE9279Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE9279/Create.cshtml", createDto);
    }

    // GET: TABLE9279/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTABLE9279Dto
        {
            NSUBLIMIT_TYPE = result.NSUBLIMIT_TYPE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/TABLE9279/Edit.cshtml", updateDto);
    }

    // POST: TABLE9279/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTABLE9279Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSUBLIMIT_TYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TABLE9279/Edit.cshtml", updateDto);
    }

    // GET: TABLE9279/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TABLE9279/Delete.cshtml", result);
    }

    // POST: TABLE9279/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
