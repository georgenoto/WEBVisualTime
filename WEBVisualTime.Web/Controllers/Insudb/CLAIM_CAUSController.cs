using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CAUS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_CAUSController : Controller
{
    private readonly ICLAIM_CAUSService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE132Service _TABLE132Service;

    public CLAIM_CAUSController(ICLAIM_CAUSService service
        , ITABLE10Service TABLE10Service
        , ITABLE132Service TABLE132Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _TABLE132Service = TABLE132Service;
    }

    // GET: CLAIM_CAUS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_CAUS/Index.cshtml", result);
    }

    // GET: CLAIM_CAUS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CAUS/Details.cshtml", result);
    }

    // GET: CLAIM_CAUS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE132DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CAUS/Create.cshtml", new CreateCLAIM_CAUSDto());
    }

    // POST: CLAIM_CAUS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_CAUSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE132DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CAUS/Create.cshtml", createDto);
    }

    // GET: CLAIM_CAUS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_CAUSDto
        {
            NBRANCH = result.NBRANCH,
            NCAUSECOD = result.NCAUSECOD,
            NPRODUCT = result.NPRODUCT,
            DCOMPDATE = result.DCOMPDATE,
            SCLAIMTYP = result.SCLAIMTYP,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SROUTINE = result.SROUTINE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE132DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CAUS/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_CAUS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_CAUSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE132DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CAUS/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_CAUS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CAUS/Delete.cshtml", result);
    }

    // POST: CLAIM_CAUS/Delete/{id}
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

    private async Task PopulateTABLE132DropdownAsync()
    {
        var items = await _TABLE132Service.GetAllAsync();
        ViewData["SCLAIMTYP"] = new SelectList(items, nameof(TABLE132Dto.SCLAIMTYP), "SDESCRIPT");
    }

}
