using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AU_VEH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_AU_VEHController : Controller
{
    private readonly ITAB_AU_VEHService _service;
    private readonly ITABLE226Service _TABLE226Service;

    public TAB_AU_VEHController(ITAB_AU_VEHService service
        , ITABLE226Service TABLE226Service
    )
    {
        _service = service;
        _TABLE226Service = TABLE226Service;
    }

    // GET: TAB_AU_VEH
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_AU_VEH/Index.cshtml");

    // GET: TAB_AU_VEH/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AU_VEH/Details.cshtml", result);
    }

    // GET: TAB_AU_VEH/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE226DropdownAsync();
        return View("~/Views/Insudb/TAB_AU_VEH/Create.cshtml", new CreateTAB_AU_VEHDto());
    }

    // POST: TAB_AU_VEH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_AU_VEHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE226DropdownAsync();
        return View("~/Views/Insudb/TAB_AU_VEH/Create.cshtml", createDto);
    }

    // GET: TAB_AU_VEH/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_AU_VEHDto
        {
            SVEHCODE = result.SVEHCODE,
            SDESCRIPT = result.SDESCRIPT,
            NNATIONAL = result.NNATIONAL,
            NVEHBRAND = result.NVEHBRAND,
            SSTATREGT = result.SSTATREGT,
            SVEHMODEL = result.SVEHMODEL,
            NVEHTYPE = result.NVEHTYPE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NVEHPLACE = result.NVEHPLACE,
            NVEHPMA = result.NVEHPMA,
            NSOAP_VEHTYPE = result.NSOAP_VEHTYPE,
            SAACHCODE = result.SAACHCODE,
            NGROUPVEH = result.NGROUPVEH,
        };
        await PopulateTABLE226DropdownAsync();
        return View("~/Views/Insudb/TAB_AU_VEH/Edit.cshtml", updateDto);
    }

    // POST: TAB_AU_VEH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_AU_VEHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SVEHCODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE226DropdownAsync();
        return View("~/Views/Insudb/TAB_AU_VEH/Edit.cshtml", updateDto);
    }

    // GET: TAB_AU_VEH/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AU_VEH/Delete.cshtml", result);
    }

    // POST: TAB_AU_VEH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE226DropdownAsync()
    {
        var items = await _TABLE226Service.GetAllAsync();
        ViewData["NVEHTYPE"] = new SelectList(items, nameof(TABLE226Dto.NVEHTYPE), "SDESCRIPT");
    }

}
