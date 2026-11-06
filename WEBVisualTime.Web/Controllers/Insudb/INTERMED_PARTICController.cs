using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_PARTIC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INTERMED_PARTICController : Controller
{
    private readonly IINTERMED_PARTICService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;

    public INTERMED_PARTICController(IINTERMED_PARTICService service
        , IINTERMEDIAService INTERMEDIAService
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
    }

    // GET: INTERMED_PARTIC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INTERMED_PARTIC/Index.cshtml");

    // GET: INTERMED_PARTIC/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMED_PARTIC/Details.cshtml", result);
    }

    // GET: INTERMED_PARTIC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/INTERMED_PARTIC/Create.cshtml", new CreateINTERMED_PARTICDto());
    }

    // POST: INTERMED_PARTIC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINTERMED_PARTICDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/INTERMED_PARTIC/Create.cshtml", createDto);
    }

    // GET: INTERMED_PARTIC/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINTERMED_PARTICDto
        {
            NINTERMED = result.NINTERMED,
            NSUPERIN_NUM = result.NSUPERIN_NUM,
            DSUPERIN_NUM = result.DSUPERIN_NUM,
            NWARRAN_POL = result.NWARRAN_POL,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NCIRCULAR_DOC = result.NCIRCULAR_DOC,
            DEXPSUPERIN_NUM = result.DEXPSUPERIN_NUM,
        };
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/INTERMED_PARTIC/Edit.cshtml", updateDto);
    }

    // POST: INTERMED_PARTIC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINTERMED_PARTICDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERMED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        return View("~/Views/Insudb/INTERMED_PARTIC/Edit.cshtml", updateDto);
    }

    // GET: INTERMED_PARTIC/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMED_PARTIC/Delete.cshtml", result);
    }

    // POST: INTERMED_PARTIC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

}
