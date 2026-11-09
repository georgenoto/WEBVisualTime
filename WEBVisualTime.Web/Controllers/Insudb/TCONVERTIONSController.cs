using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCONVERTIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCONVERTIONSController : Controller
{
    private readonly ITCONVERTIONSService _service;

    public TCONVERTIONSController(ITCONVERTIONSService service
    )
    {
        _service = service;
    }

    // GET: TCONVERTIONS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TCONVERTIONS/Index.cshtml");

    // GET: TCONVERTIONS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCONVERTIONS/Details.cshtml", result);
    }

    // GET: TCONVERTIONS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCONVERTIONS/Create.cshtml", new CreateTCONVERTIONSDto());
    }

    // POST: TCONVERTIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCONVERTIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCONVERTIONS/Create.cshtml", createDto);
    }

    // GET: TCONVERTIONS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCONVERTIONSDto
        {
            NPROPONUM = result.NPROPONUM,
            SKEY = result.SKEY,
            NPOLICY = result.NPOLICY,
            NINDEX = result.NINDEX,
            NNUM_DOC = result.NNUM_DOC,
            SPEN_DOC = result.SPEN_DOC,
            DDATE_INIT = result.DDATE_INIT,
            NSTATUS = result.NSTATUS,
            DSTAT_DATE = result.DSTAT_DATE,
            NNULLCODE = result.NNULLCODE,
            NROLE = result.NROLE,
            DEFFECDATE = result.DEFFECDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            DLIMIT_DATE = result.DLIMIT_DATE,
            SOBSERV = result.SOBSERV,
            NSERV_ORDER = result.NSERV_ORDER,
            NSTATUS_ORD = result.NSTATUS_ORD,
            NBORDEREAUX = result.NBORDEREAUX,
            NFIRST_PREM = result.NFIRST_PREM,
            NPREM_CURR = result.NPREM_CURR,
            SPREM_CHE = result.SPREM_CHE,
            SPAY_ORDER = result.SPAY_ORDER,
            NEXPENSES = result.NEXPENSES,
            SDEVOLUT = result.SDEVOLUT,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NORIGIN = result.NORIGIN,
            SCLIENT = result.SCLIENT,
            NCERTIF = result.NCERTIF,
            NNO_CONVERS = result.NNO_CONVERS,
            NPOL_QUOT = result.NPOL_QUOT,
            NWAIT_CODE = result.NWAIT_CODE,
            NTYPE_AMEND = result.NTYPE_AMEND,
            NEXCHANGE = result.NEXCHANGE,
            NORIG_PREM = result.NORIG_PREM,
            NORIG_CURR = result.NORIG_CURR,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NOFFICE = result.NOFFICE,
            NAGENCY = result.NAGENCY,
            SAPPLYCOSTFP = result.SAPPLYCOSTFP,
            NROUTINE = result.NROUTINE,
            NHEALTHEXP = result.NHEALTHEXP,
            SPENSTATUS_POL = result.SPENSTATUS_POL,
        };
        return View("~/Views/Insudb/TCONVERTIONS/Edit.cshtml", updateDto);
    }

    // POST: TCONVERTIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTCONVERTIONSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCONVERTIONS/Edit.cshtml", updateDto);
    }

    // GET: TCONVERTIONS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCONVERTIONS/Delete.cshtml", result);
    }

    // POST: TCONVERTIONS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
