using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_DOCTYP_BKP20260910;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_DOCTYP_BKP20260910Controller : Controller
{
    private readonly IT_DOCTYP_BKP20260910Service _service;

    public T_DOCTYP_BKP20260910Controller(IT_DOCTYP_BKP20260910Service service
    )
    {
        _service = service;
    }

    // GET: T_DOCTYP_BKP20260910
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Index.cshtml", result);
    }

    // GET: T_DOCTYP_BKP20260910/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Details.cshtml", result);
    }

    // GET: T_DOCTYP_BKP20260910/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Create.cshtml", new CreateT_DOCTYP_BKP20260910Dto());
    }

    // POST: T_DOCTYP_BKP20260910/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_DOCTYP_BKP20260910Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Create.cshtml", createDto);
    }

    // GET: T_DOCTYP_BKP20260910/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_DOCTYP_BKP20260910Dto
        {
            SSEL = result.SSEL,
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NCOLLECDOCTYP = result.NCOLLECDOCTYP,
            NDOCUMENT = result.NDOCUMENT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            SCLIENT = result.SCLIENT,
            NBULLETINS = result.NBULLETINS,
            NPROPONUM = result.NPROPONUM,
            NTYPEMOVE = result.NTYPEMOVE,
            DMOVDATE = result.DMOVDATE,
            NTYPE = result.NTYPE,
            NTRATYPEI = result.NTRATYPEI,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            NAMOUNTCOL = result.NAMOUNTCOL,
            NAMOUNTPAY = result.NAMOUNTPAY,
            NPAYSOONDISC = result.NPAYSOONDISC,
            NINTEREST_RATE = result.NINTEREST_RATE,
            DEXPIRDAT = result.DEXPIRDAT,
            SMANAUTI = result.SMANAUTI,
            NSTATUS_PRE = result.NSTATUS_PRE,
            NCOMAMOU = result.NCOMAMOU,
            NPARTICIP = result.NPARTICIP,
            NPREMIUM = result.NPREMIUM,
            NINTERMED = result.NINTERMED,
            NUSERCODE = result.NUSERCODE,
            NCASH_MOV = result.NCASH_MOV,
            DPOSTED = result.DPOSTED,
            STYPE_DETAI = result.STYPE_DETAI,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NINTERTYP = result.NINTERTYP,
            NRATE_DISC = result.NRATE_DISC,
            NNOM_VALBON = result.NNOM_VALBON,
            DISSUEDATBON = result.DISSUEDATBON,
            DEXPIRDATBON = result.DEXPIRDATBON,
            NTAX = result.NTAX,
            NORIGIN = result.NORIGIN,
            DDATE_ORIGIN = result.DDATE_ORIGIN,
            NINSTITUTION = result.NINSTITUTION,
            NCHANGESDAT = result.NCHANGESDAT,
            DVALUEDATE = result.DVALUEDATE,
            NCOLLECTOR = result.NCOLLECTOR,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NLOANS = result.NLOANS,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            SNEWRECEIPT = result.SNEWRECEIPT,
            NCOD_SAAPV = result.NCOD_SAAPV,
            SFOLIONUMBER = result.SFOLIONUMBER,
            SBILLADVANCE = result.SBILLADVANCE,
            DLIMITDATE = result.DLIMITDATE,
        };
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Edit.cshtml", updateDto);
    }

    // POST: T_DOCTYP_BKP20260910/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_DOCTYP_BKP20260910Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SSEL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Edit.cshtml", updateDto);
    }

    // GET: T_DOCTYP_BKP20260910/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_DOCTYP_BKP20260910/Delete.cshtml", result);
    }

    // POST: T_DOCTYP_BKP20260910/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
