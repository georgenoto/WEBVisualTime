using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LOGBILLS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LOGBILLSController : Controller
{
    private readonly ILOGBILLSService _service;

    public LOGBILLSController(ILOGBILLSService service
    )
    {
        _service = service;
    }

    // GET: LOGBILLS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LOGBILLS/Index.cshtml");

    // GET: LOGBILLS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LOGBILLS/Details.cshtml", result);
    }

    // GET: LOGBILLS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/LOGBILLS/Create.cshtml", new CreateLOGBILLSDto());
    }

    // POST: LOGBILLS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLOGBILLSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LOGBILLS/Create.cshtml", createDto);
    }

    // GET: LOGBILLS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLOGBILLSDto
        {
            NINSUR_AREA = result.NINSUR_AREA,
            NOPERTYPE = result.NOPERTYPE,
            SCLIENT = result.SCLIENT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NBORDEREAUX = result.NBORDEREAUX,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
            DSTATDATE = result.DSTATDATE,
            NSTATUSCODE = result.NSTATUSCODE,
            SSTATUSDESC = result.SSTATUSDESC,
            SBILLNUMSFE = result.SBILLNUMSFE,
            NBILLNUM = result.NBILLNUM,
            SPROCESSED = result.SPROCESSED,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NRECEIPTCORP = result.NRECEIPTCORP,
        };
        return View("~/Views/Insudb/LOGBILLS/Edit.cshtml", updateDto);
    }

    // POST: LOGBILLS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateLOGBILLSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LOGBILLS/Edit.cshtml", updateDto);
    }

    // GET: LOGBILLS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LOGBILLS/Delete.cshtml", result);
    }

    // POST: LOGBILLS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
