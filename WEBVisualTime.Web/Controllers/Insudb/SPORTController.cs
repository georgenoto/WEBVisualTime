using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SPORT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE512;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SPORTController : Controller
{
    private readonly ISPORTService _service;
    private readonly ITABLE512Service _TABLE512Service;
    private readonly ICLIENTService _CLIENTService;

    public SPORTController(ISPORTService service
        , ITABLE512Service TABLE512Service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _TABLE512Service = TABLE512Service;
        _CLIENTService = CLIENTService;
    }

    // GET: SPORT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SPORT/Index.cshtml");

    // GET: SPORT/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SPORT/Details.cshtml", result);
    }

    // GET: SPORT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE512DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SPORT/Create.cshtml", new CreateSPORTDto());
    }

    // POST: SPORT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSPORTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE512DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SPORT/Create.cshtml", createDto);
    }

    // GET: SPORT/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSPORTDto
        {
            NSPORT = result.NSPORT,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE512DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SPORT/Edit.cshtml", updateDto);
    }

    // POST: SPORT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSPORTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSPORT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE512DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/SPORT/Edit.cshtml", updateDto);
    }

    // GET: SPORT/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SPORT/Delete.cshtml", result);
    }

    // POST: SPORT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE512DropdownAsync()
    {
        var items = await _TABLE512Service.GetAllAsync();
        ViewData["NSPORT"] = new SelectList(items, nameof(TABLE512Dto.NSPORT), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
