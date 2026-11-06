using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTRMASTERController : Controller
{
    private readonly ICONTRMASTERService _service;
    private readonly ITABLE173Service _TABLE173Service;
    private readonly ITABLE5000Service _TABLE5000Service;

    public CONTRMASTERController(ICONTRMASTERService service
        , ITABLE173Service TABLE173Service
        , ITABLE5000Service TABLE5000Service
    )
    {
        _service = service;
        _TABLE173Service = TABLE173Service;
        _TABLE5000Service = TABLE5000Service;
    }

    // GET: CONTRMASTER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CONTRMASTER/Index.cshtml");

    // GET: CONTRMASTER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRMASTER/Details.cshtml", result);
    }

    // GET: CONTRMASTER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE173DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        return View("~/Views/Insudb/CONTRMASTER/Create.cshtml", new CreateCONTRMASTERDto());
    }

    // POST: CONTRMASTER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTRMASTERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE173DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        return View("~/Views/Insudb/CONTRMASTER/Create.cshtml", createDto);
    }

    // GET: CONTRMASTER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTRMASTERDto
        {
            NTYPE_REL = result.NTYPE_REL,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            DSTARTDATE = result.DSTARTDATE,
            NBRANCH = result.NBRANCH,
            NCURRENCY = result.NCURRENCY,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DEXPIRDAT = result.DEXPIRDAT,
            NCURR_PAY = result.NCURR_PAY,
            SFORMPAY = result.SFORMPAY,
        };
        await PopulateTABLE173DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        return View("~/Views/Insudb/CONTRMASTER/Edit.cshtml", updateDto);
    }

    // POST: CONTRMASTER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTRMASTERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_REL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE173DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        return View("~/Views/Insudb/CONTRMASTER/Edit.cshtml", updateDto);
    }

    // GET: CONTRMASTER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRMASTER/Delete.cshtml", result);
    }

    // POST: CONTRMASTER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE173DropdownAsync()
    {
        var items = await _TABLE173Service.GetAllAsync();
        ViewData["NTYPE"] = new SelectList(items, nameof(TABLE173Dto.NTYPE_REIN), "SDESCRIPT");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

}
