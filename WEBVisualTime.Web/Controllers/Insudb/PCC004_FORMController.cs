using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_FORM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PCC004_FORMController : Controller
{
    private readonly IPCC004_FORMService _service;

    public PCC004_FORMController(IPCC004_FORMService service
    )
    {
        _service = service;
    }

    // GET: PCC004_FORM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PCC004_FORM/Index.cshtml", result);
    }

    // GET: PCC004_FORM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PCC004_FORM/Details.cshtml", result);
    }

    // GET: PCC004_FORM/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PCC004_FORM/Create.cshtml", new CreatePCC004_FORMDto());
    }

    // POST: PCC004_FORM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePCC004_FORMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PCC004_FORM/Create.cshtml", createDto);
    }

    // GET: PCC004_FORM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePCC004_FORMDto
        {
            NNUM_PCC004 = result.NNUM_PCC004,
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
            SDESPOLICY = result.SDESPOLICY,
        };
        return View("~/Views/Insudb/PCC004_FORM/Edit.cshtml", updateDto);
    }

    // POST: PCC004_FORM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePCC004_FORMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NNUM_PCC004, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PCC004_FORM/Edit.cshtml", updateDto);
    }

    // GET: PCC004_FORM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PCC004_FORM/Delete.cshtml", result);
    }

    // POST: PCC004_FORM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
