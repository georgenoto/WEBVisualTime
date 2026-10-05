using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SECUR_SCHEController : Controller
{
    private readonly ISECUR_SCHEService _service;

    public SECUR_SCHEController(ISECUR_SCHEService service
    )
    {
        _service = service;
    }

    // GET: SECUR_SCHE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SECUR_SCHE/Index.cshtml", result);
    }

    // GET: SECUR_SCHE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECUR_SCHE/Details.cshtml", result);
    }

    // GET: SECUR_SCHE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SECUR_SCHE/Create.cshtml", new CreateSECUR_SCHEDto());
    }

    // POST: SECUR_SCHE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSECUR_SCHEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SECUR_SCHE/Create.cshtml", createDto);
    }

    // GET: SECUR_SCHE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSECUR_SCHEDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NACCESOF = result.NACCESOF,
            DCOMPDATE = result.DCOMPDATE,
            DDATE_FROM = result.DDATE_FROM,
            DDATE_TO = result.DDATE_TO,
            NIND_CURREN = result.NIND_CURREN,
            NIND_LIMITS = result.NIND_LIMITS,
            SLONGDESC = result.SLONGDESC,
            NSECURLEV = result.NSECURLEV,
            SSHORTDES = result.SSHORTDES,
            SSTATREGT = result.SSTATREGT,
            STIME1_FROM = result.STIME1_FROM,
            STIME1_TO = result.STIME1_TO,
            STIME2_FROM = result.STIME2_FROM,
            STIME2_TO = result.STIME2_TO,
            STIMEQ1_FRO = result.STIMEQ1_FRO,
            STIMEQ1_TO = result.STIMEQ1_TO,
            STIMEQ2_FRO = result.STIMEQ2_FRO,
            STIMEQ2_TO = result.STIMEQ2_TO,
            SUSEQUERY = result.SUSEQUERY,
            NIND_CONCE = result.NIND_CONCE,
            NUSERCODE = result.NUSERCODE,
            NDURATION = result.NDURATION,
            NDAYSADV = result.NDAYSADV,
            SENCRYPTED = result.SENCRYPTED,
        };
        return View("~/Views/Insudb/SECUR_SCHE/Edit.cshtml", updateDto);
    }

    // POST: SECUR_SCHE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSECUR_SCHEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SECUR_SCHE/Edit.cshtml", updateDto);
    }

    // GET: SECUR_SCHE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECUR_SCHE/Delete.cshtml", result);
    }

    // POST: SECUR_SCHE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
