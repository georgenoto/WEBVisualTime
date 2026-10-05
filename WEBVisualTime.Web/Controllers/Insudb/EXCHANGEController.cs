using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.EXCHANGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class EXCHANGEController : Controller
{
    private readonly IEXCHANGEService _service;

    public EXCHANGEController(IEXCHANGEService service
    )
    {
        _service = service;
    }

    // GET: EXCHANGE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/EXCHANGE/Index.cshtml", result);
    }

    // GET: EXCHANGE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EXCHANGE/Details.cshtml", result);
    }

    // GET: EXCHANGE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/EXCHANGE/Create.cshtml", new CreateEXCHANGEDto());
    }

    // POST: EXCHANGE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateEXCHANGEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/EXCHANGE/Create.cshtml", createDto);
    }

    // GET: EXCHANGE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateEXCHANGEDto
        {
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NEXCHANGE = result.NEXCHANGE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/EXCHANGE/Edit.cshtml", updateDto);
    }

    // POST: EXCHANGE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateEXCHANGEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCURRENCY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/EXCHANGE/Edit.cshtml", updateDto);
    }

    // GET: EXCHANGE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EXCHANGE/Delete.cshtml", result);
    }

    // POST: EXCHANGE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
