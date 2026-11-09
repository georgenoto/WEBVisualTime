using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_PREMIU_INI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class OUT_PREMIU_INIController : Controller
{
    private readonly IOUT_PREMIU_INIService _service;

    public OUT_PREMIU_INIController(IOUT_PREMIU_INIService service
    )
    {
        _service = service;
    }

    // GET: OUT_PREMIU_INI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/OUT_PREMIU_INI/Index.cshtml");

    // GET: OUT_PREMIU_INI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_PREMIU_INI/Details.cshtml", result);
    }

    // GET: OUT_PREMIU_INI/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/OUT_PREMIU_INI/Create.cshtml", new CreateOUT_PREMIU_INIDto());
    }

    // POST: OUT_PREMIU_INI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOUT_PREMIU_INIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/OUT_PREMIU_INI/Create.cshtml", createDto);
    }

    // GET: OUT_PREMIU_INI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateOUT_PREMIU_INIDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMOVNUMBE = result.NMOVNUMBE,
            NDIGIT = result.NDIGIT,
            NID_BILL = result.NID_BILL,
            SADDSUINI = result.SADDSUINI,
            STYPE_DETAI = result.STYPE_DETAI,
            NBILL_ITEM = result.NBILL_ITEM,
            NCODE_DETAI = result.NCODE_DETAI,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            DCOMPDATE = result.DCOMPDATE,
            NPREMIUM = result.NPREMIUM,
            NTAX = result.NTAX,
            NUSERCODE = result.NUSERCODE,
            NPROVINCIE = result.NPROVINCIE,
            NPREM_ANU = result.NPREM_ANU,
            NCOM_ANU = result.NCOM_ANU,
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
            NDISSUR_TYPE = result.NDISSUR_TYPE,
        };
        return View("~/Views/Insudb/OUT_PREMIU_INI/Edit.cshtml", updateDto);
    }

    // POST: OUT_PREMIU_INI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateOUT_PREMIU_INIDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/OUT_PREMIU_INI/Edit.cshtml", updateDto);
    }

    // GET: OUT_PREMIU_INI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_PREMIU_INI/Delete.cshtml", result);
    }

    // POST: OUT_PREMIU_INI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
