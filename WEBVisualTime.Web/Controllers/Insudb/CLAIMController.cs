using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE133;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_MASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIMController : Controller
{
    private readonly ICLAIMService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE132Service _TABLE132Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE136Service _TABLE136Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE135Service _TABLE135Service;
    private readonly ITABLE133Service _TABLE133Service;
    private readonly ICLAIM_MASTERService _CLAIM_MASTERService;
    private readonly ITABLE5604Service _TABLE5604Service;
    private readonly ITABLE15Service _TABLE15Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly IAGENCIESService _AGENCIESService;
    private readonly IPRECLAIMService _PRECLAIMService;
    private readonly ITABLE9212Service _TABLE9212Service;

    public CLAIMController(ICLAIMService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE132Service TABLE132Service
        , ICLIENTService CLIENTService
        , ITABLE136Service TABLE136Service
        , ITABLE9Service TABLE9Service
        , ITABLE135Service TABLE135Service
        , ITABLE133Service TABLE133Service
        , ICLAIM_MASTERService CLAIM_MASTERService
        , ITABLE5604Service TABLE5604Service
        , ITABLE15Service TABLE15Service
        , ITABLE5556Service TABLE5556Service
        , IAGENCIESService AGENCIESService
        , IPRECLAIMService PRECLAIMService
        , ITABLE9212Service TABLE9212Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE132Service = TABLE132Service;
        _CLIENTService = CLIENTService;
        _TABLE136Service = TABLE136Service;
        _TABLE9Service = TABLE9Service;
        _TABLE135Service = TABLE135Service;
        _TABLE133Service = TABLE133Service;
        _CLAIM_MASTERService = CLAIM_MASTERService;
        _TABLE5604Service = TABLE5604Service;
        _TABLE15Service = TABLE15Service;
        _TABLE5556Service = TABLE5556Service;
        _AGENCIESService = AGENCIESService;
        _PRECLAIMService = PRECLAIMService;
        _TABLE9212Service = TABLE9212Service;
    }

    // GET: CLAIM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM/Index.cshtml");

    // GET: CLAIM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM/Details.cshtml", result);
    }

    // GET: CLAIM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE132DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE136DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE133DropdownAsync();
        await PopulateCLAIM_MASTERDropdownAsync();
        await PopulateTABLE5604DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/CLAIM/Create.cshtml", new CreateCLAIMDto());
    }

    // POST: CLAIM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE132DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE136DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE133DropdownAsync();
        await PopulateCLAIM_MASTERDropdownAsync();
        await PopulateTABLE5604DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/CLAIM/Create.cshtml", createDto);
    }

    // GET: CLAIM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIMDto
        {
            NCLAIM = result.NCLAIM,
            SCERTYPE = result.SCERTYPE,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NBRANCH = result.NBRANCH,
            SCLAIMTYP = result.SCLAIMTYP,
            NCAUSECOD = result.NCAUSECOD,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            SCOINSURI = result.SCOINSURI,
            DCOMPDATE = result.DCOMPDATE,
            DDECLADAT = result.DDECLADAT,
            SINS_CLAIM = result.SINS_CLAIM,
            SLEADCIAL = result.SLEADCIAL,
            NLOC_COS_RE = result.NLOC_COS_RE,
            NLOC_OUT_AM = result.NLOC_OUT_AM,
            NLOC_PAY_AM = result.NLOC_PAY_AM,
            NLOC_REC_AM = result.NLOC_REC_AM,
            NLOC_RESERV = result.NLOC_RESERV,
            SMAILNUMB = result.SMAILNUMB,
            NMOVEMENT = result.NMOVEMENT,
            NNOTENUM = result.NNOTENUM,
            NNULLCODE = result.NNULLCODE,
            DOCCURDAT = result.DOCCURDAT,
            NOFFICE = result.NOFFICE,
            NOFFICE_OWN = result.NOFFICE_OWN,
            NOFFICTRA = result.NOFFICTRA,
            DPRESCDAT = result.DPRESCDAT,
            SPRINTED = result.SPRINTED,
            SREINSURI = result.SREINSURI,
            DSHOW_DATE = result.DSHOW_DATE,
            SSHOW_STATU = result.SSHOW_STATU,
            SSTACLAIM = result.SSTACLAIM,
            NUNACCODE = result.NUNACCODE,
            NUSERCODE = result.NUSERCODE,
            SNUMFORM = result.SNUMFORM,
            NTAX_AMO = result.NTAX_AMO,
            NIMAGENUM = result.NIMAGENUM,
            SCESS_NPR = result.SCESS_NPR,
            SCLIENT2 = result.SCLIENT2,
            NBORDEREAUX_CL = result.NBORDEREAUX_CL,
            DLIMIT_PAY = result.DLIMIT_PAY,
            NIDCATAS = result.NIDCATAS,
            NOFFICE_PAY = result.NOFFICE_PAY,
            NWAITCL_CODE = result.NWAITCL_CODE,
            NRELASHIP = result.NRELASHIP,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            NAGENCY_PAY = result.NAGENCY_PAY,
            NOFFICEAGEN_PAY = result.NOFFICEAGEN_PAY,
            NCLAIMPARENT = result.NCLAIMPARENT,
            SUNIQUEID = result.SUNIQUEID,
            DMC_OCCURDAT = result.DMC_OCCURDAT,
            DCOMPLETDATE = result.DCOMPLETDATE,
            DPAYDATE = result.DPAYDATE,
            NIDPRECLAIM = result.NIDPRECLAIM,
            NPRECLAIM = result.NPRECLAIM,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            DPRESENTDATE = result.DPRESENTDATE,
            NIND_REOPENCL = result.NIND_REOPENCL,
            NCAUSEREOPENCL = result.NCAUSEREOPENCL,
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            SHISTORICAL_CLAIM = result.SHISTORICAL_CLAIM,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE132DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE136DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE133DropdownAsync();
        await PopulateCLAIM_MASTERDropdownAsync();
        await PopulateTABLE5604DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/CLAIM/Edit.cshtml", updateDto);
    }

    // POST: CLAIM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE132DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE136DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE133DropdownAsync();
        await PopulateCLAIM_MASTERDropdownAsync();
        await PopulateTABLE5604DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulatePRECLAIMDropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/CLAIM/Edit.cshtml", updateDto);
    }

    // GET: CLAIM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM/Delete.cshtml", result);
    }

    // POST: CLAIM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLAIM/GetBySCERTYPE?SCERTYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCERTYPE(string SCERTYPE)
    {
        var items = await _service.FindAsync(p => p.SCERTYPE == SCERTYPE);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SCOINSURI }));
    }

    // GET: CLAIM/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SCOINSURI }));
    }

    // GET: CLAIM/GetByNNULLCODE?NNULLCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNNULLCODE(int NNULLCODE)
    {
        var items = await _service.FindAsync(p => p.NNULLCODE == NNULLCODE);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SCOINSURI }));
    }

    // GET: CLAIM/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SCOINSURI }));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE132DropdownAsync()
    {
        var items = await _TABLE132Service.GetAllAsync();
        ViewData["SCLAIMTYP"] = new SelectList(items, nameof(TABLE132Dto.SCLAIMTYP), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENT2"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE136DropdownAsync()
    {
        var items = await _TABLE136Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE136Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
        ViewData["NOFFICE_OWN"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
        ViewData["NOFFICTRA"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
        ViewData["NOFFICE_PAY"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE135DropdownAsync()
    {
        var items = await _TABLE135Service.GetAllAsync();
        ViewData["SSTACLAIM"] = new SelectList(items, nameof(TABLE135Dto.SSTACLAIM), "SDESCRIPT");
    }

    private async Task PopulateTABLE133DropdownAsync()
    {
        var items = await _TABLE133Service.GetAllAsync();
        ViewData["NUNACCODE"] = new SelectList(items, nameof(TABLE133Dto.NUNACCODE), "SDESCRIPT");
    }

    private async Task PopulateCLAIM_MASTERDropdownAsync()
    {
        var items = await _CLAIM_MASTERService.GetAllAsync();
        ViewData["NBORDEREAUX_CL"] = new SelectList(items, nameof(CLAIM_MASTERDto.NBORDEREAUX_CL), "SCLIENT");
    }

    private async Task PopulateTABLE5604DropdownAsync()
    {
        var items = await _TABLE5604Service.GetAllAsync();
        ViewData["NWAITCL_CODE"] = new SelectList(items, nameof(TABLE5604Dto.NWAITCL_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE15DropdownAsync()
    {
        var items = await _TABLE15Service.GetAllAsync();
        ViewData["NRELASHIP"] = new SelectList(items, nameof(TABLE15Dto.NRELASHIP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
        ViewData["NOFFICEAGEN_PAY"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateAGENCIESDropdownAsync()
    {
        var items = await _AGENCIESService.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(AGENCIESDto.NAGENCY), "SPAY");
        ViewData["NAGENCY_PAY"] = new SelectList(items, nameof(AGENCIESDto.NAGENCY), "SPAY");
    }

    private async Task PopulatePRECLAIMDropdownAsync()
    {
        var items = await _PRECLAIMService.GetAllAsync();
        ViewData["NIDPRECLAIM"] = new SelectList(items, nameof(PRECLAIMDto.NIDPRECLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE9212DropdownAsync()
    {
        var items = await _TABLE9212Service.GetAllAsync();
        ViewData["NCLAIMANTTYPE"] = new SelectList(items, nameof(TABLE9212Dto.NCLAIMANTTYPE), "SDESCRIPT");
    }

}
