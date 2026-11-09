using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_MOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_BANK_MOVController : Controller
{
    private readonly IT_BANK_MOVService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;

    public T_BANK_MOVController(IT_BANK_MOVService service
        , ICOLFORMREFService COLFORMREFService
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
    }

    // GET: T_BANK_MOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/T_BANK_MOV/Index.cshtml");

    // GET: T_BANK_MOV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_BANK_MOV/Details.cshtml", result);
    }

    // GET: T_BANK_MOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_MOV/Create.cshtml", new CreateT_BANK_MOVDto());
    }

    // POST: T_BANK_MOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_BANK_MOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_MOV/Create.cshtml", createDto);
    }

    // GET: T_BANK_MOV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_BANK_MOVDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NACC_BANK = result.NACC_BANK,
            NAMOUNT = result.NAMOUNT,
            DDOC_DATE = result.DDOC_DATE,
            SDEP_NUMBER = result.SDEP_NUMBER,
            NTYPE_MOV = result.NTYPE_MOV,
            NMOVEMENT = result.NMOVEMENT,
            SNULL_MOVEM = result.SNULL_MOVEM,
            SNULL_RECOR = result.SNULL_RECOR,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NCASH_AMOUN = result.NCASH_AMOUN,
            NCHEQ_AMOUN = result.NCHEQ_AMOUN,
            NYEAR_MONTH = result.NYEAR_MONTH,
            SDOCNUMBE = result.SDOCNUMBE,
            NCONCEPT = result.NCONCEPT,
            SCLIENT = result.SCLIENT,
            NINTERMED = result.NINTERMED,
            NUSERCODE = result.NUSERCODE,
            SNUMFORM = result.SNUMFORM,
            NCLAIM = result.NCLAIM,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            NCOMPANYC = result.NCOMPANYC,
            NVOUCHER = result.NVOUCHER,
            NTYP_ACCO = result.NTYP_ACCO,
            STYPE_ACC = result.STYPE_ACC,
            NCASHNUM = result.NCASHNUM,
            DPOSTED = result.DPOSTED,
            NNOTENUM = result.NNOTENUM,
            NINSUR_AREA = result.NINSUR_AREA,
            DCOLLECTION = result.DCOLLECTION,
            NPROPONUM = result.NPROPONUM,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCURRENCY = result.NCURRENCY,
            NEXCHANGE = result.NEXCHANGE,
            NORI_CURR = result.NORI_CURR,
            NSUPPORT_ID = result.NSUPPORT_ID,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NCASH_ID = result.NCASH_ID,
            NCOD_AGREE = result.NCOD_AGREE,
            NBANK_AGREE = result.NBANK_AGREE,
            NINPUTCHANNEL = result.NINPUTCHANNEL,
            SACTION = result.SACTION,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NORI_AMOUNT = result.NORI_AMOUNT,
            DVALUEDATE = result.DVALUEDATE,
        };
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_MOV/Edit.cshtml", updateDto);
    }

    // POST: T_BANK_MOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateT_BANK_MOVDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_MOV/Edit.cshtml", updateDto);
    }

    // GET: T_BANK_MOV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_BANK_MOV/Delete.cshtml", result);
    }

    // POST: T_BANK_MOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

}
