using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REQUEST;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5527;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5635;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FN_INSTITUTION;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REQUESTController : Controller
{
    private readonly IREQUESTService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5580Service _TABLE5580Service;
    private readonly ITABLE193Service _TABLE193Service;
    private readonly ITABLE13Service _TABLE13Service;
    private readonly ITABLE5527Service _TABLE5527Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5635Service _TABLE5635Service;
    private readonly ITABLE5636Service _TABLE5636Service;
    private readonly ITAB_FN_INSTITUTIONService _TAB_FN_INSTITUTIONService;

    public REQUESTController(IREQUESTService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE5580Service TABLE5580Service
        , ITABLE193Service TABLE193Service
        , ITABLE13Service TABLE13Service
        , ITABLE5527Service TABLE5527Service
        , ICLIENTService CLIENTService
        , ITABLE5635Service TABLE5635Service
        , ITABLE5636Service TABLE5636Service
        , ITAB_FN_INSTITUTIONService TAB_FN_INSTITUTIONService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5580Service = TABLE5580Service;
        _TABLE193Service = TABLE193Service;
        _TABLE13Service = TABLE13Service;
        _TABLE5527Service = TABLE5527Service;
        _CLIENTService = CLIENTService;
        _TABLE5635Service = TABLE5635Service;
        _TABLE5636Service = TABLE5636Service;
        _TAB_FN_INSTITUTIONService = TAB_FN_INSTITUTIONService;
    }

    // GET: REQUEST
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REQUEST/Index.cshtml");

    // GET: REQUEST/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REQUEST/Details.cshtml", result);
    }

    // GET: REQUEST/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE5527DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5635DropdownAsync();
        await PopulateTABLE5636DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/REQUEST/Create.cshtml", new CreateREQUESTDto());
    }

    // POST: REQUEST/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREQUESTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE5527DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5635DropdownAsync();
        await PopulateTABLE5636DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/REQUEST/Create.cshtml", createDto);
    }

    // GET: REQUEST/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREQUESTDto
        {
            SCERTYPE = result.SCERTYPE,
            NORIGIN = result.NORIGIN,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            STYP_SURR = result.STYP_SURR,
            SPAYORDER = result.SPAYORDER,
            SNULL_REC = result.SNULL_REC,
            NAMOUNT = result.NAMOUNT,
            SDESCRIPT = result.SDESCRIPT,
            NNOTENUM = result.NNOTENUM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NNULLCODE = result.NNULLCODE,
            NTYP_REC = result.NTYP_REC,
            SREH_LREC = result.SREH_LREC,
            NINTERESTRATE = result.NINTERESTRATE,
            NTYPEPAY = result.NTYPEPAY,
            DMOVDATE = result.DMOVDATE,
            NREQUEST_NU = result.NREQUEST_NU,
            SCLIPAYSURR = result.SCLIPAYSURR,
            SCERTPAYSURR = result.SCERTPAYSURR,
            NBRAPAYSURR = result.NBRAPAYSURR,
            NPROPAYSURR = result.NPROPAYSURR,
            NPOLPAYSURR = result.NPOLPAYSURR,
            NCERPAYSURR = result.NCERPAYSURR,
            NAGENCY = result.NAGENCY,
            NSURR_REASON = result.NSURR_REASON,
            NTYPE_PAYMENT = result.NTYPE_PAYMENT,
            NINSTITUTION = result.NINSTITUTION,
            SCLIENTINSTITUTION = result.SCLIENTINSTITUTION,
            SRETURN_IND = result.SRETURN_IND,
            NRETURN_RAT = result.NRETURN_RAT,
            NORIGIN_APV = result.NORIGIN_APV,
            NCOSTAMOUNT = result.NCOSTAMOUNT,
            NTAX = result.NTAX,
            NTAX_RENT = result.NTAX_RENT,
            NFUNDS = result.NFUNDS,
            NSIGNAL = result.NSIGNAL,
            NUNITSCHANGE = result.NUNITSCHANGE,
            NCURRENCY = result.NCURRENCY,
            NSELL_COST = result.NSELL_COST,
            NBUY_COST = result.NBUY_COST,
            NSWI_COST = result.NSWI_COST,
            NVALUECHANGE = result.NVALUECHANGE,
            NSWITCHORIGIN = result.NSWITCHORIGIN,
            SSWITCHSTATUS = result.SSWITCHSTATUS,
            SIND_INSUR = result.SIND_INSUR,
            DPAYMENTDATE = result.DPAYMENTDATE,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            NCOST_COV_DEV = result.NCOST_COV_DEV,
            NRENTABILITY = result.NRENTABILITY,
            NAMOUNT_REC_DEV = result.NAMOUNT_REC_DEV,
            NAMOUNT_DEV = result.NAMOUNT_DEV,
            SSWITCHORIGIN = result.SSWITCHORIGIN,
            NPROPONUM = result.NPROPONUM,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE5527DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5635DropdownAsync();
        await PopulateTABLE5636DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/REQUEST/Edit.cshtml", updateDto);
    }

    // POST: REQUEST/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREQUESTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        await PopulateTABLE13DropdownAsync();
        await PopulateTABLE5527DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5635DropdownAsync();
        await PopulateTABLE5636DropdownAsync();
        await PopulateTAB_FN_INSTITUTIONDropdownAsync();
        return View("~/Views/Insudb/REQUEST/Edit.cshtml", updateDto);
    }

    // GET: REQUEST/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REQUEST/Delete.cshtml", result);
    }

    // POST: REQUEST/Delete/{id}
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
        ViewData["SCERTPAYSURR"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRAPAYSURR"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPROPAYSURR"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLPAYSURR"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERPAYSURR"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE5580DropdownAsync()
    {
        var items = await _TABLE5580Service.GetAllAsync();
        ViewData["NORIGIN"] = new SelectList(items, nameof(TABLE5580Dto.NORIGIN), "SDESCRIPT");
    }

    private async Task PopulateTABLE193DropdownAsync()
    {
        var items = await _TABLE193Service.GetAllAsync();
        ViewData["SPAYORDER"] = new SelectList(items, nameof(TABLE193Dto.SREQUEST_TY), "SDESCRIPT");
    }

    private async Task PopulateTABLE13DropdownAsync()
    {
        var items = await _TABLE13Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE13Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5527DropdownAsync()
    {
        var items = await _TABLE5527Service.GetAllAsync();
        ViewData["NTYPEPAY"] = new SelectList(items, nameof(TABLE5527Dto.NTYPEPAY), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIPAYSURR"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENTINSTITUTION"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5635DropdownAsync()
    {
        var items = await _TABLE5635Service.GetAllAsync();
        ViewData["NSURR_REASON"] = new SelectList(items, nameof(TABLE5635Dto.NSURR_REASON), "SDESCRIPT");
    }

    private async Task PopulateTABLE5636DropdownAsync()
    {
        var items = await _TABLE5636Service.GetAllAsync();
        ViewData["NTYPE_PAYMENT"] = new SelectList(items, nameof(TABLE5636Dto.NTYPE_PAYMENT), "SDESCRIPT");
    }

    private async Task PopulateTAB_FN_INSTITUTIONDropdownAsync()
    {
        var items = await _TAB_FN_INSTITUTIONService.GetAllAsync();
        ViewData["NINSTITUTION"] = new SelectList(items, nameof(TAB_FN_INSTITUTIONDto.NINSTITUTION), "SNAME");
    }

}
