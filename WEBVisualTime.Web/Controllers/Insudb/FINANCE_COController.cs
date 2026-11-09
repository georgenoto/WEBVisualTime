using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FINANCE_CO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE250;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE278;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FINANCE_COController : Controller
{
    private readonly IFINANCE_COService _service;
    private readonly ITABLE250Service _TABLE250Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE278Service _TABLE278Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE5002Service _TABLE5002Service;

    public FINANCE_COController(IFINANCE_COService service
        , ITABLE250Service TABLE250Service
        , ICLIENTService CLIENTService
        , ITABLE278Service TABLE278Service
        , ITABLE9Service TABLE9Service
        , IUSERSService USERSService
        , ITABLE5002Service TABLE5002Service
    )
    {
        _service = service;
        _TABLE250Service = TABLE250Service;
        _CLIENTService = CLIENTService;
        _TABLE278Service = TABLE278Service;
        _TABLE9Service = TABLE9Service;
        _USERSService = USERSService;
        _TABLE5002Service = TABLE5002Service;
    }

    // GET: FINANCE_CO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FINANCE_CO/Index.cshtml");

    // GET: FINANCE_CO/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANCE_CO/Details.cshtml", result);
    }

    // GET: FINANCE_CO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE250DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE278DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANCE_CO/Create.cshtml", new CreateFINANCE_CODto());
    }

    // POST: FINANCE_CO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFINANCE_CODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE250DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE278DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANCE_CO/Create.cshtml", createDto);
    }

    // GET: FINANCE_CO/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFINANCE_CODto
        {
            NAMOUNT = result.NAMOUNT,
            NFRECUENCY = result.NFRECUENCY,
            NAMOUNT_D = result.NAMOUNT_D,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            NCONTRAT = result.NCONTRAT,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            DDATE_PRINT = result.DDATE_PRINT,
            NDSCTO_AMO = result.NDSCTO_AMO,
            NSTAT_CONTR = result.NSTAT_CONTR,
            DFIRST_DRAF = result.DFIRST_DRAF,
            NINITIAL = result.NINITIAL,
            NINITIAL_OR = result.NINITIAL_OR,
            NINTEREST = result.NINTEREST,
            DLEDGER_DAT = result.DLEDGER_DAT,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NOFFICE = result.NOFFICE,
            SOPT_COMMI = result.SOPT_COMMI,
            SPAYMENT_IN = result.SPAYMENT_IN,
            NQ_DRAFT = result.NQ_DRAFT,
            SWAIT_CONTR = result.SWAIT_CONTR,
            NUSERCODE = result.NUSERCODE,
            NBILL_DAY = result.NBILL_DAY,
            NWAY_PAY = result.NWAY_PAY,
            NCOD_AGREE = result.NCOD_AGREE,
            STYPE_CONTR = result.STYPE_CONTR,
            NPOLICY = result.NPOLICY,
            SORIGIN = result.SORIGIN,
        };
        await PopulateTABLE250DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE278DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANCE_CO/Edit.cshtml", updateDto);
    }

    // POST: FINANCE_CO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateFINANCE_CODto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE250DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE278DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        return View("~/Views/Insudb/FINANCE_CO/Edit.cshtml", updateDto);
    }

    // GET: FINANCE_CO/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FINANCE_CO/Delete.cshtml", result);
    }

    // POST: FINANCE_CO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE250DropdownAsync()
    {
        var items = await _TABLE250Service.GetAllAsync();
        ViewData["NFRECUENCY"] = new SelectList(items, nameof(TABLE250Dto.NFRECUENCY), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE278DropdownAsync()
    {
        var items = await _TABLE278Service.GetAllAsync();
        ViewData["NSTAT_CONTR"] = new SelectList(items, nameof(TABLE278Dto.NSTAT_CONTR), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

}
