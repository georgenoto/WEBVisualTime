using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_M_COVER;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRPROC;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE534;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_CESController : Controller
{
    private readonly ICLAIM_CESService _service;
    private readonly ICL_M_COVERService _CL_M_COVERService;
    private readonly ICONTRPROCService _CONTRPROCService;
    private readonly ITABLE140Service _TABLE140Service;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE534Service _TABLE534Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE5001Service _TABLE5001Service;

    public CLAIM_CESController(ICLAIM_CESService service
        , ICL_M_COVERService CL_M_COVERService
        , ICONTRPROCService CONTRPROCService
        , ITABLE140Service TABLE140Service
        , ICOMPANYService COMPANYService
        , ITABLE534Service TABLE534Service
        , ITABLE75Service TABLE75Service
        , ITABLE5001Service TABLE5001Service
    )
    {
        _service = service;
        _CL_M_COVERService = CL_M_COVERService;
        _CONTRPROCService = CONTRPROCService;
        _TABLE140Service = TABLE140Service;
        _COMPANYService = COMPANYService;
        _TABLE534Service = TABLE534Service;
        _TABLE75Service = TABLE75Service;
        _TABLE5001Service = TABLE5001Service;
    }

    // GET: CLAIM_CES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_CES/Index.cshtml", result);
    }

    // GET: CLAIM_CES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CES/Details.cshtml", result);
    }

    // GET: CLAIM_CES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCL_M_COVERDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE534DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CES/Create.cshtml", new CreateCLAIM_CESDto());
    }

    // POST: CLAIM_CES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_CESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCL_M_COVERDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE534DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CES/Create.cshtml", createDto);
    }

    // GET: CLAIM_CES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_CESDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NID = result.NID,
            NTRANSAC = result.NTRANSAC,
            NNUMBER = result.NNUMBER,
            NCESS_NU = result.NCESS_NU,
            NBRANCH_REI = result.NBRANCH_REI,
            NNUM_CESS = result.NNUM_CESS,
            NCURRENCY = result.NCURRENCY,
            NCED_AMNT = result.NCED_AMNT,
            NCED_PER = result.NCED_PER,
            NCESS_CONC = result.NCESS_CONC,
            NCOMPANY = result.NCOMPANY,
            NCESS_TYPE = result.NCESS_TYPE,
            DCOMPDATE = result.DCOMPDATE,
            DEND_DATE = result.DEND_DATE,
            DINIT_DATE = result.DINIT_DATE,
            DOCCURDATE = result.DOCCURDATE,
            NPOLICY = result.NPOLICY,
            SPRINT_C = result.SPRINT_C,
            NUSERCODE = result.NUSERCODE,
            DEFFECDATE = result.DEFFECDATE,
            NBRANCH_LED = result.NBRANCH_LED,
            NMODULEC = result.NMODULEC,
            NINSUR_AREA = result.NINSUR_AREA,
            SCLIENT = result.SCLIENT,
            NCOVER = result.NCOVER,
            NYEARMONTH = result.NYEARMONTH,
            NGROUP_INSU = result.NGROUP_INSU,
            NTYPE = result.NTYPE,
            SSTACLAIM = result.SSTACLAIM,
            NRET_AMNT = result.NRET_AMNT,
            NCLA_AMNT = result.NCLA_AMNT,
            DCLAIM_PAY = result.DCLAIM_PAY,
            DLEDGERDAT = result.DLEDGERDAT,
            DPOSTED = result.DPOSTED,
        };
        await PopulateCL_M_COVERDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE534DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CES/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_CES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_CESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCL_M_COVERDropdownAsync();
        await PopulateCONTRPROCDropdownAsync();
        await PopulateTABLE140DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE534DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CES/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_CES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CES/Delete.cshtml", result);
    }

    // POST: CLAIM_CES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCL_M_COVERDropdownAsync()
    {
        var items = await _CL_M_COVERService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CL_M_COVERDto.NCLAIM), "SAUT_ADJUST");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CL_M_COVERDto.NCASE_NUM), "SAUT_ADJUST");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CL_M_COVERDto.NDEMAN_TYPE), "SAUT_ADJUST");
        ViewData["NTRANSAC"] = new SelectList(items, nameof(CL_M_COVERDto.NTRANSAC), "SAUT_ADJUST");
        ViewData["NCURRENCY"] = new SelectList(items, nameof(CL_M_COVERDto.NCURRENCY), "SAUT_ADJUST");
        ViewData["NMODULEC"] = new SelectList(items, nameof(CL_M_COVERDto.NMODULEC), "SAUT_ADJUST");
        ViewData["SCLIENT"] = new SelectList(items, nameof(CL_M_COVERDto.SCLIENT), "SAUT_ADJUST");
        ViewData["NCOVER"] = new SelectList(items, nameof(CL_M_COVERDto.NCOVER), "SAUT_ADJUST");
    }

    private async Task PopulateCONTRPROCDropdownAsync()
    {
        var items = await _CONTRPROCService.GetAllAsync();
        ViewData["NNUMBER"] = new SelectList(items, nameof(CONTRPROCDto.NNUMBER), "SCAP_NOM_RI");
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(CONTRPROCDto.NBRANCH), "SCAP_NOM_RI");
        ViewData["DEFFECDATE"] = new SelectList(items, nameof(CONTRPROCDto.DEFFECDATE), "SCAP_NOM_RI");
        ViewData["NTYPE"] = new SelectList(items, nameof(CONTRPROCDto.NTYPE), "SCAP_NOM_RI");
    }

    private async Task PopulateTABLE140DropdownAsync()
    {
        var items = await _TABLE140Service.GetAllAsync();
        ViewData["NCESS_CONC"] = new SelectList(items, nameof(TABLE140Dto.NOPER_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE534DropdownAsync()
    {
        var items = await _TABLE534Service.GetAllAsync();
        ViewData["NCESS_TYPE"] = new SelectList(items, nameof(TABLE534Dto.NCESS_TYPE), "SDESCRIPT");
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

}
