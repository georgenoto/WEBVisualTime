using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9204;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETTLEMENTController : Controller
{
    private readonly ICLAIM_SETTLEMENTService _service;
    private readonly ITABLE9252Service _TABLE9252Service;
    private readonly ITABLE9251Service _TABLE9251Service;
    private readonly ITABLE9250Service _TABLE9250Service;
    private readonly ITABLE9249Service _TABLE9249Service;
    private readonly ITABLE9203Service _TABLE9203Service;
    private readonly ITABLE9204Service _TABLE9204Service;
    private readonly ITABLE9212Service _TABLE9212Service;
    private readonly ITABLE190Service _TABLE190Service;
    private readonly ITABLE9274Service _TABLE9274Service;

    public CLAIM_SETTLEMENTController(ICLAIM_SETTLEMENTService service
        , ITABLE9252Service TABLE9252Service
        , ITABLE9251Service TABLE9251Service
        , ITABLE9250Service TABLE9250Service
        , ITABLE9249Service TABLE9249Service
        , ITABLE9203Service TABLE9203Service
        , ITABLE9204Service TABLE9204Service
        , ITABLE9212Service TABLE9212Service
        , ITABLE190Service TABLE190Service
        , ITABLE9274Service TABLE9274Service
    )
    {
        _service = service;
        _TABLE9252Service = TABLE9252Service;
        _TABLE9251Service = TABLE9251Service;
        _TABLE9250Service = TABLE9250Service;
        _TABLE9249Service = TABLE9249Service;
        _TABLE9203Service = TABLE9203Service;
        _TABLE9204Service = TABLE9204Service;
        _TABLE9212Service = TABLE9212Service;
        _TABLE190Service = TABLE190Service;
        _TABLE9274Service = TABLE9274Service;
    }

    // GET: CLAIM_SETTLEMENT
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Index.cshtml", result);
    }

    // GET: CLAIM_SETTLEMENT/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Details.cshtml", result);
    }

    // GET: CLAIM_SETTLEMENT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateTABLE9204DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Create.cshtml", new CreateCLAIM_SETTLEMENTDto());
    }

    // POST: CLAIM_SETTLEMENT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETTLEMENTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateTABLE9204DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETTLEMENT/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETTLEMENTDto
        {
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE_REF = result.NEXCHANGE_REF,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NPAYMENT_METHOD = result.NPAYMENT_METHOD,
            NPAYEE = result.NPAYEE,
            NSETTLEMENT_STAT = result.NSETTLEMENT_STAT,
            NSETTLEMENT_CONC = result.NSETTLEMENT_CONC,
            NNOTENUM = result.NNOTENUM,
            NUSER_AMEND = result.NUSER_AMEND,
            NSEQUENCE_ID = result.NSEQUENCE_ID,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTYPELIST = result.NTYPELIST,
            DPEPSEARCH = result.DPEPSEARCH,
            NUSERPEPSEARCH = result.NUSERPEPSEARCH,
            NSEVERITYPEP = result.NSEVERITYPEP,
            NINDAUTHPEP = result.NINDAUTHPEP,
            DPEPSTATUS = result.DPEPSTATUS,
            NUSERUIF = result.NUSERUIF,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            SCLIENT2 = result.SCLIENT2,
            NPROVIDER = result.NPROVIDER,
            SCLIENT_PAYEE = result.SCLIENT_PAYEE,
            DSETTLEMENTDAT = result.DSETTLEMENTDAT,
            DPAYAUTH = result.DPAYAUTH,
            NAMOUNT_ORDEN = result.NAMOUNT_ORDEN,
            NAMOUNT_TOTAL = result.NAMOUNT_TOTAL,
            NAMOUNT_DEDUCOIN = result.NAMOUNT_DEDUCOIN,
            NAMOUNT_VAT = result.NAMOUNT_VAT,
            NAMOUNT_FTT = result.NAMOUNT_FTT,
            NAMOUNT_AGREE = result.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = result.NAMOUNT_ADJUST,
            NSETTLEMENT_PAY = result.NSETTLEMENT_PAY,
            NAMOUNT_VAT_LOSS = result.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = result.NAMOUNT_FTT_LOSS,
            NREQUEST_NU = result.NREQUEST_NU,
            DLEDGERDAT = result.DLEDGERDAT,
            NAMOUNT_BASE = result.NAMOUNT_BASE,
            NBANKEXT = result.NBANKEXT,
            SBANKACCOUNT = result.SBANKACCOUNT,
            NACC_TYPE = result.NACC_TYPE,
            SREFUND = result.SREFUND,
            SCLIENAMEPAYEE = result.SCLIENAMEPAYEE,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            SCLINUMDOCU = result.SCLINUMDOCU,
            NOFFICE = result.NOFFICE,
            SPHONE = result.SPHONE,
            SCELLPHONE = result.SCELLPHONE,
            SEMAIL = result.SEMAIL,
            NUSER_PAYMETHODCREATE = result.NUSER_PAYMETHODCREATE,
            DPAYMETHODCREATE = result.DPAYMETHODCREATE,
            NUSER_PAYMETHODAMEN = result.NUSER_PAYMETHODAMEN,
            DPAYMETHODAMEN = result.DPAYMETHODAMEN,
            NSEQ_IDPAYMENTMETHOD = result.NSEQ_IDPAYMENTMETHOD,
            NUSER_DERIVEDBY = result.NUSER_DERIVEDBY,
            NUSER_AUTHORIZATION = result.NUSER_AUTHORIZATION,
            DNULLDATE = result.DNULLDATE,
            NNULLCODE = result.NNULLCODE,
            NSETTLEMENT_ORIG = result.NSETTLEMENT_ORIG,
            NSEQ_IDLEDGERDOCUM = result.NSEQ_IDLEDGERDOCUM,
            SCLIENT_BENEF = result.SCLIENT_BENEF,
            SCLIENT_REP = result.SCLIENT_REP,
        };
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateTABLE9204DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETTLEMENT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_SETTLEMENTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSETTLEMENT_NUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateTABLE9204DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETTLEMENT/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETTLEMENT/Delete.cshtml", result);
    }

    // POST: CLAIM_SETTLEMENT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLAIM_SETTLEMENT/GetByNSETTLEMENT_CONC?NSETTLEMENT_CONC=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNSETTLEMENT_CONC(int NSETTLEMENT_CONC)
    {
        var items = await _service.FindAsync(p => p.NSETTLEMENT_CONC == NSETTLEMENT_CONC);
        return Json(items.Select(i => new { value = i.NSETTLEMENT_NUM, text = i.SCLIENT2 }));
    }

    private async Task PopulateTABLE9252DropdownAsync()
    {
        var items = await _TABLE9252Service.GetAllAsync();
        ViewData["NPAYMENT_METHOD"] = new SelectList(items, nameof(TABLE9252Dto.NPAYMENT_METHOD), "SDESCRIPT");
    }

    private async Task PopulateTABLE9251DropdownAsync()
    {
        var items = await _TABLE9251Service.GetAllAsync();
        ViewData["NPAYEE"] = new SelectList(items, nameof(TABLE9251Dto.NPAYEE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9250DropdownAsync()
    {
        var items = await _TABLE9250Service.GetAllAsync();
        ViewData["NSETTLEMENT_STAT"] = new SelectList(items, nameof(TABLE9250Dto.NSETTLEMENT_STAT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9249DropdownAsync()
    {
        var items = await _TABLE9249Service.GetAllAsync();
        ViewData["NSETTLEMENT_CONC"] = new SelectList(items, nameof(TABLE9249Dto.NSETTLEMENT_CONC), "SDESCRIPT");
    }

    private async Task PopulateTABLE9203DropdownAsync()
    {
        var items = await _TABLE9203Service.GetAllAsync();
        ViewData["NTYPELIST"] = new SelectList(items, nameof(TABLE9203Dto.NTYPELIST), "SDESCRIPT");
    }

    private async Task PopulateTABLE9204DropdownAsync()
    {
        var items = await _TABLE9204Service.GetAllAsync();
        ViewData["NSEVERITYPEP"] = new SelectList(items, nameof(TABLE9204Dto.NSEVERITYPEP), "SDESCRIPT");
    }

    private async Task PopulateTABLE9212DropdownAsync()
    {
        var items = await _TABLE9212Service.GetAllAsync();
        ViewData["NCLAIMANTTYPE"] = new SelectList(items, nameof(TABLE9212Dto.NCLAIMANTTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE190DropdownAsync()
    {
        var items = await _TABLE190Service.GetAllAsync();
        ViewData["NACC_TYPE"] = new SelectList(items, nameof(TABLE190Dto.NACC_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9274DropdownAsync()
    {
        var items = await _TABLE9274Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE9274Dto.NNULLCODE), "SDESCRIPT");
    }

}
