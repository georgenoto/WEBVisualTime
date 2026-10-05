using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_ORD_CONCEPTS;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE295;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE187;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CHEQUESController : Controller
{
    private readonly ICHEQUESService _service;
    private readonly IPAY_ORD_CONCEPTSService _PAY_ORD_CONCEPTSService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE295Service _TABLE295Service;
    private readonly ITABLE193Service _TABLE193Service;
    private readonly ITABLE187Service _TABLE187Service;
    private readonly IBANK_ACCService _BANK_ACCService;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ITABLE5570Service _TABLE5570Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly IAGENCIESService _AGENCIESService;

    public CHEQUESController(ICHEQUESService service
        , IPAY_ORD_CONCEPTSService PAY_ORD_CONCEPTSService
        , ICLIENTService CLIENTService
        , ITABLE75Service TABLE75Service
        , ICLAIMService CLAIMService
        , ITABLE295Service TABLE295Service
        , ITABLE193Service TABLE193Service
        , ITABLE187Service TABLE187Service
        , IBANK_ACCService BANK_ACCService
        , ICOLFORMREFService COLFORMREFService
        , ITABLE9Service TABLE9Service
        , ITABLE5001Service TABLE5001Service
        , ITABLE5570Service TABLE5570Service
        , ITABLE5556Service TABLE5556Service
        , IAGENCIESService AGENCIESService
    )
    {
        _service = service;
        _PAY_ORD_CONCEPTSService = PAY_ORD_CONCEPTSService;
        _CLIENTService = CLIENTService;
        _TABLE75Service = TABLE75Service;
        _CLAIMService = CLAIMService;
        _TABLE295Service = TABLE295Service;
        _TABLE193Service = TABLE193Service;
        _TABLE187Service = TABLE187Service;
        _BANK_ACCService = BANK_ACCService;
        _COLFORMREFService = COLFORMREFService;
        _TABLE9Service = TABLE9Service;
        _TABLE5001Service = TABLE5001Service;
        _TABLE5570Service = TABLE5570Service;
        _TABLE5556Service = TABLE5556Service;
        _AGENCIESService = AGENCIESService;
    }

    // GET: CHEQUES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CHEQUES/Index.cshtml", result);
    }

    // GET: CHEQUES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQUES/Details.cshtml", result);
    }

    // GET: CHEQUES/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePAY_ORD_CONCEPTSDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE295DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE187DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        return View("~/Views/Insudb/CHEQUES/Create.cshtml", new CreateCHEQUESDto());
    }

    // POST: CHEQUES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCHEQUESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePAY_ORD_CONCEPTSDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE295DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE187DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        return View("~/Views/Insudb/CHEQUES/Create.cshtml", createDto);
    }

    // GET: CHEQUES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCHEQUESDto
        {
            NREQUEST_NU = result.NREQUEST_NU,
            SCHEQUE = result.SCHEQUE,
            NCONSEC = result.NCONSEC,
            NCONCEPT = result.NCONCEPT,
            NAMOUNT = result.NAMOUNT,
            SCLIENT = result.SCLIENT,
            NBRANCH_LED = result.NBRANCH_LED,
            NCLAIM = result.NCLAIM,
            DCOMPDATE = result.DCOMPDATE,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NVOUCHER = result.NVOUCHER,
            DDAT_PROPOS = result.DDAT_PROPOS,
            SDESCRIPT = result.SDESCRIPT,
            DISSUE_DAT = result.DISSUE_DAT,
            DLEDGER_DAT = result.DLEDGER_DAT,
            NNULLCODE = result.NNULLCODE,
            DNULLDATE = result.DNULLDATE,
            SPAY_FREQ = result.SPAY_FREQ,
            NQ_PAYS = result.NQ_PAYS,
            NRECEIPT = result.NRECEIPT,
            SREQUEST_TY = result.SREQUEST_TY,
            NSTA_CHEQUE = result.NSTA_CHEQUE,
            DSTAT_DATE = result.DSTAT_DATE,
            NTRANSAC = result.NTRANSAC,
            NUSER_SOL = result.NUSER_SOL,
            NUSERCODE = result.NUSERCODE,
            NYEAR_MONTH = result.NYEAR_MONTH,
            NACC_BANK = result.NACC_BANK,
            NBORDEREAUX = result.NBORDEREAUX,
            NNOTENUM = result.NNOTENUM,
            NAFECT = result.NAFECT,
            NEXENT = result.NEXENT,
            NTAXCODE = result.NTAXCODE,
            NTAX_AMOUNT = result.NTAX_AMOUNT,
            NOFFICE = result.NOFFICE,
            NCASHNUM = result.NCASHNUM,
            NINSUR_AREA = result.NINSUR_AREA,
            NPAYORDBORD = result.NPAYORDBORD,
            NCOMPANY = result.NCOMPANY,
            SINTER_PAY = result.SINTER_PAY,
            NAMOUNT_LOCAL = result.NAMOUNT_LOCAL,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            SFILE_FIN700 = result.SFILE_FIN700,
            DDATE_FIN700 = result.DDATE_FIN700,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NDOCSUPPORT = result.NDOCSUPPORT,
            NTAX_PERCENT = result.NTAX_PERCENT,
            NCURRENCYORI = result.NCURRENCYORI,
            NCURRENCYPAY = result.NCURRENCYPAY,
            NAMOUNTPAY = result.NAMOUNTPAY,
            DPOSTED = result.DPOSTED,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            NORDPAY_REL = result.NORDPAY_REL,
            NNUM_RELPAY = result.NNUM_RELPAY,
            SINDPROCES = result.SINDPROCES,
            SACCOUNTHOLDER = result.SACCOUNTHOLDER,
            NBANKEXT = result.NBANKEXT,
            SBANKACCOUNT = result.SBANKACCOUNT,
            NPAY_COMM = result.NPAY_COMM,
            NACC_TYPE = result.NACC_TYPE,
            NID_EXTERNALSYSTEM = result.NID_EXTERNALSYSTEM,
            NEXTERNAL_CONCEPT = result.NEXTERNAL_CONCEPT,
        };
        await PopulatePAY_ORD_CONCEPTSDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE295DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE187DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        return View("~/Views/Insudb/CHEQUES/Edit.cshtml", updateDto);
    }

    // POST: CHEQUES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCHEQUESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NREQUEST_NU, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePAY_ORD_CONCEPTSDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE295DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE187DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        return View("~/Views/Insudb/CHEQUES/Edit.cshtml", updateDto);
    }

    // GET: CHEQUES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQUES/Delete.cshtml", result);
    }

    // POST: CHEQUES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePAY_ORD_CONCEPTSDropdownAsync()
    {
        var items = await _PAY_ORD_CONCEPTSService.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(PAY_ORD_CONCEPTSDto.NCONCEPT), "SSTATREGT");
        ViewData["NCOMPANY"] = new SelectList(items, nameof(PAY_ORD_CONCEPTSDto.NCOMPANY), "SSTATREGT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE295DropdownAsync()
    {
        var items = await _TABLE295Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE295Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE193DropdownAsync()
    {
        var items = await _TABLE193Service.GetAllAsync();
        ViewData["SREQUEST_TY"] = new SelectList(items, nameof(TABLE193Dto.SREQUEST_TY), "SDESCRIPT");
    }

    private async Task PopulateTABLE187DropdownAsync()
    {
        var items = await _TABLE187Service.GetAllAsync();
        ViewData["NSTA_CHEQUE"] = new SelectList(items, nameof(TABLE187Dto.NSTA_CHEQUE), "SDESCRIPT");
    }

    private async Task PopulateBANK_ACCDropdownAsync()
    {
        var items = await _BANK_ACCService.GetAllAsync();
        ViewData["NACC_BANK"] = new SelectList(items, nameof(BANK_ACCDto.NACC_BANK), "SACC_LEDGER");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NTYPESUPPORT"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateAGENCIESDropdownAsync()
    {
        var items = await _AGENCIESService.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(AGENCIESDto.NAGENCY), "SPAY");
    }

}
