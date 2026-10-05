using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BRANPROD_ALLOW;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BRANPROD_ALLOWController : Controller
{
    private readonly IBRANPROD_ALLOWService _service;
    private readonly ITABLE9202Service _TABLE9202Service;

    public BRANPROD_ALLOWController(IBRANPROD_ALLOWService service
        , ITABLE9202Service TABLE9202Service
    )
    {
        _service = service;
        _TABLE9202Service = TABLE9202Service;
    }

    // GET: BRANPROD_ALLOW
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Index.cshtml", result);
    }

    // GET: BRANPROD_ALLOW/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Details.cshtml", result);
    }

    // GET: BRANPROD_ALLOW/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Create.cshtml", new CreateBRANPROD_ALLOWDto());
    }

    // POST: BRANPROD_ALLOW/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBRANPROD_ALLOWDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Create.cshtml", createDto);
    }

    // GET: BRANPROD_ALLOW/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBRANPROD_ALLOWDto
        {
            NINTERMED = result.NINTERMED,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NINSTALLMENTS = result.NINSTALLMENTS,
            NSTARTMONTH = result.NSTARTMONTH,
            NENDMONTH = result.NENDMONTH,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NNOTE_INT = result.NNOTE_INT,
            NCATEGORY = result.NCATEGORY,
        };
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Edit.cshtml", updateDto);
    }

    // POST: BRANPROD_ALLOW/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBRANPROD_ALLOWDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERMED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9202DropdownAsync();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Edit.cshtml", updateDto);
    }

    // GET: BRANPROD_ALLOW/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BRANPROD_ALLOW/Delete.cshtml", result);
    }

    // POST: BRANPROD_ALLOW/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9202DropdownAsync()
    {
        var items = await _TABLE9202Service.GetAllAsync();
        ViewData["NCATEGORY"] = new SelectList(items, nameof(TABLE9202Dto.NCATEGORY), "SDESCRIPT");
    }

}
