using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.QC_PARAM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_ROUTINE;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class QC_PARAMController : Controller
{
    private readonly IQC_PARAMService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly IPRODMASTERService _PRODMASTERService;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly ITABLE9105Service _TABLE9105Service;
    private readonly ITAB_ROUTINEService _TAB_ROUTINEService;
    private readonly IUSERSService _USERSService;

    public QC_PARAMController(IQC_PARAMService service
        , ITABLE10Service TABLE10Service
        , IPRODMASTERService PRODMASTERService
        , ITABLE11Service TABLE11Service
        , ITABLE9105Service TABLE9105Service
        , ITAB_ROUTINEService TAB_ROUTINEService
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _PRODMASTERService = PRODMASTERService;
        _TABLE11Service = TABLE11Service;
        _TABLE9105Service = TABLE9105Service;
        _TAB_ROUTINEService = TAB_ROUTINEService;
        _USERSService = USERSService;
    }

    // GET: QC_PARAM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/QC_PARAM/Index.cshtml");

    // GET: QC_PARAM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/QC_PARAM/Details.cshtml", result);
    }

    // GET: QC_PARAM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE9105DropdownAsync();
        await PopulateTAB_ROUTINEDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/QC_PARAM/Create.cshtml", new CreateQC_PARAMDto());
    }

    // POST: QC_PARAM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateQC_PARAMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE9105DropdownAsync();
        await PopulateTAB_ROUTINEDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/QC_PARAM/Create.cshtml", createDto);
    }

    // GET: QC_PARAM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateQC_PARAMDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SPOLITYPE = result.SPOLITYPE,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            SINDQCOBL = result.SINDQCOBL,
            NROUTY_QC = result.NROUTY_QC,
            SROUT_QC = result.SROUT_QC,
            NROUTY_QCCAP = result.NROUTY_QCCAP,
            SROUT_QCCAP = result.SROUT_QCCAP,
            NMINAGEQC = result.NMINAGEQC,
            NCAPMINCC = result.NCAPMINCC,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREG = result.SSTATREG,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE9105DropdownAsync();
        await PopulateTAB_ROUTINEDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/QC_PARAM/Edit.cshtml", updateDto);
    }

    // POST: QC_PARAM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateQC_PARAMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE9105DropdownAsync();
        await PopulateTAB_ROUTINEDropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/QC_PARAM/Edit.cshtml", updateDto);
    }

    // GET: QC_PARAM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/QC_PARAM/Delete.cshtml", result);
    }

    // POST: QC_PARAM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulatePRODMASTERDropdownAsync()
    {
        var items = await _PRODMASTERService.GetAllAsync();
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PRODMASTERDto.NPRODUCT), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9105DropdownAsync()
    {
        var items = await _TABLE9105Service.GetAllAsync();
        ViewData["NROUTY_QC"] = new SelectList(items, nameof(TABLE9105Dto.NROUTINETYPE), "SDESCRIPT");
        ViewData["NROUTY_QCCAP"] = new SelectList(items, nameof(TABLE9105Dto.NROUTINETYPE), "SDESCRIPT");
    }

    private async Task PopulateTAB_ROUTINEDropdownAsync()
    {
        var items = await _TAB_ROUTINEService.GetAllAsync();
        ViewData["SROUT_QC"] = new SelectList(items, nameof(TAB_ROUTINEDto.SROUTINE), "SDESCRIPT");
        ViewData["SROUT_QCCAP"] = new SelectList(items, nameof(TAB_ROUTINEDto.SROUTINE), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
