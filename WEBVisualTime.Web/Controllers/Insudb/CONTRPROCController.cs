using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRPROC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTRPROCController : Controller
{
    private readonly ICONTRPROCService _service;
    private readonly ICONTRMASTERService _CONTRMASTERService;
    private readonly ITABLE97Service _TABLE97Service;
    private readonly ITABLE79Service _TABLE79Service;
    private readonly ITABLE90Service _TABLE90Service;
    private readonly ITABLE36Service _TABLE36Service;

    public CONTRPROCController(ICONTRPROCService service
        , ICONTRMASTERService CONTRMASTERService
        , ITABLE97Service TABLE97Service
        , ITABLE79Service TABLE79Service
        , ITABLE90Service TABLE90Service
        , ITABLE36Service TABLE36Service
    )
    {
        _service = service;
        _CONTRMASTERService = CONTRMASTERService;
        _TABLE97Service = TABLE97Service;
        _TABLE79Service = TABLE79Service;
        _TABLE90Service = TABLE90Service;
        _TABLE36Service = TABLE36Service;
    }

    // GET: CONTRPROC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CONTRPROC/Index.cshtml");

    // GET: CONTRPROC/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRPROC/Details.cshtml", result);
    }

    // GET: CONTRPROC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/CONTRPROC/Create.cshtml", new CreateCONTRPROCDto());
    }

    // POST: CONTRPROC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTRPROCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/CONTRPROC/Create.cshtml", createDto);
    }

    // GET: CONTRPROC/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTRPROCDto
        {
            NNUMBER = result.NNUMBER,
            NBRANCH = result.NBRANCH,
            DEFFECDATE = result.DEFFECDATE,
            NTYPE = result.NTYPE,
            NAMOUNT = result.NAMOUNT,
            NTYPE_REL = result.NTYPE_REL,
            NFQCY_ACC = result.NFQCY_ACC,
            SCAP_NOM_RI = result.SCAP_NOM_RI,
            DCOMPDATE = result.DCOMPDATE,
            NEXCESS = result.NEXCESS,
            NEXPENSES = result.NEXPENSES,
            NFACT_RESER = result.NFACT_RESER,
            NFIXED_PRAT = result.NFIXED_PRAT,
            NGROUP_BENE = result.NGROUP_BENE,
            NGROUP_CO = result.NGROUP_CO,
            NINT_CLAIM = result.NINT_CLAIM,
            NINT_PREM = result.NINT_PREM,
            NLINES = result.NLINES,
            NMAX_EVEN = result.NMAX_EVEN,
            DNULLDATE = result.DNULLDATE,
            NPREM_DEP = result.NPREM_DEP,
            NPROFIT_SH = result.NPROFIT_SH,
            NQUOTA_SHA = result.NQUOTA_SHA,
            NRATE_CLAIM = result.NRATE_CLAIM,
            SRESER_CLAI = result.SRESER_CLAI,
            NRETEN_MIN = result.NRETEN_MIN,
            NTAB_COMMI = result.NTAB_COMMI,
            STAB_LIMIT = result.STAB_LIMIT,
            NTRAN_PREM = result.NTRAN_PREM,
            NUSERCODE = result.NUSERCODE,
            NYEAR_BEGIN = result.NYEAR_BEGIN,
            NYEAR_END = result.NYEAR_END,
            SRETCOVER = result.SRETCOVER,
            SLIMITCOV = result.SLIMITCOV,
            SCESSPRCOV = result.SCESSPRCOV,
            SEXTRAPREM = result.SEXTRAPREM,
            SGENCESS = result.SGENCESS,
            NRATE = result.NRATE,
            NCESSPRFIX = result.NCESSPRFIX,
            NMINCAPCESS = result.NMINCAPCESS,
            NNEXTMONTHP = result.NNEXTMONTHP,
            NNEXTYEARP = result.NNEXTYEARP,
            NNEXTMONTHC = result.NNEXTMONTHC,
            NNEXTYEARC = result.NNEXTYEARC,
            SROUPROFIT = result.SROUPROFIT,
            SCOMMCOV = result.SCOMMCOV,
            NINTEREST = result.NINTEREST,
            SCUMULTYP = result.SCUMULTYP,
            SCUMREINT = result.SCUMREINT,
            SCUMULPOL = result.SCUMULPOL,
            NFREQPAY = result.NFREQPAY,
            NNEXTMONTHPA = result.NNEXTMONTHPA,
            NNEXTYEARPA = result.NNEXTYEARPA,
            SRETZONE = result.SRETZONE,
            SCESSCIA = result.SCESSCIA,
            NIND_AGE = result.NIND_AGE,
            SROUCESS = result.SROUCESS,
            NMAXRETAMOUNT = result.NMAXRETAMOUNT,
            SDESCRIPT = result.SDESCRIPT,
        };
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/CONTRPROC/Edit.cshtml", updateDto);
    }

    // POST: CONTRPROC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTRPROCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NNUMBER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        await PopulateTABLE79DropdownAsync();
        await PopulateTABLE90DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/CONTRPROC/Edit.cshtml", updateDto);
    }

    // GET: CONTRPROC/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRPROC/Delete.cshtml", result);
    }

    // POST: CONTRPROC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCONTRMASTERDropdownAsync()
    {
        var items = await _CONTRMASTERService.GetAllAsync();
        ViewData["NNUMBER"] = new SelectList(items, nameof(CONTRMASTERDto.NNUMBER), "SSTATREGT");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CONTRMASTERDto.NBRANCH), "SSTATREGT");
        ViewData["NTYPE"] = new SelectList(items, nameof(CONTRMASTERDto.NTYPE), "SSTATREGT");
        ViewData["NTYPE_REL"] = new SelectList(items, nameof(CONTRMASTERDto.NTYPE_REL), "SSTATREGT");
    }

    private async Task PopulateTABLE97DropdownAsync()
    {
        var items = await _TABLE97Service.GetAllAsync();
        ViewData["NFQCY_ACC"] = new SelectList(items, nameof(TABLE97Dto.NTYPE_PER), "SDESCRIPT");
    }

    private async Task PopulateTABLE79DropdownAsync()
    {
        var items = await _TABLE79Service.GetAllAsync();
        ViewData["SCUMULTYP"] = new SelectList(items, nameof(TABLE79Dto.SCUMULTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE90DropdownAsync()
    {
        var items = await _TABLE90Service.GetAllAsync();
        ViewData["SCUMREINT"] = new SelectList(items, nameof(TABLE90Dto.SCUMREINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NFREQPAY"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

}
