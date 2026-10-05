using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCOMMISS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCOMMISSController : Controller
{
    private readonly ITCOMMISSService _service;

    public TCOMMISSController(ITCOMMISSService service
    )
    {
        _service = service;
    }

    // GET: TCOMMISS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TCOMMISS/Index.cshtml", result);
    }

    // GET: TCOMMISS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCOMMISS/Details.cshtml", result);
    }

    // GET: TCOMMISS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCOMMISS/Create.cshtml", new CreateTCOMMISSDto());
    }

    // POST: TCOMMISS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCOMMISSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCOMMISS/Create.cshtml", createDto);
    }

    // GET: TCOMMISS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCOMMISSDto
        {
            SKEY = result.SKEY,
            NINTERMED = result.NINTERMED,
            NCOMMISSION = result.NCOMMISSION,
            NSHARE = result.NSHARE,
            NCURRENCY = result.NCURRENCY,
            NCOM_AFEC = result.NCOM_AFEC,
            NCOM_EXEN = result.NCOM_EXEN,
            NPERCENT = result.NPERCENT,
        };
        return View("~/Views/Insudb/TCOMMISS/Edit.cshtml", updateDto);
    }

    // POST: TCOMMISS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTCOMMISSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCOMMISS/Edit.cshtml", updateDto);
    }

    // GET: TCOMMISS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCOMMISS/Delete.cshtml", result);
    }

    // POST: TCOMMISS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
