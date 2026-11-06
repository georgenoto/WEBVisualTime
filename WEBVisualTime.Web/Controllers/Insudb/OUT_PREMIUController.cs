using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_PREMIU;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.OUT_MOVEME;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class OUT_PREMIUController : Controller
{
    private readonly IOUT_PREMIUService _service;
    private readonly IOUT_MOVEMEService _OUT_MOVEMEService;
    private readonly ITABLE9207Service _TABLE9207Service;

    public OUT_PREMIUController(IOUT_PREMIUService service
        , IOUT_MOVEMEService OUT_MOVEMEService
        , ITABLE9207Service TABLE9207Service
    )
    {
        _service = service;
        _OUT_MOVEMEService = OUT_MOVEMEService;
        _TABLE9207Service = TABLE9207Service;
    }

    // GET: OUT_PREMIU
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/OUT_PREMIU/Index.cshtml");

    // GET: OUT_PREMIU/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_PREMIU/Details.cshtml", result);
    }

    // GET: OUT_PREMIU/Create
    public async Task<IActionResult> Create()
    {
        await PopulateOUT_MOVEMEDropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/OUT_PREMIU/Create.cshtml", new CreateOUT_PREMIUDto());
    }

    // POST: OUT_PREMIU/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOUT_PREMIUDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateOUT_MOVEMEDropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/OUT_PREMIU/Create.cshtml", createDto);
    }

    // GET: OUT_PREMIU/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateOUT_PREMIUDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NMOVNUMBE = result.NMOVNUMBE,
            NDIGIT = result.NDIGIT,
            NID_BILL = result.NID_BILL,
            SADDSUINI = result.SADDSUINI,
            STYPE_DETAI = result.STYPE_DETAI,
            NBILL_ITEM = result.NBILL_ITEM,
            NCODE_DETAI = result.NCODE_DETAI,
            NBRANCH_EST = result.NBRANCH_EST,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            DCOMPDATE = result.DCOMPDATE,
            NPREMIUM = result.NPREMIUM,
            NTAX = result.NTAX,
            NUSERCODE = result.NUSERCODE,
            NPROVINCIE = result.NPROVINCIE,
            NPREM_ANU = result.NPREM_ANU,
            NCOM_ANU = result.NCOM_ANU,
            NPREMANUAL = result.NPREMANUAL,
            SADDTAX = result.SADDTAX,
            NCOMANUAL = result.NCOMANUAL,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
            NCOM_SUPER = result.NCOM_SUPER,
            NCOMANUAL_SUPER = result.NCOMANUAL_SUPER,
            NCOMSUP_RATE = result.NCOMSUP_RATE,
        };
        await PopulateOUT_MOVEMEDropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/OUT_PREMIU/Edit.cshtml", updateDto);
    }

    // POST: OUT_PREMIU/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateOUT_PREMIUDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateOUT_MOVEMEDropdownAsync();
        await PopulateTABLE9207DropdownAsync();
        return View("~/Views/Insudb/OUT_PREMIU/Edit.cshtml", updateDto);
    }

    // GET: OUT_PREMIU/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/OUT_PREMIU/Delete.cshtml", result);
    }

    // POST: OUT_PREMIU/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateOUT_MOVEMEDropdownAsync()
    {
        var items = await _OUT_MOVEMEService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(OUT_MOVEMEDto.SCERTYPE), "SSTATUS_MOV");
        ViewData["NBRANCH"] = new SelectList(items, nameof(OUT_MOVEMEDto.NBRANCH), "SSTATUS_MOV");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(OUT_MOVEMEDto.NPRODUCT), "SSTATUS_MOV");
        ViewData["NPOLICY"] = new SelectList(items, nameof(OUT_MOVEMEDto.NPOLICY), "SSTATUS_MOV");
        ViewData["NCERTIF"] = new SelectList(items, nameof(OUT_MOVEMEDto.NCERTIF), "SSTATUS_MOV");
        ViewData["NMOVNUMBE"] = new SelectList(items, nameof(OUT_MOVEMEDto.NMOVNUMBE), "SSTATUS_MOV");
        ViewData["NDIGIT"] = new SelectList(items, nameof(OUT_MOVEMEDto.NDIGIT), "SSTATUS_MOV");
    }

    private async Task PopulateTABLE9207DropdownAsync()
    {
        var items = await _TABLE9207Service.GetAllAsync();
        ViewData["NDISSUR_TYPE"] = new SelectList(items, nameof(TABLE9207Dto.NDISSUR_TYPE), "SDESCRIPT");
    }

}
