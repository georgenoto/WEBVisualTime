using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NUMERATOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NUMERATORController : Controller
{
    private readonly INUMERATORService _service;

    public NUMERATORController(INUMERATORService service
    )
    {
        _service = service;
    }

    // GET: NUMERATOR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NUMERATOR/Index.cshtml", result);
    }

    // GET: NUMERATOR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NUMERATOR/Details.cshtml", result);
    }

    // GET: NUMERATOR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/NUMERATOR/Create.cshtml", new CreateNUMERATORDto());
    }

    // POST: NUMERATOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNUMERATORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/NUMERATOR/Create.cshtml", createDto);
    }

    // GET: NUMERATOR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNUMERATORDto
        {
            NTYPENUM = result.NTYPENUM,
            NORD_NUM = result.NORD_NUM,
            DCOMPDATE = result.DCOMPDATE,
            NEND_NUM = result.NEND_NUM,
            NINITIAL = result.NINITIAL,
            NLASTNUMB = result.NLASTNUMB,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/NUMERATOR/Edit.cshtml", updateDto);
    }

    // POST: NUMERATOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNUMERATORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPENUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/NUMERATOR/Edit.cshtml", updateDto);
    }

    // GET: NUMERATOR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NUMERATOR/Delete.cshtml", result);
    }

    // POST: NUMERATOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
