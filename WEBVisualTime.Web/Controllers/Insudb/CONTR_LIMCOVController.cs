using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_LIMCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTR_LIMCOVController : Controller
{
    private readonly ICONTR_LIMCOVService _service;
    private readonly ITABLE5001Service _TABLE5001Service;

    public CONTR_LIMCOVController(ICONTR_LIMCOVService service
        , ITABLE5001Service TABLE5001Service
    )
    {
        _service = service;
        _TABLE5001Service = TABLE5001Service;
    }

    // GET: CONTR_LIMCOV
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CONTR_LIMCOV/Index.cshtml", result);
    }

    // GET: CONTR_LIMCOV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTR_LIMCOV/Details.cshtml", result);
    }

    // GET: CONTR_LIMCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CONTR_LIMCOV/Create.cshtml", new CreateCONTR_LIMCOVDto());
    }

    // POST: CONTR_LIMCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTR_LIMCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CONTR_LIMCOV/Create.cshtml", createDto);
    }

    // GET: CONTR_LIMCOV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTR_LIMCOVDto
        {
            NBRANCH_REI = result.NBRANCH_REI,
            DEFFECDATE = result.DEFFECDATE,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NINSUR_AREA = result.NINSUR_AREA,
            NCOVERGEN = result.NCOVERGEN,
            DNULLDATE = result.DNULLDATE,
            NAMOUNT = result.NAMOUNT,
            NLINES = result.NLINES,
            NQUOTA_SHA = result.NQUOTA_SHA,
            SROUTINE = result.SROUTINE,
            NCOVERAPP = result.NCOVERAPP,
            NPERCENT = result.NPERCENT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NMAXAMOUNT = result.NMAXAMOUNT,
        };
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CONTR_LIMCOV/Edit.cshtml", updateDto);
    }

    // POST: CONTR_LIMCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTR_LIMCOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH_REI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CONTR_LIMCOV/Edit.cshtml", updateDto);
    }

    // GET: CONTR_LIMCOV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTR_LIMCOV/Delete.cshtml", result);
    }

    // POST: CONTR_LIMCOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

}
