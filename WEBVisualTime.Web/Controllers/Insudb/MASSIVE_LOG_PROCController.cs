using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_PROC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.MASS_PROC_SPONSOR;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASSIVE_LOG_PROCController : Controller
{
    private readonly IMASSIVE_LOG_PROCService _service;
    private readonly IMASS_PROC_SPONSORService _MASS_PROC_SPONSORService;

    public MASSIVE_LOG_PROCController(IMASSIVE_LOG_PROCService service
        , IMASS_PROC_SPONSORService MASS_PROC_SPONSORService
    )
    {
        _service = service;
        _MASS_PROC_SPONSORService = MASS_PROC_SPONSORService;
    }

    // GET: MASSIVE_LOG_PROC
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Index.cshtml", result);
    }

    // GET: MASSIVE_LOG_PROC/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Details.cshtml", result);
    }

    // GET: MASSIVE_LOG_PROC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateMASS_PROC_SPONSORDropdownAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Create.cshtml", new CreateMASSIVE_LOG_PROCDto());
    }

    // POST: MASSIVE_LOG_PROC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASSIVE_LOG_PROCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateMASS_PROC_SPONSORDropdownAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Create.cshtml", createDto);
    }

    // GET: MASSIVE_LOG_PROC/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASSIVE_LOG_PROCDto
        {
            SKEY = result.SKEY,
            NKEY = result.NKEY,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCLAIM = result.NCLAIM,
            DSTARTDATE = result.DSTARTDATE,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NSEQ = result.NSEQ,
            DEXPIRDAT = result.DEXPIRDAT,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM = result.NPREMIUM,
            NDECLAREDCLAIM = result.NDECLAREDCLAIM,
            NCLAIMSPAID = result.NCLAIMSPAID,
            NRECEIPTPAID = result.NRECEIPTPAID,
            SCANCELEDCLAIMS = result.SCANCELEDCLAIMS,
            DNULLDATE = result.DNULLDATE,
            NROLE = result.NROLE,
            SCLIENT = result.SCLIENT,
            SITEM = result.SITEM,
            NROW = result.NROW,
            NCOMBPOLICY = result.NCOMBPOLICY,
            NCOMMISION = result.NCOMMISION,
            NSTIPEND_AMOUNT = result.NSTIPEND_AMOUNT,
            NCOD_AGREE = result.NCOD_AGREE,
            NAMOUNT_ORI = result.NAMOUNT_ORI,
            NAMOUNT_LOC = result.NAMOUNT_LOC,
            NACTION = result.NACTION,
            SLOT = result.SLOT,
            SCOMERPRODUCT = result.SCOMERPRODUCT,
            SOFFICIALPOL = result.SOFFICIALPOL,
            NPREMIUMN = result.NPREMIUMN,
            NPAYFREQ = result.NPAYFREQ,
            NWAY_PAY = result.NWAY_PAY,
            SPREVNUMPOL = result.SPREVNUMPOL,
            DDATEORIGINCERT = result.DDATEORIGINCERT,
        };
        await PopulateMASS_PROC_SPONSORDropdownAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Edit.cshtml", updateDto);
    }

    // POST: MASSIVE_LOG_PROC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASSIVE_LOG_PROCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateMASS_PROC_SPONSORDropdownAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Edit.cshtml", updateDto);
    }

    // GET: MASSIVE_LOG_PROC/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_LOG_PROC/Delete.cshtml", result);
    }

    // POST: MASSIVE_LOG_PROC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateMASS_PROC_SPONSORDropdownAsync()
    {
        var items = await _MASS_PROC_SPONSORService.GetAllAsync();
        ViewData["SKEY"] = new SelectList(items, nameof(MASS_PROC_SPONSORDto.SKEY), "SLOT");
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(MASS_PROC_SPONSORDto.NCOD_AGREE), "SLOT");
    }

}
