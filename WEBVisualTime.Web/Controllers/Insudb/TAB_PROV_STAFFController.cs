using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_STAFF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_STAFFController : Controller
{
    private readonly ITAB_PROV_STAFFService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE9258Service _TABLE9258Service;

    public TAB_PROV_STAFFController(ITAB_PROV_STAFFService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ICLIENTService CLIENTService
        , ITABLE9258Service TABLE9258Service
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _CLIENTService = CLIENTService;
        _TABLE9258Service = TABLE9258Service;
    }

    // GET: TAB_PROV_STAFF
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_STAFF/Index.cshtml");

    // GET: TAB_PROV_STAFF/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Details.cshtml", result);
    }

    // GET: TAB_PROV_STAFF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9258DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Create.cshtml", new CreateTAB_PROV_STAFFDto());
    }

    // POST: TAB_PROV_STAFF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_STAFFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9258DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_STAFF/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_STAFFDto
        {
            NPROVIDER = result.NPROVIDER,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            NSERV_ESTRUCT = result.NSERV_ESTRUCT,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NPROVIDER_REL = result.NPROVIDER_REL,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9258DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_STAFF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_STAFFDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9258DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_STAFF/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_STAFF/Delete.cshtml", result);
    }

    // POST: TAB_PROV_STAFF/Delete/{id}
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
        ViewData["NPROVIDER_REL"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE9258DropdownAsync()
    {
        var items = await _TABLE9258Service.GetAllAsync();
        ViewData["NSERV_ESTRUCT"] = new SelectList(items, nameof(TABLE9258Dto.NSERV_ESTRUCT), "SDESCRIPT");
    }

}
