using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE199;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE138;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_HISController : Controller
{
    private readonly ICLAIM_HISService _service;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;
    private readonly ITABLE140Service _TABLE140Service;
    private readonly ITABLE199Service _TABLE199Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE138Service _TABLE138Service;
    private readonly ITABLE5570Service _TABLE5570Service;

    public CLAIM_HISController(ICLAIM_HISService service
        , ICLAIM_CASEService CLAIM_CASEService
        , ITABLE140Service TABLE140Service
        , ITABLE199Service TABLE199Service
        , ICLIENTService CLIENTService
        , ICOLFORMREFService COLFORMREFService
        , ITABLE138Service TABLE138Service
        , ITABLE5570Service TABLE5570Service
    )
    {
        _service = service;
        _CLAIM_CASEService = CLAIM_CASEService;
        _TABLE140Service = TABLE140Service;
        _TABLE199Service = TABLE199Service;
        _CLIENTService = CLIENTService;
        _COLFORMREFService = COLFORMREFService;
        _TABLE138Service = TABLE138Service;
        _TABLE5570Service = TABLE5570Service;
    }

    // GET: CLAIM_HIS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_HIS/Index.cshtml", result);
    }

    // GET: CLAIM_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_HIS/Details.cshtml", result);
    }

    // GET: CLAIM_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE199DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE138DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/CLAIM_HIS/Create.cshtml", new CreateCLAIM_HISDto());
    }

    // POST: CLAIM_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE199DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE138DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/CLAIM_HIS/Create.cshtml", createDto);
    }

    // GET: CLAIM_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_HISDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NTRANSAC = result.NTRANSAC,
            NAMOUNT = result.NAMOUNT,
            NOPER_TYPE = result.NOPER_TYPE,
            SCESSICOI = result.SCESSICOI,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            SEXECUTED = result.SEXECUTED,
            NINC_AMOUNT = result.NINC_AMOUNT,
            NINCOMETAX = result.NINCOMETAX,
            SIND_AUT = result.SIND_AUT,
            SIND_ORDER = result.SIND_ORDER,
            SIND_REV = result.SIND_REV,
            NLOC_AMOUNT = result.NLOC_AMOUNT,
            DOPERDATE = result.DOPERDATE,
            SORDER_NUM = result.SORDER_NUM,
            NPAY_TYPE = result.NPAY_TYPE,
            DPOSTED = result.DPOSTED,
            NSERV_ORDER = result.NSERV_ORDER,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SCLIENT = result.SCLIENT,
            NBORDEREAUX = result.NBORDEREAUX,
            NPAY_FORM = result.NPAY_FORM,
            SREINSU_IND = result.SREINSU_IND,
            SCOINSU_IND = result.SCOINSU_IND,
            NCASH_ID = result.NCASH_ID,
            NDOC_TYPE = result.NDOC_TYPE,
            NBILL = result.NBILL,
            DBILL_DATE = result.DBILL_DATE,
            SCO_PAY = result.SCO_PAY,
            NNOTENUM = result.NNOTENUM,
            NID = result.NID,
            SINDMARGIN = result.SINDMARGIN,
            SPAY_RENT = result.SPAY_RENT,
            SIND_TRANFER = result.SIND_TRANFER,
            NPROCEEDINGNUM = result.NPROCEEDINGNUM,
            NTRANSCLAIMREV = result.NTRANSCLAIMREV,
            NDDR = result.NDDR,
            NDEDUCTIBLE_METHOD = result.NDEDUCTIBLE_METHOD,
            SIND_RASA = result.SIND_RASA,
            SINDPROCESS = result.SINDPROCESS,
            NDED_AMOUNT = result.NDED_AMOUNT,
            DBACKUPDATE = result.DBACKUPDATE,
            NRECOVER = result.NRECOVER,
            NRELATION = result.NRELATION,
            NRASA = result.NRASA,
            DCTB_DATE = result.DCTB_DATE,
            SPOSTEDSEQUENCE = result.SPOSTEDSEQUENCE,
            DLEDGERDAT = result.DLEDGERDAT,
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NAMOUNT_BASE = result.NAMOUNT_BASE,
            NAMOUNT_VAT = result.NAMOUNT_VAT,
            NAMOUNT_FTT = result.NAMOUNT_FTT,
            NAMOUNT_AGREE = result.NAMOUNT_AGREE,
            NAMOUNT_ADJUST = result.NAMOUNT_ADJUST,
            NAMOUNT_VAT_LOSS = result.NAMOUNT_VAT_LOSS,
            NAMOUNT_FTT_LOSS = result.NAMOUNT_FTT_LOSS,
            NSETTLEMENT_PAY = result.NSETTLEMENT_PAY,
            NSETTLEMENT_CONC = result.NSETTLEMENT_CONC,
        };
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE199DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE138DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/CLAIM_HIS/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE199DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE138DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        return View("~/Views/Insudb/CLAIM_HIS/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_HIS/Delete.cshtml", result);
    }

    // POST: CLAIM_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_CASEDropdownAsync()
    {
        var items = await _CLAIM_CASEService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCLAIM), "SSTACASE");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCASE_NUM), "SSTACASE");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CLAIM_CASEDto.NDEMAN_TYPE), "SSTACASE");
    }

    private async Task PopulateTABLE140DropdownAsync()
    {
        var items = await _TABLE140Service.GetAllAsync();
        ViewData["NOPER_TYPE"] = new SelectList(items, nameof(TABLE140Dto.NOPER_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE199DropdownAsync()
    {
        var items = await _TABLE199Service.GetAllAsync();
        ViewData["NPAY_TYPE"] = new SelectList(items, nameof(TABLE199Dto.NPAY_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE138DropdownAsync()
    {
        var items = await _TABLE138Service.GetAllAsync();
        ViewData["NPAY_FORM"] = new SelectList(items, nameof(TABLE138Dto.NPAY_FORM), "SDESCRIPT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NDOC_TYPE"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

}
