using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CASH_ACCController : Controller
{
    private readonly ICASH_ACCService _service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ILEDGER_ACCService _LEDGER_ACCService;
    private readonly ICOMPANYService _COMPANYService;

    public CASH_ACCController(ICASH_ACCService service
        , ITABLE9Service TABLE9Service
        , ILEDGER_ACCService LEDGER_ACCService
        , ICOMPANYService COMPANYService
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
        _LEDGER_ACCService = LEDGER_ACCService;
        _COMPANYService = COMPANYService;
    }

    // GET: CASH_ACC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CASH_ACC/Index.cshtml");

    // GET: CASH_ACC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_ACC/Details.cshtml", result);
    }

    // GET: CASH_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_ACC/Create.cshtml", new CreateCASH_ACCDto());
    }

    // POST: CASH_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCASH_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_ACC/Create.cshtml", createDto);
    }

    // GET: CASH_ACC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCASH_ACCDto
        {
            NACC_CASH = result.NACC_CASH,
            NOFFICE = result.NOFFICE,
            NLED_COMPAN = result.NLED_COMPAN,
            SACCOUNT = result.SACCOUNT,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            DCOMPDATE = result.DCOMPDATE,
            NAVAILABLE = result.NAVAILABLE,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
            NCASHNUM = result.NCASHNUM,
            NMIN_AMOUNT = result.NMIN_AMOUNT,
            NCOMPANY = result.NCOMPANY,
            NTYPECASH = result.NTYPECASH,
        };
        await PopulateTABLE9DropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_ACC/Edit.cshtml", updateDto);
    }

    // POST: CASH_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCASH_ACCDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_ACC/Edit.cshtml", updateDto);
    }

    // GET: CASH_ACC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_ACC/Delete.cshtml", result);
    }

    // POST: CASH_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CASH_ACC/GetByNCOMPANY?NCOMPANY=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCOMPANY(int NCOMPANY)
    {
        var items = await _service.FindAsync(p => p.NCOMPANY == NCOMPANY);
        return Json(items.Select(i => new { value = i.NACC_CASH, text = i.SSTATREGT }));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateLEDGER_ACCDropdownAsync()
    {
        var items = await _LEDGER_ACCService.GetAllAsync();
        ViewData["NLED_COMPAN"] = new SelectList(items, nameof(LEDGER_ACCDto.NLED_COMPAN), "SADJU_EXCI");
        ViewData["SACCOUNT"] = new SelectList(items, nameof(LEDGER_ACCDto.SACCOUNT), "SADJU_EXCI");
        ViewData["SAUX_ACCOUN"] = new SelectList(items, nameof(LEDGER_ACCDto.SAUX_ACCOUN), "SADJU_EXCI");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

}
