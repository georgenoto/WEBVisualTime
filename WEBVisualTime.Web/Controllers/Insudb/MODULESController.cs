using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MODULES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MODULESController : Controller
{
    private readonly IMODULESService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE9214Service _TABLE9214Service;
    private readonly ITABLE9215Service _TABLE9215Service;

    public MODULESController(IMODULESService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE9214Service TABLE9214Service
        , ITABLE9215Service TABLE9215Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE9214Service = TABLE9214Service;
        _TABLE9215Service = TABLE9215Service;
    }

    // GET: MODULES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MODULES/Index.cshtml");

    // GET: MODULES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODULES/Details.cshtml", result);
    }

    // GET: MODULES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODULES/Create.cshtml", new CreateMODULESDto());
    }

    // POST: MODULES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMODULESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODULES/Create.cshtml", createDto);
    }

    // GET: MODULES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMODULESDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SCHANGEI = result.SCHANGEI,
            NCURRENCY = result.NCURRENCY,
            NPREMIRAT = result.NPREMIRAT,
            STYP_RAT = result.STYP_RAT,
            SINHERIT = result.SINHERIT,
            NGEOGRAPHAREA = result.NGEOGRAPHAREA,
            NATTENSYSTEM = result.NATTENSYSTEM,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODULES/Edit.cshtml", updateDto);
    }

    // POST: MODULES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMODULESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/MODULES/Edit.cshtml", updateDto);
    }

    // GET: MODULES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODULES/Delete.cshtml", result);
    }

    // POST: MODULES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
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
