using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5561;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5592;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9203;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ROLESController : Controller
{
    private readonly IROLESService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE18Service _TABLE18Service;
    private readonly ITABLE5639Service _TABLE5639Service;
    private readonly ITABLE5561Service _TABLE5561Service;
    private readonly ITABLE5592Service _TABLE5592Service;
    private readonly ITABLE9203Service _TABLE9203Service;
    private readonly IFORMATVALUESService _FORMATVALUESService;
    private readonly ITABLE9Service _TABLE9Service;

    public ROLESController(IROLESService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE12Service TABLE12Service
        , ICLIENTService CLIENTService
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE18Service TABLE18Service
        , ITABLE5639Service TABLE5639Service
        , ITABLE5561Service TABLE5561Service
        , ITABLE5592Service TABLE5592Service
        , ITABLE9203Service TABLE9203Service
        , IFORMATVALUESService FORMATVALUESService
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE12Service = TABLE12Service;
        _CLIENTService = CLIENTService;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE18Service = TABLE18Service;
        _TABLE5639Service = TABLE5639Service;
        _TABLE5561Service = TABLE5561Service;
        _TABLE5592Service = TABLE5592Service;
        _TABLE9203Service = TABLE9203Service;
        _FORMATVALUESService = FORMATVALUESService;
        _TABLE9Service = TABLE9Service;
    }

    // GET: ROLES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ROLES/Index.cshtml");

    // GET: ROLES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLES/Details.cshtml", result);
    }

    // GET: ROLES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE5561DropdownAsync();
        await PopulateTABLE5592DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/ROLES/Create.cshtml", new CreateROLESDto());
    }

    // POST: ROLES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateROLESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE5561DropdownAsync();
        await PopulateTABLE5592DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/ROLES/Create.cshtml", createDto);
    }

    // GET: ROLES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateROLESDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NROLE = result.NROLE,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            NINTERMED = result.NINTERMED,
            DBIRTHDATE = result.DBIRTHDATE,
            SSEXCLIEN = result.SSEXCLIEN,
            SSMOKING = result.SSMOKING,
            NTYPERISK = result.NTYPERISK,
            SVIP = result.SVIP,
            NSTATUSROL = result.NSTATUSROL,
            NRATING = result.NRATING,
            NTYPENAME = result.NTYPENAME,
            NCOVERPOS = result.NCOVERPOS,
            DCONTINUE = result.DCONTINUE,
            NCONTRAT_PAY = result.NCONTRAT_PAY,
            SCONTINUED = result.SCONTINUED,
            SPRINTNAME = result.SPRINTNAME,
            SITEM = result.SITEM,
            NWEIGHT = result.NWEIGHT,
            NHEIGHT = result.NHEIGHT,
            NIMC = result.NIMC,
            NTYPELIST = result.NTYPELIST,
            DPEPSEARCH = result.DPEPSEARCH,
            NUSERPEPSEARCH = result.NUSERPEPSEARCH,
            SFPHYSICAL_CREDEN = result.SFPHYSICAL_CREDEN,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            NCITY_RESIDENCE = result.NCITY_RESIDENCE,
            SSHORT_DES = result.SSHORT_DES,
            NSEVERITYPEP = result.NSEVERITYPEP,
            NINDAUTHPEP = result.NINDAUTHPEP,
            DPEPSTATUS = result.DPEPSTATUS,
            NCAPITAL = result.NCAPITAL,
            NUSERPEPAUTHREJ = result.NUSERPEPAUTHREJ,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE5561DropdownAsync();
        await PopulateTABLE5592DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/ROLES/Edit.cshtml", updateDto);
    }

    // POST: ROLES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateROLESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE5561DropdownAsync();
        await PopulateTABLE5592DropdownAsync();
        await PopulateTABLE9203DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/ROLES/Edit.cshtml", updateDto);
    }

    // GET: ROLES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLES/Delete.cshtml", result);
    }

    // POST: ROLES/Delete/{id}
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

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE18DropdownAsync()
    {
        var items = await _TABLE18Service.GetAllAsync();
        ViewData["SSEXCLIEN"] = new SelectList(items, nameof(TABLE18Dto.SSEXCLIEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE5639DropdownAsync()
    {
        var items = await _TABLE5639Service.GetAllAsync();
        ViewData["NTYPERISK"] = new SelectList(items, nameof(TABLE5639Dto.NTYPERISK), "SDESCRIPT");
    }

    private async Task PopulateTABLE5561DropdownAsync()
    {
        var items = await _TABLE5561Service.GetAllAsync();
        ViewData["NSTATUSROL"] = new SelectList(items, nameof(TABLE5561Dto.NSTATUSROL), "SDESCRIPT");
    }

    private async Task PopulateTABLE5592DropdownAsync()
    {
        var items = await _TABLE5592Service.GetAllAsync();
        ViewData["NTYPENAME"] = new SelectList(items, nameof(TABLE5592Dto.NTYPENAME), "SDESCRIPT");
    }

    private async Task PopulateTABLE9203DropdownAsync()
    {
        var items = await _TABLE9203Service.GetAllAsync();
        ViewData["NTYPELIST"] = new SelectList(items, nameof(TABLE9203Dto.NTYPELIST), "SDESCRIPT");
    }

    private async Task PopulateFORMATVALUESDropdownAsync()
    {
        var items = await _FORMATVALUESService.GetAllAsync();
        ViewData["NCLASSTYPDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NCLASSTYPDOC), "SDESCRIPT");
        ViewData["NTYPCLIENTDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NTYPCLIENTDOC), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NCITY_RESIDENCE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
