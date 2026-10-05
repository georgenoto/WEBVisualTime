using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TREINSURANController : Controller
{
    private readonly ITREINSURANService _service;

    public TREINSURANController(ITREINSURANService service
    )
    {
        _service = service;
    }

    // GET: TREINSURAN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TREINSURAN/Index.cshtml", result);
    }

    // GET: TREINSURAN/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREINSURAN/Details.cshtml", result);
    }

    // GET: TREINSURAN/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TREINSURAN/Create.cshtml", new CreateTREINSURANDto());
    }

    // POST: TREINSURAN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTREINSURANDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREINSURAN/Create.cshtml", createDto);
    }

    // GET: TREINSURAN/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTREINSURANDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NBRANCH_REI = result.NBRANCH_REI,
            NTYPE = result.NTYPE,
            NNUMBER = result.NNUMBER,
            NCAPITAL = result.NCAPITAL,
            NCAPITALMAX = result.NCAPITALMAX,
            NQUOTASHA = result.NQUOTASHA,
            SKEY = result.SKEY,
            NCURRENCY = result.NCURRENCY,
            NCOVER = result.NCOVER,
            NMODULEC = result.NMODULEC,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            NCOMPANY = result.NCOMPANY,
            NCOMMISSI = result.NCOMMISSI,
            DCOMPDATE = result.DCOMPDATE,
            SHEAP_CODE = result.SHEAP_CODE,
            NINTER_RATE = result.NINTER_RATE,
            DNULLDATE = result.DNULLDATE,
            NCHANGE = result.NCHANGE,
            NACEP_CODE = result.NACEP_CODE,
            SMANUALMOV = result.SMANUALMOV,
            SCOVERDESC = result.SCOVERDESC,
            NREST = result.NREST,
            NPREMIUM = result.NPREMIUM,
            NCAPITAL_REI = result.NCAPITAL_REI,
            NRESER_RATE = result.NRESER_RATE,
            SCLIENAME = result.SCLIENAME,
            DACCEDATE = result.DACCEDATE,
            SCOMPANY = result.SCOMPANY,
            NRESERVE = result.NRESERVE,
            NCOVERGEN = result.NCOVERGEN,
            NPREMIUM_AGREE = result.NPREMIUM_AGREE,
            NEXCESS = result.NEXCESS,
            NRETENTION = result.NRETENTION,
            NSPCPRIORITY = result.NSPCPRIORITY,
            NCOMPANYBROKER = result.NCOMPANYBROKER,
            NFACPERCENTREQ = result.NFACPERCENTREQ,
            NFACBRANCH_REIREQ = result.NFACBRANCH_REIREQ,
            NFACPERCENTREQ_COV = result.NFACPERCENTREQ_COV,
            NCOVAPPSCOPE = result.NCOVAPPSCOPE,
            NLIMITFROM = result.NLIMITFROM,
            NLIMIT = result.NLIMIT,
            NAGGREGATELIMIT = result.NAGGREGATELIMIT,
            NPERCENT = result.NPERCENT,
            NAMOUNT_CONT = result.NAMOUNT_CONT,
        };
        return View("~/Views/Insudb/TREINSURAN/Edit.cshtml", updateDto);
    }

    // POST: TREINSURAN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTREINSURANDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREINSURAN/Edit.cshtml", updateDto);
    }

    // GET: TREINSURAN/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREINSURAN/Delete.cshtml", result);
    }

    // POST: TREINSURAN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
