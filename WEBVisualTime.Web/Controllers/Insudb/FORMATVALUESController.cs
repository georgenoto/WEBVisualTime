using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6023;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FORMATVALUESController : Controller
{
    private readonly IFORMATVALUESService _service;
    private readonly ITABLE6023Service _TABLE6023Service;

    public FORMATVALUESController(IFORMATVALUESService service
        , ITABLE6023Service TABLE6023Service
    )
    {
        _service = service;
        _TABLE6023Service = TABLE6023Service;
    }

    // GET: FORMATVALUES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FORMATVALUES/Index.cshtml");

    // GET: FORMATVALUES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FORMATVALUES/Details.cshtml", result);
    }

    // GET: FORMATVALUES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE6023DropdownAsync();
        return View("~/Views/Insudb/FORMATVALUES/Create.cshtml", new CreateFORMATVALUESDto());
    }

    // POST: FORMATVALUES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFORMATVALUESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6023DropdownAsync();
        return View("~/Views/Insudb/FORMATVALUES/Create.cshtml", createDto);
    }

    // GET: FORMATVALUES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFORMATVALUESDto
        {
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            SFORMAT = result.SFORMAT,
            STYPPERSON = result.STYPPERSON,
            SROUTINE = result.SROUTINE,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE6023DropdownAsync();
        return View("~/Views/Insudb/FORMATVALUES/Edit.cshtml", updateDto);
    }

    // POST: FORMATVALUES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateFORMATVALUESDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE6023DropdownAsync();
        return View("~/Views/Insudb/FORMATVALUES/Edit.cshtml", updateDto);
    }

    // GET: FORMATVALUES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FORMATVALUES/Delete.cshtml", result);
    }

    // POST: FORMATVALUES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE6023DropdownAsync()
    {
        var items = await _TABLE6023Service.GetAllAsync();
        ViewData["NCLASSTYPDOC"] = new SelectList(items, nameof(TABLE6023Dto.NCLASSTYPDOC), "SDESCRIPT");
    }

}
