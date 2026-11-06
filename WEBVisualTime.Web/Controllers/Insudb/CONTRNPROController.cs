using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNPRO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTRNPROController : Controller
{
    private readonly ICONTRNPROService _service;
    private readonly ICONTRMASTERService _CONTRMASTERService;
    private readonly ITABLE97Service _TABLE97Service;

    public CONTRNPROController(ICONTRNPROService service
        , ICONTRMASTERService CONTRMASTERService
        , ITABLE97Service TABLE97Service
    )
    {
        _service = service;
        _CONTRMASTERService = CONTRMASTERService;
        _TABLE97Service = TABLE97Service;
    }

    // GET: CONTRNPRO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CONTRNPRO/Index.cshtml");

    // GET: CONTRNPRO/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRNPRO/Details.cshtml", result);
    }

    // GET: CONTRNPRO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CONTRNPRO/Create.cshtml", new CreateCONTRNPRODto());
    }

    // POST: CONTRNPRO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTRNPRODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CONTRNPRO/Create.cshtml", createDto);
    }

    // GET: CONTRNPRO/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTRNPRODto
        {
            NNUMBER = result.NNUMBER,
            NBRANCH = result.NBRANCH,
            DEFFECDATE = result.DEFFECDATE,
            NTYPE = result.NTYPE,
            NAMOUNT = result.NAMOUNT,
            NTYPE_REL = result.NTYPE_REL,
            NCESSION = result.NCESSION,
            NCLAUSULE = result.NCLAUSULE,
            DCOMPDATE = result.DCOMPDATE,
            NDEDUCIBLE = result.NDEDUCIBLE,
            SDESCRIPT = result.SDESCRIPT,
            NEXCESS = result.NEXCESS,
            NMAX_EVEN = result.NMAX_EVEN,
            DNULLDATE = result.DNULLDATE,
            NNUMBER_REP = result.NNUMBER_REP,
            NPORC_REP = result.NPORC_REP,
            NPREM_DEP = result.NPREM_DEP,
            NPREM_FIJ = result.NPREM_FIJ,
            NPREM_MIN = result.NPREM_MIN,
            NRATE_FIJ = result.NRATE_FIJ,
            NRATE_MAX = result.NRATE_MAX,
            NRATE_MIN = result.NRATE_MIN,
            SREINSURAN = result.SREINSURAN,
            NRETENTION = result.NRETENTION,
            NUSERCODE = result.NUSERCODE,
            NCURR_PAY = result.NCURR_PAY,
            NINTEREST = result.NINTEREST,
            NFREQPAY = result.NFREQPAY,
            NNEXTMONTHPA = result.NNEXTMONTHPA,
            NNEXTYEARPA = result.NNEXTYEARPA,
            NFREQCT = result.NFREQCT,
            NNEXTMONTHC = result.NNEXTMONTHC,
            NNEXTYEARC = result.NNEXTYEARC,
            SROUCESSPR = result.SROUCESSPR,
            SROUCESSCL = result.SROUCESSCL,
            SAGREEMENTPAYS = result.SAGREEMENTPAYS,
            SROUNETRET = result.SROUNETRET,
            NRATE_NRIFV = result.NRATE_NRIFV,
            NCLAIMSCATAS = result.NCLAIMSCATAS,
            NMAXRESPEVEN = result.NMAXRESPEVEN,
            NNUMBERREPEVEN = result.NNUMBERREPEVEN,
            SPRORATEREP = result.SPRORATEREP,
            NPORC_PAY = result.NPORC_PAY,
            NPREMIUM_DEVENG = result.NPREMIUM_DEVENG,
            NEPI = result.NEPI,
            NTAX = result.NTAX,
            NCLAIMADJ = result.NCLAIMADJ,
            NCAPITALREF = result.NCAPITALREF,
            NLIFENUM = result.NLIFENUM,
            NSPCPRIORITY = result.NSPCPRIORITY,
            NSPCLIMIT = result.NSPCLIMIT,
        };
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CONTRNPRO/Edit.cshtml", updateDto);
    }

    // POST: CONTRNPRO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTRNPRODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NNUMBER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CONTRNPRO/Edit.cshtml", updateDto);
    }

    // GET: CONTRNPRO/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRNPRO/Delete.cshtml", result);
    }

    // POST: CONTRNPRO/Delete/{id}
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
        ViewData["NFREQPAY"] = new SelectList(items, nameof(TABLE97Dto.NTYPE_PER), "SDESCRIPT");
        ViewData["NFREQCT"] = new SelectList(items, nameof(TABLE97Dto.NTYPE_PER), "SDESCRIPT");
    }

}
