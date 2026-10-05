using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BK_AGE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE197;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BANK_ACCController : Controller
{
    private readonly IBANK_ACCService _service;
    private readonly ITAB_BK_AGEService _TAB_BK_AGEService;
    private readonly ITABLE190Service _TABLE190Service;
    private readonly ITABLE197Service _TABLE197Service;
    private readonly ICOMPANYService _COMPANYService;

    public BANK_ACCController(IBANK_ACCService service
        , ITAB_BK_AGEService TAB_BK_AGEService
        , ITABLE190Service TABLE190Service
        , ITABLE197Service TABLE197Service
        , ICOMPANYService COMPANYService
    )
    {
        _service = service;
        _TAB_BK_AGEService = TAB_BK_AGEService;
        _TABLE190Service = TABLE190Service;
        _TABLE197Service = TABLE197Service;
        _COMPANYService = COMPANYService;
    }

    // GET: BANK_ACC
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BANK_ACC/Index.cshtml", result);
    }

    // GET: BANK_ACC/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_ACC/Details.cshtml", result);
    }

    // GET: BANK_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_BK_AGEDropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE197DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/BANK_ACC/Create.cshtml", new CreateBANK_ACCDto());
    }

    // POST: BANK_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBANK_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_BK_AGEDropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE197DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/BANK_ACC/Create.cshtml", createDto);
    }

    // GET: BANK_ACC/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBANK_ACCDto
        {
            NACC_BANK = result.NACC_BANK,
            SACC_LEDGER = result.SACC_LEDGER,
            NBANK_CODE = result.NBANK_CODE,
            NBK_AGENCY = result.NBK_AGENCY,
            SACC_NUMBER = result.SACC_NUMBER,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            NACC_TYPE = result.NACC_TYPE,
            NAVAILABLE = result.NAVAILABLE,
            DCOMPDATE = result.DCOMPDATE,
            NAVAIL_TYPE = result.NAVAIL_TYPE,
            NCURRENCY = result.NCURRENCY,
            DEFFECDATE = result.DEFFECDATE,
            NLED_COMPAN = result.NLED_COMPAN,
            NOFFICE = result.NOFFICE,
            NTRANSIT_1 = result.NTRANSIT_1,
            NTRANSIT_2 = result.NTRANSIT_2,
            NTRANSIT_3 = result.NTRANSIT_3,
            NTRANSIT_4 = result.NTRANSIT_4,
            NTRANSIT_5 = result.NTRANSIT_5,
            NUSERCODE = result.NUSERCODE,
            SSTATREGT = result.SSTATREGT,
            NCOMPANY = result.NCOMPANY,
            DREALDEP = result.DREALDEP,
        };
        await PopulateTAB_BK_AGEDropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE197DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/BANK_ACC/Edit.cshtml", updateDto);
    }

    // POST: BANK_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBANK_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NACC_BANK, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_BK_AGEDropdownAsync();
        await PopulateTABLE190DropdownAsync();
        await PopulateTABLE197DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/BANK_ACC/Edit.cshtml", updateDto);
    }

    // GET: BANK_ACC/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BANK_ACC/Delete.cshtml", result);
    }

    // POST: BANK_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: BANK_ACC/GetByNCOMPANY?NCOMPANY=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCOMPANY(int NCOMPANY)
    {
        var items = await _service.FindAsync(p => p.NCOMPANY == NCOMPANY);
        return Json(items.Select(i => new { value = i.NACC_BANK, text = i.SACC_LEDGER }));
    }

    private async Task PopulateTAB_BK_AGEDropdownAsync()
    {
        var items = await _TAB_BK_AGEService.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TAB_BK_AGEDto.NBANK_CODE), "SDESCRIPT");
        ViewData["NBK_AGENCY"] = new SelectList(items, nameof(TAB_BK_AGEDto.NBK_AGENCY), "SDESCRIPT");
    }

    private async Task PopulateTABLE190DropdownAsync()
    {
        var items = await _TABLE190Service.GetAllAsync();
        ViewData["NACC_TYPE"] = new SelectList(items, nameof(TABLE190Dto.NACC_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE197DropdownAsync()
    {
        var items = await _TABLE197Service.GetAllAsync();
        ViewData["NAVAIL_TYPE"] = new SelectList(items, nameof(TABLE197Dto.NAVAIL_TYPE), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

}
