using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_WAITPO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_WAITPOController : Controller
{
    private readonly ITAB_WAITPOService _service;
    private readonly ITABLE5603Service _TABLE5603Service;

    public TAB_WAITPOController(ITAB_WAITPOService service
        , ITABLE5603Service TABLE5603Service
    )
    {
        _service = service;
        _TABLE5603Service = TABLE5603Service;
    }

    // GET: TAB_WAITPO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_WAITPO/Index.cshtml");

    // GET: TAB_WAITPO/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WAITPO/Details.cshtml", result);
    }

    // GET: TAB_WAITPO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/TAB_WAITPO/Create.cshtml", new CreateTAB_WAITPODto());
    }

    // POST: TAB_WAITPO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_WAITPODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/TAB_WAITPO/Create.cshtml", createDto);
    }

    // GET: TAB_WAITPO/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_WAITPODto
        {
            NWAIT_CODE = result.NWAIT_CODE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NAREAWAIT = result.NAREAWAIT,
            NORDER = result.NORDER,
            SCONVERT = result.SCONVERT,
        };
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/TAB_WAITPO/Edit.cshtml", updateDto);
    }

    // POST: TAB_WAITPO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_WAITPODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NWAIT_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/TAB_WAITPO/Edit.cshtml", updateDto);
    }

    // GET: TAB_WAITPO/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_WAITPO/Delete.cshtml", result);
    }

    // POST: TAB_WAITPO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5603DropdownAsync()
    {
        var items = await _TABLE5603Service.GetAllAsync();
        ViewData["NAREAWAIT"] = new SelectList(items, nameof(TABLE5603Dto.NAREAWAIT), "SDESCRIPT");
    }

}
