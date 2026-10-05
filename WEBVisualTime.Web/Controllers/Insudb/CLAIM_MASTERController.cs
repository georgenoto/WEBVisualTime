using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_MASTER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_MASTERController : Controller
{
    private readonly ICLAIM_MASTERService _service;
    private readonly ICLIENTService _CLIENTService;

    public CLAIM_MASTERController(ICLAIM_MASTERService service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
    }

    // GET: CLAIM_MASTER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_MASTER/Index.cshtml", result);
    }

    // GET: CLAIM_MASTER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_MASTER/Details.cshtml", result);
    }

    // GET: CLAIM_MASTER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_MASTER/Create.cshtml", new CreateCLAIM_MASTERDto());
    }

    // POST: CLAIM_MASTER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_MASTERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_MASTER/Create.cshtml", createDto);
    }

    // GET: CLAIM_MASTER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_MASTERDto
        {
            NBORDEREAUX_CL = result.NBORDEREAUX_CL,
            SCLIENT = result.SCLIENT,
            NCOVER = result.NCOVER,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SKEY = result.SKEY,
            SFILENAME = result.SFILENAME,
            NPROVIDER = result.NPROVIDER,
            NOFFICE = result.NOFFICE,
            NSTATUS = result.NSTATUS,
            SSTATUS_PROC = result.SSTATUS_PROC,
            NPAY_PROVIDER = result.NPAY_PROVIDER,
        };
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_MASTER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_MASTER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_MASTERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX_CL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLAIM_MASTER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_MASTER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_MASTER/Delete.cshtml", result);
    }

    // POST: CLAIM_MASTER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLAIM_MASTER/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NBORDEREAUX_CL, text = i.SKEY }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
