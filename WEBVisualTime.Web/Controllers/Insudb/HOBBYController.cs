using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.HOBBY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class HOBBYController : Controller
{
    private readonly IHOBBYService _service;
    private readonly ITABLE5506Service _TABLE5506Service;
    private readonly ICLIENTService _CLIENTService;

    public HOBBYController(IHOBBYService service
        , ITABLE5506Service TABLE5506Service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _TABLE5506Service = TABLE5506Service;
        _CLIENTService = CLIENTService;
    }

    // GET: HOBBY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/HOBBY/Index.cshtml");

    // GET: HOBBY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOBBY/Details.cshtml", result);
    }

    // GET: HOBBY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5506DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/HOBBY/Create.cshtml", new CreateHOBBYDto());
    }

    // POST: HOBBY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateHOBBYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5506DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/HOBBY/Create.cshtml", createDto);
    }

    // GET: HOBBY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateHOBBYDto
        {
            NHOBBY = result.NHOBBY,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE5506DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/HOBBY/Edit.cshtml", updateDto);
    }

    // POST: HOBBY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHOBBYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NHOBBY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5506DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/HOBBY/Edit.cshtml", updateDto);
    }

    // GET: HOBBY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HOBBY/Delete.cshtml", result);
    }

    // POST: HOBBY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5506DropdownAsync()
    {
        var items = await _TABLE5506Service.GetAllAsync();
        ViewData["NHOBBY"] = new SelectList(items, nameof(TABLE5506Dto.NHOBBY), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
