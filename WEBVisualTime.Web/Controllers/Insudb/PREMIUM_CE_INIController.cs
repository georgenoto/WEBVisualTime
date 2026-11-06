using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_CE_INI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PREMIUM_CE_INIController : Controller
{
    private readonly IPREMIUM_CE_INIService _service;

    public PREMIUM_CE_INIController(IPREMIUM_CE_INIService service
    )
    {
        _service = service;
    }

    // GET: PREMIUM_CE_INI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PREMIUM_CE_INI/Index.cshtml");

    // GET: PREMIUM_CE_INI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_CE_INI/Details.cshtml", result);
    }

    // GET: PREMIUM_CE_INI/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PREMIUM_CE_INI/Create.cshtml", new CreatePREMIUM_CE_INIDto());
    }

    // POST: PREMIUM_CE_INI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePREMIUM_CE_INIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PREMIUM_CE_INI/Create.cshtml", createDto);
    }

    // GET: PREMIUM_CE_INI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePREMIUM_CE_INIDto
        {
            SCERTYPE = result.SCERTYPE,
            NPRODUCT = result.NPRODUCT,
            NBRANCH = result.NBRANCH,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            STYPE_DETAI = result.STYPE_DETAI,
            NID_BILL = result.NID_BILL,
            NCODE_DETAI = result.NCODE_DETAI,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_REI = result.NBRANCH_REI,
            DCOMPDATE = result.DCOMPDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NPREMIUM = result.NPREMIUM,
            NPREMIUMN = result.NPREMIUMN,
            DSTARTDATE = result.DSTARTDATE,
            NTRATYPEI = result.NTRATYPEI,
            NUSERCODE = result.NUSERCODE,
            NPREMANUAL = result.NPREMANUAL,
            NCOMANUAL = result.NCOMANUAL,
            SADDTAX = result.SADDTAX,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NORIGI = result.NORIGI,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
        };
        return View("~/Views/Insudb/PREMIUM_CE_INI/Edit.cshtml", updateDto);
    }

    // POST: PREMIUM_CE_INI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePREMIUM_CE_INIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PREMIUM_CE_INI/Edit.cshtml", updateDto);
    }

    // GET: PREMIUM_CE_INI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_CE_INI/Delete.cshtml", result);
    }

    // POST: PREMIUM_CE_INI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
