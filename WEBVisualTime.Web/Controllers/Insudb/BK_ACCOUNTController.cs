using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BK_ACCOUNT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BK_ACCOUNTController : Controller
{
    private readonly IBK_ACCOUNTService _service;
    private readonly ICLIENTService _CLIENTService;

    public BK_ACCOUNTController(IBK_ACCOUNTService service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
    }

    // GET: BK_ACCOUNT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BK_ACCOUNT/Index.cshtml");

    // GET: BK_ACCOUNT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BK_ACCOUNT/Details.cshtml", result);
    }

    // GET: BK_ACCOUNT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BK_ACCOUNT/Create.cshtml", new CreateBK_ACCOUNTDto());
    }

    // POST: BK_ACCOUNT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBK_ACCOUNTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BK_ACCOUNT/Create.cshtml", createDto);
    }

    // GET: BK_ACCOUNT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBK_ACCOUNTDto
        {
            NBANKEXT = result.NBANKEXT,
            SACCOUNT = result.SACCOUNT,
            NTYP_ACC = result.NTYP_ACC,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDEPOSIT = result.SDEPOSIT,
            SCLIENT = result.SCLIENT,
            NCURRENCY = result.NCURRENCY,
        };
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BK_ACCOUNT/Edit.cshtml", updateDto);
    }

    // POST: BK_ACCOUNT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateBK_ACCOUNTDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BK_ACCOUNT/Edit.cshtml", updateDto);
    }

    // GET: BK_ACCOUNT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BK_ACCOUNT/Delete.cshtml", result);
    }

    // POST: BK_ACCOUNT/Delete/{id}
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

}
