using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SITUATION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SITUATIONController : Controller
{
    private readonly ISITUATIONService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ICLIENTService _CLIENTService;

    public SITUATIONController(ISITUATIONService service
        , IPOLICYService POLICYService
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _CLIENTService = CLIENTService;
    }

    // GET: SITUATION
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SITUATION/Index.cshtml");

    // GET: SITUATION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SITUATION/Details.cshtml", result);
    }

    // GET: SITUATION/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SITUATION/Create.cshtml", new CreateSITUATIONDto());
    }

    // POST: SITUATION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSITUATIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SITUATION/Create.cshtml", createDto);
    }

    // GET: SITUATION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSITUATIONDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NSITUATION = result.NSITUATION,
            NCOD_AGREE = result.NCOD_AGREE,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            NPARTICIP_POLEMP = result.NPARTICIP_POLEMP,
            NPARTICIP_POLCO = result.NPARTICIP_POLCO,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SITUATION/Edit.cshtml", updateDto);
    }

    // POST: SITUATION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSITUATIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SITUATION/Edit.cshtml", updateDto);
    }

    // GET: SITUATION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SITUATION/Delete.cshtml", result);
    }

    // POST: SITUATION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: SITUATION/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SDESCRIPT }));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
