using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQFOLDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.FOLDERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SEQFOLDERController : Controller
{
    private readonly ISEQFOLDERService _service;
    private readonly IFOLDERSService _FOLDERSService;

    public SEQFOLDERController(ISEQFOLDERService service
        , IFOLDERSService FOLDERSService
    )
    {
        _service = service;
        _FOLDERSService = FOLDERSService;
    }

    // GET: SEQFOLDER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SEQFOLDER/Index.cshtml");

    // GET: SEQFOLDER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SEQFOLDER/Details.cshtml", result);
    }

    // GET: SEQFOLDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateFOLDERSDropdownAsync();
        return View("~/Views/Insudb/SEQFOLDER/Create.cshtml", new CreateSEQFOLDERDto());
    }

    // POST: SEQFOLDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSEQFOLDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateFOLDERSDropdownAsync();
        return View("~/Views/Insudb/SEQFOLDER/Create.cshtml", createDto);
    }

    // GET: SEQFOLDER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSEQFOLDERDto
        {
            NQUERYTYPE = result.NQUERYTYPE,
            NPARENT = result.NPARENT,
            NFOLDER = result.NFOLDER,
            NSEQUENCE = result.NSEQUENCE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateFOLDERSDropdownAsync();
        return View("~/Views/Insudb/SEQFOLDER/Edit.cshtml", updateDto);
    }

    // POST: SEQFOLDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSEQFOLDERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NQUERYTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateFOLDERSDropdownAsync();
        return View("~/Views/Insudb/SEQFOLDER/Edit.cshtml", updateDto);
    }

    // GET: SEQFOLDER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SEQFOLDER/Delete.cshtml", result);
    }

    // POST: SEQFOLDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateFOLDERSDropdownAsync()
    {
        var items = await _FOLDERSService.GetAllAsync();
        ViewData["NFOLDER"] = new SelectList(items, nameof(FOLDERSDto.NFOLDER), "SFOLDERNAME");
    }

}
