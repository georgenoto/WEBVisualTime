using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN_CESSION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TREINSURAN_CESSIONController : Controller
{
    private readonly ITREINSURAN_CESSIONService _service;

    public TREINSURAN_CESSIONController(ITREINSURAN_CESSIONService service
    )
    {
        _service = service;
    }

    // GET: TREINSURAN_CESSION
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TREINSURAN_CESSION/Index.cshtml", result);
    }

    // GET: TREINSURAN_CESSION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREINSURAN_CESSION/Details.cshtml", result);
    }

    // GET: TREINSURAN_CESSION/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TREINSURAN_CESSION/Create.cshtml", new CreateTREINSURAN_CESSIONDto());
    }

    // POST: TREINSURAN_CESSION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTREINSURAN_CESSIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREINSURAN_CESSION/Create.cshtml", createDto);
    }

    // GET: TREINSURAN_CESSION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTREINSURAN_CESSIONDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NTYPE_REIN = result.NTYPE_REIN,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            NCOMPANY = result.NCOMPANY,
            NCOVAPPSCOPE = result.NCOVAPPSCOPE,
            NBRANCH_REI = result.NBRANCH_REI,
            NSHARE = result.NSHARE,
            NRATE = result.NRATE,
            NLIMITFROM = result.NLIMITFROM,
            NLIMIT = result.NLIMIT,
            NCAPITAL = result.NCAPITAL,
            NCOMMISSI = result.NCOMMISSI,
            NPREMIUM_AGREE = result.NPREMIUM_AGREE,
            NPREMIUM = result.NPREMIUM,
            NCOMMISSIONAMOUNT = result.NCOMMISSIONAMOUNT,
            NTAXPERCEN = result.NTAXPERCEN,
            NTAXAMOUNT = result.NTAXAMOUNT,
            SKEY = result.SKEY,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NORDER = result.NORDER,
            NCURRENCY = result.NCURRENCY,
            NNUMBER = result.NNUMBER,
            DISSUEDATE = result.DISSUEDATE,
        };
        return View("~/Views/Insudb/TREINSURAN_CESSION/Edit.cshtml", updateDto);
    }

    // POST: TREINSURAN_CESSION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTREINSURAN_CESSIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TREINSURAN_CESSION/Edit.cshtml", updateDto);
    }

    // GET: TREINSURAN_CESSION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TREINSURAN_CESSION/Delete.cshtml", result);
    }

    // POST: TREINSURAN_CESSION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
