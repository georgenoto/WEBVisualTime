using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.EVAL_MASTER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class EVAL_MASTERController : Controller
{
    private readonly IEVAL_MASTERService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5572Service _TABLE5572Service;

    public EVAL_MASTERController(IEVAL_MASTERService service
        , ICLIENTService CLIENTService
        , ICERTIFICATService CERTIFICATService
        , ITABLE5572Service TABLE5572Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5572Service = TABLE5572Service;
    }

    // GET: EVAL_MASTER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/EVAL_MASTER/Index.cshtml");

    // GET: EVAL_MASTER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EVAL_MASTER/Details.cshtml", result);
    }

    // GET: EVAL_MASTER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5572DropdownAsync();
        return View("~/Views/Insudb/EVAL_MASTER/Create.cshtml", new CreateEVAL_MASTERDto());
    }

    // POST: EVAL_MASTER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateEVAL_MASTERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5572DropdownAsync();
        return View("~/Views/Insudb/EVAL_MASTER/Create.cshtml", createDto);
    }

    // GET: EVAL_MASTER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateEVAL_MASTERDto
        {
            NEVAL = result.NEVAL,
            SCLIENT = result.SCLIENT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            DSTARTDATE = result.DSTARTDATE,
            NCERTIF = result.NCERTIF,
            DEXPIRDAT = result.DEXPIRDAT,
            NSTATUS_EVAL = result.NSTATUS_EVAL,
            NCAPITAL = result.NCAPITAL,
            NNOTEREST = result.NNOTEREST,
            NCURRENCY = result.NCURRENCY,
            NCUMUL = result.NCUMUL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCERTYPE = result.SCERTYPE,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5572DropdownAsync();
        return View("~/Views/Insudb/EVAL_MASTER/Edit.cshtml", updateDto);
    }

    // POST: EVAL_MASTER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateEVAL_MASTERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NEVAL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5572DropdownAsync();
        return View("~/Views/Insudb/EVAL_MASTER/Edit.cshtml", updateDto);
    }

    // GET: EVAL_MASTER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/EVAL_MASTER/Delete.cshtml", result);
    }

    // POST: EVAL_MASTER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: EVAL_MASTER/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NEVAL, text = i.NEVAL }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE5572DropdownAsync()
    {
        var items = await _TABLE5572Service.GetAllAsync();
        ViewData["NSTATUS_EVAL"] = new SelectList(items, nameof(TABLE5572Dto.NSTATUS_EVAL), "SDESCRIPT");
    }

}
