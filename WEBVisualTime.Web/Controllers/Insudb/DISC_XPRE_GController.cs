using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DISC_XPRE_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISC_XPRE_GController : Controller
{
    private readonly IDISC_XPRE_GService _service;

    public DISC_XPRE_GController(IDISC_XPRE_GService service
    )
    {
        _service = service;
    }

    // GET: DISC_XPRE_G
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DISC_XPRE_G/Index.cshtml");

    // GET: DISC_XPRE_G/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPRE_G/Details.cshtml", result);
    }

    // GET: DISC_XPRE_G/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/DISC_XPRE_G/Create.cshtml", new CreateDISC_XPRE_GDto());
    }

    // POST: DISC_XPRE_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDISC_XPRE_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DISC_XPRE_G/Create.cshtml", createDto);
    }

    // GET: DISC_XPRE_G/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDISC_XPRE_GDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NGROUP = result.NGROUP,
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
        return View("~/Views/Insudb/DISC_XPRE_G/Edit.cshtml", updateDto);
    }

    // POST: DISC_XPRE_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateDISC_XPRE_GDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DISC_XPRE_G/Edit.cshtml", updateDto);
    }

    // GET: DISC_XPRE_G/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISC_XPRE_G/Delete.cshtml", result);
    }

    // POST: DISC_XPRE_G/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
