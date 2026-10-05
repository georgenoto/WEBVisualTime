using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class POLICY_WINController : Controller
{
    private readonly IPOLICY_WINService _service;
    private readonly ICERTIFICATService _CERTIFICATService;

    public POLICY_WINController(IPOLICY_WINService service
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: POLICY_WIN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/POLICY_WIN/Index.cshtml", result);
    }

    // GET: POLICY_WIN/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_WIN/Details.cshtml", result);
    }

    // GET: POLICY_WIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_WIN/Create.cshtml", new CreatePOLICY_WINDto());
    }

    // POST: POLICY_WIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePOLICY_WINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_WIN/Create.cshtml", createDto);
    }

    // GET: POLICY_WIN/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePOLICY_WINDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SV_CONPOLIC = result.SV_CONPOLIC,
            SV_WINPOLIC = result.SV_WINPOLIC,
        };
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_WIN/Edit.cshtml", updateDto);
    }

    // POST: POLICY_WIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePOLICY_WINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/POLICY_WIN/Edit.cshtml", updateDto);
    }

    // GET: POLICY_WIN/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_WIN/Delete.cshtml", result);
    }

    // POST: POLICY_WIN/Delete/{id}
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
