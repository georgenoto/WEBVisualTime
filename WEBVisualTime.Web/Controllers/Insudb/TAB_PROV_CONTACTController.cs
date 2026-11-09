using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_CONTACT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE283;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_CONTACTController : Controller
{
    private readonly ITAB_PROV_CONTACTService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE283Service _TABLE283Service;

    public TAB_PROV_CONTACTController(ITAB_PROV_CONTACTService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE283Service TABLE283Service
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE283Service = TABLE283Service;
    }

    // GET: TAB_PROV_CONTACT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_PROV_CONTACT/Index.cshtml");

    // GET: TAB_PROV_CONTACT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Details.cshtml", result);
    }

    // GET: TAB_PROV_CONTACT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE283DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Create.cshtml", new CreateTAB_PROV_CONTACTDto());
    }

    // POST: TAB_PROV_CONTACT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_CONTACTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE283DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_CONTACT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_CONTACTDto
        {
            NPROVIDER = result.NPROVIDER,
            NSEQ = result.NSEQ,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NPOSITION = result.NPOSITION,
            SNAME_CONTACT = result.SNAME_CONTACT,
            SE_MAIL = result.SE_MAIL,
            SPHONE_CONTACT = result.SPHONE_CONTACT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE283DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_CONTACT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateTAB_PROV_CONTACTDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE283DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_CONTACT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_CONTACT/Delete.cshtml", result);
    }

    // POST: TAB_PROV_CONTACT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

    private async Task PopulateTABLE283DropdownAsync()
    {
        var items = await _TABLE283Service.GetAllAsync();
        ViewData["NPOSITION"] = new SelectList(items, nameof(TABLE283Dto.NPOSITION), "SDESCRIPT");
    }

}
