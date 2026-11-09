using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_DOCUM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETT_DOCUMController : Controller
{
    private readonly ICLAIM_SETT_DOCUMService _service;
    private readonly ITABLE203Service _TABLE203Service;

    public CLAIM_SETT_DOCUMController(ICLAIM_SETT_DOCUMService service
        , ITABLE203Service TABLE203Service
    )
    {
        _service = service;
        _TABLE203Service = TABLE203Service;
    }

    // GET: CLAIM_SETT_DOCUM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_SETT_DOCUM/Index.cshtml");

    // GET: CLAIM_SETT_DOCUM/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Details.cshtml", result);
    }

    // GET: CLAIM_SETT_DOCUM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE203DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Create.cshtml", new CreateCLAIM_SETT_DOCUMDto());
    }

    // POST: CLAIM_SETT_DOCUM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETT_DOCUMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE203DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETT_DOCUM/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETT_DOCUMDto
        {
            NSEQ_IDLEDGERDOCUM = result.NSEQ_IDLEDGERDOCUM,
            NCONSEC_DOC = result.NCONSEC_DOC,
            DRECEPDATE = result.DRECEPDATE,
            SDESCRIPT = result.SDESCRIPT,
            NSTATUS_DOC = result.NSTATUS_DOC,
            NDOC_CODE = result.NDOC_CODE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
        };
        await PopulateTABLE203DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETT_DOCUM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLAIM_SETT_DOCUMDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE203DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETT_DOCUM/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_DOCUM/Delete.cshtml", result);
    }

    // POST: CLAIM_SETT_DOCUM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE203DropdownAsync()
    {
        var items = await _TABLE203Service.GetAllAsync();
        ViewData["NSTATUS_DOC"] = new SelectList(items, nameof(TABLE203Dto.NSTATUS_DOC), "SDESCRIPT");
    }

}
