using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE62;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NOTESController : Controller
{
    private readonly INOTESService _service;
    private readonly ITABLE62Service _TABLE62Service;

    public NOTESController(INOTESService service
        , ITABLE62Service TABLE62Service
    )
    {
        _service = service;
        _TABLE62Service = TABLE62Service;
    }

    // GET: NOTES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NOTES/Index.cshtml", result);
    }

    // GET: NOTES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOTES/Details.cshtml", result);
    }

    // GET: NOTES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE62DropdownAsync();
        return View("~/Views/Insudb/NOTES/Create.cshtml", new CreateNOTESDto());
    }

    // POST: NOTES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNOTESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE62DropdownAsync();
        return View("~/Views/Insudb/NOTES/Create.cshtml", createDto);
    }

    // GET: NOTES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNOTESDto
        {
            NNOTENUM = result.NNOTENUM,
            DCOMPDATE = result.DCOMPDATE,
            NCONSEC = result.NCONSEC,
            SDESCRIPT = result.SDESCRIPT,
            TDS_TEXT = result.TDS_TEXT,
            DNULLDATE = result.DNULLDATE,
            NRECTYPE = result.NRECTYPE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE62DropdownAsync();
        return View("~/Views/Insudb/NOTES/Edit.cshtml", updateDto);
    }

    // POST: NOTES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNOTESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NNOTENUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE62DropdownAsync();
        return View("~/Views/Insudb/NOTES/Edit.cshtml", updateDto);
    }

    // GET: NOTES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOTES/Delete.cshtml", result);
    }

    // POST: NOTES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE62DropdownAsync()
    {
        var items = await _TABLE62Service.GetAllAsync();
        ViewData["NRECTYPE"] = new SelectList(items, nameof(TABLE62Dto.NRECTYPE), "SDESCRIPT");
    }

}
