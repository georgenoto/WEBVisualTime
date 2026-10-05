using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMM_TOT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMM_TOTController : Controller
{
    private readonly ICOMM_TOTService _service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ICERTIFICATService _CERTIFICATService;

    public COMM_TOTController(ICOMM_TOTService service
        , IINTERMEDIAService INTERMEDIAService
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _INTERMEDIAService = INTERMEDIAService;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: COMM_TOT
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COMM_TOT/Index.cshtml", result);
    }

    // GET: COMM_TOT/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMM_TOT/Details.cshtml", result);
    }

    // GET: COMM_TOT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COMM_TOT/Create.cshtml", new CreateCOMM_TOTDto());
    }

    // POST: COMM_TOT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMM_TOTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COMM_TOT/Create.cshtml", createDto);
    }

    // GET: COMM_TOT/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMM_TOTDto
        {
            NINTERMED = result.NINTERMED,
            NRECEIPT = result.NRECEIPT,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NCOMM = result.NCOMM,
            NMOVNUMBE = result.NMOVNUMBE,
            NTOTALPREMIUM = result.NTOTALPREMIUM,
            NTOTALCOMM = result.NTOTALCOMM,
        };
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COMM_TOT/Edit.cshtml", updateDto);
    }

    // POST: COMM_TOT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMM_TOTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateINTERMEDIADropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COMM_TOT/Edit.cshtml", updateDto);
    }

    // GET: COMM_TOT/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMM_TOT/Delete.cshtml", result);
    }

    // POST: COMM_TOT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
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

}
