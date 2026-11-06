using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PART_CONTR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PART_CONTRController : Controller
{
    private readonly IPART_CONTRService _service;
    private readonly ICONTRMASTERService _CONTRMASTERService;
    private readonly ICOMPANYService _COMPANYService;

    public PART_CONTRController(IPART_CONTRService service
        , ICONTRMASTERService CONTRMASTERService
        , ICOMPANYService COMPANYService
    )
    {
        _service = service;
        _CONTRMASTERService = CONTRMASTERService;
        _COMPANYService = COMPANYService;
    }

    // GET: PART_CONTR
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PART_CONTR/Index.cshtml");

    // GET: PART_CONTR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PART_CONTR/Details.cshtml", result);
    }

    // GET: PART_CONTR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/PART_CONTR/Create.cshtml", new CreatePART_CONTRDto());
    }

    // POST: PART_CONTR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePART_CONTRDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/PART_CONTR/Create.cshtml", createDto);
    }

    // GET: PART_CONTR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePART_CONTRDto
        {
            NTYPE_REL = result.NTYPE_REL,
            NNUMBER = result.NNUMBER,
            NBRANCH = result.NBRANCH,
            DEFFECDATE = result.DEFFECDATE,
            NTYPE = result.NTYPE,
            DSTARTDATE = result.DSTARTDATE,
            NCOMPANY = result.NCOMPANY,
            NARR_PERD = result.NARR_PERD,
            NCOMISION = result.NCOMISION,
            DCOMPDATE = result.DCOMPDATE,
            NCORREDOR = result.NCORREDOR,
            DNULLDATE = result.DNULLDATE,
            NPR_INOUT = result.NPR_INOUT,
            NCL_INOUT = result.NCL_INOUT,
            NRATE = result.NRATE,
            NRATE_BENE = result.NRATE_BENE,
            NSHARE = result.NSHARE,
            NUSERCODE = result.NUSERCODE,
            NCESSPRFIX = result.NCESSPRFIX,
            NCESSRATE = result.NCESSRATE,
            SROUCESS = result.SROUCESS,
            SROUPROFIT = result.SROUPROFIT,
            NAMOUNTPROFIT = result.NAMOUNTPROFIT,
            SFREQPROFIT = result.SFREQPROFIT,
            NEXCESS = result.NEXCESS,
            NTAX = result.NTAX,
            NEXPENSES = result.NEXPENSES,
            NRATE_DEV = result.NRATE_DEV,
        };
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/PART_CONTR/Edit.cshtml", updateDto);
    }

    // POST: PART_CONTR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePART_CONTRDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_REL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRMASTERDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/PART_CONTR/Edit.cshtml", updateDto);
    }

    // GET: PART_CONTR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PART_CONTR/Delete.cshtml", result);
    }

    // POST: PART_CONTR/Delete/{id}
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
        ViewData["NTYPE_REL"] = new SelectList(items, nameof(CONTRMASTERDto.NTYPE_REL), "SSTATREGT");
        ViewData["NNUMBER"] = new SelectList(items, nameof(CONTRMASTERDto.NNUMBER), "SSTATREGT");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CONTRMASTERDto.NBRANCH), "SSTATREGT");
        ViewData["NTYPE"] = new SelectList(items, nameof(CONTRMASTERDto.NTYPE), "SSTATREGT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

}
