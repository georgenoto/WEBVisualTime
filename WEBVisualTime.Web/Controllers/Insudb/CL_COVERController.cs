using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CL_COVERController : Controller
{
    private readonly ICL_COVERService _service;
    private readonly ICLAIM_CASEService _CLAIM_CASEService;
    private readonly ITABLE71Service _TABLE71Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE75Service _TABLE75Service;
    private readonly ITABLE5000Service _TABLE5000Service;
    private readonly ITABLE64Service _TABLE64Service;

    public CL_COVERController(ICL_COVERService service
        , ICLAIM_CASEService CLAIM_CASEService
        , ITABLE71Service TABLE71Service
        , ICLIENTService CLIENTService
        , ITABLE75Service TABLE75Service
        , ITABLE5000Service TABLE5000Service
        , ITABLE64Service TABLE64Service
    )
    {
        _service = service;
        _CLAIM_CASEService = CLAIM_CASEService;
        _TABLE71Service = TABLE71Service;
        _CLIENTService = CLIENTService;
        _TABLE75Service = TABLE75Service;
        _TABLE5000Service = TABLE5000Service;
        _TABLE64Service = TABLE64Service;
    }

    // GET: CL_COVER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CL_COVER/Index.cshtml");

    // GET: CL_COVER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COVER/Details.cshtml", result);
    }

    // GET: CL_COVER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        return View("~/Views/Insudb/CL_COVER/Create.cshtml", new CreateCL_COVERDto());
    }

    // POST: CL_COVER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCL_COVERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        return View("~/Views/Insudb/CL_COVER/Create.cshtml", createDto);
    }

    // GET: CL_COVER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCL_COVERDto
        {
            NCLAIM = result.NCLAIM,
            NCOVER = result.NCOVER,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NMODULEC = result.NMODULEC,
            NCURRENCY = result.NCURRENCY,
            NBRANCH_EST = result.NBRANCH_EST,
            SCLIENT = result.SCLIENT,
            NBRANCH_LED = result.NBRANCH_LED,
            NBRANCH_REI = result.NBRANCH_REI,
            DCOMPDATE = result.DCOMPDATE,
            NCOST_RECU = result.NCOST_RECU,
            NDAMAGES = result.NDAMAGES,
            NEXP_AMOUNT = result.NEXP_AMOUNT,
            NFRA_AMOUNT = result.NFRA_AMOUNT,
            SFRANTYPE = result.SFRANTYPE,
            NGROUP = result.NGROUP,
            NLOC_COS_RE = result.NLOC_COS_RE,
            NLOC_PAY_AM = result.NLOC_PAY_AM,
            NLOC_REC_AM = result.NLOC_REC_AM,
            NLOC_RESERV = result.NLOC_RESERV,
            NPAY_AMOUNT = result.NPAY_AMOUNT,
            NQUANTITY = result.NQUANTITY,
            NREC_AMOUNT = result.NREC_AMOUNT,
            NRESERVE = result.NRESERVE,
            SRESERVSTAT = result.SRESERVSTAT,
            NUSERCODE = result.NUSERCODE,
            NDAMPROF = result.NDAMPROF,
            NTAX_AMO = result.NTAX_AMO,
            SBILL_IND = result.SBILL_IND,
            NRATEEQCOST = result.NRATEEQCOST,
            NDEPRECIATEBASE = result.NDEPRECIATEBASE,
            NDEPRECIATERATE = result.NDEPRECIATERATE,
            NDEPRECIATEAMOUNT = result.NDEPRECIATEAMOUNT,
            NRASA = result.NRASA,
            NFRANCDAYS = result.NFRANCDAYS,
            NDAYDEDAMOUNT = result.NDAYDEDAMOUNT,
            NORIG_RESERVE = result.NORIG_RESERVE,
        };
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        return View("~/Views/Insudb/CL_COVER/Edit.cshtml", updateDto);
    }

    // POST: CL_COVER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCL_COVERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_CASEDropdownAsync();
        await PopulateTABLE71DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE75DropdownAsync();
        await PopulateTABLE5000DropdownAsync();
        await PopulateTABLE64DropdownAsync();
        return View("~/Views/Insudb/CL_COVER/Edit.cshtml", updateDto);
    }

    // GET: CL_COVER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COVER/Delete.cshtml", result);
    }

    // POST: CL_COVER/Delete/{id}
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

    private async Task PopulateTABLE71DropdownAsync()
    {
        var items = await _TABLE71Service.GetAllAsync();
        ViewData["NBRANCH_EST"] = new SelectList(items, nameof(TABLE71Dto.NBRANCH_EST), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE75DropdownAsync()
    {
        var items = await _TABLE75Service.GetAllAsync();
        ViewData["NBRANCH_LED"] = new SelectList(items, nameof(TABLE75Dto.NBRANCH_LED), "SDESCRIPT");
    }

    private async Task PopulateTABLE5000DropdownAsync()
    {
        var items = await _TABLE5000Service.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(TABLE5000Dto.NBRANCH_REI), "SDESCRIPT");
    }

    private async Task PopulateTABLE64DropdownAsync()
    {
        var items = await _TABLE64Service.GetAllAsync();
        ViewData["SFRANTYPE"] = new SelectList(items, nameof(TABLE64Dto.SFRANTYPE), "SDESCRIPT");
    }

}
