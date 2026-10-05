using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TRENEWPOL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TRENEWPOLController : Controller
{
    private readonly ITRENEWPOLService _service;

    public TRENEWPOLController(ITRENEWPOLService service
    )
    {
        _service = service;
    }

    // GET: TRENEWPOL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TRENEWPOL/Index.cshtml", result);
    }

    // GET: TRENEWPOL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRENEWPOL/Details.cshtml", result);
    }

    // GET: TRENEWPOL/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TRENEWPOL/Create.cshtml", new CreateTRENEWPOLDto());
    }

    // POST: TRENEWPOL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTRENEWPOLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRENEWPOL/Create.cshtml", createDto);
    }

    // GET: TRENEWPOL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTRENEWPOLDto
        {
            SKEY = result.SKEY,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            DEXPIRDATE = result.DEXPIRDATE,
            NINSAMOUNT = result.NINSAMOUNT,
            NPREMIUNAN = result.NPREMIUNAN,
            NINCIDENTYP = result.NINCIDENTYP,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPENRECAMO = result.NPENRECAMO,
            NQPAYCLAIM = result.NQPAYCLAIM,
            NPAYCLAIMAMO = result.NPAYCLAIMAMO,
            NQPENCLAIM = result.NQPENCLAIM,
            NPENCLAIMAMO = result.NPENCLAIMAMO,
            NQRECPEN = result.NQRECPEN,
            NQCLAIM = result.NQCLAIM,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM = result.NPREMIUM,
            STEXT_ERR = result.STEXT_ERR,
            DSTARTDATE = result.DSTARTDATE,
            NOFFICE = result.NOFFICE,
            NAGENCY = result.NAGENCY,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NINTERMED = result.NINTERMED,
            NCURRENCY = result.NCURRENCY,
            NPAYFREQ = result.NPAYFREQ,
            SCOLINVOT = result.SCOLINVOT,
            NPREMIUMPROYECT = result.NPREMIUMPROYECT,
            SWARNING = result.SWARNING,
        };
        return View("~/Views/Insudb/TRENEWPOL/Edit.cshtml", updateDto);
    }

    // POST: TRENEWPOL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTRENEWPOLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TRENEWPOL/Edit.cshtml", updateDto);
    }

    // GET: TRENEWPOL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TRENEWPOL/Delete.cshtml", result);
    }

    // POST: TRENEWPOL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
