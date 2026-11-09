using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TLEDAUTREJECTM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TLEDAUTREJECTMController : Controller
{
    private readonly ITLEDAUTREJECTMService _service;

    public TLEDAUTREJECTMController(ITLEDAUTREJECTMService service
    )
    {
        _service = service;
    }

    // GET: TLEDAUTREJECTM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TLEDAUTREJECTM/Index.cshtml");

    // GET: TLEDAUTREJECTM/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TLEDAUTREJECTM/Details.cshtml", result);
    }

    // GET: TLEDAUTREJECTM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TLEDAUTREJECTM/Create.cshtml", new CreateTLEDAUTREJECTMDto());
    }

    // POST: TLEDAUTREJECTM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTLEDAUTREJECTMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TLEDAUTREJECTM/Create.cshtml", createDto);
    }

    // GET: TLEDAUTREJECTM/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTLEDAUTREJECTMDto
        {
            NAREA_LED = result.NAREA_LED,
            NID = result.NID,
            NGROUP = result.NGROUP,
            NFAILNUM = result.NFAILNUM,
            DLEDGERDAT = result.DLEDGERDAT,
            NAMOUNT = result.NAMOUNT,
            NCURRENCY = result.NCURRENCY,
            DPOSTED = result.DPOSTED,
            SERRDETAIL = result.SERRDETAIL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NRECEIPT = result.NRECEIPT,
            NACC_CASH = result.NACC_CASH,
            NOFFICE = result.NOFFICE,
            NTRANSAC = result.NTRANSAC,
            NCASHNUM = result.NCASHNUM,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NTYP_ACCO = result.NTYP_ACCO,
            STYPE_ACC = result.STYPE_ACC,
            SCLIENT = result.SCLIENT,
            NREQUEST_NU = result.NREQUEST_NU,
            SCHEQUE = result.SCHEQUE,
            SCOLUMN = result.SCOLUMN,
            NPARAMETER = result.NPARAMETER,
            NTRANSAC_TY = result.NTRANSAC_TY,
        };
        return View("~/Views/Insudb/TLEDAUTREJECTM/Edit.cshtml", updateDto);
    }

    // POST: TLEDAUTREJECTM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTLEDAUTREJECTMDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TLEDAUTREJECTM/Edit.cshtml", updateDto);
    }

    // GET: TLEDAUTREJECTM/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TLEDAUTREJECTM/Delete.cshtml", result);
    }

    // POST: TLEDAUTREJECTM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
