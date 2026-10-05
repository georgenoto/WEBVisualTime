using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TOBLIGREIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TOBLIGREINController : Controller
{
    private readonly ITOBLIGREINService _service;

    public TOBLIGREINController(ITOBLIGREINService service
    )
    {
        _service = service;
    }

    // GET: TOBLIGREIN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TOBLIGREIN/Index.cshtml", result);
    }

    // GET: TOBLIGREIN/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOBLIGREIN/Details.cshtml", result);
    }

    // GET: TOBLIGREIN/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TOBLIGREIN/Create.cshtml", new CreateTOBLIGREINDto());
    }

    // POST: TOBLIGREIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTOBLIGREINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOBLIGREIN/Create.cshtml", createDto);
    }

    // GET: TOBLIGREIN/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTOBLIGREINDto
        {
            NBRANCH = result.NBRANCH,
            NBRANCH_REI = result.NBRANCH_REI,
            SBUSSITYP = result.SBUSSITYP,
            NCED_AMNT = result.NCED_AMNT,
            NCED_PER = result.NCED_PER,
            NCESS_CONC = result.NCESS_CONC,
            NCESS_TYPE = result.NCESS_TYPE,
            NCLAIM = result.NCLAIM,
            NCOMPANY = result.NCOMPANY,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NPOLICY = result.NPOLICY,
            NNUMBER = result.NNUMBER,
            DINIT_DATE = result.DINIT_DATE,
            DEND_DATE = result.DEND_DATE,
            NINDIC_TR = result.NINDIC_TR,
            NYEAR_SER_POL = result.NYEAR_SER_POL,
            NTYPE = result.NTYPE,
            NCAPITAL = result.NCAPITAL,
            NSHARE = result.NSHARE,
            NCOMMISSION = result.NCOMMISSION,
            NCONCEPT = result.NCONCEPT,
            NINTER_RATE = result.NINTER_RATE,
            NTYPE_CESSI = result.NTYPE_CESSI,
            NPREMIUM = result.NPREMIUM,
            NRESER_PREM = result.NRESER_PREM,
            DEFFECDATE = result.DEFFECDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NTYPE_REI = result.NTYPE_REI,
            NYEAR_CONTR = result.NYEAR_CONTR,
            SKEY = result.SKEY,
        };
        return View("~/Views/Insudb/TOBLIGREIN/Edit.cshtml", updateDto);
    }

    // POST: TOBLIGREIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTOBLIGREINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TOBLIGREIN/Edit.cshtml", updateDto);
    }

    // GET: TOBLIGREIN/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TOBLIGREIN/Delete.cshtml", result);
    }

    // POST: TOBLIGREIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
