using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_MOVEME;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class OUT_MOVEMEController : Controller
{
    private readonly IOUT_MOVEMEService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5002Service _TABLE5002Service;

    public OUT_MOVEMEController(IOUT_MOVEMEService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE5002Service TABLE5002Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5002Service = TABLE5002Service;
    }

    // GET: OUT_MOVEME
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/OUT_MOVEME/Index.cshtml");

    // GET: OUT_MOVEME/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_MOVEME/Details.cshtml", result);
    }

    // GET: OUT_MOVEME/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/OUT_MOVEME/Create.cshtml", new CreateOUT_MOVEMEDto());
    }

    // POST: OUT_MOVEME/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOUT_MOVEMEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/OUT_MOVEME/Create.cshtml", createDto);
    }

    // GET: OUT_MOVEME/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateOUT_MOVEMEDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMOVNUMBE = result.NMOVNUMBE,
            NDIGIT = result.NDIGIT,
            NCAPITAL = result.NCAPITAL,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            DEXPIRDAT = result.DEXPIRDAT,
            NPREMIUM = result.NPREMIUM,
            SSTATUS_MOV = result.SSTATUS_MOV,
            NTAXAMOU = result.NTAXAMOU,
            NTRATYPEI = result.NTRATYPEI,
            NUSERCODE = result.NUSERCODE,
            NYEAR_MONTH = result.NYEAR_MONTH,
            SZONE = result.SZONE,
            NPROVINCE = result.NPROVINCE,
            DSTARTDATE = result.DSTARTDATE,
            NINSUR_AREA = result.NINSUR_AREA,
            NWAY_PAY = result.NWAY_PAY,
            NORIGI = result.NORIGI,
            NRECEIPT = result.NRECEIPT,
            NSITUATION = result.NSITUATION,
            SCLIENT = result.SCLIENT,
            NGROUP = result.NGROUP,
            NMOVNUMBE_REL = result.NMOVNUMBE_REL,
            NPREMIUMTEC = result.NPREMIUMTEC,
            NMOVEMENT = result.NMOVEMENT,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/OUT_MOVEME/Edit.cshtml", updateDto);
    }

    // POST: OUT_MOVEME/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateOUT_MOVEMEDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/OUT_MOVEME/Edit.cshtml", updateDto);
    }

    // GET: OUT_MOVEME/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_MOVEME/Delete.cshtml", result);
    }

    // POST: OUT_MOVEME/Delete/{id}
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

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

}
