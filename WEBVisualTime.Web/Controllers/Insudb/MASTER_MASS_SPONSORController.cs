using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTER_MASS_SPONSOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTER_MASS_SPONSORController : Controller
{
    private readonly IMASTER_MASS_SPONSORService _service;

    public MASTER_MASS_SPONSORController(IMASTER_MASS_SPONSORService service
    )
    {
        _service = service;
    }

    // GET: MASTER_MASS_SPONSOR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Index.cshtml", result);
    }

    // GET: MASTER_MASS_SPONSOR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Details.cshtml", result);
    }

    // GET: MASTER_MASS_SPONSOR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Create.cshtml", new CreateMASTER_MASS_SPONSORDto());
    }

    // POST: MASTER_MASS_SPONSOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTER_MASS_SPONSORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Create.cshtml", createDto);
    }

    // GET: MASTER_MASS_SPONSOR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTER_MASS_SPONSORDto
        {
            NCOD_AGREE = result.NCOD_AGREE,
            NSELLCHANNEL = result.NSELLCHANNEL,
            NPROCESS = result.NPROCESS,
            NSHEET = result.NSHEET,
            NBUSIN = result.NBUSIN,
            NBUSOUT = result.NBUSOUT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCOLLECTDEBT = result.SCOLLECTDEBT,
            SCOLLCURRDEBT = result.SCOLLCURRDEBT,
            SMAIL = result.SMAIL,
            NSHEET_OUT = result.NSHEET_OUT,
            DRECEPTION_DAY = result.DRECEPTION_DAY,
            NUSERINCHARGE = result.NUSERINCHARGE,
            NKEY = result.NKEY,
            SDESCRIPT = result.SDESCRIPT,
            NPERIOD = result.NPERIOD,
            DLAST_DATE = result.DLAST_DATE,
            NDAYSFREQ = result.NDAYSFREQ,
        };
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Edit.cshtml", updateDto);
    }

    // POST: MASTER_MASS_SPONSOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTER_MASS_SPONSORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOD_AGREE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Edit.cshtml", updateDto);
    }

    // GET: MASTER_MASS_SPONSOR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTER_MASS_SPONSOR/Delete.cshtml", result);
    }

    // POST: MASTER_MASS_SPONSOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
