using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DSEX_CONDI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE298;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DSEX_CONDIController : Controller
{
    private readonly IDSEX_CONDIService _service;
    private readonly ITABLE298Service _TABLE298Service;

    public DSEX_CONDIController(IDSEX_CONDIService service
        , ITABLE298Service TABLE298Service
    )
    {
        _service = service;
        _TABLE298Service = TABLE298Service;
    }

    // GET: DSEX_CONDI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/DSEX_CONDI/Index.cshtml", result);
    }

    // GET: DSEX_CONDI/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DSEX_CONDI/Details.cshtml", result);
    }

    // GET: DSEX_CONDI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE298DropdownAsync();
        return View("~/Views/Insudb/DSEX_CONDI/Create.cshtml", new CreateDSEX_CONDIDto());
    }

    // POST: DSEX_CONDI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDSEX_CONDIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE298DropdownAsync();
        return View("~/Views/Insudb/DSEX_CONDI/Create.cshtml", createDto);
    }

    // GET: DSEX_CONDI/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDSEX_CONDIDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NDISEXPRC = result.NDISEXPRC,
            NAPLICATION = result.NAPLICATION,
            NCODE = result.NCODE,
            DCOMPDATE = result.DCOMPDATE,
            DEFFECDATE = result.DEFFECDATE,
            NMODULEC = result.NMODULEC,
            DNULLDATE = result.DNULLDATE,
            NROLE = result.NROLE,
            NUSERCODE = result.NUSERCODE,
            NRATE = result.NRATE,
        };
        await PopulateTABLE298DropdownAsync();
        return View("~/Views/Insudb/DSEX_CONDI/Edit.cshtml", updateDto);
    }

    // POST: DSEX_CONDI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDSEX_CONDIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE298DropdownAsync();
        return View("~/Views/Insudb/DSEX_CONDI/Edit.cshtml", updateDto);
    }

    // GET: DSEX_CONDI/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DSEX_CONDI/Delete.cshtml", result);
    }

    // POST: DSEX_CONDI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE298DropdownAsync()
    {
        var items = await _TABLE298Service.GetAllAsync();
        ViewData["NAPLICATION"] = new SelectList(items, nameof(TABLE298Dto.NAPLICATION), "SDESCRIPT");
    }

}
