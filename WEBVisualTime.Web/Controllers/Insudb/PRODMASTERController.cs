using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PRODMASTERController : Controller
{
    private readonly IPRODMASTERService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE37Service _TABLE37Service;

    public PRODMASTERController(IPRODMASTERService service
        , ITABLE10Service TABLE10Service
        , ITABLE37Service TABLE37Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _TABLE37Service = TABLE37Service;
    }

    // GET: PRODMASTER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PRODMASTER/Index.cshtml");

    // GET: PRODMASTER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODMASTER/Details.cshtml", result);
    }

    // GET: PRODMASTER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE37DropdownAsync();
        return View("~/Views/Insudb/PRODMASTER/Create.cshtml", new CreatePRODMASTERDto());
    }

    // POST: PRODMASTER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePRODMASTERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE37DropdownAsync();
        return View("~/Views/Insudb/PRODMASTER/Create.cshtml", createDto);
    }

    // GET: PRODMASTER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePRODMASTERDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SBRANCHT = result.SBRANCHT,
            DCOMPDATE = result.DCOMPDATE,
            SREALIND = result.SREALIND,
            NCOMPANY = result.NCOMPANY,
            SPREFFIX = result.SPREFFIX,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE37DropdownAsync();
        return View("~/Views/Insudb/PRODMASTER/Edit.cshtml", updateDto);
    }

    // POST: PRODMASTER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePRODMASTERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE37DropdownAsync();
        return View("~/Views/Insudb/PRODMASTER/Edit.cshtml", updateDto);
    }

    // GET: PRODMASTER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRODMASTER/Delete.cshtml", result);
    }

    // POST: PRODMASTER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: PRODMASTER/GetByNBRANCH?NBRANCH=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNBRANCH(int NBRANCH)
    {
        var items = await _service.FindAsync(p => p.NBRANCH == NBRANCH);
        return Json(items.Select(i => new { value = i.NBRANCH, text = i.SDESCRIPT }));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE37DropdownAsync()
    {
        var items = await _TABLE37Service.GetAllAsync();
        ViewData["SBRANCHT"] = new SelectList(items, nameof(TABLE37Dto.SBRANCHT), "SDESCRIPT");
    }

}
