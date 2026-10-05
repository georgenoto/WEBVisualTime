using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MEDICAL_EVAL_ROL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLES;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9216;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MEDICAL_EVAL_ROLController : Controller
{
    private readonly IMEDICAL_EVAL_ROLService _service;
    private readonly IROLESService _ROLESService;
    private readonly ITABLE9216Service _TABLE9216Service;

    public MEDICAL_EVAL_ROLController(IMEDICAL_EVAL_ROLService service
        , IROLESService ROLESService
        , ITABLE9216Service TABLE9216Service
    )
    {
        _service = service;
        _ROLESService = ROLESService;
        _TABLE9216Service = TABLE9216Service;
    }

    // GET: MEDICAL_EVAL_ROL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Index.cshtml", result);
    }

    // GET: MEDICAL_EVAL_ROL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Details.cshtml", result);
    }

    // GET: MEDICAL_EVAL_ROL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateROLESDropdownAsync();
        await PopulateTABLE9216DropdownAsync();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Create.cshtml", new CreateMEDICAL_EVAL_ROLDto());
    }

    // POST: MEDICAL_EVAL_ROL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMEDICAL_EVAL_ROLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateROLESDropdownAsync();
        await PopulateTABLE9216DropdownAsync();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Create.cshtml", createDto);
    }

    // GET: MEDICAL_EVAL_ROL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMEDICAL_EVAL_ROLDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NROLE = result.NROLE,
            SCLIENT = result.SCLIENT,
            NMEDICALSTAT = result.NMEDICALSTAT,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DEFFECDATE = result.DEFFECDATE,
            NMONTHS = result.NMONTHS,
        };
        await PopulateROLESDropdownAsync();
        await PopulateTABLE9216DropdownAsync();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Edit.cshtml", updateDto);
    }

    // POST: MEDICAL_EVAL_ROL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMEDICAL_EVAL_ROLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateROLESDropdownAsync();
        await PopulateTABLE9216DropdownAsync();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Edit.cshtml", updateDto);
    }

    // GET: MEDICAL_EVAL_ROL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MEDICAL_EVAL_ROL/Delete.cshtml", result);
    }

    // POST: MEDICAL_EVAL_ROL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateROLESDropdownAsync()
    {
        var items = await _ROLESService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(ROLESDto.SCERTYPE), "SSMOKING");
        ViewData["NBRANCH"] = new SelectList(items, nameof(ROLESDto.NBRANCH), "SSMOKING");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(ROLESDto.NPRODUCT), "SSMOKING");
        ViewData["NPOLICY"] = new SelectList(items, nameof(ROLESDto.NPOLICY), "SSMOKING");
        ViewData["NCERTIF"] = new SelectList(items, nameof(ROLESDto.NCERTIF), "SSMOKING");
        ViewData["NROLE"] = new SelectList(items, nameof(ROLESDto.NROLE), "SSMOKING");
        ViewData["SCLIENT"] = new SelectList(items, nameof(ROLESDto.SCLIENT), "SSMOKING");
        ViewData["DEFFECDATE"] = new SelectList(items, nameof(ROLESDto.DEFFECDATE), "SSMOKING");
    }

    private async Task PopulateTABLE9216DropdownAsync()
    {
        var items = await _TABLE9216Service.GetAllAsync();
        ViewData["NMEDICALSTAT"] = new SelectList(items, nameof(TABLE9216Dto.NMEDICALSTAT), "SDESCRIPT");
    }

}
