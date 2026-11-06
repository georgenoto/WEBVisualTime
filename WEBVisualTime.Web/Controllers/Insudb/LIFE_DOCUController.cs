using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_DOCU;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5719;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LIFE_DOCUController : Controller
{
    private readonly ILIFE_DOCUService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly ITABLE275Service _TABLE275Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly IEVAL_MASTERService _EVAL_MASTERService;
    private readonly ITABLE5719Service _TABLE5719Service;

    public LIFE_DOCUController(ILIFE_DOCUService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE12Service TABLE12Service
        , ITABLE275Service TABLE275Service
        , ICLIENTService CLIENTService
        , IEVAL_MASTERService EVAL_MASTERService
        , ITABLE5719Service TABLE5719Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE12Service = TABLE12Service;
        _TABLE275Service = TABLE275Service;
        _CLIENTService = CLIENTService;
        _EVAL_MASTERService = EVAL_MASTERService;
        _TABLE5719Service = TABLE5719Service;
    }

    // GET: LIFE_DOCU
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LIFE_DOCU/Index.cshtml");

    // GET: LIFE_DOCU/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_DOCU/Details.cshtml", result);
    }

    // GET: LIFE_DOCU/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE5719DropdownAsync();
        return View("~/Views/Insudb/LIFE_DOCU/Create.cshtml", new CreateLIFE_DOCUDto());
    }

    // POST: LIFE_DOCU/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLIFE_DOCUDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE5719DropdownAsync();
        return View("~/Views/Insudb/LIFE_DOCU/Create.cshtml", createDto);
    }

    // GET: LIFE_DOCU/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLIFE_DOCUDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPOLICY = result.NPOLICY,
            NPRODUCT = result.NPRODUCT,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NMODULEC = result.NMODULEC,
            NCRTHECNI = result.NCRTHECNI,
            NCOVER = result.NCOVER,
            DRECEP_DATE = result.DRECEP_DATE,
            NROLE = result.NROLE,
            NSTAT_DOCREQ = result.NSTAT_DOCREQ,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DDATE_TO = result.DDATE_TO,
            DDATEFREE = result.DDATEFREE,
            NEVAL = result.NEVAL,
            DDATEVIG = result.DDATEVIG,
            NNOTENUM = result.NNOTENUM,
            SREQUEST = result.SREQUEST,
            NREASON = result.NREASON,
            SRANDOM = result.SRANDOM,
            NID_SECUENCIA = result.NID_SECUENCIA,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE5719DropdownAsync();
        return View("~/Views/Insudb/LIFE_DOCU/Edit.cshtml", updateDto);
    }

    // POST: LIFE_DOCU/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLIFE_DOCUDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE5719DropdownAsync();
        return View("~/Views/Insudb/LIFE_DOCU/Edit.cshtml", updateDto);
    }

    // GET: LIFE_DOCU/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_DOCU/Delete.cshtml", result);
    }

    // POST: LIFE_DOCU/Delete/{id}
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
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateTABLE275DropdownAsync()
    {
        var items = await _TABLE275Service.GetAllAsync();
        ViewData["NSTAT_DOCREQ"] = new SelectList(items, nameof(TABLE275Dto.NSTAT_DOCREQ), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateEVAL_MASTERDropdownAsync()
    {
        var items = await _EVAL_MASTERService.GetAllAsync();
        ViewData["NEVAL"] = new SelectList(items, nameof(EVAL_MASTERDto.NEVAL), "SCERTYPE");
    }

    private async Task PopulateTABLE5719DropdownAsync()
    {
        var items = await _TABLE5719Service.GetAllAsync();
        ViewData["NREASON"] = new SelectList(items, nameof(TABLE5719Dto.NREASON), "SDESCRIPT");
    }

}
