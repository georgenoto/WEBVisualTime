using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_MOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE296;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_DRA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BANK_MOVController : Controller
{
    private readonly IBANK_MOVService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE22Service _TABLE22Service;
    private readonly IBANK_ACCService _BANK_ACCService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE296Service _TABLE296Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ICLAIMService _CLAIMService;
    private readonly IFINANC_DRAService _FINANC_DRAService;
    private readonly ITABLE400Service _TABLE400Service;

    public BANK_MOVController(IBANK_MOVService service
        , ICOLFORMREFService COLFORMREFService
        , ITABLE22Service TABLE22Service
        , IBANK_ACCService BANK_ACCService
        , ICLIENTService CLIENTService
        , ITABLE296Service TABLE296Service
        , IINTERMEDIAService INTERMEDIAService
        , ICLAIMService CLAIMService
        , IFINANC_DRAService FINANC_DRAService
        , ITABLE400Service TABLE400Service
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
        _TABLE22Service = TABLE22Service;
        _BANK_ACCService = BANK_ACCService;
        _CLIENTService = CLIENTService;
        _TABLE296Service = TABLE296Service;
        _INTERMEDIAService = INTERMEDIAService;
        _CLAIMService = CLAIMService;
        _FINANC_DRAService = FINANC_DRAService;
        _TABLE400Service = TABLE400Service;
    }

    // GET: BANK_MOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BANK_MOV/Index.cshtml");

    // GET: BANK_MOV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_MOV/Details.cshtml", result);
    }

    // GET: BANK_MOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE296DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/BANK_MOV/Create.cshtml", new CreateBANK_MOVDto());
    }

    // POST: BANK_MOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBANK_MOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE296DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/BANK_MOV/Create.cshtml", createDto);
    }

    // GET: BANK_MOV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBANK_MOVDto
        {
            SDEP_NUMBER = result.SDEP_NUMBER,
            SNULL_MOVEM = result.SNULL_MOVEM,
            SNULL_RECOR = result.SNULL_RECOR,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DDOC_DATE = result.DDOC_DATE,
            NCASH_AMOUN = result.NCASH_AMOUN,
            NCHEQ_AMOUN = result.NCHEQ_AMOUN,
            NMOVEMENT = result.NMOVEMENT,
            NYEAR_MONTH = result.NYEAR_MONTH,
            NBORDEREAUX = result.NBORDEREAUX,
            SDOCNUMBE = result.SDOCNUMBE,
            NCONCEPT = result.NCONCEPT,
            NACC_BANK = result.NACC_BANK,
            SCLIENT = result.SCLIENT,
            NTYPE_MOV = result.NTYPE_MOV,
            NINTERMED = result.NINTERMED,
            NUSERCODE = result.NUSERCODE,
            SNUMFORM = result.SNUMFORM,
            NCLAIM = result.NCLAIM,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            NCOMPANYC = result.NCOMPANYC,
            NVOUCHER = result.NVOUCHER,
            NTYP_ACCO = result.NTYP_ACCO,
            STYPE_ACC = result.STYPE_ACC,
            NCASHNUM = result.NCASHNUM,
            DPOSTED = result.DPOSTED,
            NNOTENUM = result.NNOTENUM,
            NID = result.NID,
            NINSUR_AREA = result.NINSUR_AREA,
            DCOLLECTION = result.DCOLLECTION,
            NPROPONUM = result.NPROPONUM,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            NORI_CURR = result.NORI_CURR,
            NORI_AMOUNT = result.NORI_AMOUNT,
            NSUPPORT_ID = result.NSUPPORT_ID,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NCASH_ID = result.NCASH_ID,
            NCOD_AGREE = result.NCOD_AGREE,
            NBANK_AGREE = result.NBANK_AGREE,
            NINPUTCHANNEL = result.NINPUTCHANNEL,
            NBORDERUSED = result.NBORDERUSED,
            DREALDEP = result.DREALDEP,
            NAMOUNTDEC = result.NAMOUNTDEC,
            DVALUEDATE = result.DVALUEDATE,
        };
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE296DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/BANK_MOV/Edit.cshtml", updateDto);
    }

    // POST: BANK_MOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateBANK_MOVDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE296DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/BANK_MOV/Edit.cshtml", updateDto);
    }

    // GET: BANK_MOV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_MOV/Delete.cshtml", result);
    }

    // POST: BANK_MOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE22DropdownAsync()
    {
        var items = await _TABLE22Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE22Dto.NCONCEPT), "SDESCRIPT");
    }

    private async Task PopulateBANK_ACCDropdownAsync()
    {
        var items = await _BANK_ACCService.GetAllAsync();
        ViewData["NACC_BANK"] = new SelectList(items, nameof(BANK_ACCDto.NACC_BANK), "SACC_LEDGER");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE296DropdownAsync()
    {
        var items = await _TABLE296Service.GetAllAsync();
        ViewData["NTYPE_MOV"] = new SelectList(items, nameof(TABLE296Dto.NTYPE_MOV), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateFINANC_DRADropdownAsync()
    {
        var items = await _FINANC_DRAService.GetAllAsync();
        ViewData["NCONTRAT"] = new SelectList(items, nameof(FINANC_DRADto.NCONTRAT), "SINDCHEQUE");
        ViewData["NDRAFT"] = new SelectList(items, nameof(FINANC_DRADto.NDRAFT), "SINDCHEQUE");
    }

    private async Task PopulateTABLE400DropdownAsync()
    {
        var items = await _TABLE400Service.GetAllAsync();
        ViewData["NTYP_ACCO"] = new SelectList(items, nameof(TABLE400Dto.NTYP_ACCO), "SDESCRIPT");
    }

}
