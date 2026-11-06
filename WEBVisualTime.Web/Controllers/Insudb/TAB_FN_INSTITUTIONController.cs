using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_FN_INSTITUTION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5634;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_FN_INSTITUTIONController : Controller
{
    private readonly ITAB_FN_INSTITUTIONService _service;
    private readonly ITABLE5634Service _TABLE5634Service;

    public TAB_FN_INSTITUTIONController(ITAB_FN_INSTITUTIONService service
        , ITABLE5634Service TABLE5634Service
    )
    {
        _service = service;
        _TABLE5634Service = TABLE5634Service;
    }

    // GET: TAB_FN_INSTITUTION
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_FN_INSTITUTION/Index.cshtml");

    // GET: TAB_FN_INSTITUTION/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Details.cshtml", result);
    }

    // GET: TAB_FN_INSTITUTION/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5634DropdownAsync();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Create.cshtml", new CreateTAB_FN_INSTITUTIONDto());
    }

    // POST: TAB_FN_INSTITUTION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_FN_INSTITUTIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5634DropdownAsync();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Create.cshtml", createDto);
    }

    // GET: TAB_FN_INSTITUTION/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_FN_INSTITUTIONDto
        {
            NINSTITUTION = result.NINSTITUTION,
            NTYPEINSTITU = result.NTYPEINSTITU,
            SNAME = result.SNAME,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
            SINSTITUTION = result.SINSTITUTION,
            SCLIENT = result.SCLIENT,
            SDIGIT = result.SDIGIT,
        };
        await PopulateTABLE5634DropdownAsync();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Edit.cshtml", updateDto);
    }

    // POST: TAB_FN_INSTITUTION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_FN_INSTITUTIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINSTITUTION, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5634DropdownAsync();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Edit.cshtml", updateDto);
    }

    // GET: TAB_FN_INSTITUTION/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_FN_INSTITUTION/Delete.cshtml", result);
    }

    // POST: TAB_FN_INSTITUTION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5634DropdownAsync()
    {
        var items = await _TABLE5634Service.GetAllAsync();
        ViewData["NTYPEINSTITU"] = new SelectList(items, nameof(TABLE5634Dto.NTYPEINSTITU), "SDESCRIPT");
    }

}
