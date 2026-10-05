using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WINPOL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WINPOLController : Controller
{
    private readonly ITAB_WINPOLService _service;
    private readonly ITABLE5588Service _TABLE5588Service;
    private readonly IWINDOWSService _WINDOWSService;

    public TAB_WINPOLController(ITAB_WINPOLService service
        , ITABLE5588Service TABLE5588Service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _TABLE5588Service = TABLE5588Service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: TAB_WINPOL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_WINPOL/Index.cshtml", result);
    }

    // GET: TAB_WINPOL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINPOL/Details.cshtml", result);
    }

    // GET: TAB_WINPOL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPOL/Create.cshtml", new CreateTAB_WINPOLDto());
    }

    // POST: TAB_WINPOL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WINPOLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPOL/Create.cshtml", createDto);
    }

    // GET: TAB_WINPOL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WINPOLDto
        {
            SBUSSITYP = result.SBUSSITYP,
            SPOLITYPE = result.SPOLITYPE,
            SCOMPON = result.SCOMPON,
            NSEQUENCE = result.NSEQUENCE,
            NTRATYPEP = result.NTRATYPEP,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
            SAUTOMATIC = result.SAUTOMATIC,
            NTYPE_AMEND = result.NTYPE_AMEND,
            SBRANCHT = result.SBRANCHT,
        };
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPOL/Edit.cshtml", updateDto);
    }

    // POST: TAB_WINPOL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WINPOLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SBUSSITYP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/TAB_WINPOL/Edit.cshtml", updateDto);
    }

    // GET: TAB_WINPOL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WINPOL/Delete.cshtml", result);
    }

    // POST: TAB_WINPOL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5588DropdownAsync()
    {
        var items = await _TABLE5588Service.GetAllAsync();
        ViewData["NTRATYPEP"] = new SelectList(items, nameof(TABLE5588Dto.NTRATYPEP), "SDESCRIPT");
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
