using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSURAN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5531;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REINSURANController : Controller
{
    private readonly IREINSURANService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE173Service _TABLE173Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE5531Service _TABLE5531Service;

    public REINSURANController(IREINSURANService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE5000Service TABLE5000Service
        , ITABLE173Service TABLE173Service
        , ICLIENTService CLIENTService
        , ICOMPANYService COMPANYService
        , ITABLE5531Service TABLE5531Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5000Service = TABLE5000Service;
        _TABLE173Service = TABLE173Service;
        _CLIENTService = CLIENTService;
        _COMPANYService = COMPANYService;
        _TABLE5531Service = TABLE5531Service;
    }

    // GET: REINSURAN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REINSURAN/Index.cshtml");

    // GET: REINSURAN/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSURAN/Details.cshtml", result);
    }

    // GET: REINSURAN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE173DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5531DropdownAsync();
        return View("~/Views/Insudb/REINSURAN/Create.cshtml", new CreateREINSURANDto());
    }

    // POST: REINSURAN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREINSURANDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE173DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5531DropdownAsync();
        return View("~/Views/Insudb/REINSURAN/Create.cshtml", createDto);
    }

    // GET: REINSURAN/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREINSURANDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NBRANCH_REI = result.NBRANCH_REI,
            NMODULEC = result.NMODULEC,
            NTYPE_REIN = result.NTYPE_REIN,
            SCLIENT = result.SCLIENT,
            NCOVER = result.NCOVER,
            DEFFECDATE = result.DEFFECDATE,
            NCOMPANY = result.NCOMPANY,
            DACCEDATE = result.DACCEDATE,
            NCAPITAL = result.NCAPITAL,
            NCOMMISSI = result.NCOMMISSI,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            SHEAP_CODE = result.SHEAP_CODE,
            NINTER_RATE = result.NINTER_RATE,
            DNULLDATE = result.DNULLDATE,
            NNUMBER = result.NNUMBER,
            NRESER_RATE = result.NRESER_RATE,
            NSHARE = result.NSHARE,
            NUSERCODE = result.NUSERCODE,
            NCHANGE = result.NCHANGE,
            NACEP_CODE = result.NACEP_CODE,
            SMANUALMOV = result.SMANUALMOV,
            NCAPITAL_REI = result.NCAPITAL_REI,
            NORDEN = result.NORDEN,
            NSHARE_REI = result.NSHARE_REI,
            NPREMIUM_AGREE = result.NPREMIUM_AGREE,
            NEXCESS = result.NEXCESS,
            NRETENTION = result.NRETENTION,
            NSPCPRIORITY = result.NSPCPRIORITY,
            NCOMPANYBROKER = result.NCOMPANYBROKER,
            NFACPERCENTREQ = result.NFACPERCENTREQ,
            NFACBRANCH_REIREQ = result.NFACBRANCH_REIREQ,
            NFACPERCENTREQ_COV = result.NFACPERCENTREQ_COV,
            NCOVAPPSCOPE = result.NCOVAPPSCOPE,
            NLIMITFROM = result.NLIMITFROM,
            NLIMIT = result.NLIMIT,
            NAGGREGATELIMIT = result.NAGGREGATELIMIT,
            NPERCENT = result.NPERCENT,
            NAMOUNT_CONT = result.NAMOUNT_CONT,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE173DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5531DropdownAsync();
        return View("~/Views/Insudb/REINSURAN/Edit.cshtml", updateDto);
    }

    // POST: REINSURAN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREINSURANDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE173DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5531DropdownAsync();
        return View("~/Views/Insudb/REINSURAN/Edit.cshtml", updateDto);
    }

    // GET: REINSURAN/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSURAN/Delete.cshtml", result);
    }

    // POST: REINSURAN/Delete/{id}
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

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE173DropdownAsync()
    {
        var items = await _TABLE173Service.GetAllAsync();
        ViewData["NTYPE_REIN"] = new SelectList(items, nameof(TABLE173Dto.NTYPE_REIN), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE5531DropdownAsync()
    {
        var items = await _TABLE5531Service.GetAllAsync();
        ViewData["NCHANGE"] = new SelectList(items, nameof(TABLE5531Dto.NCHANGE), "SDESCRIPT");
    }

}
