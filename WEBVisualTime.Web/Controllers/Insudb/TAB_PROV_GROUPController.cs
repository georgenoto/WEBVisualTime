using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_GROUP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE642;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROV_GROUPController : Controller
{
    private readonly ITAB_PROV_GROUPService _service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ITABLE642Service _TABLE642Service;

    public TAB_PROV_GROUPController(ITAB_PROV_GROUPService service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ITABLE642Service TABLE642Service
    )
    {
        _service = service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _TABLE642Service = TABLE642Service;
    }

    // GET: TAB_PROV_GROUP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Index.cshtml", result);
    }

    // GET: TAB_PROV_GROUP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Details.cshtml", result);
    }

    // GET: TAB_PROV_GROUP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE642DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Create.cshtml", new CreateTAB_PROV_GROUPDto());
    }

    // POST: TAB_PROV_GROUP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROV_GROUPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE642DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Create.cshtml", createDto);
    }

    // GET: TAB_PROV_GROUP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROV_GROUPDto
        {
            NPROVIDER = result.NPROVIDER,
            NPROV_GROUP = result.NPROV_GROUP,
            DINPDATE = result.DINPDATE,
            DOUTDATE = result.DOUTDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE642DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROV_GROUP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROV_GROUPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateTABLE642DropdownAsync();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROV_GROUP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROV_GROUP/Delete.cshtml", result);
    }

    // POST: TAB_PROV_GROUP/Delete/{id}
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

    private async Task PopulateTABLE642DropdownAsync()
    {
        var items = await _TABLE642Service.GetAllAsync();
        ViewData["NPROV_GROUP"] = new SelectList(items, nameof(TABLE642Dto.NPROV_GROUP), "SDESCRIPT");
    }

}
