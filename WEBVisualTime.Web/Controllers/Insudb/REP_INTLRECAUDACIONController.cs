using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REP_INTLRECAUDACION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REP_INTLRECAUDACIONController : Controller
{
    private readonly IREP_INTLRECAUDACIONService _service;

    public REP_INTLRECAUDACIONController(IREP_INTLRECAUDACIONService service
    )
    {
        _service = service;
    }

    // GET: REP_INTLRECAUDACION
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Index.cshtml", result);
    }

    // GET: REP_INTLRECAUDACION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Details.cshtml", result);
    }

    // GET: REP_INTLRECAUDACION/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Create.cshtml", new CreateREP_INTLRECAUDACIONDto());
    }

    // POST: REP_INTLRECAUDACION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREP_INTLRECAUDACIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Create.cshtml", createDto);
    }

    // GET: REP_INTLRECAUDACION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREP_INTLRECAUDACIONDto
        {
            SKEY = result.SKEY,
            NSEQ = result.NSEQ,
            SCLIENT = result.SCLIENT,
            SDIGIT = result.SDIGIT,
            NPOLICY = result.NPOLICY,
            NPROPONUM = result.NPROPONUM,
            NPRODUCT = result.NPRODUCT,
            NAMOUNT_LOCAL = result.NAMOUNT_LOCAL,
            NAMOUNT = result.NAMOUNT,
            NRECEIPT = result.NRECEIPT,
            NBORDEREAUX = result.NBORDEREAUX,
            SDESCRIPTOLD = result.SDESCRIPTOLD,
            SDESCRIPTACC = result.SDESCRIPTACC,
            NSHEET = result.NSHEET,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NSTATUSREND = result.NSTATUSREND,
            NTYPEREJEC = result.NTYPEREJEC,
            NBULLETINS = result.NBULLETINS,
            NSECTION = result.NSECTION,
            NORDER = result.NORDER,
            NCERTIF = result.NCERTIF,
            NBANK = result.NBANK,
        };
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Edit.cshtml", updateDto);
    }

    // POST: REP_INTLRECAUDACION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREP_INTLRECAUDACIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Edit.cshtml", updateDto);
    }

    // GET: REP_INTLRECAUDACION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REP_INTLRECAUDACION/Delete.cshtml", result);
    }

    // POST: REP_INTLRECAUDACION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
