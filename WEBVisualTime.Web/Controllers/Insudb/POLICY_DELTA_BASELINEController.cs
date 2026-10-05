using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_DELTA_BASELINE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class POLICY_DELTA_BASELINEController : Controller
{
    private readonly IPOLICY_DELTA_BASELINEService _service;
    private readonly ICERTIFICATService _CERTIFICATService;

    public POLICY_DELTA_BASELINEController(IPOLICY_DELTA_BASELINEService service
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: POLICY_DELTA_BASELINE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Index.cshtml", result);
    }

    // GET: POLICY_DELTA_BASELINE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Details.cshtml", result);
    }

    // GET: POLICY_DELTA_BASELINE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Create.cshtml", new CreatePOLICY_DELTA_BASELINEDto());
    }

    // POST: POLICY_DELTA_BASELINE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePOLICY_DELTA_BASELINEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Create.cshtml", createDto);
    }

    // GET: POLICY_DELTA_BASELINE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePOLICY_DELTA_BASELINEDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMOVEMENT = result.NMOVEMENT,
            STYPE = result.STYPE,
            SCLIENT = result.SCLIENT,
            NITEM_CODE = result.NITEM_CODE,
            NCURRENCY = result.NCURRENCY,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM = result.NPREMIUM,
            NPERCENT = result.NPERCENT,
            SSMOKER = result.SSMOKER,
            STYP_RISK = result.STYP_RISK,
            SSTREET = result.SSTREET,
            STYPEOFADDRESS = result.STYPEOFADDRESS,
            SPHONE = result.SPHONE,
            NFUNDS = result.NFUNDS,
            NPAY_WAY = result.NPAY_WAY,
            NTYP_CRECARD = result.NTYP_CRECARD,
            NTYP_ACC = result.NTYP_ACC,
            SACCOUNT = result.SACCOUNT,
            NBANKEXT = result.NBANKEXT,
            SCREDI_CARD = result.SCREDI_CARD,
            DCARDEXPIR = result.DCARDEXPIR,
            SDIRIND = result.SDIRIND,
            DCOMPDATE = result.DCOMPDATE,
            NTYPERISK = result.NTYPERISK,
            NPAYFREQ = result.NPAYFREQ,
            NROLE = result.NROLE,
            NMODULEC = result.NMODULEC,
        };
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Edit.cshtml", updateDto);
    }

    // POST: POLICY_DELTA_BASELINE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePOLICY_DELTA_BASELINEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Edit.cshtml", updateDto);
    }

    // GET: POLICY_DELTA_BASELINE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_DELTA_BASELINE/Delete.cshtml", result);
    }

    // POST: POLICY_DELTA_BASELINE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

}
