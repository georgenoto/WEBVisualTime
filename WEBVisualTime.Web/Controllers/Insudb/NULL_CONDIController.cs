using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NULL_CONDI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NULL_CONDIController : Controller
{
    private readonly INULL_CONDIService _service;
    private readonly ITABLE13Service _TABLE13Service;

    public NULL_CONDIController(INULL_CONDIService service
        , ITABLE13Service TABLE13Service
    )
    {
        _service = service;
        _TABLE13Service = TABLE13Service;
    }

    // GET: NULL_CONDI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NULL_CONDI/Index.cshtml", result);
    }

    // GET: NULL_CONDI/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NULL_CONDI/Details.cshtml", result);
    }

    // GET: NULL_CONDI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE13DropdownAsync();
        return View("~/Views/Insudb/NULL_CONDI/Create.cshtml", new CreateNULL_CONDIDto());
    }

    // POST: NULL_CONDI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNULL_CONDIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE13DropdownAsync();
        return View("~/Views/Insudb/NULL_CONDI/Create.cshtml", createDto);
    }

    // GET: NULL_CONDI/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNULL_CONDIDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NNULLCODE = result.NNULLCODE,
            DEFFECDATE = result.DEFFECDATE,
            NAMELEVEL = result.NAMELEVEL,
            DCOMPDATE = result.DCOMPDATE,
            SREGTYPEN = result.SREGTYPEN,
            SRETURN_IND = result.SRETURN_IND,
            NRETURN_RAT = result.NRETURN_RAT,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
            SNOTREHAB = result.SNOTREHAB,
            SREHAB_AUTO = result.SREHAB_AUTO,
            SROUTINE_PAY = result.SROUTINE_PAY,
            NRETRACTION = result.NRETRACTION,
        };
        await PopulateTABLE13DropdownAsync();
        return View("~/Views/Insudb/NULL_CONDI/Edit.cshtml", updateDto);
    }

    // POST: NULL_CONDI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNULL_CONDIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE13DropdownAsync();
        return View("~/Views/Insudb/NULL_CONDI/Edit.cshtml", updateDto);
    }

    // GET: NULL_CONDI/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NULL_CONDI/Delete.cshtml", result);
    }

    // POST: NULL_CONDI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE13DropdownAsync()
    {
        var items = await _TABLE13Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE13Dto.NNULLCODE), "SDESCRIPT");
    }

}
