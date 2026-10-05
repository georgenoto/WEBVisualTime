using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_FILTERS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETTLEMENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETT_FILTERSController : Controller
{
    private readonly ICLAIM_SETT_FILTERSService _service;
    private readonly ICLAIM_SETTLEMENTService _CLAIM_SETTLEMENTService;
    private readonly ITABLE9242Service _TABLE9242Service;
    private readonly ITABLE9249Service _TABLE9249Service;

    public CLAIM_SETT_FILTERSController(ICLAIM_SETT_FILTERSService service
        , ICLAIM_SETTLEMENTService CLAIM_SETTLEMENTService
        , ITABLE9242Service TABLE9242Service
        , ITABLE9249Service TABLE9249Service
    )
    {
        _service = service;
        _CLAIM_SETTLEMENTService = CLAIM_SETTLEMENTService;
        _TABLE9242Service = TABLE9242Service;
        _TABLE9249Service = TABLE9249Service;
    }

    // GET: CLAIM_SETT_FILTERS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Index.cshtml", result);
    }

    // GET: CLAIM_SETT_FILTERS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Details.cshtml", result);
    }

    // GET: CLAIM_SETT_FILTERS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Create.cshtml", new CreateCLAIM_SETT_FILTERSDto());
    }

    // POST: CLAIM_SETT_FILTERS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETT_FILTERSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETT_FILTERS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETT_FILTERSDto
        {
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            SCLIENT = result.SCLIENT,
            SCLIENT2 = result.SCLIENT2,
            NORDER_NUM = result.NORDER_NUM,
            NPROVIDER = result.NPROVIDER,
            NTYPEPROV = result.NTYPEPROV,
            DFROM = result.DFROM,
            DTO = result.DTO,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCURRENCY = result.NCURRENCY,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            NSETTLEMENT_CONC = result.NSETTLEMENT_CONC,
            NPHYSICIAN = result.NPHYSICIAN,
            NCLINIC = result.NCLINIC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBORDEREAUX_CL = result.NBORDEREAUX_CL,
            NMASTERORDERTYPE = result.NMASTERORDERTYPE,
            NMASTERORDER = result.NMASTERORDER,
            DMASTERORDERFROM = result.DMASTERORDERFROM,
            DMASTERORDERTO = result.DMASTERORDERTO,
            SCLIENT_BENEF = result.SCLIENT_BENEF,
            DLEDGERDAT = result.DLEDGERDAT,
        };
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETT_FILTERS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_SETT_FILTERSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSETTLEMENT_NUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_SETTLEMENTDropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETT_FILTERS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_FILTERS/Delete.cshtml", result);
    }

    // POST: CLAIM_SETT_FILTERS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_SETTLEMENTDropdownAsync()
    {
        var items = await _CLAIM_SETTLEMENTService.GetAllAsync();
        ViewData["NSETTLEMENT_NUM"] = new SelectList(items, nameof(CLAIM_SETTLEMENTDto.NSETTLEMENT_NUM), "SCLIENT2");
    }

    private async Task PopulateTABLE9242DropdownAsync()
    {
        var items = await _TABLE9242Service.GetAllAsync();
        ViewData["NTYPEDOC_PAY"] = new SelectList(items, nameof(TABLE9242Dto.NTYPEDOC_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9249DropdownAsync()
    {
        var items = await _TABLE9249Service.GetAllAsync();
        ViewData["NSETTLEMENT_CONC"] = new SelectList(items, nameof(TABLE9249Dto.NSETTLEMENT_CONC), "SDESCRIPT");
    }

}
