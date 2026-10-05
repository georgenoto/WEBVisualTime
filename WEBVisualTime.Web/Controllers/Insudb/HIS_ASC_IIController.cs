using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_II;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class HIS_ASC_IIController : Controller
{
    private readonly IHIS_ASC_IIService _service;

    public HIS_ASC_IIController(IHIS_ASC_IIService service
    )
    {
        _service = service;
    }

    // GET: HIS_ASC_II
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/HIS_ASC_II/Index.cshtml", result);
    }

    // GET: HIS_ASC_II/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HIS_ASC_II/Details.cshtml", result);
    }

    // GET: HIS_ASC_II/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/HIS_ASC_II/Create.cshtml", new CreateHIS_ASC_IIDto());
    }

    // POST: HIS_ASC_II/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateHIS_ASC_IIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/HIS_ASC_II/Create.cshtml", createDto);
    }

    // GET: HIS_ASC_II/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateHIS_ASC_IIDto
        {
            NID_UPLOAD = result.NID_UPLOAD,
            NID = result.NID,
            SBANK_ORI = result.SBANK_ORI,
            NPERIOD_YEAR = result.NPERIOD_YEAR,
            NPERIOD_MONTH = result.NPERIOD_MONTH,
            NORDER = result.NORDER,
            SUNIQ_CODE = result.SUNIQ_CODE,
            NAMOUNT = result.NAMOUNT,
            SCURRENCY = result.SCURRENCY,
            SPAY_MET = result.SPAY_MET,
            SCONCEPT = result.SCONCEPT,
            SREFERENCE = result.SREFERENCE,
            SDOC_TYPE = result.SDOC_TYPE,
            SCLIENAME = result.SCLIENAME,
            SPHON_BEN = result.SPHON_BEN,
            SBANKACCOUNT = result.SBANKACCOUNT,
            SBANKEXT = result.SBANKEXT,
            SSTATUS = result.SSTATUS,
            SREASON = result.SREASON,
            SDETAIL = result.SDETAIL,
            NCHEQUE = result.NCHEQUE,
            NORDER_ACH = result.NORDER_ACH,
            DATE_UPLOAD = result.DATE_UPLOAD,
            DATE_PAY = result.DATE_PAY,
            NTRANSF = result.NTRANSF,
            DCOMPDATE = result.DCOMPDATE,
            SSTATMOV = result.SSTATMOV,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NREQUEST_NU = result.NREQUEST_NU,
            SKEY = result.SKEY,
            NDOCUMENT = result.NDOCUMENT,
        };
        return View("~/Views/Insudb/HIS_ASC_II/Edit.cshtml", updateDto);
    }

    // POST: HIS_ASC_II/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHIS_ASC_IIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_UPLOAD, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/HIS_ASC_II/Edit.cshtml", updateDto);
    }

    // GET: HIS_ASC_II/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HIS_ASC_II/Delete.cshtml", result);
    }

    // POST: HIS_ASC_II/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
