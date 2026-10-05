using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COV_USEDController : Controller
{
    private readonly ICOV_USEDService _service;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ICERTIFICATService _CERTIFICATService;

    public COV_USEDController(ICOV_USEDService service
        , ICLAIM_CASEService CLAIM_CASEService
        , ICLIENTService CLIENTService
        , ICERTIFICATService CERTIFICATService
    )
    {
        _service = service;
        _CLAIM_CASEService = CLAIM_CASEService;
        _CLIENTService = CLIENTService;
        _CERTIFICATService = CERTIFICATService;
    }

    // GET: COV_USED
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COV_USED/Index.cshtml", result);
    }

    // GET: COV_USED/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COV_USED/Details.cshtml", result);
    }

    // GET: COV_USED/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COV_USED/Create.cshtml", new CreateCOV_USEDDto());
    }

    // POST: COV_USED/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOV_USEDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COV_USED/Create.cshtml", createDto);
    }

    // GET: COV_USED/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOV_USEDDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NGROUP_INSU = result.NGROUP_INSU,
            NTRANSAC = result.NTRANSAC,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCURRENCY = result.NCURRENCY,
            SCLIENT = result.SCLIENT,
            NSTARTDATE = result.NSTARTDATE,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NCAPITAL = result.NCAPITAL,
            DCOMPDATE = result.DCOMPDATE,
            NCON_ID = result.NCON_ID,
            DEXPIRDAT = result.DEXPIRDAT,
            NQUANTITY = result.NQUANTITY,
            DRESTIT_DAT = result.DRESTIT_DAT,
            NUSERCODE = result.NUSERCODE,
            SPURPOSE = result.SPURPOSE,
        };
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COV_USED/Edit.cshtml", updateDto);
    }

    // POST: COV_USED/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOV_USEDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        return View("~/Views/Insudb/COV_USED/Edit.cshtml", updateDto);
    }

    // GET: COV_USED/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COV_USED/Delete.cshtml", result);
    }

    // POST: COV_USED/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_CASEDropdownAsync()
    {
        var items = await _CLAIM_CASEService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCLAIM), "SSTACASE");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_CASEDto.NCASE_NUM), "SSTACASE");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CLAIM_CASEDto.NDEMAN_TYPE), "SSTACASE");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
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
