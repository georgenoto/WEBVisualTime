using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.GROUPS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class GROUPSController : Controller
{
    private readonly IGROUPSService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ICLIENTService _CLIENTService;

    public GROUPSController(IGROUPSService service
        , IPOLICYService POLICYService
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _CLIENTService = CLIENTService;
    }

    // GET: GROUPS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/GROUPS/Index.cshtml");

    // GET: GROUPS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPS/Details.cshtml", result);
    }

    // GET: GROUPS/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/GROUPS/Create.cshtml", new CreateGROUPSDto());
    }

    // POST: GROUPS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateGROUPSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/GROUPS/Create.cshtml", createDto);
    }

    // GET: GROUPS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateGROUPSDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPOLICY = result.NPOLICY,
            NPRODUCT = result.NPRODUCT,
            NGROUP = result.NGROUP,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            SCLIENT = result.SCLIENT,
            SDESCRIPT = result.SDESCRIPT,
            NPARTICIP = result.NPARTICIP,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NPARTICIP_CO = result.NPARTICIP_CO,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/GROUPS/Edit.cshtml", updateDto);
    }

    // POST: GROUPS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateGROUPSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/GROUPS/Edit.cshtml", updateDto);
    }

    // GET: GROUPS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/GROUPS/Delete.cshtml", result);
    }

    // POST: GROUPS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
