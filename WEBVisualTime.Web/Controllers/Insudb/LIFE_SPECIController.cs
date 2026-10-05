using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_SPECI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LIFE_SPECIController : Controller
{
    private readonly ILIFE_SPECIService _service;
    private readonly ITABLE32Service _TABLE32Service;
    private readonly ITABLE18Service _TABLE18Service;

    public LIFE_SPECIController(ILIFE_SPECIService service
        , ITABLE32Service TABLE32Service
        , ITABLE18Service TABLE18Service
    )
    {
        _service = service;
        _TABLE32Service = TABLE32Service;
        _TABLE18Service = TABLE18Service;
    }

    // GET: LIFE_SPECI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/LIFE_SPECI/Index.cshtml", result);
    }

    // GET: LIFE_SPECI/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_SPECI/Details.cshtml", result);
    }

    // GET: LIFE_SPECI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        return View("~/Views/Insudb/LIFE_SPECI/Create.cshtml", new CreateLIFE_SPECIDto());
    }

    // POST: LIFE_SPECI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLIFE_SPECIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        return View("~/Views/Insudb/LIFE_SPECI/Create.cshtml", createDto);
    }

    // GET: LIFE_SPECI/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLIFE_SPECIDto
        {
            NAGEEND = result.NAGEEND,
            NAGESTART = result.NAGESTART,
            NCAPEND = result.NCAPEND,
            NCONSEC = result.NCONSEC,
            NCAPSTART = result.NCAPSTART,
            NMODULEC = result.NMODULEC,
            NBRANCH = result.NBRANCH,
            NCOVER = result.NCOVER,
            NCURRENCY = result.NCURRENCY,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NCRTHECNI = result.NCRTHECNI,
            DNULLDATE = result.DNULLDATE,
            SSEXCLIEN = result.SSEXCLIEN,
            NUSERCODE = result.NUSERCODE,
            NROLE = result.NROLE,
            SRANDOM = result.SRANDOM,
        };
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        return View("~/Views/Insudb/LIFE_SPECI/Edit.cshtml", updateDto);
    }

    // POST: LIFE_SPECI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLIFE_SPECIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONSEC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE32DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        return View("~/Views/Insudb/LIFE_SPECI/Edit.cshtml", updateDto);
    }

    // GET: LIFE_SPECI/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LIFE_SPECI/Delete.cshtml", result);
    }

    // POST: LIFE_SPECI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE32DropdownAsync()
    {
        var items = await _TABLE32Service.GetAllAsync();
        ViewData["NCRTHECNI"] = new SelectList(items, nameof(TABLE32Dto.NCRTHECNI), "SDESCRIPT");
    }

    private async Task PopulateTABLE18DropdownAsync()
    {
        var items = await _TABLE18Service.GetAllAsync();
        ViewData["SSEXCLIEN"] = new SelectList(items, nameof(TABLE18Dto.SSEXCLIEN), "SDESCRIPT");
    }

}
