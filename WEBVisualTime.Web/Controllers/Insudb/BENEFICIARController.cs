using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BENEFICIAR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE55;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BENEFICIARController : Controller
{
    private readonly IBENEFICIARService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE55Service _TABLE55Service;

    public BENEFICIARController(IBENEFICIARService service
        , ICERTIFICATService CERTIFICATService
        , ICLIENTService CLIENTService
        , ITABLE55Service TABLE55Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLIENTService = CLIENTService;
        _TABLE55Service = TABLE55Service;
    }

    // GET: BENEFICIAR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BENEFICIAR/Index.cshtml");

    // GET: BENEFICIAR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFICIAR/Details.cshtml", result);
    }

    // GET: BENEFICIAR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE55DropdownAsync();
        return View("~/Views/Insudb/BENEFICIAR/Create.cshtml", new CreateBENEFICIARDto());
    }

    // POST: BENEFICIAR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBENEFICIARDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE55DropdownAsync();
        return View("~/Views/Insudb/BENEFICIAR/Create.cshtml", createDto);
    }

    // GET: BENEFICIAR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBENEFICIARDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NPARTICIP = result.NPARTICIP,
            NRELATION = result.NRELATION,
            NUSERCODE = result.NUSERCODE,
            DDATEDECLA = result.DDATEDECLA,
            SIRREVOC = result.SIRREVOC,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SCONTING = result.SCONTING,
            SSEND_MAIL = result.SSEND_MAIL,
            SDESIGN = result.SDESIGN,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE55DropdownAsync();
        return View("~/Views/Insudb/BENEFICIAR/Edit.cshtml", updateDto);
    }

    // POST: BENEFICIAR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBENEFICIARDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE55DropdownAsync();
        return View("~/Views/Insudb/BENEFICIAR/Edit.cshtml", updateDto);
    }

    // GET: BENEFICIAR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BENEFICIAR/Delete.cshtml", result);
    }

    // POST: BENEFICIAR/Delete/{id}
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE55DropdownAsync()
    {
        var items = await _TABLE55Service.GetAllAsync();
        ViewData["NRELATION"] = new SelectList(items, nameof(TABLE55Dto.NRELATION), "SDESCRIPT");
    }

}
