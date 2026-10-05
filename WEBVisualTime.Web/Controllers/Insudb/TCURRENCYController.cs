using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCURRENCY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCURRENCYController : Controller
{
    private readonly ITCURRENCYService _service;

    public TCURRENCYController(ITCURRENCYService service
    )
    {
        _service = service;
    }

    // GET: TCURRENCY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TCURRENCY/Index.cshtml", result);
    }

    // GET: TCURRENCY/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCURRENCY/Details.cshtml", result);
    }

    // GET: TCURRENCY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCURRENCY/Create.cshtml", new CreateTCURRENCYDto());
    }

    // POST: TCURRENCY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCURRENCYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCURRENCY/Create.cshtml", createDto);
    }

    // GET: TCURRENCY/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCURRENCYDto
        {
            SKEY = result.SKEY,
            NCURRENCY = result.NCURRENCY,
            NRECEIPT = result.NRECEIPT,
            NSITUATION = result.NSITUATION,
            NEXCHANGE = result.NEXCHANGE,
            NPREMIUM = result.NPREMIUM,
            NPREMIUM_N = result.NPREMIUM_N,
            NCOMMISSION = result.NCOMMISSION,
            NTAX = result.NTAX,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM_A = result.NPREMIUM_A,
            NPREMIUM_E = result.NPREMIUM_E,
            NPREMIUMTEC = result.NPREMIUMTEC,
        };
        return View("~/Views/Insudb/TCURRENCY/Edit.cshtml", updateDto);
    }

    // POST: TCURRENCY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTCURRENCYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCURRENCY/Edit.cshtml", updateDto);
    }

    // GET: TCURRENCY/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCURRENCY/Delete.cshtml", result);
    }

    // POST: TCURRENCY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
