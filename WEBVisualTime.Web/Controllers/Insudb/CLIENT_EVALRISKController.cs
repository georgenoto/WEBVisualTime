using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_EVALRISK;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9010;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9011;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9012;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9013;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9014;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9015;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9016;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9017;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9018;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9019;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9020;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9021;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9022;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9023;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9024;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9025;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9026;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9027;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9028;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9029;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9030;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9031;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_EVALRISKController : Controller
{
    private readonly ICLIENT_EVALRISKService _service;
    private readonly ITABLE9010Service _TABLE9010Service;
    private readonly ITABLE9011Service _TABLE9011Service;
    private readonly ITABLE9012Service _TABLE9012Service;
    private readonly ITABLE9013Service _TABLE9013Service;
    private readonly ITABLE9014Service _TABLE9014Service;
    private readonly ITABLE9015Service _TABLE9015Service;
    private readonly ITABLE9016Service _TABLE9016Service;
    private readonly ITABLE9017Service _TABLE9017Service;
    private readonly ITABLE9018Service _TABLE9018Service;
    private readonly ITABLE9019Service _TABLE9019Service;
    private readonly ITABLE9020Service _TABLE9020Service;
    private readonly ITABLE9021Service _TABLE9021Service;
    private readonly ITABLE9022Service _TABLE9022Service;
    private readonly ITABLE9023Service _TABLE9023Service;
    private readonly ITABLE9024Service _TABLE9024Service;
    private readonly ITABLE9025Service _TABLE9025Service;
    private readonly ITABLE9026Service _TABLE9026Service;
    private readonly ITABLE9027Service _TABLE9027Service;
    private readonly ITABLE9028Service _TABLE9028Service;
    private readonly ITABLE9029Service _TABLE9029Service;
    private readonly ITABLE9030Service _TABLE9030Service;
    private readonly ITABLE66Service _TABLE66Service;
    private readonly ITABLE9031Service _TABLE9031Service;

    public CLIENT_EVALRISKController(ICLIENT_EVALRISKService service
        , ITABLE9010Service TABLE9010Service
        , ITABLE9011Service TABLE9011Service
        , ITABLE9012Service TABLE9012Service
        , ITABLE9013Service TABLE9013Service
        , ITABLE9014Service TABLE9014Service
        , ITABLE9015Service TABLE9015Service
        , ITABLE9016Service TABLE9016Service
        , ITABLE9017Service TABLE9017Service
        , ITABLE9018Service TABLE9018Service
        , ITABLE9019Service TABLE9019Service
        , ITABLE9020Service TABLE9020Service
        , ITABLE9021Service TABLE9021Service
        , ITABLE9022Service TABLE9022Service
        , ITABLE9023Service TABLE9023Service
        , ITABLE9024Service TABLE9024Service
        , ITABLE9025Service TABLE9025Service
        , ITABLE9026Service TABLE9026Service
        , ITABLE9027Service TABLE9027Service
        , ITABLE9028Service TABLE9028Service
        , ITABLE9029Service TABLE9029Service
        , ITABLE9030Service TABLE9030Service
        , ITABLE66Service TABLE66Service
        , ITABLE9031Service TABLE9031Service
    )
    {
        _service = service;
        _TABLE9010Service = TABLE9010Service;
        _TABLE9011Service = TABLE9011Service;
        _TABLE9012Service = TABLE9012Service;
        _TABLE9013Service = TABLE9013Service;
        _TABLE9014Service = TABLE9014Service;
        _TABLE9015Service = TABLE9015Service;
        _TABLE9016Service = TABLE9016Service;
        _TABLE9017Service = TABLE9017Service;
        _TABLE9018Service = TABLE9018Service;
        _TABLE9019Service = TABLE9019Service;
        _TABLE9020Service = TABLE9020Service;
        _TABLE9021Service = TABLE9021Service;
        _TABLE9022Service = TABLE9022Service;
        _TABLE9023Service = TABLE9023Service;
        _TABLE9024Service = TABLE9024Service;
        _TABLE9025Service = TABLE9025Service;
        _TABLE9026Service = TABLE9026Service;
        _TABLE9027Service = TABLE9027Service;
        _TABLE9028Service = TABLE9028Service;
        _TABLE9029Service = TABLE9029Service;
        _TABLE9030Service = TABLE9030Service;
        _TABLE66Service = TABLE66Service;
        _TABLE9031Service = TABLE9031Service;
    }

    // GET: CLIENT_EVALRISK
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Index.cshtml", result);
    }

    // GET: CLIENT_EVALRISK/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Details.cshtml", result);
    }

    // GET: CLIENT_EVALRISK/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9010DropdownAsync();
        await PopulateTABLE9011DropdownAsync();
        await PopulateTABLE9012DropdownAsync();
        await PopulateTABLE9013DropdownAsync();
        await PopulateTABLE9014DropdownAsync();
        await PopulateTABLE9015DropdownAsync();
        await PopulateTABLE9016DropdownAsync();
        await PopulateTABLE9017DropdownAsync();
        await PopulateTABLE9018DropdownAsync();
        await PopulateTABLE9019DropdownAsync();
        await PopulateTABLE9020DropdownAsync();
        await PopulateTABLE9021DropdownAsync();
        await PopulateTABLE9022DropdownAsync();
        await PopulateTABLE9023DropdownAsync();
        await PopulateTABLE9024DropdownAsync();
        await PopulateTABLE9025DropdownAsync();
        await PopulateTABLE9026DropdownAsync();
        await PopulateTABLE9027DropdownAsync();
        await PopulateTABLE9028DropdownAsync();
        await PopulateTABLE9029DropdownAsync();
        await PopulateTABLE9030DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9031DropdownAsync();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Create.cshtml", new CreateCLIENT_EVALRISKDto());
    }

    // POST: CLIENT_EVALRISK/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_EVALRISKDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9010DropdownAsync();
        await PopulateTABLE9011DropdownAsync();
        await PopulateTABLE9012DropdownAsync();
        await PopulateTABLE9013DropdownAsync();
        await PopulateTABLE9014DropdownAsync();
        await PopulateTABLE9015DropdownAsync();
        await PopulateTABLE9016DropdownAsync();
        await PopulateTABLE9017DropdownAsync();
        await PopulateTABLE9018DropdownAsync();
        await PopulateTABLE9019DropdownAsync();
        await PopulateTABLE9020DropdownAsync();
        await PopulateTABLE9021DropdownAsync();
        await PopulateTABLE9022DropdownAsync();
        await PopulateTABLE9023DropdownAsync();
        await PopulateTABLE9024DropdownAsync();
        await PopulateTABLE9025DropdownAsync();
        await PopulateTABLE9026DropdownAsync();
        await PopulateTABLE9027DropdownAsync();
        await PopulateTABLE9028DropdownAsync();
        await PopulateTABLE9029DropdownAsync();
        await PopulateTABLE9030DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9031DropdownAsync();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Create.cshtml", createDto);
    }

    // GET: CLIENT_EVALRISK/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_EVALRISKDto
        {
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            DOTHERDATE = result.DOTHERDATE,
            NSINCEYEAR = result.NSINCEYEAR,
            NNUMEMPLOYERS = result.NNUMEMPLOYERS,
            NCNTRYRISK = result.NCNTRYRISK,
            NTYPECIA = result.NTYPECIA,
            NTYPEPRODUCT = result.NTYPEPRODUCT,
            NRISK = result.NRISK,
            NACTBUS = result.NACTBUS,
            NREFBANK = result.NREFBANK,
            NREFBUS = result.NREFBUS,
            NREFLAW = result.NREFLAW,
            NNUMPAYS = result.NNUMPAYS,
            NOLDINSURANCE = result.NOLDINSURANCE,
            NPROPAY = result.NPROPAY,
            NCODDICOM = result.NCODDICOM,
            SDESDICOM = result.SDESDICOM,
            NCREDITREASON = result.NCREDITREASON,
            NLIQCURRENT = result.NLIQCURRENT,
            NLIQACD = result.NLIQACD,
            NRENTABILITY = result.NRENTABILITY,
            NGROWSALES = result.NGROWSALES,
            NECONOMIC = result.NECONOMIC,
            NFINANCIAL = result.NFINANCIAL,
            NCODRATING = result.NCODRATING,
            NDESRATING = result.NDESRATING,
            NCOUNTRY = result.NCOUNTRY,
            SNOTE1 = result.SNOTE1,
            SNOTE2 = result.SNOTE2,
            SNOTE3 = result.SNOTE3,
            SNOTE4 = result.SNOTE4,
            NBRANCHCIA = result.NBRANCHCIA,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NLIMITCREDIT = result.NLIMITCREDIT,
            NCURRENCY = result.NCURRENCY,
        };
        await PopulateTABLE9010DropdownAsync();
        await PopulateTABLE9011DropdownAsync();
        await PopulateTABLE9012DropdownAsync();
        await PopulateTABLE9013DropdownAsync();
        await PopulateTABLE9014DropdownAsync();
        await PopulateTABLE9015DropdownAsync();
        await PopulateTABLE9016DropdownAsync();
        await PopulateTABLE9017DropdownAsync();
        await PopulateTABLE9018DropdownAsync();
        await PopulateTABLE9019DropdownAsync();
        await PopulateTABLE9020DropdownAsync();
        await PopulateTABLE9021DropdownAsync();
        await PopulateTABLE9022DropdownAsync();
        await PopulateTABLE9023DropdownAsync();
        await PopulateTABLE9024DropdownAsync();
        await PopulateTABLE9025DropdownAsync();
        await PopulateTABLE9026DropdownAsync();
        await PopulateTABLE9027DropdownAsync();
        await PopulateTABLE9028DropdownAsync();
        await PopulateTABLE9029DropdownAsync();
        await PopulateTABLE9030DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9031DropdownAsync();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_EVALRISK/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_EVALRISKDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9010DropdownAsync();
        await PopulateTABLE9011DropdownAsync();
        await PopulateTABLE9012DropdownAsync();
        await PopulateTABLE9013DropdownAsync();
        await PopulateTABLE9014DropdownAsync();
        await PopulateTABLE9015DropdownAsync();
        await PopulateTABLE9016DropdownAsync();
        await PopulateTABLE9017DropdownAsync();
        await PopulateTABLE9018DropdownAsync();
        await PopulateTABLE9019DropdownAsync();
        await PopulateTABLE9020DropdownAsync();
        await PopulateTABLE9021DropdownAsync();
        await PopulateTABLE9022DropdownAsync();
        await PopulateTABLE9023DropdownAsync();
        await PopulateTABLE9024DropdownAsync();
        await PopulateTABLE9025DropdownAsync();
        await PopulateTABLE9026DropdownAsync();
        await PopulateTABLE9027DropdownAsync();
        await PopulateTABLE9028DropdownAsync();
        await PopulateTABLE9029DropdownAsync();
        await PopulateTABLE9030DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9031DropdownAsync();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_EVALRISK/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_EVALRISK/Delete.cshtml", result);
    }

    // POST: CLIENT_EVALRISK/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9010DropdownAsync()
    {
        var items = await _TABLE9010Service.GetAllAsync();
        ViewData["NSINCEYEAR"] = new SelectList(items, nameof(TABLE9010Dto.NSINCEYEAR), "SDESCRIPT");
    }

    private async Task PopulateTABLE9011DropdownAsync()
    {
        var items = await _TABLE9011Service.GetAllAsync();
        ViewData["NCNTRYRISK"] = new SelectList(items, nameof(TABLE9011Dto.NCNTRYRISK), "SDESCRIPT");
    }

    private async Task PopulateTABLE9012DropdownAsync()
    {
        var items = await _TABLE9012Service.GetAllAsync();
        ViewData["NTYPECIA"] = new SelectList(items, nameof(TABLE9012Dto.NTYPECIA), "SDESCRIPT");
    }

    private async Task PopulateTABLE9013DropdownAsync()
    {
        var items = await _TABLE9013Service.GetAllAsync();
        ViewData["NTYPEPRODUCT"] = new SelectList(items, nameof(TABLE9013Dto.NTYPEPRODUCT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9014DropdownAsync()
    {
        var items = await _TABLE9014Service.GetAllAsync();
        ViewData["NRISK"] = new SelectList(items, nameof(TABLE9014Dto.NRISK), "SDESCRIPT");
    }

    private async Task PopulateTABLE9015DropdownAsync()
    {
        var items = await _TABLE9015Service.GetAllAsync();
        ViewData["NACTBUS"] = new SelectList(items, nameof(TABLE9015Dto.NACTBUS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9016DropdownAsync()
    {
        var items = await _TABLE9016Service.GetAllAsync();
        ViewData["NREFBANK"] = new SelectList(items, nameof(TABLE9016Dto.NREFBANK), "SDESCRIPT");
    }

    private async Task PopulateTABLE9017DropdownAsync()
    {
        var items = await _TABLE9017Service.GetAllAsync();
        ViewData["NREFBUS"] = new SelectList(items, nameof(TABLE9017Dto.NREFBUS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9018DropdownAsync()
    {
        var items = await _TABLE9018Service.GetAllAsync();
        ViewData["NREFLAW"] = new SelectList(items, nameof(TABLE9018Dto.NREFLAW), "SDESCRIPT");
    }

    private async Task PopulateTABLE9019DropdownAsync()
    {
        var items = await _TABLE9019Service.GetAllAsync();
        ViewData["NNUMPAYS"] = new SelectList(items, nameof(TABLE9019Dto.NNUMPAYS), "SDESCRIPT");
    }

    private async Task PopulateTABLE9020DropdownAsync()
    {
        var items = await _TABLE9020Service.GetAllAsync();
        ViewData["NOLDINSURANCE"] = new SelectList(items, nameof(TABLE9020Dto.NOLDINSURANCE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9021DropdownAsync()
    {
        var items = await _TABLE9021Service.GetAllAsync();
        ViewData["NPROPAY"] = new SelectList(items, nameof(TABLE9021Dto.NPROPAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9022DropdownAsync()
    {
        var items = await _TABLE9022Service.GetAllAsync();
        ViewData["NCREDITREASON"] = new SelectList(items, nameof(TABLE9022Dto.NCREDITREASON), "SDESCRIPT");
    }

    private async Task PopulateTABLE9023DropdownAsync()
    {
        var items = await _TABLE9023Service.GetAllAsync();
        ViewData["NLIQCURRENT"] = new SelectList(items, nameof(TABLE9023Dto.NLIQCURRENT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9024DropdownAsync()
    {
        var items = await _TABLE9024Service.GetAllAsync();
        ViewData["NLIQACD"] = new SelectList(items, nameof(TABLE9024Dto.NLIQACD), "SDESCRIPT");
    }

    private async Task PopulateTABLE9025DropdownAsync()
    {
        var items = await _TABLE9025Service.GetAllAsync();
        ViewData["NRENTABILITY"] = new SelectList(items, nameof(TABLE9025Dto.NRENTABILITY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9026DropdownAsync()
    {
        var items = await _TABLE9026Service.GetAllAsync();
        ViewData["NGROWSALES"] = new SelectList(items, nameof(TABLE9026Dto.NGROWSALES), "SDESCRIPT");
    }

    private async Task PopulateTABLE9027DropdownAsync()
    {
        var items = await _TABLE9027Service.GetAllAsync();
        ViewData["NECONOMIC"] = new SelectList(items, nameof(TABLE9027Dto.NECONOMIC), "SDESCRIPT");
    }

    private async Task PopulateTABLE9028DropdownAsync()
    {
        var items = await _TABLE9028Service.GetAllAsync();
        ViewData["NFINANCIAL"] = new SelectList(items, nameof(TABLE9028Dto.NFINANCIAL), "SDESCRIPT");
    }

    private async Task PopulateTABLE9029DropdownAsync()
    {
        var items = await _TABLE9029Service.GetAllAsync();
        ViewData["NCODRATING"] = new SelectList(items, nameof(TABLE9029Dto.NCODRATING), "SDESCRIPT");
    }

    private async Task PopulateTABLE9030DropdownAsync()
    {
        var items = await _TABLE9030Service.GetAllAsync();
        ViewData["NDESRATING"] = new SelectList(items, nameof(TABLE9030Dto.NDESRATING), "SDESCRIPT");
    }

    private async Task PopulateTABLE66DropdownAsync()
    {
        var items = await _TABLE66Service.GetAllAsync();
        ViewData["NCOUNTRY"] = new SelectList(items, nameof(TABLE66Dto.NCOUNTRY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9031DropdownAsync()
    {
        var items = await _TABLE9031Service.GetAllAsync();
        ViewData["NBRANCHCIA"] = new SelectList(items, nameof(TABLE9031Dto.NBRANCHCIA), "SDESCRIPT");
    }

}
