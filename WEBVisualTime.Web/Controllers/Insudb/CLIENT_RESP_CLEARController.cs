using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_RESP_CLEAR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_RESP_CLEARController : Controller
{
    private readonly ICLIENT_RESP_CLEARService _service;

    public CLIENT_RESP_CLEARController(ICLIENT_RESP_CLEARService service
    )
    {
        _service = service;
    }

    // GET: CLIENT_RESP_CLEAR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Index.cshtml", result);
    }

    // GET: CLIENT_RESP_CLEAR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Details.cshtml", result);
    }

    // GET: CLIENT_RESP_CLEAR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Create.cshtml", new CreateCLIENT_RESP_CLEARDto());
    }

    // POST: CLIENT_RESP_CLEAR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_RESP_CLEARDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Create.cshtml", createDto);
    }

    // GET: CLIENT_RESP_CLEAR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_RESP_CLEARDto
        {
            SCLIENT = result.SCLIENT,
            SACCOUNT_IN = result.SACCOUNT_IN,
            NINVOICING = result.NINVOICING,
            NCIVILSTA = result.NCIVILSTA,
            DAPROBDATE = result.DAPROBDATE,
            DBIRTHDAT = result.DBIRTHDAT,
            SBLOCKADE = result.SBLOCKADE,
            NCLASS = result.NCLASS,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            DCOMPDATE = result.DCOMPDATE,
            DDEATHDAT = result.DDEATHDAT,
            DDRIVERDAT = result.DDRIVERDAT,
            NHEIGHT = result.NHEIGHT,
            DINPDATE = result.DINPDATE,
            NHOUSE_TYPE = result.NHOUSE_TYPE,
            SLICENSE = result.SLICENSE,
            NNOTENUM = result.NNOTENUM,
            NOFFICE = result.NOFFICE,
            NQ_CARS = result.NQ_CARS,
            NQ_CHILD = result.NQ_CHILD,
            NRATE = result.NRATE,
            STAX_CODE = result.STAX_CODE,
            SSEXCLIEN = result.SSEXCLIEN,
            SSMOKING = result.SSMOKING,
            SCUIT = result.SCUIT,
            NTITLE = result.NTITLE,
            NUSERCODE = result.NUSERCODE,
            NWEIGHT = result.NWEIGHT,
            SAUTO_CHAR = result.SAUTO_CHAR,
            SCREDIT_CARD = result.SCREDIT_CARD,
            NECONOMIC_L = result.NECONOMIC_L,
            NEMPL_QUA = result.NEMPL_QUA,
            NIMAGENUM = result.NIMAGENUM,
            NPERSON_TYP = result.NPERSON_TYP,
            NAREA = result.NAREA,
            DDRIVEXPDAT = result.DDRIVEXPDAT,
            NTYPDRIVER = result.NTYPDRIVER,
            NDISABILITY = result.NDISABILITY,
            NLIMITDRIV = result.NLIMITDRIV,
            SLEGALNAME = result.SLEGALNAME,
            SLASTNAME2 = result.SLASTNAME2,
            NHEALTH_ORG = result.NHEALTH_ORG,
            NAFP = result.NAFP,
            DWEDD = result.DWEDD,
            SBILL_IND = result.SBILL_IND,
            NINCAPACITY = result.NINCAPACITY,
            DINCAPACITY = result.DINCAPACITY,
            NINCAP_COD = result.NINCAP_COD,
            NNATIONALITY = result.NNATIONALITY,
            SDIGIT = result.SDIGIT,
            DRETIREMENT = result.DRETIREMENT,
            DINDEPENDANT = result.DINDEPENDANT,
            DDEPENDANT = result.DDEPENDANT,
            NMAILINGPREF = result.NMAILINGPREF,
            NLANGUAGE = result.NLANGUAGE,
            NSPECIALITY = result.NSPECIALITY,
            NCOMP_TYPE = result.NCOMP_TYPE,
            SCLIENAME = result.SCLIENAME,
            SLEDGERPROCESS = result.SLEDGERPROCESS,
            SCOMPLCOD = result.SCOMPLCOD,
            NTYPECOMPANY = result.NTYPECOMPANY,
            SFATCA = result.SFATCA,
            SCLIENTPEP = result.SCLIENTPEP,
            SUSPERSON = result.SUSPERSON,
            NADDRESSID = result.NADDRESSID,
            NPHONEID = result.NPHONEID,
            SCRS = result.SCRS,
            SMARRIEDSURNAME = result.SMARRIEDSURNAME,
            SSPOUSENAME = result.SSPOUSENAME,
            SOTHERTITLE = result.SOTHERTITLE,
            SOTHERSPECIALITY = result.SOTHERSPECIALITY,
            NRESIDENCECOUNTRY = result.NRESIDENCECOUNTRY,
            NBIRTHCOUNTRY = result.NBIRTHCOUNTRY,
            NPOSITION_CLI = result.NPOSITION_CLI,
        };
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_RESP_CLEAR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_RESP_CLEARDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_RESP_CLEAR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_RESP_CLEAR/Delete.cshtml", result);
    }

    // POST: CLIENT_RESP_CLEAR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
