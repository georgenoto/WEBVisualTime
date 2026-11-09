using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DETAIL_PRE_INI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DETAIL_PRE_INIController : Controller
{
    private readonly IDETAIL_PRE_INIService _service;

    public DETAIL_PRE_INIController(IDETAIL_PRE_INIService service
    )
    {
        _service = service;
    }

    // GET: DETAIL_PRE_INI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DETAIL_PRE_INI/Index.cshtml");

    // GET: DETAIL_PRE_INI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DETAIL_PRE_INI/Details.cshtml", result);
    }

    // GET: DETAIL_PRE_INI/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/DETAIL_PRE_INI/Create.cshtml", new CreateDETAIL_PRE_INIDto());
    }

    // POST: DETAIL_PRE_INI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDETAIL_PRE_INIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DETAIL_PRE_INI/Create.cshtml", createDto);
    }

    // GET: DETAIL_PRE_INI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDETAIL_PRE_INIDto
        {
            NPRODUCT = result.NPRODUCT,
            NRECEIPT = result.NRECEIPT,
            NBRANCH = result.NBRANCH,
            SCERTYPE = result.SCERTYPE,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NID_BILL = result.NID_BILL,
            SADDSUINI = result.SADDSUINI,
            STYPE_DETAI = result.STYPE_DETAI,
            NDET_CODE = result.NDET_CODE,
            DCOMPDATE = result.DCOMPDATE,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            NPREMIUM = result.NPREMIUM,
            NTAX = result.NTAX,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            NUSERCODE = result.NUSERCODE,
            NPREMANUAL = result.NPREMANUAL,
            SADDTAX = result.SADDTAX,
            NCOMANUAL = result.NCOMANUAL,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NREL_IDCODE = result.NREL_IDCODE,
            NSTIPEND_AMOUNT = result.NSTIPEND_AMOUNT,
            NSTIPEND_ANNUAL = result.NSTIPEND_ANNUAL,
            NTAXRATE = result.NTAXRATE,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
            NCOM_SUPER = result.NCOM_SUPER,
            NCOMANUAL_SUPER = result.NCOMANUAL_SUPER,
        };
        return View("~/Views/Insudb/DETAIL_PRE_INI/Edit.cshtml", updateDto);
    }

    // POST: DETAIL_PRE_INI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateDETAIL_PRE_INIDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DETAIL_PRE_INI/Edit.cshtml", updateDto);
    }

    // GET: DETAIL_PRE_INI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DETAIL_PRE_INI/Delete.cshtml", result);
    }

    // POST: DETAIL_PRE_INI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
