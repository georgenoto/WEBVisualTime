using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TDETAIL_PRE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TDETAIL_PREController : Controller
{
    private readonly ITDETAIL_PREService _service;
    private readonly ITABLE9207Service _TABLE9207Service;

    public TDETAIL_PREController(ITDETAIL_PREService service
        , ITABLE9207Service TABLE9207Service
    )
    {
        _service = service;
        _TABLE9207Service = TABLE9207Service;
    }

    // GET: TDETAIL_PRE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TDETAIL_PRE/Index.cshtml", result);
    }

    // GET: TDETAIL_PRE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TDETAIL_PRE/Details.cshtml", result);
    }

    // GET: TDETAIL_PRE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/TDETAIL_PRE/Create.cshtml", new CreateTDETAIL_PREDto());
    }

    // POST: TDETAIL_PRE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTDETAIL_PREDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/TDETAIL_PRE/Create.cshtml", createDto);
    }

    // GET: TDETAIL_PRE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTDETAIL_PREDto
        {
            SKEY = result.SKEY,
            NCURRENCY = result.NCURRENCY,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            SADDSUINI = result.SADDSUINI,
            NMODULEC = result.NMODULEC,
            NCODE = result.NCODE,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            NTAX = result.NTAX,
            NCAPI_INI = result.NCAPI_INI,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM = result.NPREMIUM,
            NPREMIUM_AN = result.NPREMIUM_AN,
            STYPE_DETAI = result.STYPE_DETAI,
            NP_NOTCONS = result.NP_NOTCONS,
            NP_OUTSTAND = result.NP_OUTSTAND,
            NP_ADJUST = result.NP_ADJUST,
            NPREM_INI = result.NPREM_INI,
            NPREM_ACT = result.NPREM_ACT,
            NCOMMI_ANU = result.NCOMMI_ANU,
            SADDTAX = result.SADDTAX,
            NID_BILL = result.NID_BILL,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NROLE = result.NROLE,
            NTAXIVA = result.NTAXIVA,
            NINSURED = result.NINSURED,
            NGROUP = result.NGROUP,
            NINSUCOUNT = result.NINSUCOUNT,
            NTAXMAR = result.NTAXMAR,
            NAMOUNTIVA = result.NAMOUNTIVA,
            NTAXTARIF = result.NTAXTARIF,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            SSHORT_DES = result.SSHORT_DES,
            SCACALILI = result.SCACALILI,
            SCOMMISSI_I = result.SCOMMISSI_I,
            SADDTAXIN = result.SADDTAXIN,
            NTYPDURINS = result.NTYPDURINS,
            NTYPDURPAY = result.NTYPDURPAY,
            NCOM_NOTCONS = result.NCOM_NOTCONS,
            NCOM_OUTSTAND = result.NCOM_OUTSTAND,
            NPREM_DET = result.NPREM_DET,
            SPREM_DET = result.SPREM_DET,
            NREL_IDCODE = result.NREL_IDCODE,
            NTAXRATE = result.NTAXRATE,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
            NCOM_SUPER = result.NCOM_SUPER,
            NCOMANUAL_SUPER = result.NCOMANUAL_SUPER,
            NCOMSUP_RATE = result.NCOMSUP_RATE,
        };
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/TDETAIL_PRE/Edit.cshtml", updateDto);
    }

    // POST: TDETAIL_PRE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTDETAIL_PREDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/TDETAIL_PRE/Edit.cshtml", updateDto);
    }

    // GET: TDETAIL_PRE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TDETAIL_PRE/Delete.cshtml", result);
    }

    // POST: TDETAIL_PRE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9207DropdownAsync()
    {
        var items = await _TABLE9207Service.GetAllAsync();
        ViewData["NDISSUR_TYPE"] = new SelectList(items, nameof(TABLE9207Dto.NDISSUR_TYPE), "SDESCRIPT");
    }

}
