using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.LEDGER_ACC;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CURR_ACCController : Controller
{
    private readonly ICURR_ACCService _service;
    private readonly ITABLE400Service _TABLE400Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ILEDGER_ACCService _LEDGER_ACCService;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE5001Service _TABLE5001Service;

    public CURR_ACCController(ICURR_ACCService service
        , ITABLE400Service TABLE400Service
        , ICLIENTService CLIENTService
        , ILEDGER_ACCService LEDGER_ACCService
        , ICERTIFICATService CERTIFICATService
        , ICOMPANYService COMPANYService
        , ITABLE5001Service TABLE5001Service
    )
    {
        _service = service;
        _TABLE400Service = TABLE400Service;
        _CLIENTService = CLIENTService;
        _LEDGER_ACCService = LEDGER_ACCService;
        _CERTIFICATService = CERTIFICATService;
        _COMPANYService = COMPANYService;
        _TABLE5001Service = TABLE5001Service;
    }

    // GET: CURR_ACC
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CURR_ACC/Index.cshtml");

    // GET: CURR_ACC/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CURR_ACC/Details.cshtml", result);
    }

    // GET: CURR_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CURR_ACC/Create.cshtml", new CreateCURR_ACCDto());
    }

    // POST: CURR_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCURR_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CURR_ACC/Create.cshtml", createDto);
    }

    // GET: CURR_ACC/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCURR_ACCDto
        {
            NTYP_ACCO = result.NTYP_ACCO,
            STYPE_ACC = result.STYPE_ACC,
            SCLIENT = result.SCLIENT,
            NCURRENCY = result.NCURRENCY,
            NBALANCE = result.NBALANCE,
            NCREDIT = result.NCREDIT,
            NDEBIT = result.NDEBIT,
            DEFFECDATE = result.DEFFECDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NLED_COMPAN = result.NLED_COMPAN,
            SACCOUNT = result.SACCOUNT,
            SCERTYPE = result.SCERTYPE,
            NCOMPANY = result.NCOMPANY,
            NPRODUCT = result.NPRODUCT,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            NBRANCH = result.NBRANCH,
            NCERTIF = result.NCERTIF,
            NPOLICY = result.NPOLICY,
            NINSUR_AREA = result.NINSUR_AREA,
        };
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CURR_ACC/Edit.cshtml", updateDto);
    }

    // POST: CURR_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCURR_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYP_ACCO, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE400DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateLEDGER_ACCDropdownAsync();
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/CURR_ACC/Edit.cshtml", updateDto);
    }

    // GET: CURR_ACC/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CURR_ACC/Delete.cshtml", result);
    }

    // POST: CURR_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE400DropdownAsync()
    {
        var items = await _TABLE400Service.GetAllAsync();
        ViewData["NTYP_ACCO"] = new SelectList(items, nameof(TABLE400Dto.NTYP_ACCO), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateLEDGER_ACCDropdownAsync()
    {
        var items = await _LEDGER_ACCService.GetAllAsync();
        ViewData["NLED_COMPAN"] = new SelectList(items, nameof(LEDGER_ACCDto.NLED_COMPAN), "SADJU_EXCI");
        ViewData["SACCOUNT"] = new SelectList(items, nameof(LEDGER_ACCDto.SACCOUNT), "SADJU_EXCI");
        ViewData["SAUX_ACCOUN"] = new SelectList(items, nameof(LEDGER_ACCDto.SAUX_ACCOUN), "SADJU_EXCI");
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

}
