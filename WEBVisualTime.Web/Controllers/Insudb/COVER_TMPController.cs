using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_TMP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COVER_TMPController : Controller
{
    private readonly ICOVER_TMPService _service;
    private readonly ICERTIFICATService _CERTIFICATService;

    public COVER_TMPController(ICOVER_TMPService service
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: COVER_TMP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COVER_TMP/Index.cshtml", result);
    }

    // GET: COVER_TMP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_TMP/Details.cshtml", result);
    }

    // GET: COVER_TMP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COVER_TMP/Create.cshtml", new CreateCOVER_TMPDto());
    }

    // POST: COVER_TMP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOVER_TMPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COVER_TMP/Create.cshtml", createDto);
    }

    // GET: COVER_TMP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOVER_TMPDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NIDCONSEC = result.NIDCONSEC,
            NROW = result.NROW,
            NCOLUMN = result.NCOLUMN,
            SVALUE = result.SVALUE,
            SSECTION = result.SSECTION,
            SDATATYPE = result.SDATATYPE,
            SUPDATE = result.SUPDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COVER_TMP/Edit.cshtml", updateDto);
    }

    // POST: COVER_TMP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOVER_TMPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COVER_TMP/Edit.cshtml", updateDto);
    }

    // GET: COVER_TMP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COVER_TMP/Delete.cshtml", result);
    }

    // POST: COVER_TMP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

}
