using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TRELDOC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TRELDOCController : Controller
{
    private readonly ITRELDOCService _service;

    public TRELDOCController(ITRELDOCService service
    )
    {
        _service = service;
    }

    // GET: TRELDOC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TRELDOC/Index.cshtml");

    // GET: TRELDOC/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRELDOC/Details.cshtml", result);
    }

    // GET: TRELDOC/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TRELDOC/Create.cshtml", new CreateTRELDOCDto());
    }

    // POST: TRELDOC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTRELDOCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRELDOC/Create.cshtml", createDto);
    }

    // GET: TRELDOC/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTRELDOCDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NCOLLECDOCTYP = result.NCOLLECDOCTYP,
            NRECEIPT = result.NRECEIPT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            NBULLETINS = result.NBULLETINS,
            NPROPONUM = result.NPROPONUM,
            NIDMOV = result.NIDMOV,
            NAMOUNT = result.NAMOUNT,
            NINTERESTAMOUNT = result.NINTERESTAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            DCOMPDATE = result.DCOMPDATE,
            DPAYDATE = result.DPAYDATE,
            DVALUEDATE = result.DVALUEDATE,
            NCHANGESDAT = result.NCHANGESDAT,
            NORIGIN = result.NORIGIN,
            DDATE_ORIGIN = result.DDATE_ORIGIN,
            NINSTITUTION = result.NINSTITUTION,
            NCOLLECTOR = result.NCOLLECTOR,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NLOANS = result.NLOANS,
            NINDREV = result.NINDREV,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            NAMOUNT_LOC = result.NAMOUNT_LOC,
            NCOD_SAAPV = result.NCOD_SAAPV,
            SFOLIONUMBER = result.SFOLIONUMBER,
        };
        return View("~/Views/Insudb/TRELDOC/Edit.cshtml", updateDto);
    }

    // POST: TRELDOC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTRELDOCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRELDOC/Edit.cshtml", updateDto);
    }

    // GET: TRELDOC/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRELDOC/Delete.cshtml", result);
    }

    // POST: TRELDOC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
