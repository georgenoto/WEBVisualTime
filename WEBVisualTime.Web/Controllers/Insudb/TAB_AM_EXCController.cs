using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_EXC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AM_ILL;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_AM_EXCController : Controller
{
    private readonly ITAB_AM_EXCService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITAB_AM_ILLService _TAB_AM_ILLService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE271Service _TABLE271Service;

    public TAB_AM_EXCController(ITAB_AM_EXCService service
        , ICERTIFICATService CERTIFICATService
        , ITAB_AM_ILLService TAB_AM_ILLService
        , ICLIENTService CLIENTService
        , ITABLE271Service TABLE271Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TAB_AM_ILLService = TAB_AM_ILLService;
        _CLIENTService = CLIENTService;
        _TABLE271Service = TABLE271Service;
    }

    // GET: TAB_AM_EXC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_AM_EXC/Index.cshtml");

    // GET: TAB_AM_EXC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AM_EXC/Details.cshtml", result);
    }

    // GET: TAB_AM_EXC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE271DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_EXC/Create.cshtml", new CreateTAB_AM_EXCDto());
    }

    // POST: TAB_AM_EXC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_AM_EXCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE271DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_EXC/Create.cshtml", createDto);
    }

    // GET: TAB_AM_EXC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_AM_EXCDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NTARIFF = result.NTARIFF,
            SILLNESS = result.SILLNESS,
            DEFFECDATE = result.DEFFECDATE,
            NID = result.NID,
            SCLIENT = result.SCLIENT,
            NEXC_CODE = result.NEXC_CODE,
            DCOMPDATE = result.DCOMPDATE,
            DINIT_DATE = result.DINIT_DATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DEND_DATE = result.DEND_DATE,
            STYPE_EXC = result.STYPE_EXC,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SPREEXISTING = result.SPREEXISTING,
            SCARENCY = result.SCARENCY,
            SPERMANENT = result.SPERMANENT,
            SDESCRIPT = result.SDESCRIPT,
            NMOVEMENT = result.NMOVEMENT,
            SSEL = result.SSEL,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE271DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_EXC/Edit.cshtml", updateDto);
    }

    // POST: TAB_AM_EXC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_AM_EXCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTAB_AM_ILLDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE271DropdownAsync();
        return View("~/Views/Insudb/TAB_AM_EXC/Edit.cshtml", updateDto);
    }

    // GET: TAB_AM_EXC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_AM_EXC/Delete.cshtml", result);
    }

    // POST: TAB_AM_EXC/Delete/{id}
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

    private async Task PopulateTAB_AM_ILLDropdownAsync()
    {
        var items = await _TAB_AM_ILLService.GetAllAsync();
        ViewData["SILLNESS"] = new SelectList(items, nameof(TAB_AM_ILLDto.SILLNESS), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE271DropdownAsync()
    {
        var items = await _TABLE271Service.GetAllAsync();
        ViewData["NEXC_CODE"] = new SelectList(items, nameof(TABLE271Dto.NEXC_CODE), "SDESCRIPT");
    }

}
