using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMED_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INTERMED_HISController : Controller
{
    private readonly IINTERMED_HISService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE163Service _TABLE163Service;
    private readonly IINTERM_TYPService _INTERM_TYPService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE200Service _TABLE200Service;

    public INTERMED_HISController(IINTERMED_HISService service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE163Service TABLE163Service
        , IINTERM_TYPService INTERM_TYPService
        , ITABLE9Service TABLE9Service
        , ITABLE200Service TABLE200Service
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE163Service = TABLE163Service;
        _INTERM_TYPService = INTERM_TYPService;
        _TABLE9Service = TABLE9Service;
        _TABLE200Service = TABLE200Service;
    }

    // GET: INTERMED_HIS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/INTERMED_HIS/Index.cshtml", result);
    }

    // GET: INTERMED_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMED_HIS/Details.cshtml", result);
    }

    // GET: INTERMED_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE200DropdownAsync();
        return View("~/Views/Insudb/INTERMED_HIS/Create.cshtml", new CreateINTERMED_HISDto());
    }

    // POST: INTERMED_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINTERMED_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE200DropdownAsync();
        return View("~/Views/Insudb/INTERMED_HIS/Create.cshtml", createDto);
    }

    // GET: INTERMED_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINTERMED_HISDto
        {
            NINTERMED = result.NINTERMED,
            DEFFECDATE = result.DEFFECDATE,
            NNULLCODE = result.NNULLCODE,
            NINTERTYP = result.NINTERTYP,
            NOFFICE = result.NOFFICE,
            NSUPERVIS = result.NSUPERVIS,
            NINT_STATUS = result.NINT_STATUS,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NRECEPTYP = result.NRECEPTYP,
            SDESCRIPT = result.SDESCRIPT,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE200DropdownAsync();
        return View("~/Views/Insudb/INTERMED_HIS/Edit.cshtml", updateDto);
    }

    // POST: INTERMED_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINTERMED_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NINTERMED, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE163DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE200DropdownAsync();
        return View("~/Views/Insudb/INTERMED_HIS/Edit.cshtml", updateDto);
    }

    // GET: INTERMED_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INTERMED_HIS/Delete.cshtml", result);
    }

    // POST: INTERMED_HIS/Delete/{id}
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

    private async Task PopulateTABLE163DropdownAsync()
    {
        var items = await _TABLE163Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE163Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE200DropdownAsync()
    {
        var items = await _TABLE200Service.GetAllAsync();
        ViewData["NINT_STATUS"] = new SelectList(items, nameof(TABLE200Dto.NINT_STATUS), "SDESCRIPT");
    }

}
