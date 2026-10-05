using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM_VALUE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_JOB;
using WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BATCH_PARAM_VALUEController : Controller
{
    private readonly IBATCH_PARAM_VALUEService _service;
    private readonly IBATCH_JOBService _BATCH_JOBService;
    private readonly IBATCH_PARAMService _BATCH_PARAMService;

    public BATCH_PARAM_VALUEController(IBATCH_PARAM_VALUEService service
        , IBATCH_JOBService BATCH_JOBService
        , IBATCH_PARAMService BATCH_PARAMService
    )
    {
        _service = service;
        _BATCH_JOBService = BATCH_JOBService;
        _BATCH_PARAMService = BATCH_PARAMService;
    }

    // GET: BATCH_PARAM_VALUE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Index.cshtml", result);
    }

    // GET: BATCH_PARAM_VALUE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Details.cshtml", result);
    }

    // GET: BATCH_PARAM_VALUE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateBATCH_JOBDropdownAsync();
        await PopulateBATCH_PARAMDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Create.cshtml", new CreateBATCH_PARAM_VALUEDto());
    }

    // POST: BATCH_PARAM_VALUE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBATCH_PARAM_VALUEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_JOBDropdownAsync();
        await PopulateBATCH_PARAMDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Create.cshtml", createDto);
    }

    // GET: BATCH_PARAM_VALUE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBATCH_PARAM_VALUEDto
        {
            SKEY = result.SKEY,
            NAREA = result.NAREA,
            NSEQ = result.NSEQ,
            NBATCH = result.NBATCH,
            SVALUE = result.SVALUE,
            NDATATYPE = result.NDATATYPE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
        };
        await PopulateBATCH_JOBDropdownAsync();
        await PopulateBATCH_PARAMDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Edit.cshtml", updateDto);
    }

    // POST: BATCH_PARAM_VALUE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBATCH_PARAM_VALUEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateBATCH_JOBDropdownAsync();
        await PopulateBATCH_PARAMDropdownAsync();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Edit.cshtml", updateDto);
    }

    // GET: BATCH_PARAM_VALUE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BATCH_PARAM_VALUE/Delete.cshtml", result);
    }

    // POST: BATCH_PARAM_VALUE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateBATCH_JOBDropdownAsync()
    {
        var items = await _BATCH_JOBService.GetAllAsync();
        ViewData["SKEY"] = new SelectList(items, nameof(BATCH_JOBDto.SKEY), "SCOMMAND");
    }

    private async Task PopulateBATCH_PARAMDropdownAsync()
    {
        var items = await _BATCH_PARAMService.GetAllAsync();
        ViewData["NAREA"] = new SelectList(items, nameof(BATCH_PARAMDto.NAREA), "SNAME");
        ViewData["NSEQ"] = new SelectList(items, nameof(BATCH_PARAMDto.NSEQ), "SNAME");
        ViewData["NBATCH"] = new SelectList(items, nameof(BATCH_PARAMDto.NBATCH), "SNAME");
    }

}
