using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DETAIL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICALBENEFITS;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_SURCHARGE;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLORDER_DETAILController : Controller
{
    private readonly ICLORDER_DETAILService _service;
    private readonly ICLAIM_ORDERService _CLAIM_ORDERService;
    private readonly ITABLE692Service _TABLE692Service;
    private readonly IMEDICALBENEFITSService _MEDICALBENEFITSService;
    private readonly ITAB_AM_ILLService _TAB_AM_ILLService;
    private readonly ITABLE8603Service _TABLE8603Service;
    private readonly IMEDICAL_SURCHARGEService _MEDICAL_SURCHARGEService;

    public CLORDER_DETAILController(ICLORDER_DETAILService service
        , ICLAIM_ORDERService CLAIM_ORDERService
        , ITABLE692Service TABLE692Service
        , IMEDICALBENEFITSService MEDICALBENEFITSService
        , ITAB_AM_ILLService TAB_AM_ILLService
        , ITABLE8603Service TABLE8603Service
        , IMEDICAL_SURCHARGEService MEDICAL_SURCHARGEService
    )
    {
        _service = service;
        _CLAIM_ORDERService = CLAIM_ORDERService;
        _TABLE692Service = TABLE692Service;
        _MEDICALBENEFITSService = MEDICALBENEFITSService;
        _TAB_AM_ILLService = TAB_AM_ILLService;
        _TABLE8603Service = TABLE8603Service;
        _MEDICAL_SURCHARGEService = MEDICAL_SURCHARGEService;
    }

    // GET: CLORDER_DETAIL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLORDER_DETAIL/Index.cshtml", result);
    }

    // GET: CLORDER_DETAIL/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_DETAIL/Details.cshtml", result);
    }

    // GET: CLORDER_DETAIL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateMEDICALBENEFITSDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        await PopulateMEDICAL_SURCHARGEDropdownAsync();
        return View("~/Views/Insudb/CLORDER_DETAIL/Create.cshtml", new CreateCLORDER_DETAILDto());
    }

    // POST: CLORDER_DETAIL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLORDER_DETAILDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateMEDICALBENEFITSDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        await PopulateMEDICAL_SURCHARGEDropdownAsync();
        return View("~/Views/Insudb/CLORDER_DETAIL/Create.cshtml", createDto);
    }

    // GET: CLORDER_DETAIL/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLORDER_DETAILDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NORDER_NUM = result.NORDER_NUM,
            NDETAIL_ORDER = result.NDETAIL_ORDER,
            NID = result.NID,
            SBENEFIT = result.SBENEFIT,
            VADEMECUM = result.VADEMECUM,
            NQUANTITY = result.NQUANTITY,
            NAMOUNT_DOCU = result.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = result.NAMOUNT_ORDEN,
            NAMOUNT_UNITAMV = result.NAMOUNT_UNITAMV,
            NAMOUNT_UNITRECAL = result.NAMOUNT_UNITRECAL,
            NAMOUNT_TOTAL = result.NAMOUNT_TOTAL,
            NPERCEN_COVERAGE = result.NPERCEN_COVERAGE,
            NAMOUNT_DEDUCOIN = result.NAMOUNT_DEDUCOIN,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NCOD_REJECT = result.NCOD_REJECT,
            NACCEPT_EVALMED = result.NACCEPT_EVALMED,
            NAPPLY_EXCLU = result.NAPPLY_EXCLU,
            SILLNES_DETECT = result.SILLNES_DETECT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBALANCE = result.NBALANCE,
            SREJECTALERT = result.SREJECTALERT,
            SILLNESS = result.SILLNESS,
            NAMOUNT_PAY_POL = result.NAMOUNT_PAY_POL,
            SMEDSPECIALIALTY = result.SMEDSPECIALIALTY,
            NSURCHAR_MED = result.NSURCHAR_MED,
            NPERC_SURCHAR = result.NPERC_SURCHAR,
            NAMOUNT_SURCHAR = result.NAMOUNT_SURCHAR,
            SSECONDVISIT = result.SSECONDVISIT,
            NAMOUNT_UNITAMV_INT = result.NAMOUNT_UNITAMV_INT,
            SMEDICAL_REJEC = result.SMEDICAL_REJEC,
            SREJECTOBSV = result.SREJECTOBSV,
            NMASTERORDER = result.NMASTERORDER,
            NPROCEDURE_ID = result.NPROCEDURE_ID,
            NPERCENTAGE_ROLE = result.NPERCENTAGE_ROLE,
            NIND_DONOTRECALCULATE = result.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = result.NAMOUNT_DIFFERENCETARIFF,
            NAMOUNT_DEDUCTIBLE = result.NAMOUNT_DEDUCTIBLE,
            NAMOUNT_DISCOUNTS = result.NAMOUNT_DISCOUNTS,
            NPERCENT_COV_ORIG = result.NPERCENT_COV_ORIG,
            NTOTALAMOUNT_ORDER = result.NTOTALAMOUNT_ORDER,
        };
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateMEDICALBENEFITSDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        await PopulateMEDICAL_SURCHARGEDropdownAsync();
        return View("~/Views/Insudb/CLORDER_DETAIL/Edit.cshtml", updateDto);
    }

    // POST: CLORDER_DETAIL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLORDER_DETAILDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateMEDICALBENEFITSDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateTABLE8603DropdownAsync();
        await PopulateMEDICAL_SURCHARGEDropdownAsync();
        return View("~/Views/Insudb/CLORDER_DETAIL/Edit.cshtml", updateDto);
    }

    // GET: CLORDER_DETAIL/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_DETAIL/Delete.cshtml", result);
    }

    // POST: CLORDER_DETAIL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_ORDERDropdownAsync()
    {
        var items = await _CLAIM_ORDERService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCLAIM), "STYPECARE");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCASE_NUM), "STYPECARE");
        ViewData["NORDER_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NORDER_NUM), "STYPECARE");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateMEDICALBENEFITSDropdownAsync()
    {
        var items = await _MEDICALBENEFITSService.GetAllAsync();
        ViewData["SBENEFIT"] = new SelectList(items, nameof(MEDICALBENEFITSDto.SBENEFIT), "STYPEBENEFIT");
    }

    private async Task PopulateTAB_AM_ILLDropdownAsync()
    {
        var items = await _TAB_AM_ILLService.GetAllAsync();
        ViewData["SILLNESS"] = new SelectList(items, nameof(TAB_AM_ILLDto.SILLNESS), "SDESCRIPT");
    }

    private async Task PopulateTABLE8603DropdownAsync()
    {
        var items = await _TABLE8603Service.GetAllAsync();
        ViewData["SMEDSPECIALIALTY"] = new SelectList(items, nameof(TABLE8603Dto.SMEDSPECIALIALTY), "SDESCRIPT");
    }

    private async Task PopulateMEDICAL_SURCHARGEDropdownAsync()
    {
        var items = await _MEDICAL_SURCHARGEService.GetAllAsync();
        ViewData["NSURCHAR_MED"] = new SelectList(items, nameof(MEDICAL_SURCHARGEDto.NSURCHAR_MED), "SDESCRIPT");
    }

}
