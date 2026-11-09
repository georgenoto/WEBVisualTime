using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRAT_PAY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8100;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8101;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTRAT_PAYController : Controller
{
    private readonly ICONTRAT_PAYService _service;
    private readonly ITABLE8100Service _TABLE8100Service;
    private readonly ITABLE8101Service _TABLE8101Service;

    public CONTRAT_PAYController(ICONTRAT_PAYService service
        , ITABLE8100Service TABLE8100Service
        , ITABLE8101Service TABLE8101Service
    )
    {
        _service = service;
        _TABLE8100Service = TABLE8100Service;
        _TABLE8101Service = TABLE8101Service;
    }

    // GET: CONTRAT_PAY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CONTRAT_PAY/Index.cshtml");

    // GET: CONTRAT_PAY/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRAT_PAY/Details.cshtml", result);
    }

    // GET: CONTRAT_PAY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8100DropdownAsync();
        await PopulateTABLE8101DropdownAsync();
        return View("~/Views/Insudb/CONTRAT_PAY/Create.cshtml", new CreateCONTRAT_PAYDto());
    }

    // POST: CONTRAT_PAY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTRAT_PAYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8100DropdownAsync();
        await PopulateTABLE8101DropdownAsync();
        return View("~/Views/Insudb/CONTRAT_PAY/Create.cshtml", createDto);
    }

    // GET: CONTRAT_PAY/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTRAT_PAYDto
        {
            NCONTRAT_PAY = result.NCONTRAT_PAY,
            NTYPE_CONTRAT = result.NTYPE_CONTRAT,
            STYP_COM_IND = result.STYP_COM_IND,
            NCOM_TABNUM = result.NCOM_TABNUM,
            SCLIENT = result.SCLIENT,
            SDESCRIPT = result.SDESCRIPT,
            DSTARTDATE = result.DSTARTDATE,
            NTYPE_CALC = result.NTYPE_CALC,
            NPERCENT = result.NPERCENT,
            NAMOUNT = result.NAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NAPLY = result.NAPLY,
            STAXIN = result.STAXIN,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTYP_ACCO = result.NTYP_ACCO,
            DEXPIRDAT = result.DEXPIRDAT,
            SROUTINE = result.SROUTINE,
            DLASTCALCULATED = result.DLASTCALCULATED,
        };
        await PopulateTABLE8100DropdownAsync();
        await PopulateTABLE8101DropdownAsync();
        return View("~/Views/Insudb/CONTRAT_PAY/Edit.cshtml", updateDto);
    }

    // POST: CONTRAT_PAY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCONTRAT_PAYDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8100DropdownAsync();
        await PopulateTABLE8101DropdownAsync();
        return View("~/Views/Insudb/CONTRAT_PAY/Edit.cshtml", updateDto);
    }

    // GET: CONTRAT_PAY/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRAT_PAY/Delete.cshtml", result);
    }

    // POST: CONTRAT_PAY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8100DropdownAsync()
    {
        var items = await _TABLE8100Service.GetAllAsync();
        ViewData["NTYPE_CALC"] = new SelectList(items, nameof(TABLE8100Dto.NTYPE_CALC), "SDESCRIPT");
    }

    private async Task PopulateTABLE8101DropdownAsync()
    {
        var items = await _TABLE8101Service.GetAllAsync();
        ViewData["NAPLY"] = new SelectList(items, nameof(TABLE8101Dto.NAPLY), "SDESCRIPT");
    }

}
