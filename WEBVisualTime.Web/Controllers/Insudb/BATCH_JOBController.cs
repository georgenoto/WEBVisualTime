using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_JOB;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PROCESS;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BATCH_JOBController : Controller
{
    private readonly IBATCH_JOBService _service;
    private readonly IBATCH_PROCESSService _BATCH_PROCESSService;
    private readonly IUSERSService _USERSService;

    public BATCH_JOBController(IBATCH_JOBService service
        , IBATCH_PROCESSService BATCH_PROCESSService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _BATCH_PROCESSService = BATCH_PROCESSService;
        _USERSService = USERSService;
    }

    // GET: BATCH_JOB
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BATCH_JOB/Index.cshtml", result);
    }

    // GET: BATCH_JOB/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_JOB/Details.cshtml", result);
    }

    // GET: BATCH_JOB/Create
    public async Task<IActionResult> Create()
    {
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_JOB/Create.cshtml", new CreateBATCH_JOBDto());
    }

    // POST: BATCH_JOB/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBATCH_JOBDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_JOB/Create.cshtml", createDto);
    }

    // GET: BATCH_JOB/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBATCH_JOBDto
        {
            SKEY = result.SKEY,
            NBATCH = result.NBATCH,
            DSTART = result.DSTART,
            DEND = result.DEND,
            NSTATUS = result.NSTATUS,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCOMMAND = result.SCOMMAND,
            DSUBMIT = result.DSUBMIT,
            NORAJOB = result.NORAJOB,
            NUSERSUBMIT = result.NUSERSUBMIT,
            NSHEET = result.NSHEET,
            SKEY_FATHER = result.SKEY_FATHER,
            SOUTPUTFILE = result.SOUTPUTFILE,
            SFILE = result.SFILE,
            SVERIFIED_PLA = result.SVERIFIED_PLA,
        };
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_JOB/Edit.cshtml", updateDto);
    }

    // POST: BATCH_JOB/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBATCH_JOBDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_PROCESSDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/BATCH_JOB/Edit.cshtml", updateDto);
    }

    // GET: BATCH_JOB/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_JOB/Delete.cshtml", result);
    }

    // POST: BATCH_JOB/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateBATCH_PROCESSDropdownAsync()
    {
        var items = await _BATCH_PROCESSService.GetAllAsync();
        ViewData["NBATCH"] = new SelectList(items, nameof(BATCH_PROCESSDto.NBATCH), "SCODISPL");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
