using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_PARAM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INTERM_PARAMController : Controller
{
    private readonly IINTERM_PARAMService _service;

    public INTERM_PARAMController(IINTERM_PARAMService service
    )
    {
        _service = service;
    }

    // GET: INTERM_PARAM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/INTERM_PARAM/Index.cshtml", result);
    }

    // GET: INTERM_PARAM/Details/{id}
    public async Task<IActionResult> Details(decimal id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERM_PARAM/Details.cshtml", result);
    }

    // GET: INTERM_PARAM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/INTERM_PARAM/Create.cshtml", new CreateINTERM_PARAMDto());
    }

    // POST: INTERM_PARAM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINTERM_PARAMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/INTERM_PARAM/Create.cshtml", createDto);
    }

    // GET: INTERM_PARAM/Edit/{id}
    public async Task<IActionResult> Edit(decimal id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINTERM_PARAMDto
        {
            NINSU_ASSIST = result.NINSU_ASSIST,
            NSOAP_AGENT = result.NSOAP_AGENT,
            NSOAP_SUPERVIS = result.NSOAP_SUPERVIS,
            NBONUS_CURR = result.NBONUS_CURR,
            NMAX_BONUS = result.NMAX_BONUS,
            NMAX_ACCOMP = result.NMAX_ACCOMP,
            NMINAMOUNT = result.NMINAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NDAY_DISCLOAN = result.NDAY_DISCLOAN,
        };
        return View("~/Views/Insudb/INTERM_PARAM/Edit.cshtml", updateDto);
    }

    // POST: INTERM_PARAM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINTERM_PARAMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINSU_ASSIST, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/INTERM_PARAM/Edit.cshtml", updateDto);
    }

    // GET: INTERM_PARAM/Delete/{id}
    public async Task<IActionResult> Delete(decimal id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERM_PARAM/Delete.cshtml", result);
    }

    // POST: INTERM_PARAM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(decimal id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
