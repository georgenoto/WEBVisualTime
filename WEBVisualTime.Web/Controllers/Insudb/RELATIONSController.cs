using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RELATIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RELATIONSController : Controller
{
    private readonly IRELATIONSService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE15Service _TABLE15Service;

    public RELATIONSController(IRELATIONSService service
        , ICLIENTService CLIENTService
        , ITABLE15Service TABLE15Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE15Service = TABLE15Service;
    }

    // GET: RELATIONS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/RELATIONS/Index.cshtml");

    // GET: RELATIONS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELATIONS/Details.cshtml", result);
    }

    // GET: RELATIONS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/RELATIONS/Create.cshtml", new CreateRELATIONSDto());
    }

    // POST: RELATIONS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRELATIONSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/RELATIONS/Create.cshtml", createDto);
    }

    // GET: RELATIONS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRELATIONSDto
        {
            SCLIENTR = result.SCLIENTR,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NRELASHIP = result.NRELASHIP,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/RELATIONS/Edit.cshtml", updateDto);
    }

    // POST: RELATIONS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateRELATIONSDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE15DropdownAsync();
        return View("~/Views/Insudb/RELATIONS/Edit.cshtml", updateDto);
    }

    // GET: RELATIONS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RELATIONS/Delete.cshtml", result);
    }

    // POST: RELATIONS/Delete/{id}
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
        ViewData["SCLIENTR"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE15DropdownAsync()
    {
        var items = await _TABLE15Service.GetAllAsync();
        ViewData["NRELASHIP"] = new SelectList(items, nameof(TABLE15Dto.NRELASHIP), "SDESCRIPT");
    }

}
