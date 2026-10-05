using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_CESCOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5552;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTR_CESCOVController : Controller
{
    private readonly ICONTR_CESCOVService _service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ITABLE5552Service _TABLE5552Service;

    public CONTR_CESCOVController(ICONTR_CESCOVService service
        , ITABLE5001Service TABLE5001Service
        , ITABLE5552Service TABLE5552Service
    )
    {
        _service = service;
        _TABLE5001Service = TABLE5001Service;
        _TABLE5552Service = TABLE5552Service;
    }

    // GET: CONTR_CESCOV
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CONTR_CESCOV/Index.cshtml", result);
    }

    // GET: CONTR_CESCOV/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTR_CESCOV/Details.cshtml", result);
    }

    // GET: CONTR_CESCOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5552DropdownAsync();
        return View("~/Views/Insudb/CONTR_CESCOV/Create.cshtml", new CreateCONTR_CESCOVDto());
    }

    // POST: CONTR_CESCOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTR_CESCOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5552DropdownAsync();
        return View("~/Views/Insudb/CONTR_CESCOV/Create.cshtml", createDto);
    }

    // GET: CONTR_CESCOV/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTR_CESCOVDto
        {
            NBRANCH_REI = result.NBRANCH_REI,
            DEFFECDATE = result.DEFFECDATE,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NINSUR_AREA = result.NINSUR_AREA,
            NCOVERGEN = result.NCOVERGEN,
            DNULLDATE = result.DNULLDATE,
            NTYPECAP = result.NTYPECAP,
            SROUCESS = result.SROUCESS,
            NRATE = result.NRATE,
            NCESSPRFIX = result.NCESSPRFIX,
            SINOTHERCOV = result.SINOTHERCOV,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCOMPANY = result.NCOMPANY,
            NCOVERGEN_OTHER = result.NCOVERGEN_OTHER,
            NSHARE_CIA = result.NSHARE_CIA,
            NAGEMAX = result.NAGEMAX,
            NRATE_EXPREM = result.NRATE_EXPREM,
            SMORTACOF = result.SMORTACOF,
            SMORTACOM = result.SMORTACOM,
        };
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5552DropdownAsync();
        return View("~/Views/Insudb/CONTR_CESCOV/Edit.cshtml", updateDto);
    }

    // POST: CONTR_CESCOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTR_CESCOVDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH_REI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5552DropdownAsync();
        return View("~/Views/Insudb/CONTR_CESCOV/Edit.cshtml", updateDto);
    }

    // GET: CONTR_CESCOV/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTR_CESCOV/Delete.cshtml", result);
    }

    // POST: CONTR_CESCOV/Delete/{id}
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

    private async Task PopulateTABLE5552DropdownAsync()
    {
        var items = await _TABLE5552Service.GetAllAsync();
        ViewData["NTYPECAP"] = new SelectList(items, nameof(TABLE5552Dto.NTYPECAP), "SDESCRIPT");
    }

}
