using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASS_PROC_SPONSOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASS_PROC_SPONSORController : Controller
{
    private readonly IMASS_PROC_SPONSORService _service;

    public MASS_PROC_SPONSORController(IMASS_PROC_SPONSORService service
    )
    {
        _service = service;
    }

    // GET: MASS_PROC_SPONSOR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MASS_PROC_SPONSOR/Index.cshtml");

    // GET: MASS_PROC_SPONSOR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Details.cshtml", result);
    }

    // GET: MASS_PROC_SPONSOR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Create.cshtml", new CreateMASS_PROC_SPONSORDto());
    }

    // POST: MASS_PROC_SPONSOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASS_PROC_SPONSORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Create.cshtml", createDto);
    }

    // GET: MASS_PROC_SPONSOR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASS_PROC_SPONSORDto
        {
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NPROCESS = result.NPROCESS,
            SKEY = result.SKEY,
            SLOT = result.SLOT,
            STYPEEXECUTION = result.STYPEEXECUTION,
            NSTATUS = result.NSTATUS,
            DPROCESSDATE = result.DPROCESSDATE,
            NTOTALRECPROC = result.NTOTALRECPROC,
            NSUCCESSRECPROC = result.NSUCCESSRECPROC,
            NERRORRECPROC = result.NERRORRECPROC,
            NCOLLECTPREMIUM = result.NCOLLECTPREMIUM,
            NSUSCRIBEDPOLICIES = result.NSUSCRIBEDPOLICIES,
            NCANCELEDPOLICIES = result.NCANCELEDPOLICIES,
            NMODIFIEDPOLICIES = result.NMODIFIEDPOLICIES,
            NCLAIMSREPORTED = result.NCLAIMSREPORTED,
            NDECLAREDCLAIMS = result.NDECLAREDCLAIMS,
            NTOTALCLAIMSPAID = result.NTOTALCLAIMSPAID,
            NCLAIMSPAID = result.NCLAIMSPAID,
            NCANCELEDCLAIMS = result.NCANCELEDCLAIMS,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NKEY = result.NKEY,
            NCANCELEDCERTIFICATE = result.NCANCELEDCERTIFICATE,
            NMODIFIEDCERTIFICATE = result.NMODIFIEDCERTIFICATE,
            NPOLICY = result.NPOLICY,
            NSUSCRIBEDCERTIFICATE = result.NSUSCRIBEDCERTIFICATE,
            NSHEET_OUT = result.NSHEET_OUT,
            NUSERINCHARGE = result.NUSERINCHARGE,
            DRECEPTION_DAY = result.DRECEPTION_DAY,
            NCOD_AGREE = result.NCOD_AGREE,
            SFILENAME = result.SFILENAME,
            DEXECUTE = result.DEXECUTE,
            NMONTH = result.NMONTH,
            NYEAR = result.NYEAR,
        };
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Edit.cshtml", updateDto);
    }

    // POST: MASS_PROC_SPONSOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASS_PROC_SPONSORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Edit.cshtml", updateDto);
    }

    // GET: MASS_PROC_SPONSOR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASS_PROC_SPONSOR/Delete.cshtml", result);
    }

    // POST: MASS_PROC_SPONSOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
