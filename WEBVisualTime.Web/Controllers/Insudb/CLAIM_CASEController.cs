using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_CASE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_CASEController : Controller
{
    private readonly ICLAIM_CASEService _service;
    private readonly ICLAIMService _CLAIMService;
    private readonly ITABLE692Service _TABLE692Service;
    private readonly ITABLE135Service _TABLE135Service;
    private readonly ITABLE5524Service _TABLE5524Service;
    private readonly ITABLE136Service _TABLE136Service;

    public CLAIM_CASEController(ICLAIM_CASEService service
        , ICLAIMService CLAIMService
        , ITABLE692Service TABLE692Service
        , ITABLE135Service TABLE135Service
        , ITABLE5524Service TABLE5524Service
        , ITABLE136Service TABLE136Service
    )
    {
        _service = service;
        _CLAIMService = CLAIMService;
        _TABLE692Service = TABLE692Service;
        _TABLE135Service = TABLE135Service;
        _TABLE5524Service = TABLE5524Service;
        _TABLE136Service = TABLE136Service;
    }

    // GET: CLAIM_CASE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_CASE/Index.cshtml");

    // GET: CLAIM_CASE/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CASE/Details.cshtml", result);
    }

    // GET: CLAIM_CASE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE136DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CASE/Create.cshtml", new CreateCLAIM_CASEDto());
    }

    // POST: CLAIM_CASE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_CASEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE136DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CASE/Create.cshtml", createDto);
    }

    // GET: CLAIM_CASE/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_CASEDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSTACASE = result.SSTACASE,
            NNOTEDAMA = result.NNOTEDAMA,
            SCLAIM_AFFE = result.SCLAIM_AFFE,
            NGROWTH_RATEI = result.NGROWTH_RATEI,
            NGROWTH_RATEE = result.NGROWTH_RATEE,
            NAPV_CAPITAL = result.NAPV_CAPITAL,
            DSUMMON_LIMIT = result.DSUMMON_LIMIT,
            SHAS_SURV_PENSION_BENEFS = result.SHAS_SURV_PENSION_BENEFS,
            DSUMMON = result.DSUMMON,
            SAFP_TRANS_TYPE = result.SAFP_TRANS_TYPE,
            NSTAY_BONUS = result.NSTAY_BONUS,
            NAPV_BALANCE_BC2052 = result.NAPV_BALANCE_BC2052,
            NAPV_BALANCE_AC2052 = result.NAPV_BALANCE_AC2052,
            NTRANSF_AMOUNT = result.NTRANSF_AMOUNT,
            NAPV_TAX = result.NAPV_TAX,
            NAPV_BENEF_BALANCE = result.NAPV_BENEF_BALANCE,
            NAFP = result.NAFP,
            NSENDTO_LGM = result.NSENDTO_LGM,
            DNULLDATE = result.DNULLDATE,
            NNULLCODE = result.NNULLCODE,
        };
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE136DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CASE/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_CASE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_CASEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE135DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE136DropdownAsync();
        return View("~/Views/Insudb/CLAIM_CASE/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_CASE/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_CASE/Delete.cshtml", result);
    }

    // POST: CLAIM_CASE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLAIM_CASE/GetByNCLAIM?NCLAIM=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCLAIM(long NCLAIM)
    {
        var items = await _service.FindAsync(p => p.NCLAIM == NCLAIM);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SCLAIM_AFFE }));
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE135DropdownAsync()
    {
        var items = await _TABLE135Service.GetAllAsync();
        ViewData["SSTACASE"] = new SelectList(items, nameof(TABLE135Dto.SSTACLAIM), "SDESCRIPT");
    }

    private async Task PopulateTABLE5524DropdownAsync()
    {
        var items = await _TABLE5524Service.GetAllAsync();
        ViewData["NAFP"] = new SelectList(items, nameof(TABLE5524Dto.NAFP), "SDESCRIPT");
    }

    private async Task PopulateTABLE136DropdownAsync()
    {
        var items = await _TABLE136Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE136Dto.NNULLCODE), "SDESCRIPT");
    }

}
