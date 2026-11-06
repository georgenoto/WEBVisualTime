using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CRED_CARD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CRED_CARDController : Controller
{
    private readonly ICRED_CARDService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE183Service _TABLE183Service;

    public CRED_CARDController(ICRED_CARDService service
        , ICLIENTService CLIENTService
        , ITABLE7Service TABLE7Service
        , ITABLE183Service TABLE183Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE7Service = TABLE7Service;
        _TABLE183Service = TABLE183Service;
    }

    // GET: CRED_CARD
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CRED_CARD/Index.cshtml");

    // GET: CRED_CARD/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CRED_CARD/Details.cshtml", result);
    }

    // GET: CRED_CARD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/CRED_CARD/Create.cshtml", new CreateCRED_CARDDto());
    }

    // POST: CRED_CARD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCRED_CARDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/CRED_CARD/Create.cshtml", createDto);
    }

    // GET: CRED_CARD/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCRED_CARDDto
        {
            SCLIENT = result.SCLIENT,
            NBANKEXT = result.NBANKEXT,
            SCREDI_CARD = result.SCREDI_CARD,
            NCARD_TYPE = result.NCARD_TYPE,
            SSTATREGT = result.SSTATREGT,
            DCARDEXPIR = result.DCARDEXPIR,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            STYP_DIRDEB = result.STYP_DIRDEB,
            NCURRENCY = result.NCURRENCY,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/CRED_CARD/Edit.cshtml", updateDto);
    }

    // POST: CRED_CARD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCRED_CARDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE183DropdownAsync();
        return View("~/Views/Insudb/CRED_CARD/Edit.cshtml", updateDto);
    }

    // GET: CRED_CARD/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CRED_CARD/Delete.cshtml", result);
    }

    // POST: CRED_CARD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE183DropdownAsync()
    {
        var items = await _TABLE183Service.GetAllAsync();
        ViewData["NCARD_TYPE"] = new SelectList(items, nameof(TABLE183Dto.NCARD_TYPE), "SDESCRIPT");
    }

}
