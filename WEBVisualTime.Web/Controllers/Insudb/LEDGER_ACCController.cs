using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.LED_COMPAN;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LEDGER_ACCController : Controller
{
    private readonly ILEDGER_ACCService _service;
    private readonly ILED_COMPANService _LED_COMPANService;

    public LEDGER_ACCController(ILEDGER_ACCService service
        , ILED_COMPANService LED_COMPANService
    )
    {
        _service = service;
        _LED_COMPANService = LED_COMPANService;
    }

    // GET: LEDGER_ACC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LEDGER_ACC/Index.cshtml");

    // GET: LEDGER_ACC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEDGER_ACC/Details.cshtml", result);
    }

    // GET: LEDGER_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateLED_COMPANDropdownAsync();
        return View("~/Views/Insudb/LEDGER_ACC/Create.cshtml", new CreateLEDGER_ACCDto());
    }

    // POST: LEDGER_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLEDGER_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateLED_COMPANDropdownAsync();
        return View("~/Views/Insudb/LEDGER_ACC/Create.cshtml", createDto);
    }

    // GET: LEDGER_ACC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLEDGER_ACCDto
        {
            NLED_COMPAN = result.NLED_COMPAN,
            SACCOUNT = result.SACCOUNT,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            SADJU_EXCI = result.SADJU_EXCI,
            NAUX_CREATE = result.NAUX_CREATE,
            NBALANCE = result.NBALANCE,
            SBLOCK_CRE = result.SBLOCK_CRE,
            SBLOCK_DEB = result.SBLOCK_DEB,
            SBUDGET_IND = result.SBUDGET_IND,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SORGAN_UNIT = result.SORGAN_UNIT,
            SSTATREGT = result.SSTATREGT,
            NTOTAL_CRE = result.NTOTAL_CRE,
            NTOTAL_DEB = result.NTOTAL_DEB,
            STYPE_ACC = result.STYPE_ACC,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateLED_COMPANDropdownAsync();
        return View("~/Views/Insudb/LEDGER_ACC/Edit.cshtml", updateDto);
    }

    // POST: LEDGER_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateLEDGER_ACCDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateLED_COMPANDropdownAsync();
        return View("~/Views/Insudb/LEDGER_ACC/Edit.cshtml", updateDto);
    }

    // GET: LEDGER_ACC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEDGER_ACC/Delete.cshtml", result);
    }

    // POST: LEDGER_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateLED_COMPANDropdownAsync()
    {
        var items = await _LED_COMPANService.GetAllAsync();
        ViewData["NLED_COMPAN"] = new SelectList(items, nameof(LED_COMPANDto.NLED_COMPAN), "SACCOUNT_BG");
    }

}
