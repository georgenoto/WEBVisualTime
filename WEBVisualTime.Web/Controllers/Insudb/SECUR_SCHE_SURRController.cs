using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE_SURR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SECUR_SCHE_SURRController : Controller
{
    private readonly ISECUR_SCHE_SURRService _service;

    public SECUR_SCHE_SURRController(ISECUR_SCHE_SURRService service
    )
    {
        _service = service;
    }

    // GET: SECUR_SCHE_SURR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Index.cshtml", result);
    }

    // GET: SECUR_SCHE_SURR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Details.cshtml", result);
    }

    // GET: SECUR_SCHE_SURR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Create.cshtml", new CreateSECUR_SCHE_SURRDto());
    }

    // POST: SECUR_SCHE_SURR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSECUR_SCHE_SURRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Create.cshtml", createDto);
    }

    // GET: SECUR_SCHE_SURR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSECUR_SCHE_SURRDto
        {
            SSCHE_CODE = result.SSCHE_CODE,
            NTYPERESC = result.NTYPERESC,
            DCOMPDATE = result.DCOMPDATE,
            SMOD_DATE_R = result.SMOD_DATE_R,
            SRESC_TOT = result.SRESC_TOT,
            SRESC_PAR = result.SRESC_PAR,
            STYPEXECUT = result.STYPEXECUT,
            SMOD_DATE_P = result.SMOD_DATE_P,
            NUSERCODE = result.NUSERCODE,
            NTYPERESCV = result.NTYPERESCV,
            SMOD_DATE_RV = result.SMOD_DATE_RV,
            SRESC_TOTV = result.SRESC_TOTV,
            SRESC_PARV = result.SRESC_PARV,
            STYPEXECUTV = result.STYPEXECUTV,
            SANULREC = result.SANULREC,
            SMOD_DATE_PV = result.SMOD_DATE_PV,
            SREQUEST = result.SREQUEST,
            SREPORT = result.SREPORT,
            NVALUE_TYP = result.NVALUE_TYP,
        };
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Edit.cshtml", updateDto);
    }

    // POST: SECUR_SCHE_SURR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSECUR_SCHE_SURRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSCHE_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Edit.cshtml", updateDto);
    }

    // GET: SECUR_SCHE_SURR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECUR_SCHE_SURR/Delete.cshtml", result);
    }

    // POST: SECUR_SCHE_SURR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
