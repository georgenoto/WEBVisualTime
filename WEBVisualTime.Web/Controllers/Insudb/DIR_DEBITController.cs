using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DIR_DEBITController : Controller
{
    private readonly IDIR_DEBITService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE183Service _TABLE183Service;

    public DIR_DEBITController(IDIR_DEBITService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE7Service TABLE7Service
        , ICLIENTService CLIENTService
        , ITABLE183Service TABLE183Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE7Service = TABLE7Service;
        _CLIENTService = CLIENTService;
        _TABLE183Service = TABLE183Service;
    }

    // GET: DIR_DEBIT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DIR_DEBIT/Index.cshtml");

    // GET: DIR_DEBIT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DIR_DEBIT/Details.cshtml", result);
    }

    // GET: DIR_DEBIT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT/Create.cshtml", new CreateDIR_DEBITDto());
    }

    // POST: DIR_DEBIT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDIR_DEBITDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT/Create.cshtml", createDto);
    }

    // GET: DIR_DEBIT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDIR_DEBITDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            SACCOUNT = result.SACCOUNT,
            NBANKEXT = result.NBANKEXT,
            SCLIENT = result.SCLIENT,
            DNULLDATE = result.DNULLDATE,
            SCREDI_CARD = result.SCREDI_CARD,
            NTYP_CRECARD = result.NTYP_CRECARD,
            STYP_DIRDEB = result.STYP_DIRDEB,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DCARDEXPIR = result.DCARDEXPIR,
            SBANKAUTH = result.SBANKAUTH,
            SREUSE = result.SREUSE,
            NTYP_ACC = result.NTYP_ACC,
            NSTATUS_BANKAUTH = result.NSTATUS_BANKAUTH,
            NIDCOLLECT = result.NIDCOLLECT,
            NBILL_DAYINI = result.NBILL_DAYINI,
            DBANKAUTH = result.DBANKAUTH,
            SDEBIT_CARD = result.SDEBIT_CARD,
            NBILL_DAYEND = result.NBILL_DAYEND,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT/Edit.cshtml", updateDto);
    }

    // POST: DIR_DEBIT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDIR_DEBITDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT/Edit.cshtml", updateDto);
    }

    // GET: DIR_DEBIT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DIR_DEBIT/Delete.cshtml", result);
    }

    // POST: DIR_DEBIT/Delete/{id}
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

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE183DropdownAsync()
    {
        var items = await _TABLE183Service.GetAllAsync();
        ViewData["NTYP_CRECARD"] = new SelectList(items, nameof(TABLE183Dto.NCARD_TYPE), "SDESCRIPT");
    }

}
