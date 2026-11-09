using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LEND_AGREE_PRES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LEND_AGREE_PRESController : Controller
{
    private readonly ILEND_AGREE_PRESService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE9Service _TABLE9Service;

    public LEND_AGREE_PRESController(ILEND_AGREE_PRESService service
        , ICERTIFICATService CERTIFICATService
        , ICLIENTService CLIENTService
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLIENTService = CLIENTService;
        _TABLE9Service = TABLE9Service;
    }

    // GET: LEND_AGREE_PRES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/LEND_AGREE_PRES/Index.cshtml");

    // GET: LEND_AGREE_PRES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Details.cshtml", result);
    }

    // GET: LEND_AGREE_PRES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Create.cshtml", new CreateLEND_AGREE_PRESDto());
    }

    // POST: LEND_AGREE_PRES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLEND_AGREE_PRESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Create.cshtml", createDto);
    }

    // GET: LEND_AGREE_PRES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLEND_AGREE_PRESDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NGROUP = result.NGROUP,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SCLIENT = result.SCLIENT,
            NPRESTAC = result.NPRESTAC,
            NCOD_AGREE = result.NCOD_AGREE,
            NCITY_RESIDENCE = result.NCITY_RESIDENCE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NAMOUNT = result.NAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Edit.cshtml", updateDto);
    }

    // POST: LEND_AGREE_PRES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateLEND_AGREE_PRESDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Edit.cshtml", updateDto);
    }

    // GET: LEND_AGREE_PRES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LEND_AGREE_PRES/Delete.cshtml", result);
    }

    // POST: LEND_AGREE_PRES/Delete/{id}
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

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NCITY_RESIDENCE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
