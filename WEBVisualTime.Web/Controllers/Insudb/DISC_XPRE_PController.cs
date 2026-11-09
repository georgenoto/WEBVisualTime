using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_P;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISC_XPRE_PController : Controller
{
    private readonly IDISC_XPRE_PService _service;
    private readonly IPOLICYService _POLICYService;

    public DISC_XPRE_PController(IDISC_XPRE_PService service
        , IPOLICYService POLICYService
    )
    {
        _service = service;
        _POLICYService = POLICYService;
    }

    // GET: DISC_XPRE_P
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DISC_XPRE_P/Index.cshtml");

    // GET: DISC_XPRE_P/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPRE_P/Details.cshtml", result);
    }

    // GET: DISC_XPRE_P/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/DISC_XPRE_P/Create.cshtml", new CreateDISC_XPRE_PDto());
    }

    // POST: DISC_XPRE_P/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDISC_XPRE_PDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/DISC_XPRE_P/Create.cshtml", createDto);
    }

    // GET: DISC_XPRE_P/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDISC_XPRE_PDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NDISC_CODE = result.NDISC_CODE,
            DEFFECDATE = result.DEFFECDATE,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            NPERCENT = result.NPERCENT,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/DISC_XPRE_P/Edit.cshtml", updateDto);
    }

    // POST: DISC_XPRE_P/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateDISC_XPRE_PDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/DISC_XPRE_P/Edit.cshtml", updateDto);
    }

    // GET: DISC_XPRE_P/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPRE_P/Delete.cshtml", result);
    }

    // POST: DISC_XPRE_P/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

}
