using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_NPR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CESSION_NPRController : Controller
{
    private readonly ICESSION_NPRService _service;

    public CESSION_NPRController(ICESSION_NPRService service
    )
    {
        _service = service;
    }

    // GET: CESSION_NPR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CESSION_NPR/Index.cshtml", result);
    }

    // GET: CESSION_NPR/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CESSION_NPR/Details.cshtml", result);
    }

    // GET: CESSION_NPR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CESSION_NPR/Create.cshtml", new CreateCESSION_NPRDto());
    }

    // POST: CESSION_NPR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCESSION_NPRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CESSION_NPR/Create.cshtml", createDto);
    }

    // GET: CESSION_NPR/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCESSION_NPRDto
        {
            NCESSION_NU = result.NCESSION_NU,
            NID = result.NID,
            NCOMPANY = result.NCOMPANY,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NBRANCH_REI = result.NBRANCH_REI,
            NTYPE_CESSI = result.NTYPE_CESSI,
            NCONCEPT = result.NCONCEPT,
            NCOMMISSION = result.NCOMMISSION,
            NCURRENCY = result.NCURRENCY,
            SPRINT_CE = result.SPRINT_CE,
            NSHARE = result.NSHARE,
            NYEARMONTH = result.NYEARMONTH,
            DSTARTDATE = result.DSTARTDATE,
            DENDDATE = result.DENDDATE,
            NPREM_DEP = result.NPREM_DEP,
            NCESS_PREM = result.NCESS_PREM,
            NTAXRATE = result.NTAXRATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCESS_CL = result.NCESS_CL,
            NCAPITAL_EXP = result.NCAPITAL_EXP,
            NCAPITAL_EXP_I = result.NCAPITAL_EXP_I,
            NAVG_CAPITALEXP = result.NAVG_CAPITALEXP,
            NINSURANCE_EXP = result.NINSURANCE_EXP,
            NINSURANCE_EXP_I = result.NINSURANCE_EXP_I,
            NAVG_INS_EXP = result.NAVG_INS_EXP,
            NCLAIMCES_PEND = result.NCLAIMCES_PEND,
            NCLAIMCES_PAY = result.NCLAIMCES_PAY,
            NTOTAL_CESS = result.NTOTAL_CESS,
            NRATE_ADJ = result.NRATE_ADJ,
            NFACTOR_ADJ = result.NFACTOR_ADJ,
            NRATE = result.NRATE,
            NPREMIUM = result.NPREMIUM,
            NPREMWTAX = result.NPREMWTAX,
            NFACTOR_ADJ_B = result.NFACTOR_ADJ_B,
            NRATE_B = result.NRATE_B,
            NPREMIUM_B = result.NPREMIUM_B,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SCLIENT = result.SCLIENT,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
        };
        return View("~/Views/Insudb/CESSION_NPR/Edit.cshtml", updateDto);
    }

    // POST: CESSION_NPR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCESSION_NPRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCESSION_NU, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CESSION_NPR/Edit.cshtml", updateDto);
    }

    // GET: CESSION_NPR/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CESSION_NPR/Delete.cshtml", result);
    }

    // POST: CESSION_NPR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
