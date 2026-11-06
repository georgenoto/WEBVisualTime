using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPREM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5631;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISC_XPREMController : Controller
{
    private readonly IDISC_XPREMService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5631Service _TABLE5631Service;

    public DISC_XPREMController(IDISC_XPREMService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE5631Service TABLE5631Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5631Service = TABLE5631Service;
    }

    // GET: DISC_XPREM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DISC_XPREM/Index.cshtml");

    // GET: DISC_XPREM/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPREM/Details.cshtml", result);
    }

    // GET: DISC_XPREM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5631DropdownAsync();
        return View("~/Views/Insudb/DISC_XPREM/Create.cshtml", new CreateDISC_XPREMDto());
    }

    // POST: DISC_XPREM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDISC_XPREMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5631DropdownAsync();
        return View("~/Views/Insudb/DISC_XPREM/Create.cshtml", createDto);
    }

    // GET: DISC_XPREM/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDISC_XPREMDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NDISC_CODE = result.NDISC_CODE,
            DEFFECDATE = result.DEFFECDATE,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            NCAUSE = result.NCAUSE,
            SAGREE = result.SAGREE,
            NPERCENT = result.NPERCENT,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5631DropdownAsync();
        return View("~/Views/Insudb/DISC_XPREM/Edit.cshtml", updateDto);
    }

    // POST: DISC_XPREM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDISC_XPREMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5631DropdownAsync();
        return View("~/Views/Insudb/DISC_XPREM/Edit.cshtml", updateDto);
    }

    // GET: DISC_XPREM/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPREM/Delete.cshtml", result);
    }

    // POST: DISC_XPREM/Delete/{id}
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

    private async Task PopulateTABLE5631DropdownAsync()
    {
        var items = await _TABLE5631Service.GetAllAsync();
        ViewData["NCAUSE"] = new SelectList(items, nameof(TABLE5631Dto.NCAUSE), "SDESCRIPT");
    }

}
