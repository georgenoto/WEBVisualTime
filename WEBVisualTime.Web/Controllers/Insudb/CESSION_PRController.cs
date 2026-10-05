using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CESSION_PR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRPROC;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE533;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CESSION_PRController : Controller
{
    private readonly ICESSION_PRService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICONTRPROCService _CONTRPROCService;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE533Service _TABLE533Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ICLIENTService _CLIENTService;

    public CESSION_PRController(ICESSION_PRService service
        , ICERTIFICATService CERTIFICATService
        , ICONTRPROCService CONTRPROCService
        , ITABLE5000Service TABLE5000Service
        , ICOMPANYService COMPANYService
        , ITABLE533Service TABLE533Service
        , ITABLE75Service TABLE75Service
        , ITABLE5001Service TABLE5001Service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CONTRPROCService = CONTRPROCService;
        _TABLE5000Service = TABLE5000Service;
        _COMPANYService = COMPANYService;
        _TABLE533Service = TABLE533Service;
        _TABLE75Service = TABLE75Service;
        _TABLE5001Service = TABLE5001Service;
        _CLIENTService = CLIENTService;
    }

    // GET: CESSION_PR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CESSION_PR/Index.cshtml", result);
    }

    // GET: CESSION_PR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CESSION_PR/Details.cshtml", result);
    }

    // GET: CESSION_PR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE533DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CESSION_PR/Create.cshtml", new CreateCESSION_PRDto());
    }

    // POST: CESSION_PR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCESSION_PRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE533DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CESSION_PR/Create.cshtml", createDto);
    }

    // GET: CESSION_PR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCESSION_PRDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCESSION_NU = result.NCESSION_NU,
            NNUM_CESS = result.NNUM_CESS,
            NNUMBER = result.NNUMBER,
            NID = result.NID,
            NBRANCH_REI = result.NBRANCH_REI,
            NCOMPANY = result.NCOMPANY,
            NCAPITAL = result.NCAPITAL,
            NCERTIF = result.NCERTIF,
            NCOMMISSION = result.NCOMMISSION,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NCONCEPT = result.NCONCEPT,
            DEXPIRDAT = result.DEXPIRDAT,
            NINTER_RATE = result.NINTER_RATE,
            NPOLICY = result.NPOLICY,
            NPREMIUM = result.NPREMIUM,
            SPRINT_CE = result.SPRINT_CE,
            NRESER_PREM = result.NRESER_PREM,
            SRETENTION = result.SRETENTION,
            NSHARE = result.NSHARE,
            NTYPE_CESSI = result.NTYPE_CESSI,
            NUSERCODE = result.NUSERCODE,
            NEXPENSIV = result.NEXPENSIV,
            NBRANCH_LED = result.NBRANCH_LED,
            NINSUR_AREA = result.NINSUR_AREA,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SCLIENT = result.SCLIENT,
            DEFD_CONTRPROC = result.DEFD_CONTRPROC,
            NYEARMONTH = result.NYEARMONTH,
            NCAPCESS = result.NCAPCESS,
            DSTARTDATE = result.DSTARTDATE,
            NCESSPREM = result.NCESSPREM,
            NCESSEXTRAPR = result.NCESSEXTRAPR,
            NTYPE = result.NTYPE,
            DEFFECDATE = result.DEFFECDATE,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NTRANSAC = result.NTRANSAC,
            NRATE_TAR = result.NRATE_TAR,
            NPREM_TAR = result.NPREM_TAR,
            NINSUAGE = result.NINSUAGE,
            SSMOKING = result.SSMOKING,
            DBIRTHDATE = result.DBIRTHDATE,
            SSEXCLIEN = result.SSEXCLIEN,
            NTYPERISK = result.NTYPERISK,
            NRESERVE = result.NRESERVE,
            DSTART_PROC = result.DSTART_PROC,
            DEND_PROC = result.DEND_PROC,
            NTAXRATE = result.NTAXRATE,
            NFACTOR = result.NFACTOR,
            NRATE_FAC = result.NRATE_FAC,
            NRATE_REA = result.NRATE_REA,
            SEXTRAPREM = result.SEXTRAPREM,
            DINIEXPR = result.DINIEXPR,
            DENDEXPR = result.DENDEXPR,
            NFACTOREXT = result.NFACTOREXT,
            NCODEXTRA = result.NCODEXTRA,
            NPOLYEAR = result.NPOLYEAR,
            DPOSTED = result.DPOSTED,
            SKEY = result.SKEY,
            DCTB_DATE = result.DCTB_DATE,
            SPOSTEDSEQUENCE = result.SPOSTEDSEQUENCE,
            NBILLNUM = result.NBILLNUM,
            SINDPROCESS = result.SINDPROCESS,
            NCTA_X_PAGAR = result.NCTA_X_PAGAR,
            NVALUE_BASERETENCOMM = result.NVALUE_BASERETENCOMM,
            NVALUE_PREMCED = result.NVALUE_PREMCED,
            NVALUE_RETENTAXPRE = result.NVALUE_RETENTAXPRE,
            NVALUE_BASERETENPRECED = result.NVALUE_BASERETENPRECED,
            NVALUE_RETENCOMM = result.NVALUE_RETENCOMM,
            NCOMISSION_IVA = result.NCOMISSION_IVA,
            NUN_PER_REM = result.NUN_PER_REM,
            DLEDGERDAT = result.DLEDGERDAT,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE533DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CESSION_PR/Edit.cshtml", updateDto);
    }

    // POST: CESSION_PR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCESSION_PRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE533DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CESSION_PR/Edit.cshtml", updateDto);
    }

    // GET: CESSION_PR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CESSION_PR/Delete.cshtml", result);
    }

    // POST: CESSION_PR/Delete/{id}
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
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
    }

    private async Task PopulateCONTRPROCDropdownAsync()
    {
        var items = await _CONTRPROCService.GetAllAsync();
        ViewData["NNUMBER"] = new SelectList(items, nameof(CONTRPROCDto.NNUMBER), "SCAP_NOM_RI");
        ViewData["DEFD_CONTRPROC"] = new SelectList(items, nameof(CONTRPROCDto.DEFFECDATE), "SCAP_NOM_RI");
        ViewData["NTYPE"] = new SelectList(items, nameof(CONTRPROCDto.NTYPE), "SCAP_NOM_RI");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE533DropdownAsync()
    {
        var items = await _TABLE533Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE533Dto.NCONCEPT), "SDESCRIPT");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
