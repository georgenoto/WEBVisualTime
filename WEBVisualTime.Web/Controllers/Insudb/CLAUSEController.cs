using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUSE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAUSEController : Controller
{
    private readonly ICLAUSEService _service;
    private readonly ICERTIFICATService _CERTIFICATService;

    public CLAUSEController(ICLAUSEService service
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: CLAUSE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAUSE/Index.cshtml");

    // GET: CLAUSE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUSE/Details.cshtml", result);
    }

    // GET: CLAUSE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/CLAUSE/Create.cshtml", new CreateCLAUSEDto());
    }

    // POST: CLAUSE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAUSEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/CLAUSE/Create.cshtml", createDto);
    }

    // GET: CLAUSE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAUSEDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NCLAUSE = result.NCLAUSE,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NID = result.NID,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SCLIENT = result.SCLIENT,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCAUSE = result.NCAUSE,
            SAGREE = result.SAGREE,
            STYPE_CLAUSE = result.STYPE_CLAUSE,
            SDOC_ATTACH = result.SDOC_ATTACH,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/CLAUSE/Edit.cshtml", updateDto);
    }

    // POST: CLAUSE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLAUSEDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/CLAUSE/Edit.cshtml", updateDto);
    }

    // GET: CLAUSE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUSE/Delete.cshtml", result);
    }

    // POST: CLAUSE/Delete/{id}
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
