using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RELCONCEPTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCEPTS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5642;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_AGREE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RELCONCEPTSController : Controller
{
    private readonly IRELCONCEPTSService _service;
    private readonly ICASH_CONCEPTSService _CASH_CONCEPTSService;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly ITABLE5642Service _TABLE5642Service;
    private readonly IBANK_AGREEService _BANK_AGREEService;
    private readonly ITABLE5570Service _TABLE5570Service;

    public RELCONCEPTSController(IRELCONCEPTSService service
        , ICASH_CONCEPTSService CASH_CONCEPTSService
        , ITABLE11Service TABLE11Service
        , ITABLE5642Service TABLE5642Service
        , IBANK_AGREEService BANK_AGREEService
        , ITABLE5570Service TABLE5570Service
    )
    {
        _service = service;
        _CASH_CONCEPTSService = CASH_CONCEPTSService;
        _TABLE11Service = TABLE11Service;
        _TABLE5642Service = TABLE5642Service;
        _BANK_AGREEService = BANK_AGREEService;
        _TABLE5570Service = TABLE5570Service;
    }

    // GET: RELCONCEPTS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/RELCONCEPTS/Index.cshtml");

    // GET: RELCONCEPTS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELCONCEPTS/Details.cshtml", result);
    }

    // GET: RELCONCEPTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCASH_CONCEPTSDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE5642DropdownAsync();
        await PopulateBANK_AGREEDropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/RELCONCEPTS/Create.cshtml", new CreateRELCONCEPTSDto());
    }

    // POST: RELCONCEPTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRELCONCEPTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCASH_CONCEPTSDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE5642DropdownAsync();
        await PopulateBANK_AGREEDropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/RELCONCEPTS/Create.cshtml", createDto);
    }

    // GET: RELCONCEPTS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRELCONCEPTSDto
        {
            SSEL = result.SSEL,
            NBORDEREAUX = result.NBORDEREAUX,
            NTRANSAC = result.NTRANSAC,
            NCONCEPT = result.NCONCEPT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPROPONUM = result.NPROPONUM,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            NORICURR = result.NORICURR,
            NORIAMOUNT = result.NORIAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
            NEXCHANGE = result.NEXCHANGE,
            DVALDATE = result.DVALDATE,
            NCHANGEDAT = result.NCHANGEDAT,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NBANK_CODE = result.NBANK_CODE,
            NBANK_AGREE = result.NBANK_AGREE,
            NAGREEMENT = result.NAGREEMENT,
            NNOTENUM = result.NNOTENUM,
            NSUPORT_ID = result.NSUPORT_ID,
            NTYPESUPPORT = result.NTYPESUPPORT,
            DCOLLECTION = result.DCOLLECTION,
            NCASH_ID = result.NCASH_ID,
            NMOV_TYPE = result.NMOV_TYPE,
            NTYP_ACCO = result.NTYP_ACCO,
            NINTERMED = result.NINTERMED,
            NCOMPANY = result.NCOMPANY,
            STYPE_BANKAGREE = result.STYPE_BANKAGREE,
            NACCOUNT = result.NACCOUNT,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NBULLETINS = result.NBULLETINS,
            NLOAN = result.NLOAN,
            NBORDEREAUXUSED = result.NBORDEREAUXUSED,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NLOANS = result.NLOANS,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NRELRECOVER = result.NRELRECOVER,
            NRETENTIONTAXCODE = result.NRETENTIONTAXCODE,
            NRETENTIONCODE = result.NRETENTIONCODE,
            NRETENTIONSERIES = result.NRETENTIONSERIES,
            DAUTORIZATIONDATE = result.DAUTORIZATIONDATE,
            DENDINGDATE = result.DENDINGDATE,
            NRETENTION = result.NRETENTION,
            NTAXRETENTION = result.NTAXRETENTION,
            NRETENTIONBASE = result.NRETENTIONBASE,
            NAUTORIZATIONNUMBER = result.NAUTORIZATIONNUMBER,
            NBILLNUM = result.NBILLNUM,
            NTAXAMOU = result.NTAXAMOU,
            NPOLICY = result.NPOLICY,
            NREQUEST_NU = result.NREQUEST_NU,
        };
        await PopulateCASH_CONCEPTSDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE5642DropdownAsync();
        await PopulateBANK_AGREEDropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/RELCONCEPTS/Edit.cshtml", updateDto);
    }

    // POST: RELCONCEPTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateRELCONCEPTSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCASH_CONCEPTSDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE5642DropdownAsync();
        await PopulateBANK_AGREEDropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/RELCONCEPTS/Edit.cshtml", updateDto);
    }

    // GET: RELCONCEPTS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELCONCEPTS/Delete.cshtml", result);
    }

    // POST: RELCONCEPTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCASH_CONCEPTSDropdownAsync()
    {
        var items = await _CASH_CONCEPTSService.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(CASH_CONCEPTSDto.NCONCEPT), "SSTATREGT");
        ViewData["NCOMPANY"] = new SelectList(items, nameof(CASH_CONCEPTSDto.NCOMPANY), "SSTATREGT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NORICURR"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE5642DropdownAsync()
    {
        var items = await _TABLE5642Service.GetAllAsync();
        ViewData["NCHANGEDAT"] = new SelectList(items, nameof(TABLE5642Dto.NCHANGESDAT), "SDESCRIPT");
    }

    private async Task PopulateBANK_AGREEDropdownAsync()
    {
        var items = await _BANK_AGREEService.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(BANK_AGREEDto.NBANK), "SFORMAT");
        ViewData["STYPE_BANKAGREE"] = new SelectList(items, nameof(BANK_AGREEDto.STYPE_BANKAGREE), "SFORMAT");
        ViewData["NACCOUNT"] = new SelectList(items, nameof(BANK_AGREEDto.NACCOUNT), "SFORMAT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NTYPESUPPORT"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

}
