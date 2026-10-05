using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CASH_MOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_CASH_MOVController : Controller
{
    private readonly IT_CASH_MOVService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITAB_LOCATService _TAB_LOCATService;

    public T_CASH_MOVController(IT_CASH_MOVService service
        , ICOLFORMREFService COLFORMREFService
        , ITAB_LOCATService TAB_LOCATService
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
        _TAB_LOCATService = TAB_LOCATService;
    }

    // GET: T_CASH_MOV
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_CASH_MOV/Index.cshtml", result);
    }

    // GET: T_CASH_MOV/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_CASH_MOV/Details.cshtml", result);
    }

    // GET: T_CASH_MOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/T_CASH_MOV/Create.cshtml", new CreateT_CASH_MOVDto());
    }

    // POST: T_CASH_MOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_CASH_MOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/T_CASH_MOV/Create.cshtml", createDto);
    }

    // GET: T_CASH_MOV/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_CASH_MOVDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NACC_CASH = result.NACC_CASH,
            NLOCAL = result.NLOCAL,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
            SCARD_NUM = result.SCARD_NUM,
            NCARD_TYP = result.NCARD_TYP,
            DDOC_DATE = result.DDOC_DATE,
            SDOCNUMBE = result.SDOCNUMBE,
            NEXCHANGE = result.NEXCHANGE,
            NMOV_TYPE = result.NMOV_TYPE,
            NBANK_CODE = result.NBANK_CODE,
            NCOMPANY = result.NCOMPANY,
            NTRANSAC = result.NTRANSAC,
            NCHEQUELOCAT = result.NCHEQUELOCAT,
            NCASH_NUM = result.NCASH_NUM,
            NOFFICE = result.NOFFICE,
            NCASHNUM = result.NCASHNUM,
            DEFFECDATE = result.DEFFECDATE,
            NCLAIM = result.NCLAIM,
            NCONCEPT = result.NCONCEPT,
            NACC_BANK = result.NACC_BANK,
            NCARD_TYPE = result.NCARD_TYPE,
            NBRANCH_LED = result.NBRANCH_LED,
            DCARD_EXPIR = result.DCARD_EXPIR,
            NCL_TRANSAC = result.NCL_TRANSAC,
            NCOMPANYC = result.NCOMPANYC,
            DCOMPDATE = result.DCOMPDATE,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NVOUCHER = result.NVOUCHER,
            NCONTRAT = result.NCONTRAT,
            SDEP_NUMBER = result.SDEP_NUMBER,
            NDRAFT = result.NDRAFT,
            NINTERMED = result.NINTERMED,
            SNULL_MOVEM = result.SNULL_MOVEM,
            SNULL_RECOR = result.SNULL_RECOR,
            DNULLDATE = result.DNULLDATE,
            NPAYNUMBE = result.NPAYNUMBE,
            NRECEIPT = result.NRECEIPT,
            NUSERCODE = result.NUSERCODE,
            NYEAR_MONTH = result.NYEAR_MONTH,
            NTYP_ACCO = result.NTYP_ACCO,
            SCLIENT = result.SCLIENT,
            SNUMFORM = result.SNUMFORM,
            SINTER_PAY = result.SINTER_PAY,
            STYPE_ACC = result.STYPE_ACC,
            SDESCRIPT = result.SDESCRIPT,
            NNOTENUM = result.NNOTENUM,
            DLEDGER_DAT = result.DLEDGER_DAT,
            NUSER_SQL = result.NUSER_SQL,
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
            NTYPESSUPORT = result.NTYPESSUPORT,
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
            SACTION = result.SACTION,
            NAMOUNTDEC = result.NAMOUNTDEC,
        };
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/T_CASH_MOV/Edit.cshtml", updateDto);
    }

    // POST: T_CASH_MOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_CASH_MOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/T_CASH_MOV/Edit.cshtml", updateDto);
    }

    // GET: T_CASH_MOV/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_CASH_MOV/Delete.cshtml", result);
    }

    // POST: T_CASH_MOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTAB_LOCATDropdownAsync()
    {
        var items = await _TAB_LOCATService.GetAllAsync();
        ViewData["NLOCAL"] = new SelectList(items, nameof(TAB_LOCATDto.NLOCAL), "SDESCRIPT");
    }

}
