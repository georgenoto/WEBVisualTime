using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_CO_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MODUL_CO_GController : Controller
{
    private readonly IMODUL_CO_GService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ITABLE9214Service _TABLE9214Service;
    private readonly ITABLE9215Service _TABLE9215Service;

    public MODUL_CO_GController(IMODUL_CO_GService service
        , IPOLICYService POLICYService
        , ITABLE9214Service TABLE9214Service
        , ITABLE9215Service TABLE9215Service
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _TABLE9214Service = TABLE9214Service;
        _TABLE9215Service = TABLE9215Service;
    }

    // GET: MODUL_CO_G
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MODUL_CO_G/Index.cshtml", result);
    }

    // GET: MODUL_CO_G/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODUL_CO_G/Details.cshtml", result);
    }

    // GET: MODUL_CO_G/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODUL_CO_G/Create.cshtml", new CreateMODUL_CO_GDto());
    }

    // POST: MODUL_CO_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMODUL_CO_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODUL_CO_G/Create.cshtml", createDto);
    }

    // GET: MODUL_CO_G/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMODUL_CO_GDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NGROUP = result.NGROUP,
            NMODULEC = result.NMODULEC,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            NPREMIRAT = result.NPREMIRAT,
            STYP_RAT = result.STYP_RAT,
            NGEOGRAPHAREA = result.NGEOGRAPHAREA,
            NATTENSYSTEM = result.NATTENSYSTEM,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODUL_CO_G/Edit.cshtml", updateDto);
    }

    // POST: MODUL_CO_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMODUL_CO_GDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODUL_CO_G/Edit.cshtml", updateDto);
    }

    // GET: MODUL_CO_G/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODUL_CO_G/Delete.cshtml", result);
    }

    // POST: MODUL_CO_G/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

    private async Task PopulateTABLE9214DropdownAsync()
    {
        var items = await _TABLE9214Service.GetAllAsync();
        ViewData["NGEOGRAPHAREA"] = new SelectList(items, nameof(TABLE9214Dto.NGEOGRAPHAREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE9215DropdownAsync()
    {
        var items = await _TABLE9215Service.GetAllAsync();
        ViewData["NATTENSYSTEM"] = new SelectList(items, nameof(TABLE9215Dto.NATTENSYSTEM), "SDESCRIPT");
    }

}
