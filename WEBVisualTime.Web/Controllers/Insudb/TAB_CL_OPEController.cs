using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_CL_OPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE294;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_CL_OPEController : Controller
{
    private readonly ITAB_CL_OPEService _service;
    private readonly ITABLE140Service _TABLE140Service;
    private readonly ITABLE294Service _TABLE294Service;

    public TAB_CL_OPEController(ITAB_CL_OPEService service
        , ITABLE140Service TABLE140Service
        , ITABLE294Service TABLE294Service
    )
    {
        _service = service;
        _TABLE140Service = TABLE140Service;
        _TABLE294Service = TABLE294Service;
    }

    // GET: TAB_CL_OPE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_CL_OPE/Index.cshtml", result);
    }

    // GET: TAB_CL_OPE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_CL_OPE/Details.cshtml", result);
    }

    // GET: TAB_CL_OPE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE294DropdownAsync();
        return View("~/Views/Insudb/TAB_CL_OPE/Create.cshtml", new CreateTAB_CL_OPEDto());
    }

    // POST: TAB_CL_OPE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_CL_OPEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE294DropdownAsync();
        return View("~/Views/Insudb/TAB_CL_OPE/Create.cshtml", createDto);
    }

    // GET: TAB_CL_OPE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_CL_OPEDto
        {
            NOPER_TYPE = result.NOPER_TYPE,
            DCOMPDATE = result.DCOMPDATE,
            NGEN_OPERA = result.NGEN_OPERA,
            NIND_REV = result.NIND_REV,
            NPAY_IND = result.NPAY_IND,
            NREC_ESP_IN = result.NREC_ESP_IN,
            NRECOVER_IN = result.NRECOVER_IN,
            NRESERVE_IN = result.NRESERVE_IN,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE294DropdownAsync();
        return View("~/Views/Insudb/TAB_CL_OPE/Edit.cshtml", updateDto);
    }

    // POST: TAB_CL_OPE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_CL_OPEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NOPER_TYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE140DropdownAsync();
        await PopulateTABLE294DropdownAsync();
        return View("~/Views/Insudb/TAB_CL_OPE/Edit.cshtml", updateDto);
    }

    // GET: TAB_CL_OPE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_CL_OPE/Delete.cshtml", result);
    }

    // POST: TAB_CL_OPE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE140DropdownAsync()
    {
        var items = await _TABLE140Service.GetAllAsync();
        ViewData["NOPER_TYPE"] = new SelectList(items, nameof(TABLE140Dto.NOPER_TYPE), "SDESCRIPT");
        ViewData["NGEN_OPERA"] = new SelectList(items, nameof(TABLE140Dto.NOPER_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE294DropdownAsync()
    {
        var items = await _TABLE294Service.GetAllAsync();
        ViewData["NPAY_IND"] = new SelectList(items, nameof(TABLE294Dto.NEFFCLAMO), "SDESCRIPT");
        ViewData["NREC_ESP_IN"] = new SelectList(items, nameof(TABLE294Dto.NEFFCLAMO), "SDESCRIPT");
        ViewData["NRECOVER_IN"] = new SelectList(items, nameof(TABLE294Dto.NEFFCLAMO), "SDESCRIPT");
        ViewData["NRESERVE_IN"] = new SelectList(items, nameof(TABLE294Dto.NEFFCLAMO), "SDESCRIPT");
    }

}
