using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5563;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMPANYController : Controller
{
    private readonly ICOMPANYService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE66Service _TABLE66Service;
    private readonly ITABLE5563Service _TABLE5563Service;
    private readonly ITAB_LOCATService _TAB_LOCATService;

    public COMPANYController(ICOMPANYService service
        , ICLIENTService CLIENTService
        , ITABLE66Service TABLE66Service
        , ITABLE5563Service TABLE5563Service
        , ITAB_LOCATService TAB_LOCATService
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE66Service = TABLE66Service;
        _TABLE5563Service = TABLE5563Service;
        _TAB_LOCATService = TAB_LOCATService;
    }

    // GET: COMPANY
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMPANY/Index.cshtml");

    // GET: COMPANY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMPANY/Details.cshtml", result);
    }

    // GET: COMPANY/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE5563DropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/COMPANY/Create.cshtml", new CreateCOMPANYDto());
    }

    // POST: COMPANY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMPANYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE5563DropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/COMPANY/Create.cshtml", createDto);
    }

    // GET: COMPANY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMPANYDto
        {
            NCOMPANY = result.NCOMPANY,
            SACCOUNT = result.SACCOUNT,
            SCLIENT = result.SCLIENT,
            SBANKNAME = result.SBANKNAME,
            DCOMPDATE = result.DCOMPDATE,
            NCOUNTRY = result.NCOUNTRY,
            DINPDATE = result.DINPDATE,
            SSTATREGT = result.SSTATREGT,
            NTAXRATE = result.NTAXRATE,
            STYPE = result.STYPE,
            SREGSVS = result.SREGSVS,
            NUSERCODE = result.NUSERCODE,
            SNATIONAL = result.SNATIONAL,
            NCLASIFIC = result.NCLASIFIC,
            SABA_ID = result.SABA_ID,
            SWIFT_IT = result.SWIFT_IT,
            NLOCAL = result.NLOCAL,
            SCITY = result.SCITY,
            NBANKCOUNTRY = result.NBANKCOUNTRY,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE5563DropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/COMPANY/Edit.cshtml", updateDto);
    }

    // POST: COMPANY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMPANYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMPANY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE5563DropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        return View("~/Views/Insudb/COMPANY/Edit.cshtml", updateDto);
    }

    // GET: COMPANY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMPANY/Delete.cshtml", result);
    }

    // POST: COMPANY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: COMPANY/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string? SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NCOMPANY, text = i.SACCOUNT }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE66DropdownAsync()
    {
        var items = await _TABLE66Service.GetAllAsync();
        ViewData["NCOUNTRY"] = new SelectList(items, nameof(TABLE66Dto.NCOUNTRY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5563DropdownAsync()
    {
        var items = await _TABLE5563Service.GetAllAsync();
        ViewData["NCLASIFIC"] = new SelectList(items, nameof(TABLE5563Dto.NCLASIFIC), "SDESCRIPT");
    }

    private async Task PopulateTAB_LOCATDropdownAsync()
    {
        var items = await _TAB_LOCATService.GetAllAsync();
        ViewData["NLOCAL"] = new SelectList(items, nameof(TAB_LOCATDto.NLOCAL), "SDESCRIPT");
    }

}
