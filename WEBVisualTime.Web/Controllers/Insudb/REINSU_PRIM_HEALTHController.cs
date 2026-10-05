using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_PRIM_HEALTH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REINSU_PRIM_HEALTHController : Controller
{
    private readonly IREINSU_PRIM_HEALTHService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly IPRODMASTERService _PRODMASTERService;
    private readonly ITABLE11Service _TABLE11Service;

    public REINSU_PRIM_HEALTHController(IREINSU_PRIM_HEALTHService service
        , ITABLE10Service TABLE10Service
        , IPRODMASTERService PRODMASTERService
        , ITABLE11Service TABLE11Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _PRODMASTERService = PRODMASTERService;
        _TABLE11Service = TABLE11Service;
    }

    // GET: REINSU_PRIM_HEALTH
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Index.cshtml", result);
    }

    // GET: REINSU_PRIM_HEALTH/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Details.cshtml", result);
    }

    // GET: REINSU_PRIM_HEALTH/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Create.cshtml", new CreateREINSU_PRIM_HEALTHDto());
    }

    // POST: REINSU_PRIM_HEALTH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREINSU_PRIM_HEALTHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Create.cshtml", createDto);
    }

    // GET: REINSU_PRIM_HEALTH/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREINSU_PRIM_HEALTHDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NCURRENCY = result.NCURRENCY,
            DEEFECDATE = result.DEEFECDATE,
            DNULLDATE = result.DNULLDATE,
            NREINPRE = result.NREINPRE,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREG = result.SSTATREG,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Edit.cshtml", updateDto);
    }

    // POST: REINSU_PRIM_HEALTH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREINSU_PRIM_HEALTHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE11DropdownAsync();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Edit.cshtml", updateDto);
    }

    // GET: REINSU_PRIM_HEALTH/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSU_PRIM_HEALTH/Delete.cshtml", result);
    }

    // POST: REINSU_PRIM_HEALTH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulatePRODMASTERDropdownAsync()
    {
        var items = await _PRODMASTERService.GetAllAsync();
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PRODMASTERDto.NPRODUCT), "SDESCRIPT");
    }

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURRENCY"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

}
