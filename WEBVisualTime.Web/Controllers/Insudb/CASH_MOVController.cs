using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_MOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANC_DRA;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5553;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CASH_MOVController : Controller
{
    private readonly ICASH_MOVService _service;
    private readonly ICASH_ACCService _CASH_ACCService;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE22Service _TABLE22Service;
    private readonly IBANK_ACCService _BANK_ACCService;
    private readonly ITABLE183Service _TABLE183Service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ICOMPANYService _COMPANYService;
    private readonly IFINANC_DRAService _FINANC_DRAService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE78Service _TABLE78Service;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE400Service _TABLE400Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5553Service _TABLE5553Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly IAGREEMENTService _AGREEMENTService;
    private readonly ITABLE5554Service _TABLE5554Service;
    private readonly ITABLE5570Service _TABLE5570Service;
    private readonly ITABLE5576Service _TABLE5576Service;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;

    public CASH_MOVController(ICASH_MOVService service
        , ICASH_ACCService CASH_ACCService
        , ICLAIMService CLAIMService
        , ITABLE22Service TABLE22Service
        , IBANK_ACCService BANK_ACCService
        , ITABLE183Service TABLE183Service
        , ITABLE7Service TABLE7Service
        , ITABLE75Service TABLE75Service
        , ICOMPANYService COMPANYService
        , IFINANC_DRAService FINANC_DRAService
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE78Service TABLE78Service
        , ICOLFORMREFService COLFORMREFService
        , ITABLE400Service TABLE400Service
        , ICLIENTService CLIENTService
        , ITABLE5553Service TABLE5553Service
        , ITABLE5001Service TABLE5001Service
        , IAGREEMENTService AGREEMENTService
        , ITABLE5554Service TABLE5554Service
        , ITABLE5570Service TABLE5570Service
        , ITABLE5576Service TABLE5576Service
        , ICLAIM_CASEService CLAIM_CASEService
    )
    {
        _service = service;
        _CASH_ACCService = CASH_ACCService;
        _CLAIMService = CLAIMService;
        _TABLE22Service = TABLE22Service;
        _BANK_ACCService = BANK_ACCService;
        _TABLE183Service = TABLE183Service;
        _TABLE7Service = TABLE7Service;
        _TABLE75Service = TABLE75Service;
        _COMPANYService = COMPANYService;
        _FINANC_DRAService = FINANC_DRAService;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE78Service = TABLE78Service;
        _COLFORMREFService = COLFORMREFService;
        _TABLE400Service = TABLE400Service;
        _CLIENTService = CLIENTService;
        _TABLE5553Service = TABLE5553Service;
        _TABLE5001Service = TABLE5001Service;
        _AGREEMENTService = AGREEMENTService;
        _TABLE5554Service = TABLE5554Service;
        _TABLE5570Service = TABLE5570Service;
        _TABLE5576Service = TABLE5576Service;
        _CLAIM_CASEService = CLAIM_CASEService;
    }

    // GET: CASH_MOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CASH_MOV/Index.cshtml");

    // GET: CASH_MOV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_MOV/Details.cshtml", result);
    }

    // GET: CASH_MOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCASH_ACCDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE78DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5553DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5576DropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        return View("~/Views/Insudb/CASH_MOV/Create.cshtml", new CreateCASH_MOVDto());
    }

    // POST: CASH_MOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCASH_MOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCASH_ACCDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE78DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5553DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5576DropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        return View("~/Views/Insudb/CASH_MOV/Create.cshtml", createDto);
    }

    // GET: CASH_MOV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCASH_MOVDto
        {
            NACC_CASH = result.NACC_CASH,
            NOFFICE = result.NOFFICE,
            NCURRENCY = result.NCURRENCY,
            NTRANSAC = result.NTRANSAC,
            NCASHNUM = result.NCASHNUM,
            DEFFECDATE = result.DEFFECDATE,
            NAMOUNT = result.NAMOUNT,
            NCLAIM = result.NCLAIM,
            NCONCEPT = result.NCONCEPT,
            NACC_BANK = result.NACC_BANK,
            NCARD_TYPE = result.NCARD_TYPE,
            NBANK_CODE = result.NBANK_CODE,
            NBRANCH_LED = result.NBRANCH_LED,
            DCARD_EXPIR = result.DCARD_EXPIR,
            SCARD_NUM = result.SCARD_NUM,
            NCL_TRANSAC = result.NCL_TRANSAC,
            NCOMPANYC = result.NCOMPANYC,
            DCOMPDATE = result.DCOMPDATE,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NVOUCHER = result.NVOUCHER,
            NCONTRAT = result.NCONTRAT,
            SDEP_NUMBER = result.SDEP_NUMBER,
            DDOC_DATE = result.DDOC_DATE,
            SDOCNUMBE = result.SDOCNUMBE,
            NDRAFT = result.NDRAFT,
            NEXCHANGE = result.NEXCHANGE,
            NINTERMED = result.NINTERMED,
            NMOV_TYPE = result.NMOV_TYPE,
            SNULL_MOVEM = result.SNULL_MOVEM,
            SNULL_RECOR = result.SNULL_RECOR,
            DNULLDATE = result.DNULLDATE,
            NPAYNUMBE = result.NPAYNUMBE,
            NRECEIPT = result.NRECEIPT,
            NUSERCODE = result.NUSERCODE,
            NYEAR_MONTH = result.NYEAR_MONTH,
            NBORDEREAUX = result.NBORDEREAUX,
            NTYP_ACCO = result.NTYP_ACCO,
            SCLIENT = result.SCLIENT,
            SNUMFORM = result.SNUMFORM,
            SINTER_PAY = result.SINTER_PAY,
            STYPE_ACC = result.STYPE_ACC,
            SDESCRIPT = result.SDESCRIPT,
            NNOTENUM = result.NNOTENUM,
            DLEDGER_DAT = result.DLEDGER_DAT,
            NUSER_SOL = result.NUSER_SOL,
            NCHEQUELOCAT = result.NCHEQUELOCAT,
            NCOMPANY = result.NCOMPANY,
            SPROCESS = result.SPROCESS,
            NINSUR_AREA = result.NINSUR_AREA,
            DPOSTED = result.DPOSTED,
            NCOD_AGREE = result.NCOD_AGREE,
            NINPUTCHANNEL = result.NINPUTCHANNEL,
            DVALDATE = result.DVALDATE,
            SR_DEPNUM = result.SR_DEPNUM,
            NORI_CURR = result.NORI_CURR,
            NORI_AMOUNT = result.NORI_AMOUNT,
            NSUPPORT_ID = result.NSUPPORT_ID,
            NTYPESUPPORT = result.NTYPESUPPORT,
            DCOLLECTION = result.DCOLLECTION,
            NCHEQUE_STAT = result.NCHEQUE_STAT,
            NCASH_ID = result.NCASH_ID,
            NFIN_INT = result.NFIN_INT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NBANK_AGREE = result.NBANK_AGREE,
            NPROPONUM = result.NPROPONUM,
            NBULLETINS = result.NBULLETINS,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NID = result.NID,
            NBORDERUSED = result.NBORDERUSED,
            NAMOUNTDEC = result.NAMOUNTDEC,
        };
        await PopulateCASH_ACCDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE78DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5553DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5576DropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        return View("~/Views/Insudb/CASH_MOV/Edit.cshtml", updateDto);
    }

    // POST: CASH_MOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCASH_MOVDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCASH_ACCDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE22DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateFINANC_DRADropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE78DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5553DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        await PopulateTABLE5554DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5576DropdownAsync();
        await PopulateCLAIM_CASEDropdownAsync();
        return View("~/Views/Insudb/CASH_MOV/Edit.cshtml", updateDto);
    }

    // GET: CASH_MOV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_MOV/Delete.cshtml", result);
    }

    // POST: CASH_MOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCASH_ACCDropdownAsync()
    {
        var items = await _CASH_ACCService.GetAllAsync();
        ViewData["NACC_CASH"] = new SelectList(items, nameof(CASH_ACCDto.NACC_CASH), "SSTATREGT");
        ViewData["NOFFICE"] = new SelectList(items, nameof(CASH_ACCDto.NOFFICE), "SSTATREGT");
        ViewData["NCURRENCY"] = new SelectList(items, nameof(CASH_ACCDto.NCURRENCY), "SSTATREGT");
        ViewData["NCASHNUM"] = new SelectList(items, nameof(CASH_ACCDto.NCASHNUM), "SSTATREGT");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
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

    private async Task PopulateTABLE183DropdownAsync()
    {
        var items = await _TABLE183Service.GetAllAsync();
        ViewData["NCARD_TYPE"] = new SelectList(items, nameof(TABLE183Dto.NCARD_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
        ViewData["NBANK_AGREE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANYC"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateFINANC_DRADropdownAsync()
    {
        var items = await _FINANC_DRAService.GetAllAsync();
        ViewData["NCONTRAT"] = new SelectList(items, nameof(FINANC_DRADto.NCONTRAT), "SINDCHEQUE");
        ViewData["NDRAFT"] = new SelectList(items, nameof(FINANC_DRADto.NDRAFT), "SINDCHEQUE");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE78DropdownAsync()
    {
        var items = await _TABLE78Service.GetAllAsync();
        ViewData["NMOV_TYPE"] = new SelectList(items, nameof(TABLE78Dto.NMOV_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE400DropdownAsync()
    {
        var items = await _TABLE400Service.GetAllAsync();
        ViewData["NTYP_ACCO"] = new SelectList(items, nameof(TABLE400Dto.NTYP_ACCO), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SINTER_PAY"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5553DropdownAsync()
    {
        var items = await _TABLE5553Service.GetAllAsync();
        ViewData["NCHEQUELOCAT"] = new SelectList(items, nameof(TABLE5553Dto.NCHEQUELOCAT), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

    private async Task PopulateTABLE5554DropdownAsync()
    {
        var items = await _TABLE5554Service.GetAllAsync();
        ViewData["NINPUTCHANNEL"] = new SelectList(items, nameof(TABLE5554Dto.NINPUTTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NTYPESUPPORT"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

    private async Task PopulateTABLE5576DropdownAsync()
    {
        var items = await _TABLE5576Service.GetAllAsync();
        ViewData["NCHEQUE_STAT"] = new SelectList(items, nameof(TABLE5576Dto.NCHEQUE_STAT), "SDESCRIPT");
    }

    private async Task PopulateCLAIM_CASEDropdownAsync()
    {
        var items = await _CLAIM_CASEService.GetAllAsync();
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCASE_NUM), "SSTACASE");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CLAIM_CASEDto.NDEMAN_TYPE), "SSTACASE");
    }

}
