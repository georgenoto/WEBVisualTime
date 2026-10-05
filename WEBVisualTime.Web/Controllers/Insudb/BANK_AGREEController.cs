using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_AGREE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BANK_AGREEController : Controller
{
    private readonly IBANK_AGREEService _service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly IBANK_ACCService _BANK_ACCService;
    private readonly ICLIENTService _CLIENTService;

    public BANK_AGREEController(IBANK_AGREEService service
        , ITABLE7Service TABLE7Service
        , IBANK_ACCService BANK_ACCService
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _TABLE7Service = TABLE7Service;
        _BANK_ACCService = BANK_ACCService;
        _CLIENTService = CLIENTService;
    }

    // GET: BANK_AGREE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BANK_AGREE/Index.cshtml", result);
    }

    // GET: BANK_AGREE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_AGREE/Details.cshtml", result);
    }

    // GET: BANK_AGREE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BANK_AGREE/Create.cshtml", new CreateBANK_AGREEDto());
    }

    // POST: BANK_AGREE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBANK_AGREEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BANK_AGREE/Create.cshtml", createDto);
    }

    // GET: BANK_AGREE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBANK_AGREEDto
        {
            STYPE_BANKAGREE = result.STYPE_BANKAGREE,
            NBANK = result.NBANK,
            NACCOUNT = result.NACCOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCLIENT = result.SCLIENT,
            NNUMDIGIT = result.NNUMDIGIT,
            SFORMAT = result.SFORMAT,
        };
        await PopulateTABLE7DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BANK_AGREE/Edit.cshtml", updateDto);
    }

    // POST: BANK_AGREE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBANK_AGREEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STYPE_BANKAGREE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateBANK_ACCDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/BANK_AGREE/Edit.cshtml", updateDto);
    }

    // GET: BANK_AGREE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_AGREE/Delete.cshtml", result);
    }

    // POST: BANK_AGREE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateBANK_ACCDropdownAsync()
    {
        var items = await _BANK_ACCService.GetAllAsync();
        ViewData["NACCOUNT"] = new SelectList(items, nameof(BANK_ACCDto.NACC_BANK), "SACC_LEDGER");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
