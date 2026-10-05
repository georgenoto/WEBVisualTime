using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TRACKINGController : Controller
{
    private readonly ITRACKINGService _service;

    public TRACKINGController(ITRACKINGService service
    )
    {
        _service = service;
    }

    // GET: TRACKING
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TRACKING/Index.cshtml", result);
    }

    // GET: TRACKING/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRACKING/Details.cshtml", result);
    }

    // GET: TRACKING/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TRACKING/Create.cshtml", new CreateTRACKINGDto());
    }

    // POST: TRACKING/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTRACKINGDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRACKING/Create.cshtml", createDto);
    }

    // GET: TRACKING/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTRACKINGDto
        {
            ID = result.ID,
            FACTTIME = result.FACTTIME,
            HOSTSOURCE = result.HOSTSOURCE,
            FORMPATH = result.FORMPATH,
            URLREFERRER = result.URLREFERRER,
            USERAGENT = result.USERAGENT,
            FORMID = result.FORMID,
            PURCHASEORDER = result.PURCHASEORDER,
            REMARK = result.REMARK,
            CALLEDFROMID = result.CALLEDFROMID,
        };
        return View("~/Views/Insudb/TRACKING/Edit.cshtml", updateDto);
    }

    // POST: TRACKING/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTRACKINGDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.ID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRACKING/Edit.cshtml", updateDto);
    }

    // GET: TRACKING/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRACKING/Delete.cshtml", result);
    }

    // POST: TRACKING/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
