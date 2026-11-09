using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIMBENEF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE184;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7801;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIMBENEFController : Controller
{
    private readonly ICLAIMBENEFService _service;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE184Service _TABLE184Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE15Service _TABLE15Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly IAGENCIESService _AGENCIESService;
    private readonly ITABLE7801Service _TABLE7801Service;

    public CLAIMBENEFController(ICLAIMBENEFService service
        , ICLAIM_CASEService CLAIM_CASEService
        , ICLIENTService CLIENTService
        , ITABLE184Service TABLE184Service
        , ITABLE9Service TABLE9Service
        , ITABLE15Service TABLE15Service
        , ITABLE5556Service TABLE5556Service
        , IAGENCIESService AGENCIESService
        , ITABLE7801Service TABLE7801Service
    )
    {
        _service = service;
        _CLAIM_CASEService = CLAIM_CASEService;
        _CLIENTService = CLIENTService;
        _TABLE184Service = TABLE184Service;
        _TABLE9Service = TABLE9Service;
        _TABLE15Service = TABLE15Service;
        _TABLE5556Service = TABLE5556Service;
        _AGENCIESService = AGENCIESService;
        _TABLE7801Service = TABLE7801Service;
    }

    // GET: CLAIMBENEF
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIMBENEF/Index.cshtml");

    // GET: CLAIMBENEF/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIMBENEF/Details.cshtml", result);
    }

    // GET: CLAIMBENEF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE184DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulateTABLE7801DropdownAsync();
        return View("~/Views/Insudb/CLAIMBENEF/Create.cshtml", new CreateCLAIMBENEFDto());
    }

    // POST: CLAIMBENEF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIMBENEFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE184DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulateTABLE7801DropdownAsync();
        return View("~/Views/Insudb/CLAIMBENEF/Create.cshtml", createDto);
    }

    // GET: CLAIMBENEF/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIMBENEFDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            SCLIENT = result.SCLIENT,
            NBENE_TYPE = result.NBENE_TYPE,
            NID = result.NID,
            NOFFICE_PAY = result.NOFFICE_PAY,
            DCOMPDATE = result.DCOMPDATE,
            SDEMANDANT = result.SDEMANDANT,
            NUSERCODE = result.NUSERCODE,
            NRELATION = result.NRELATION,
            NPARTICIP = result.NPARTICIP,
            SBENEF_TYP = result.SBENEF_TYP,
            NAMOUNT = result.NAMOUNT,
            DINIT_DATE = result.DINIT_DATE,
            DEND_DATE = result.DEND_DATE,
            SCLIENT_REP = result.SCLIENT_REP,
            DNEXT_PAY = result.DNEXT_PAY,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCURRENCY = result.NCURRENCY,
            SPAY_INSTALL = result.SPAY_INSTALL,
            NOFFICEAGEN_PAY = result.NOFFICEAGEN_PAY,
            NAGENCY_PAY = result.NAGENCY_PAY,
            NNOTENUM = result.NNOTENUM,
            DSHOWDATE = result.DSHOWDATE,
            NPAYMENTADDRESS = result.NPAYMENTADDRESS,
        };
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE184DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulateTABLE7801DropdownAsync();
        return View("~/Views/Insudb/CLAIMBENEF/Edit.cshtml", updateDto);
    }

    // POST: CLAIMBENEF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLAIMBENEFDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE184DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE15DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateAGENCIESDropdownAsync();
        await PopulateTABLE7801DropdownAsync();
        return View("~/Views/Insudb/CLAIMBENEF/Edit.cshtml", updateDto);
    }

    // GET: CLAIMBENEF/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIMBENEF/Delete.cshtml", result);
    }

    // POST: CLAIMBENEF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENT_REP"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE184DropdownAsync()
    {
        var items = await _TABLE184Service.GetAllAsync();
        ViewData["NBENE_TYPE"] = new SelectList(items, nameof(TABLE184Dto.NBENE_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE_PAY"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE15DropdownAsync()
    {
        var items = await _TABLE15Service.GetAllAsync();
        ViewData["NRELATION"] = new SelectList(items, nameof(TABLE15Dto.NRELASHIP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN_PAY"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateAGENCIESDropdownAsync()
    {
        var items = await _AGENCIESService.GetAllAsync();
        ViewData["NAGENCY_PAY"] = new SelectList(items, nameof(AGENCIESDto.NAGENCY), "SPAY");
    }

    private async Task PopulateTABLE7801DropdownAsync()
    {
        var items = await _TABLE7801Service.GetAllAsync();
        ViewData["NPAYMENTADDRESS"] = new SelectList(items, nameof(TABLE7801Dto.NPAYMENTADDRESS), "SDESCRIPT");
    }

}
