using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TREHABILITATE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TREHABILITATEController : Controller
{
    private readonly ITREHABILITATEService _service;

    public TREHABILITATEController(ITREHABILITATEService service
    )
    {
        _service = service;
    }

    // GET: TREHABILITATE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TREHABILITATE/Index.cshtml", result);
    }

    // GET: TREHABILITATE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREHABILITATE/Details.cshtml", result);
    }

    // GET: TREHABILITATE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TREHABILITATE/Create.cshtml", new CreateTREHABILITATEDto());
    }

    // POST: TREHABILITATE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTREHABILITATEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREHABILITATE/Create.cshtml", createDto);
    }

    // GET: TREHABILITATE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTREHABILITATEDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NSTATQUOTA = result.NSTATQUOTA,
            NCAPITAL = result.NCAPITAL,
            SCURRENCY = result.SCURRENCY,
            SNAME_EXEC = result.SNAME_EXEC,
            DEFFECDATE = result.DEFFECDATE,
            SCLIENT_AGE = result.SCLIENT_AGE,
            SCLIENAME_AGE = result.SCLIENAME_AGE,
            NPAYFREQ = result.NPAYFREQ,
            SKEY = result.SKEY,
            NID = result.NID,
            NRECEIPT_A = result.NRECEIPT_A,
            DEFFECDATE_A = result.DEFFECDATE_A,
            NPREMIUM_A = result.NPREMIUM_A,
            SCLIENT_A = result.SCLIENT_A,
            SCLIENAME_A = result.SCLIENAME_A,
            NRECEIPT_D = result.NRECEIPT_D,
            DEFFECDATE_D = result.DEFFECDATE_D,
            NPREMIUM_D = result.NPREMIUM_D,
            STRATYPEI = result.STRATYPEI,
            SCLIENT_D = result.SCLIENT_D,
            SCLIENAME_D = result.SCLIENAME_D,
            NAGENCY = result.NAGENCY,
            NPREMIUM_TOT = result.NPREMIUM_TOT,
            SADDRESS = result.SADDRESS,
            SLOCAL = result.SLOCAL,
            SMUNICIPALITY = result.SMUNICIPALITY,
            SPHONE = result.SPHONE,
            SMODULEC = result.SMODULEC,
            DLIMITDATE = result.DLIMITDATE,
            NCOUNT = result.NCOUNT,
            NEXCHANGE = result.NEXCHANGE,
            NPREMIUM_P = result.NPREMIUM_P,
            NINTEREST_P = result.NINTEREST_P,
            NINTEREST_O = result.NINTEREST_O,
            NPROPONUM = result.NPROPONUM,
            SCERTYPE = result.SCERTYPE,
            DNULLDATE = result.DNULLDATE,
        };
        return View("~/Views/Insudb/TREHABILITATE/Edit.cshtml", updateDto);
    }

    // POST: TREHABILITATE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTREHABILITATEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREHABILITATE/Edit.cshtml", updateDto);
    }

    // GET: TREHABILITATE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREHABILITATE/Delete.cshtml", result);
    }

    // POST: TREHABILITATE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
