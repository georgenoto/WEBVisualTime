using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE165;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WAITPO;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class POLICY_HISController : Controller
{
    private readonly IPOLICY_HISService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE165Service _TABLE165Service;
    private readonly ITAB_WAITPOService _TAB_WAITPOService;
    private readonly ITABLE5526Service _TABLE5526Service;
    private readonly INOCONVERSService _NOCONVERSService;
    private readonly IAGREEMENTService _AGREEMENTService;

    public POLICY_HISController(IPOLICY_HISService service
        , ICERTIFICATService CERTIFICATService
        , ICLAIMService CLAIMService
        , ITABLE165Service TABLE165Service
        , ITAB_WAITPOService TAB_WAITPOService
        , ITABLE5526Service TABLE5526Service
        , INOCONVERSService NOCONVERSService
        , IAGREEMENTService AGREEMENTService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLAIMService = CLAIMService;
        _TABLE165Service = TABLE165Service;
        _TAB_WAITPOService = TAB_WAITPOService;
        _TABLE5526Service = TABLE5526Service;
        _NOCONVERSService = NOCONVERSService;
        _AGREEMENTService = AGREEMENTService;
    }

    // GET: POLICY_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/POLICY_HIS/Index.cshtml");

    // GET: POLICY_HIS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_HIS/Details.cshtml", result);
    }

    // GET: POLICY_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE165DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/POLICY_HIS/Create.cshtml", new CreatePOLICY_HISDto());
    }

    // POST: POLICY_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePOLICY_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE165DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/POLICY_HIS/Create.cshtml", createDto);
    }

    // GET: POLICY_HIS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePOLICY_HISDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMOVEMENT = result.NMOVEMENT,
            DCOMPDATE = result.DCOMPDATE,
            NCLAIM = result.NCLAIM,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            SNULL_MOVE = result.SNULL_MOVE,
            DNULLDATE = result.DNULLDATE,
            NRECEIPT = result.NRECEIPT,
            NTRANSACTIO = result.NTRANSACTIO,
            NTYPE_HIST = result.NTYPE_HIST,
            NUSERCODE = result.NUSERCODE,
            DLEDGERDAT = result.DLEDGERDAT,
            NOFICIAL_P = result.NOFICIAL_P,
            NTYPE_AMEND = result.NTYPE_AMEND,
            NSERV_ORDER = result.NSERV_ORDER,
            NNOTENUM = result.NNOTENUM,
            SINTERMEI = result.SINTERMEI,
            DFER = result.DFER,
            NPROPONUM = result.NPROPONUM,
            NAGENCY = result.NAGENCY,
            NWAIT_CODE = result.NWAIT_CODE,
            NSTATQUOTA = result.NSTATQUOTA,
            NNO_CONVERS = result.NNO_CONVERS,
            NCARTPOL = result.NCARTPOL,
            NNUMCART = result.NNUMCART,
            NPOLREF = result.NPOLREF,
            NCERREF = result.NCERREF,
            NPAYFREQ = result.NPAYFREQ,
            NNULLCODE = result.NNULLCODE,
            SFILE_REPORT = result.SFILE_REPORT,
            SPROCESS_NUM = result.SPROCESS_NUM,
            DSTARPROCESS = result.DSTARPROCESS,
            DENDPROCESS = result.DENDPROCESS,
            SIND_TRANFER = result.SIND_TRANFER,
            SKEY = result.SKEY,
            NSYSTEM = result.NSYSTEM,
            SLOT = result.SLOT,
            NWAY_PAY = result.NWAY_PAY,
            NBILL_DAY = result.NBILL_DAY,
            NCOD_AGREE = result.NCOD_AGREE,
            NNUMCERT = result.NNUMCERT,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE165DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/POLICY_HIS/Edit.cshtml", updateDto);
    }

    // POST: POLICY_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePOLICY_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE165DropdownAsync();
        await PopulateTAB_WAITPODropdownAsync();
        await PopulateTABLE5526DropdownAsync();
        await PopulateNOCONVERSDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/POLICY_HIS/Edit.cshtml", updateDto);
    }

    // GET: POLICY_HIS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_HIS/Delete.cshtml", result);
    }

    // POST: POLICY_HIS/Delete/{id}
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
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE165DropdownAsync()
    {
        var items = await _TABLE165Service.GetAllAsync();
        ViewData["NTYPE_HIST"] = new SelectList(items, nameof(TABLE165Dto.NTYPE_HIST), "SDESCRIPT");
    }

    private async Task PopulateTAB_WAITPODropdownAsync()
    {
        var items = await _TAB_WAITPOService.GetAllAsync();
        ViewData["NWAIT_CODE"] = new SelectList(items, nameof(TAB_WAITPODto.NWAIT_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5526DropdownAsync()
    {
        var items = await _TABLE5526Service.GetAllAsync();
        ViewData["NSTATQUOTA"] = new SelectList(items, nameof(TABLE5526Dto.NSTATQUOTA), "SDESCRIPT");
    }

    private async Task PopulateNOCONVERSDropdownAsync()
    {
        var items = await _NOCONVERSService.GetAllAsync();
        ViewData["NNO_CONVERS"] = new SelectList(items, nameof(NOCONVERSDto.NNO_CONVERS), "SDESCRIPT");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

}
