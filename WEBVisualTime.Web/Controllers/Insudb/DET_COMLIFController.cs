using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DET_COMLIF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMLIF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5662;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DET_COMLIFController : Controller
{
    private readonly IDET_COMLIFService _service;
    private readonly ITAB_COMLIFService _TAB_COMLIFService;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE9108Service _TABLE9108Service;
    private readonly ITABLE5662Service _TABLE5662Service;
    private readonly ITABLE5639Service _TABLE5639Service;
    private readonly ITABLE9202Service _TABLE9202Service;

    public DET_COMLIFController(IDET_COMLIFService service
        , ITAB_COMLIFService TAB_COMLIFService
        , ITABLE10Service TABLE10Service
        , ITABLE9108Service TABLE9108Service
        , ITABLE5662Service TABLE5662Service
        , ITABLE5639Service TABLE5639Service
        , ITABLE9202Service TABLE9202Service
    )
    {
        _service = service;
        _TAB_COMLIFService = TAB_COMLIFService;
        _TABLE10Service = TABLE10Service;
        _TABLE9108Service = TABLE9108Service;
        _TABLE5662Service = TABLE5662Service;
        _TABLE5639Service = TABLE5639Service;
        _TABLE9202Service = TABLE9202Service;
    }

    // GET: DET_COMLIF
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/DET_COMLIF/Index.cshtml", result);
    }

    // GET: DET_COMLIF/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DET_COMLIF/Details.cshtml", result);
    }

    // GET: DET_COMLIF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9108DropdownAsync();
        await PopulateTABLE5662DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/DET_COMLIF/Create.cshtml", new CreateDET_COMLIFDto());
    }

    // POST: DET_COMLIF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDET_COMLIFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9108DropdownAsync();
        await PopulateTABLE5662DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/DET_COMLIF/Create.cshtml", createDto);
    }

    // GET: DET_COMLIF/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDET_COMLIFDto
        {
            NCOMTABLI = result.NCOMTABLI,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY_DUR = result.NPOLICY_DUR,
            NMIN_DURAT = result.NMIN_DURAT,
            DEFFECDATE = result.DEFFECDATE,
            NPERCENT = result.NPERCENT,
            DCOMPDATE = result.DCOMPDATE,
            NWAY_PAY = result.NWAY_PAY,
            NSELLCHANNEL = result.NSELLCHANNEL,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
            NCOVER = result.NCOVER,
            NMAX_DURAT = result.NMAX_DURAT,
            NMODULEC = result.NMODULEC,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
            NAGE_INIT = result.NAGE_INIT,
            NAGE_END = result.NAGE_END,
            NTYPE_CONTRAT = result.NTYPE_CONTRAT,
            SROUTINE = result.SROUTINE,
            NLIFE_SCHE = result.NLIFE_SCHE,
            NTYPCOMMIS = result.NTYPCOMMIS,
            NPERC_PAY = result.NPERC_PAY,
            NTYPERISK = result.NTYPERISK,
            SSMOKING = result.SSMOKING,
            NCAPITAL_INIT = result.NCAPITAL_INIT,
            NCAPITAL_END = result.NCAPITAL_END,
            NAMOUNTLIM = result.NAMOUNTLIM,
            NDRCOMM = result.NDRCOMM,
            NIDCOMM = result.NIDCOMM,
            NCATEGORY = result.NCATEGORY,
        };
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9108DropdownAsync();
        await PopulateTABLE5662DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/DET_COMLIF/Edit.cshtml", updateDto);
    }

    // POST: DET_COMLIF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDET_COMLIFDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMTABLI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_COMLIFDropdownAsync();
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9108DropdownAsync();
        await PopulateTABLE5662DropdownAsync();
        await PopulateTABLE5639DropdownAsync();
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/DET_COMLIF/Edit.cshtml", updateDto);
    }

    // GET: DET_COMLIF/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DET_COMLIF/Delete.cshtml", result);
    }

    // POST: DET_COMLIF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_COMLIFDropdownAsync()
    {
        var items = await _TAB_COMLIFService.GetAllAsync();
        ViewData["NCOMTABLI"] = new SelectList(items, nameof(TAB_COMLIFDto.NCOMTABLI), "SDESCRIPT");
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE9108DropdownAsync()
    {
        var items = await _TABLE9108Service.GetAllAsync();
        ViewData["NTYPE_CONTRAT"] = new SelectList(items, nameof(TABLE9108Dto.NTYPE_CONTRAT), "SDESCRIPT");
    }

    private async Task PopulateTABLE5662DropdownAsync()
    {
        var items = await _TABLE5662Service.GetAllAsync();
        ViewData["NTYPCOMMIS"] = new SelectList(items, nameof(TABLE5662Dto.NTYPE_COMM), "SDESCRIPT");
    }

    private async Task PopulateTABLE5639DropdownAsync()
    {
        var items = await _TABLE5639Service.GetAllAsync();
        ViewData["NTYPERISK"] = new SelectList(items, nameof(TABLE5639Dto.NTYPERISK), "SDESCRIPT");
    }

    private async Task PopulateTABLE9202DropdownAsync()
    {
        var items = await _TABLE9202Service.GetAllAsync();
        ViewData["NCATEGORY"] = new SelectList(items, nameof(TABLE9202Dto.NCATEGORY), "SDESCRIPT");
    }

}
