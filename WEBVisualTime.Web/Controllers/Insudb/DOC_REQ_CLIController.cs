using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DOC_REQ_CLI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DOC_REQ_CLIController : Controller
{
    private readonly IDOC_REQ_CLIService _service;
    private readonly IEVAL_MASTERService _EVAL_MASTERService;
    private readonly ITABLE32Service _TABLE32Service;
    private readonly ITABLE275Service _TABLE275Service;
    private readonly IUSERSService _USERSService;

    public DOC_REQ_CLIController(IDOC_REQ_CLIService service
        , IEVAL_MASTERService EVAL_MASTERService
        , ITABLE32Service TABLE32Service
        , ITABLE275Service TABLE275Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _EVAL_MASTERService = EVAL_MASTERService;
        _TABLE32Service = TABLE32Service;
        _TABLE275Service = TABLE275Service;
        _USERSService = USERSService;
    }

    // GET: DOC_REQ_CLI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DOC_REQ_CLI/Index.cshtml");

    // GET: DOC_REQ_CLI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOC_REQ_CLI/Details.cshtml", result);
    }

    // GET: DOC_REQ_CLI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/DOC_REQ_CLI/Create.cshtml", new CreateDOC_REQ_CLIDto());
    }

    // POST: DOC_REQ_CLI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDOC_REQ_CLIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/DOC_REQ_CLI/Create.cshtml", createDto);
    }

    // GET: DOC_REQ_CLI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDOC_REQ_CLIDto
        {
            NEVAL = result.NEVAL,
            NID = result.NID,
            NTYPEDOC = result.NTYPEDOC,
            NSTATUSDOC = result.NSTATUSDOC,
            SDESCRIPT = result.SDESCRIPT,
            DDOCREQ = result.DDOCREQ,
            DDOCREC = result.DDOCREC,
            DDOCDATE = result.DDOCDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NCAPITAL = result.NCAPITAL,
            NNOTENUM = result.NNOTENUM,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            DDATETO = result.DDATETO,
            DDATEFREE = result.DDATEFREE,
            SREQUEST = result.SREQUEST,
        };
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/DOC_REQ_CLI/Edit.cshtml", updateDto);
    }

    // POST: DOC_REQ_CLI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateDOC_REQ_CLIDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateEVAL_MASTERDropdownAsync();
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE275DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/DOC_REQ_CLI/Edit.cshtml", updateDto);
    }

    // GET: DOC_REQ_CLI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOC_REQ_CLI/Delete.cshtml", result);
    }

    // POST: DOC_REQ_CLI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateEVAL_MASTERDropdownAsync()
    {
        var items = await _EVAL_MASTERService.GetAllAsync();
        ViewData["NEVAL"] = new SelectList(items, nameof(EVAL_MASTERDto.NEVAL), "SCERTYPE");
    }

    private async Task PopulateTABLE32DropdownAsync()
    {
        var items = await _TABLE32Service.GetAllAsync();
        ViewData["NTYPEDOC"] = new SelectList(items, nameof(TABLE32Dto.NCRTHECNI), "SDESCRIPT");
    }

    private async Task PopulateTABLE275DropdownAsync()
    {
        var items = await _TABLE275Service.GetAllAsync();
        ViewData["NSTATUSDOC"] = new SelectList(items, nameof(TABLE275Dto.NSTAT_DOCREQ), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
