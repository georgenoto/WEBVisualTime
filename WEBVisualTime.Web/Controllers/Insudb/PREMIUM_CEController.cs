using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_CE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PREMIUM_CEController : Controller
{
    private readonly IPREMIUM_CEService _service;
    private readonly IPREMIUMService _PREMIUMService;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE24Service _TABLE24Service;

    public PREMIUM_CEController(IPREMIUM_CEService service
        , IPREMIUMService PREMIUMService
        , ICERTIFICATService CERTIFICATService
        , ITABLE5000Service TABLE5000Service
        , ITABLE24Service TABLE24Service
    )
    {
        _service = service;
        _PREMIUMService = PREMIUMService;
        _CERTIFICATService = CERTIFICATService;
        _TABLE5000Service = TABLE5000Service;
        _TABLE24Service = TABLE24Service;
    }

    // GET: PREMIUM_CE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PREMIUM_CE/Index.cshtml");

    // GET: PREMIUM_CE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_CE/Details.cshtml", result);
    }

    // GET: PREMIUM_CE/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePREMIUMDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        return View("~/Views/Insudb/PREMIUM_CE/Create.cshtml", new CreatePREMIUM_CEDto());
    }

    // POST: PREMIUM_CE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePREMIUM_CEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        return View("~/Views/Insudb/PREMIUM_CE/Create.cshtml", createDto);
    }

    // GET: PREMIUM_CE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePREMIUM_CEDto
        {
            SCERTYPE = result.SCERTYPE,
            NPRODUCT = result.NPRODUCT,
            NBRANCH = result.NBRANCH,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            STYPE_DETAI = result.STYPE_DETAI,
            NID_BILL = result.NID_BILL,
            NCODE_DETAI = result.NCODE_DETAI,
            NBILL_ITEM = result.NBILL_ITEM,
            NBRANCH_REI = result.NBRANCH_REI,
            DCOMPDATE = result.DCOMPDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NPREMIUM = result.NPREMIUM,
            NPREMIUMN = result.NPREMIUMN,
            DSTARTDATE = result.DSTARTDATE,
            NTRATYPEI = result.NTRATYPEI,
            NUSERCODE = result.NUSERCODE,
            NPREMANUAL = result.NPREMANUAL,
            NCOMANUAL = result.NCOMANUAL,
            SADDTAX = result.SADDTAX,
            NPREMIUMA = result.NPREMIUMA,
            NPREMIUME = result.NPREMIUME,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NRECAMOUNT = result.NRECAMOUNT,
            NDESCAMOUNT = result.NDESCAMOUNT,
            NORIGI = result.NORIGI,
            NREL_IDBILL = result.NREL_IDBILL,
            SCLIENT = result.SCLIENT,
            NCAPITAL = result.NCAPITAL,
            NCOMMI_RATE = result.NCOMMI_RATE,
            NCOMMISION = result.NCOMMISION,
            NDISSUR_TYPE = result.NDISSUR_TYPE,
        };
        await PopulatePREMIUMDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        return View("~/Views/Insudb/PREMIUM_CE/Edit.cshtml", updateDto);
    }

    // POST: PREMIUM_CE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdatePREMIUM_CEDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        return View("~/Views/Insudb/PREMIUM_CE/Edit.cshtml", updateDto);
    }

    // GET: PREMIUM_CE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_CE/Delete.cshtml", result);
    }

    // POST: PREMIUM_CE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePREMIUMDropdownAsync()
    {
        var items = await _PREMIUMService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(PREMIUMDto.SCERTYPE), "SCESSIONS");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PREMIUMDto.NPRODUCT), "SCESSIONS");
        ViewData["NBRANCH"] = new SelectList(items, nameof(PREMIUMDto.NBRANCH), "SCESSIONS");
        ViewData["NRECEIPT"] = new SelectList(items, nameof(PREMIUMDto.NRECEIPT), "SCESSIONS");
        ViewData["NDIGIT"] = new SelectList(items, nameof(PREMIUMDto.NDIGIT), "SCESSIONS");
        ViewData["NPAYNUMBE"] = new SelectList(items, nameof(PREMIUMDto.NPAYNUMBE), "SCESSIONS");
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
    }

}
