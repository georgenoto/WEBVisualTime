using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_WIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_WINController : Controller
{
    private readonly ICLIENT_WINService _service;
    private readonly ICLIENTService _CLIENTService;

    public CLIENT_WINController(ICLIENT_WINService service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
    }

    // GET: CLIENT_WIN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIENT_WIN/Index.cshtml");

    // GET: CLIENT_WIN/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_WIN/Details.cshtml", result);
    }

    // GET: CLIENT_WIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLIENT_WIN/Create.cshtml", new CreateCLIENT_WINDto());
    }

    // POST: CLIENT_WIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_WINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLIENT_WIN/Create.cshtml", createDto);
    }

    // GET: CLIENT_WIN/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_WINDto
        {
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SV_CONCLIEN = result.SV_CONCLIEN,
            SV_WINCLIEN = result.SV_WINCLIEN,
        };
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLIENT_WIN/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_WIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_WINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/CLIENT_WIN/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_WIN/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_WIN/Delete.cshtml", result);
    }

    // POST: CLIENT_WIN/Delete/{id}
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
