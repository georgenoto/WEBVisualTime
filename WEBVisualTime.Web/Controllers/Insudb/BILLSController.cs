using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5564;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BILLSController : Controller
{
    private readonly IBILLSService _service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5564Service _TABLE5564Service;

    public BILLSController(IBILLSService service
        , ITABLE5001Service TABLE5001Service
        , ICLIENTService CLIENTService
        , ITABLE5564Service TABLE5564Service
    )
    {
        _service = service;
        _TABLE5001Service = TABLE5001Service;
        _CLIENTService = CLIENTService;
        _TABLE5564Service = TABLE5564Service;
    }

    // GET: BILLS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BILLS/Index.cshtml");

    // GET: BILLS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS/Details.cshtml", result);
    }

    // GET: BILLS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5564DropdownAsync();
        return View("~/Views/Insudb/BILLS/Create.cshtml", new CreateBILLSDto());
    }

    // POST: BILLS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBILLSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5564DropdownAsync();
        return View("~/Views/Insudb/BILLS/Create.cshtml", createDto);
    }

    // GET: BILLS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBILLSDto
        {
            NINSUR_AREA = result.NINSUR_AREA,
            SBILLTYPE = result.SBILLTYPE,
            SBILLING = result.SBILLING,
            NBILLNUM = result.NBILLNUM,
            NCURRENCY = result.NCURRENCY,
            SCLIENT = result.SCLIENT,
            NAMOUNT = result.NAMOUNT,
            NAMO_AFEC = result.NAMO_AFEC,
            NAMO_EXEN = result.NAMO_EXEN,
            NIVA = result.NIVA,
            NCRE_NOTE = result.NCRE_NOTE,
            NNEWBILL = result.NNEWBILL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBILLSTAT = result.NBILLSTAT,
            DSTATDATE = result.DSTATDATE,
            DVALDATE = result.DVALDATE,
            SKEYADDRESS = result.SKEYADDRESS,
            NRECOWNER = result.NRECOWNER,
            SBILL_IND = result.SBILL_IND,
            SORIGIN = result.SORIGIN,
            NPREVBILL = result.NPREVBILL,
            DISSUEDAT = result.DISSUEDAT,
            SBILLFULLNUM = result.SBILLFULLNUM,
            SAUTHORIZATION = result.SAUTHORIZATION,
            NRUCPRINT = result.NRUCPRINT,
            NIDTRANSACTION = result.NIDTRANSACTION,
            SBILLNUMSFE = result.SBILLNUMSFE,
            NBORDEREAUX = result.NBORDEREAUX,
            NPOLICY = result.NPOLICY,
            NNULLCODE = result.NNULLCODE,
            NCERTIF = result.NCERTIF,
            NRECEIPTCORP = result.NRECEIPTCORP,
        };
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5564DropdownAsync();
        return View("~/Views/Insudb/BILLS/Edit.cshtml", updateDto);
    }

    // POST: BILLS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBILLSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINSUR_AREA, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5564DropdownAsync();
        return View("~/Views/Insudb/BILLS/Edit.cshtml", updateDto);
    }

    // GET: BILLS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS/Delete.cshtml", result);
    }

    // POST: BILLS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5564DropdownAsync()
    {
        var items = await _TABLE5564Service.GetAllAsync();
        ViewData["NBILLSTAT"] = new SelectList(items, nameof(TABLE5564Dto.NBILLSTAT), "SDESCRIPT");
    }

}
