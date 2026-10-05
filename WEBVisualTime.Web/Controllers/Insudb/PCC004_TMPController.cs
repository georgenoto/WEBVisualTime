using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_TMP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PCC004_TMPController : Controller
{
    private readonly IPCC004_TMPService _service;

    public PCC004_TMPController(IPCC004_TMPService service
    )
    {
        _service = service;
    }

    // GET: PCC004_TMP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PCC004_TMP/Index.cshtml", result);
    }

    // GET: PCC004_TMP/Details/{id}
    public async Task<IActionResult> Details(DateTime id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PCC004_TMP/Details.cshtml", result);
    }

    // GET: PCC004_TMP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PCC004_TMP/Create.cshtml", new CreatePCC004_TMPDto());
    }

    // POST: PCC004_TMP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePCC004_TMPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PCC004_TMP/Create.cshtml", createDto);
    }

    // GET: PCC004_TMP/Edit/{id}
    public async Task<IActionResult> Edit(DateTime id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePCC004_TMPDto
        {
            DISSUEDATFORM = result.DISSUEDATFORM,
            SLEGALNAME_COMPANY = result.SLEGALNAME_COMPANY,
            SCLINUMDOCU_COMPANY = result.SCLINUMDOCU_COMPANY,
            SDESCADD_COMPANY = result.SDESCADD_COMPANY,
            NLOCAL_COMPANY = result.NLOCAL_COMPANY,
            SZONA_COMPANY = result.SZONA_COMPANY,
            SPHONE_COMPANY = result.SPHONE_COMPANY,
            NPERSON_TYP = result.NPERSON_TYP,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            SLASTNAME2 = result.SLASTNAME2,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            SCLINUMDOCU = result.SCLINUMDOCU,
            SIDCOMPL = result.SIDCOMPL,
            NNATIONALITY = result.NNATIONALITY,
            NTITLE = result.NTITLE,
            NRESIDENCECOUNTRY = result.NRESIDENCECOUNTRY,
            NSPECIALITY = result.NSPECIALITY,
            SCOMPANYWORKS = result.SCOMPANYWORKS,
            NPOSITION_CLI = result.NPOSITION_CLI,
            SDESCADD_LABOUR = result.SDESCADD_LABOUR,
            SLEGALNAME = result.SLEGALNAME,
            NAREA = result.NAREA,
            NLOCAL = result.NLOCAL,
            SZONA = result.SZONA,
            SDESCADD_DOMICILE = result.SDESCADD_DOMICILE,
            SPHONE = result.SPHONE,
            NIND_OPERATION = result.NIND_OPERATION,
            NIND_PREMIUMCLAIM = result.NIND_PREMIUMCLAIM,
            NIND_INSURANCE = result.NIND_INSURANCE,
            NIND_TERM = result.NIND_TERM,
            NCURRENCY = result.NCURRENCY,
            SCLIENAME_INTERMEDIARY = result.SCLIENAME_INTERMEDIARY,
            SCLIENAME_TITULAR = result.SCLIENAME_TITULAR,
            NIND_BRANCH = result.NIND_BRANCH,
            NPOLICY = result.NPOLICY,
            SBANKACCOUNT = result.SBANKACCOUNT,
            SCHEQUE = result.SCHEQUE,
            NBANKEXT = result.NBANKEXT,
            NINDREPOSITION = result.NINDREPOSITION,
            SORIGENRESOURCES = result.SORIGENRESOURCES,
            SDESTINYRESOURCES = result.SDESTINYRESOURCES,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NBORDEREAUX = result.NBORDEREAUX,
            NACCUMULATED_PAY = result.NACCUMULATED_PAY,
            SREMARKS = result.SREMARKS,
            SPHONE_PART = result.SPHONE_PART,
            NLOCAL_PART = result.NLOCAL_PART,
            SZONE_PART = result.SZONE_PART,
            SCLIENAME_BROKER = result.SCLIENAME_BROKER,
            NIND_CASHFLOW = result.NIND_CASHFLOW,
            SDESCRIPT_CITY = result.SDESCRIPT_CITY,
        };
        return View("~/Views/Insudb/PCC004_TMP/Edit.cshtml", updateDto);
    }

    // POST: PCC004_TMP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePCC004_TMPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.DISSUEDATFORM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PCC004_TMP/Edit.cshtml", updateDto);
    }

    // GET: PCC004_TMP/Delete/{id}
    public async Task<IActionResult> Delete(DateTime id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PCC004_TMP/Delete.cshtml", result);
    }

    // POST: PCC004_TMP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(DateTime id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
