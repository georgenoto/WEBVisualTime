using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_CHEQUES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_CHEQUESController : Controller
{
    private readonly IT_CHEQUESService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;

    public T_CHEQUESController(IT_CHEQUESService service
        , ICOLFORMREFService COLFORMREFService
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
    }

    // GET: T_CHEQUES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_CHEQUES/Index.cshtml", result);
    }

    // GET: T_CHEQUES/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_CHEQUES/Details.cshtml", result);
    }

    // GET: T_CHEQUES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_CHEQUES/Create.cshtml", new CreateT_CHEQUESDto());
    }

    // POST: T_CHEQUES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_CHEQUESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_CHEQUES/Create.cshtml", createDto);
    }

    // GET: T_CHEQUES/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_CHEQUESDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NREQUEST_NU = result.NREQUEST_NU,
            SCHEQUE = result.SCHEQUE,
            NAMOUNT = result.NAMOUNT,
            SCLIENT = result.SCLIENT,
            DDAT_PROPOS = result.DDAT_PROPOS,
            SREQUEST_TY = result.SREQUEST_TY,
            NACC_BANK = result.NACC_BANK,
            NCURRENCY = result.NCURRENCY,
            NCONSEC = result.NCONSEC,
            NCONCEPT = result.NCONCEPT,
            NBRANCH_LED = result.NBRANCH_LED,
            NCLAIM = result.NCLAIM,
            DCOMPDATE = result.DCOMPDATE,
            NVOUCHER_LE = result.NVOUCHER_LE,
            NVOUCHER = result.NVOUCHER,
            SDESCRIPT = result.SDESCRIPT,
            DISSUE_DAT = result.DISSUE_DAT,
            DLEDGER_DAT = result.DLEDGER_DAT,
            NNULLCODE = result.NNULLCODE,
            DNULLDATE = result.DNULLDATE,
            SPAY_FREQ = result.SPAY_FREQ,
            NQ_PAYS = result.NQ_PAYS,
            NRECEIPT = result.NRECEIPT,
            NSTA_CHEQUE = result.NSTA_CHEQUE,
            DSTAT_DATE = result.DSTAT_DATE,
            NTRANSAC = result.NTRANSAC,
            NUSER_SOL = result.NUSER_SOL,
            NUSERCODE = result.NUSERCODE,
            NYEAR_MONTH = result.NYEAR_MONTH,
            NNOTENUM = result.NNOTENUM,
            NAFECT = result.NAFECT,
            NEXENT = result.NEXENT,
            NTAXCODE = result.NTAXCODE,
            NTAX_AMOUNT = result.NTAX_AMOUNT,
            NOFFICE = result.NOFFICE,
            NCASHNUM = result.NCASHNUM,
            NINSUR_AREA = result.NINSUR_AREA,
            NPAYORDBORD = result.NPAYORDBORD,
            NCOMPANY = result.NCOMPANY,
            SINTER_PAY = result.SINTER_PAY,
            NAMOUNT_LOCAL = result.NAMOUNT_LOCAL,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            SFILE_FIN700 = result.SFILE_FIN700,
            DDATE_FIN700 = result.DDATE_FIN700,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NDOCSUPPORT = result.NDOCSUPPORT,
            NTAX_PERCENT = result.NTAX_PERCENT,
            NCURRENCYORI = result.NCURRENCYORI,
            NCURRENCY_PAY = result.NCURRENCY_PAY,
            NAMOUNTPAY = result.NAMOUNTPAY,
            DPOSTED = result.DPOSTED,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            SACTION = result.SACTION,
        };
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_CHEQUES/Edit.cshtml", updateDto);
    }

    // POST: T_CHEQUES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_CHEQUESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_CHEQUES/Edit.cshtml", updateDto);
    }

    // GET: T_CHEQUES/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_CHEQUES/Delete.cshtml", result);
    }

    // POST: T_CHEQUES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
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
