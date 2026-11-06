using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLASSPROPERTYWIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLASSPROPERTYWINController : Controller
{
    private readonly ICLASSPROPERTYWINService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly IPROPERTYLIBRARYService _PROPERTYLIBRARYService;

    public CLASSPROPERTYWINController(ICLASSPROPERTYWINService service
        , IWINDOWSService WINDOWSService
        , IPROPERTYLIBRARYService PROPERTYLIBRARYService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _PROPERTYLIBRARYService = PROPERTYLIBRARYService;
    }

    // GET: CLASSPROPERTYWIN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLASSPROPERTYWIN/Index.cshtml");

    // GET: CLASSPROPERTYWIN/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Details.cshtml", result);
    }

    // GET: CLASSPROPERTYWIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Create.cshtml", new CreateCLASSPROPERTYWINDto());
    }

    // POST: CLASSPROPERTYWIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLASSPROPERTYWINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Create.cshtml", createDto);
    }

    // GET: CLASSPROPERTYWIN/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLASSPROPERTYWINDto
        {
            SCODISPL = result.SCODISPL,
            NIDCLASS = result.NIDCLASS,
            NIDPROPERTY = result.NIDPROPERTY,
            SVISIBLE = result.SVISIBLE,
            NORDEN = result.NORDEN,
            SCAPTION = result.SCAPTION,
            DCOMPDATE = result.DCOMPDATE,
            NWIDTH = result.NWIDTH,
            NUSERCODE = result.NUSERCODE,
            SKEY = result.SKEY,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Edit.cshtml", updateDto);
    }

    // POST: CLASSPROPERTYWIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLASSPROPERTYWINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODISPL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Edit.cshtml", updateDto);
    }

    // GET: CLASSPROPERTYWIN/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLASSPROPERTYWIN/Delete.cshtml", result);
    }

    // POST: CLASSPROPERTYWIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

    private async Task PopulatePROPERTYLIBRARYDropdownAsync()
    {
        var items = await _PROPERTYLIBRARYService.GetAllAsync();
        ViewData["NIDPROPERTY"] = new SelectList(items, nameof(PROPERTYLIBRARYDto.NIDPROPERTY), "SPROPERTY");
    }

}
