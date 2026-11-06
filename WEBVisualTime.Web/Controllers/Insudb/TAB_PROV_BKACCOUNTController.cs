using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_BKACCOUNT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_BKACCOUNTController : Controller
{
    private readonly ITAB_PROV_BKACCOUNTService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE190Service _TABLE190Service;
    private readonly ICLIENTService _CLIENTService;

    public TAB_PROV_BKACCOUNTController(ITAB_PROV_BKACCOUNTService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE7Service TABLE7Service
        , ITABLE190Service TABLE190Service
        , ICLIENTService CLIENTService
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE7Service = TABLE7Service;
        _TABLE190Service = TABLE190Service;
        _CLIENTService = CLIENTService;
    }

    // GET: TAB_PROV_BKACCOUNT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_BKACCOUNT/Index.cshtml");

    // GET: TAB_PROV_BKACCOUNT/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Details.cshtml", result);
    }

    // GET: TAB_PROV_BKACCOUNT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Create.cshtml", new CreateTAB_PROV_BKACCOUNTDto());
    }

    // POST: TAB_PROV_BKACCOUNT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_BKACCOUNTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_BKACCOUNT/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_BKACCOUNTDto
        {
            NPROVIDER = result.NPROVIDER,
            NBANKEXT = result.NBANKEXT,
            SACCOUNT = result.SACCOUNT,
            NTYP_ACC = result.NTYP_ACC,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SDEPOSIT = result.SDEPOSIT,
            SCLIENTR = result.SCLIENTR,
            NCURRENCY = result.NCURRENCY,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_BKACCOUNT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_BKACCOUNTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_BKACCOUNT/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_BKACCOUNT/Delete.cshtml", result);
    }

    // POST: TAB_PROV_BKACCOUNT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE190DropdownAsync()
    {
        var items = await _TABLE190Service.GetAllAsync();
        ViewData["NTYP_ACC"] = new SelectList(items, nameof(TABLE190Dto.NACC_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENTR"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

}
