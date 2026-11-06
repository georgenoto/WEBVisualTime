using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INTERM_TYPController : Controller
{
    private readonly IINTERM_TYPService _service;
    private readonly ITABLE400Service _TABLE400Service;

    public INTERM_TYPController(IINTERM_TYPService service
        , ITABLE400Service TABLE400Service
    )
    {
        _service = service;
        _TABLE400Service = TABLE400Service;
    }

    // GET: INTERM_TYP
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INTERM_TYP/Index.cshtml");

    // GET: INTERM_TYP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERM_TYP/Details.cshtml", result);
    }

    // GET: INTERM_TYP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/INTERM_TYP/Create.cshtml", new CreateINTERM_TYPDto());
    }

    // POST: INTERM_TYP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINTERM_TYPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/INTERM_TYP/Create.cshtml", createDto);
    }

    // GET: INTERM_TYP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINTERM_TYPDto
        {
            NINTERTYP = result.NINTERTYP,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SPARTICIN = result.SPARTICIN,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTYP_ACCO = result.NTYP_ACCO,
            SIND_FECU = result.SIND_FECU,
            SGEN_CERTIF = result.SGEN_CERTIF,
            NRECEPTYP = result.NRECEPTYP,
        };
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/INTERM_TYP/Edit.cshtml", updateDto);
    }

    // POST: INTERM_TYP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINTERM_TYPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERTYP, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE400DropdownAsync();
        return View("~/Views/Insudb/INTERM_TYP/Edit.cshtml", updateDto);
    }

    // GET: INTERM_TYP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERM_TYP/Delete.cshtml", result);
    }

    // POST: INTERM_TYP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE400DropdownAsync()
    {
        var items = await _TABLE400Service.GetAllAsync();
        ViewData["NTYP_ACCO"] = new SelectList(items, nameof(TABLE400Dto.NTYP_ACCO), "SDESCRIPT");
    }

}
