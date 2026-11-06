using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DIR_DEBIT_CLI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DIR_DEBIT_CLIController : Controller
{
    private readonly IDIR_DEBIT_CLIService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE7Service _TABLE7Service;

    public DIR_DEBIT_CLIController(IDIR_DEBIT_CLIService service
        , ICLIENTService CLIENTService
        , ITABLE7Service TABLE7Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE7Service = TABLE7Service;
    }

    // GET: DIR_DEBIT_CLI
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DIR_DEBIT_CLI/Index.cshtml");

    // GET: DIR_DEBIT_CLI/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Details.cshtml", result);
    }

    // GET: DIR_DEBIT_CLI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Create.cshtml", new CreateDIR_DEBIT_CLIDto());
    }

    // POST: DIR_DEBIT_CLI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDIR_DEBIT_CLIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Create.cshtml", createDto);
    }

    // GET: DIR_DEBIT_CLI/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDIR_DEBIT_CLIDto
        {
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            SACCOUNT = result.SACCOUNT,
            DNULLDATE = result.DNULLDATE,
            STYP_DIRDEB = result.STYP_DIRDEB,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBANKEXT = result.NBANKEXT,
            SBANKAUTH = result.SBANKAUTH,
            NBILL_DAY = result.NBILL_DAY,
            NSTATUS_BANKAUTH = result.NSTATUS_BANKAUTH,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Edit.cshtml", updateDto);
    }

    // POST: DIR_DEBIT_CLI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDIR_DEBIT_CLIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Edit.cshtml", updateDto);
    }

    // GET: DIR_DEBIT_CLI/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DIR_DEBIT_CLI/Delete.cshtml", result);
    }

    // POST: DIR_DEBIT_CLI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

}
