using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_HISController : Controller
{
    private readonly ICLIENT_HISService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE18Service _TABLE18Service;
    private readonly ITABLE14Service _TABLE14Service;
    private readonly ITABLE5523Service _TABLE5523Service;
    private readonly ITABLE5524Service _TABLE5524Service;
    private readonly ITABLE5549Service _TABLE5549Service;
    private readonly ITABLE5550Service _TABLE5550Service;
    private readonly ITABLE5504Service _TABLE5504Service;
    private readonly ITABLE5521Service _TABLE5521Service;

    public CLIENT_HISController(ICLIENT_HISService service
        , ICLIENTService CLIENTService
        , ITABLE18Service TABLE18Service
        , ITABLE14Service TABLE14Service
        , ITABLE5523Service TABLE5523Service
        , ITABLE5524Service TABLE5524Service
        , ITABLE5549Service TABLE5549Service
        , ITABLE5550Service TABLE5550Service
        , ITABLE5504Service TABLE5504Service
        , ITABLE5521Service TABLE5521Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE18Service = TABLE18Service;
        _TABLE14Service = TABLE14Service;
        _TABLE5523Service = TABLE5523Service;
        _TABLE5524Service = TABLE5524Service;
        _TABLE5549Service = TABLE5549Service;
        _TABLE5550Service = TABLE5550Service;
        _TABLE5504Service = TABLE5504Service;
        _TABLE5521Service = TABLE5521Service;
    }

    // GET: CLIENT_HIS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIENT_HIS/Index.cshtml", result);
    }

    // GET: CLIENT_HIS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_HIS/Details.cshtml", result);
    }

    // GET: CLIENT_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        return View("~/Views/Insudb/CLIENT_HIS/Create.cshtml", new CreateCLIENT_HISDto());
    }

    // POST: CLIENT_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        return View("~/Views/Insudb/CLIENT_HIS/Create.cshtml", createDto);
    }

    // GET: CLIENT_HIS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_HISDto
        {
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            SCLIENAME = result.SCLIENAME,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            SLASTNAME2 = result.SLASTNAME2,
            SSEXCLIEN = result.SSEXCLIEN,
            NCIVILSTA = result.NCIVILSTA,
            SBLOCKADE = result.SBLOCKADE,
            NHEALTH_ORG = result.NHEALTH_ORG,
            NAFP = result.NAFP,
            DWEDD = result.DWEDD,
            NINCAPACITY = result.NINCAPACITY,
            NINCAP_COD = result.NINCAP_COD,
            DDRIVERDAT = result.DDRIVERDAT,
            DDRIVEXPDAT = result.DDRIVEXPDAT,
            NTYPDRIVER = result.NTYPDRIVER,
            NLIMITDRIV = result.NLIMITDRIV,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SLEGALNAME = result.SLEGALNAME,
            DINCAPACITY = result.DINCAPACITY,
            NID = result.NID,
            DDEPENDANT = result.DDEPENDANT,
            DINDEPENDANT = result.DINDEPENDANT,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        return View("~/Views/Insudb/CLIENT_HIS/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        return View("~/Views/Insudb/CLIENT_HIS/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_HIS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_HIS/Delete.cshtml", result);
    }

    // POST: CLIENT_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE18DropdownAsync()
    {
        var items = await _TABLE18Service.GetAllAsync();
        ViewData["SSEXCLIEN"] = new SelectList(items, nameof(TABLE18Dto.SSEXCLIEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE14DropdownAsync()
    {
        var items = await _TABLE14Service.GetAllAsync();
        ViewData["NCIVILSTA"] = new SelectList(items, nameof(TABLE14Dto.NCIVILSTA), "SDESCRIPT");
    }

    private async Task PopulateTABLE5523DropdownAsync()
    {
        var items = await _TABLE5523Service.GetAllAsync();
        ViewData["NHEALTH_ORG"] = new SelectList(items, nameof(TABLE5523Dto.NHEALTH_ORG), "SDESCRIPT");
    }

    private async Task PopulateTABLE5524DropdownAsync()
    {
        var items = await _TABLE5524Service.GetAllAsync();
        ViewData["NAFP"] = new SelectList(items, nameof(TABLE5524Dto.NAFP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5549DropdownAsync()
    {
        var items = await _TABLE5549Service.GetAllAsync();
        ViewData["NINCAPACITY"] = new SelectList(items, nameof(TABLE5549Dto.NINCAPACITY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5550DropdownAsync()
    {
        var items = await _TABLE5550Service.GetAllAsync();
        ViewData["NINCAP_COD"] = new SelectList(items, nameof(TABLE5550Dto.NINCAP_COD), "SDESCRIPT");
    }

    private async Task PopulateTABLE5504DropdownAsync()
    {
        var items = await _TABLE5504Service.GetAllAsync();
        ViewData["NTYPDRIVER"] = new SelectList(items, nameof(TABLE5504Dto.NTYPDRIVER), "SDESCRIPT");
    }

    private async Task PopulateTABLE5521DropdownAsync()
    {
        var items = await _TABLE5521Service.GetAllAsync();
        ViewData["NLIMITDRIV"] = new SelectList(items, nameof(TABLE5521Dto.NLIMITDRIV), "SDESCRIPT");
    }

}
