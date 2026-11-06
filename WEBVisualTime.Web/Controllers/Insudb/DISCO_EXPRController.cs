using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DISCO_EXPR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE30;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISCO_EXPRController : Controller
{
    private readonly IDISCO_EXPRService _service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE30Service _TABLE30Service;

    public DISCO_EXPRController(IDISCO_EXPRService service
        , ITABLE5000Service TABLE5000Service
        , ITABLE71Service TABLE71Service
        , ITABLE75Service TABLE75Service
        , ITABLE30Service TABLE30Service
    )
    {
        _service = service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE71Service = TABLE71Service;
        _TABLE75Service = TABLE75Service;
        _TABLE30Service = TABLE30Service;
    }

    // GET: DISCO_EXPR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DISCO_EXPR/Index.cshtml");

    // GET: DISCO_EXPR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISCO_EXPR/Details.cshtml", result);
    }

    // GET: DISCO_EXPR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE30DropdownAsync();
        return View("~/Views/Insudb/DISCO_EXPR/Create.cshtml", new CreateDISCO_EXPRDto());
    }

    // POST: DISCO_EXPR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDISCO_EXPRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE30DropdownAsync();
        return View("~/Views/Insudb/DISCO_EXPR/Create.cshtml", createDto);
    }

    // GET: DISCO_EXPR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDISCO_EXPRDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NDISEXPRC = result.NDISEXPRC,
            DEFFECDATE = result.DEFFECDATE,
            NBRANCH_REI = result.NBRANCH_REI,
            NBILL_ITEM = result.NBILL_ITEM,
            SCHANALLO = result.SCHANALLO,
            NBRANCH_EST = result.NBRANCH_EST,
            SCOMMISSI_I = result.SCOMMISSI_I,
            NBRANCH_LED = result.NBRANCH_LED,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            SDEFAULTI = result.SDEFAULTI,
            SDESCRIPT = result.SDESCRIPT,
            SDEVOALLO = result.SDEVOALLO,
            NDISEXMAX = result.NDISEXMAX,
            NDISEXMIN = result.NDISEXMIN,
            NDISEXPRA = result.NDISEXPRA,
            SEDPERAPL = result.SEDPERAPL,
            DNULLDATE = result.DNULLDATE,
            NORDER_APL = result.NORDER_APL,
            SPRORATE = result.SPRORATE,
            SREQUIRE = result.SREQUIRE,
            SROUTINE = result.SROUTINE,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            NAMELEVEL = result.NAMELEVEL,
            SDISEXPRI = result.SDISEXPRI,
            SSTATREGT = result.SSTATREGT,
            NNOTENUM = result.NNOTENUM,
            SDEFPOL = result.SDEFPOL,
            STYPMAR = result.STYPMAR,
            SIVA = result.SIVA,
            NAPLY = result.NAPLY,
            NRATE = result.NRATE,
            NDISEXSUBPER = result.NDISEXSUBPER,
            NDISEXADDPER = result.NDISEXADDPER,
            SIND_STIPENDS = result.SIND_STIPENDS,
            NDINSUR_TYPE = result.NDINSUR_TYPE,
        };
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE30DropdownAsync();
        return View("~/Views/Insudb/DISCO_EXPR/Edit.cshtml", updateDto);
    }

    // POST: DISCO_EXPR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDISCO_EXPRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE30DropdownAsync();
        return View("~/Views/Insudb/DISCO_EXPR/Edit.cshtml", updateDto);
    }

    // GET: DISCO_EXPR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DISCO_EXPR/Delete.cshtml", result);
    }

    // POST: DISCO_EXPR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE71DropdownAsync()
    {
        var items = await _TABLE71Service.GetAllAsync();
        ViewData["NBRANCH_EST"] = new SelectList(items, nameof(TABLE71Dto.NBRANCH_EST), "SDESCRIPT");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateTABLE30DropdownAsync()
    {
        var items = await _TABLE30Service.GetAllAsync();
        ViewData["SDISEXPRI"] = new SelectList(items, nameof(TABLE30Dto.SDISEXPRI), "SDESCRIPT");
    }

}
