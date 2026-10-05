using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5522;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE146;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE149;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE222;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE147;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5006;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5503;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5505;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5518;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE85;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9213;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENTController : Controller
{
    private readonly ICLIENTService _service;
    private readonly ITABLE5522Service _TABLE5522Service;
    private readonly ITABLE14Service _TABLE14Service;
    private readonly ITABLE146Service _TABLE146Service;
    private readonly ITABLE149Service _TABLE149Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE18Service _TABLE18Service;
    private readonly ITABLE222Service _TABLE222Service;
    private readonly ITABLE147Service _TABLE147Service;
    private readonly ITABLE5006Service _TABLE5006Service;
    private readonly ITABLE5503Service _TABLE5503Service;
    private readonly ITABLE5504Service _TABLE5504Service;
    private readonly ITABLE5505Service _TABLE5505Service;
    private readonly ITABLE5521Service _TABLE5521Service;
    private readonly ITABLE5523Service _TABLE5523Service;
    private readonly ITABLE5524Service _TABLE5524Service;
    private readonly ITABLE5549Service _TABLE5549Service;
    private readonly ITABLE5550Service _TABLE5550Service;
    private readonly ITABLE5518Service _TABLE5518Service;
    private readonly ITABLE85Service _TABLE85Service;
    private readonly ITABLE66Service _TABLE66Service;
    private readonly ITABLE9213Service _TABLE9213Service;

    public CLIENTController(ICLIENTService service
        , ITABLE5522Service TABLE5522Service
        , ITABLE14Service TABLE14Service
        , ITABLE146Service TABLE146Service
        , ITABLE149Service TABLE149Service
        , ITABLE9Service TABLE9Service
        , ITABLE18Service TABLE18Service
        , ITABLE222Service TABLE222Service
        , ITABLE147Service TABLE147Service
        , ITABLE5006Service TABLE5006Service
        , ITABLE5503Service TABLE5503Service
        , ITABLE5504Service TABLE5504Service
        , ITABLE5505Service TABLE5505Service
        , ITABLE5521Service TABLE5521Service
        , ITABLE5523Service TABLE5523Service
        , ITABLE5524Service TABLE5524Service
        , ITABLE5549Service TABLE5549Service
        , ITABLE5550Service TABLE5550Service
        , ITABLE5518Service TABLE5518Service
        , ITABLE85Service TABLE85Service
        , ITABLE66Service TABLE66Service
        , ITABLE9213Service TABLE9213Service
    )
    {
        _service = service;
        _TABLE5522Service = TABLE5522Service;
        _TABLE14Service = TABLE14Service;
        _TABLE146Service = TABLE146Service;
        _TABLE149Service = TABLE149Service;
        _TABLE9Service = TABLE9Service;
        _TABLE18Service = TABLE18Service;
        _TABLE222Service = TABLE222Service;
        _TABLE147Service = TABLE147Service;
        _TABLE5006Service = TABLE5006Service;
        _TABLE5503Service = TABLE5503Service;
        _TABLE5504Service = TABLE5504Service;
        _TABLE5505Service = TABLE5505Service;
        _TABLE5521Service = TABLE5521Service;
        _TABLE5523Service = TABLE5523Service;
        _TABLE5524Service = TABLE5524Service;
        _TABLE5549Service = TABLE5549Service;
        _TABLE5550Service = TABLE5550Service;
        _TABLE5518Service = TABLE5518Service;
        _TABLE85Service = TABLE85Service;
        _TABLE66Service = TABLE66Service;
        _TABLE9213Service = TABLE9213Service;
    }

    // GET: CLIENT
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIENT/Index.cshtml", result);
    }

    // GET: CLIENT/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT/Details.cshtml", result);
    }

    // GET: CLIENT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5522DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE146DropdownAsync();
        await PopulateTABLE149DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE222DropdownAsync();
        await PopulateTABLE147DropdownAsync();
        await PopulateTABLE5006DropdownAsync();
        await PopulateTABLE5503DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5505DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5518DropdownAsync();
        await PopulateTABLE85DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9213DropdownAsync();
        return View("~/Views/Insudb/CLIENT/Create.cshtml", new CreateCLIENTDto());
    }

    // POST: CLIENT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5522DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE146DropdownAsync();
        await PopulateTABLE149DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE222DropdownAsync();
        await PopulateTABLE147DropdownAsync();
        await PopulateTABLE5006DropdownAsync();
        await PopulateTABLE5503DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5505DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5518DropdownAsync();
        await PopulateTABLE85DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9213DropdownAsync();
        return View("~/Views/Insudb/CLIENT/Create.cshtml", createDto);
    }

    // GET: CLIENT/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENTDto
        {
            SCLIENT = result.SCLIENT,
            SACCOUNT_IN = result.SACCOUNT_IN,
            NINVOICING = result.NINVOICING,
            NCIVILSTA = result.NCIVILSTA,
            DAPROBDATE = result.DAPROBDATE,
            DBIRTHDAT = result.DBIRTHDAT,
            SBLOCKADE = result.SBLOCKADE,
            NCLASS = result.NCLASS,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            DCOMPDATE = result.DCOMPDATE,
            DDEATHDAT = result.DDEATHDAT,
            DDRIVERDAT = result.DDRIVERDAT,
            NHEIGHT = result.NHEIGHT,
            DINPDATE = result.DINPDATE,
            NHOUSE_TYPE = result.NHOUSE_TYPE,
            SLICENSE = result.SLICENSE,
            NNOTENUM = result.NNOTENUM,
            NOFFICE = result.NOFFICE,
            NQ_CARS = result.NQ_CARS,
            NQ_CHILD = result.NQ_CHILD,
            NRATE = result.NRATE,
            STAX_CODE = result.STAX_CODE,
            SSEXCLIEN = result.SSEXCLIEN,
            SSMOKING = result.SSMOKING,
            SCUIT = result.SCUIT,
            NTITLE = result.NTITLE,
            NUSERCODE = result.NUSERCODE,
            NWEIGHT = result.NWEIGHT,
            SAUTO_CHAR = result.SAUTO_CHAR,
            SCREDIT_CARD = result.SCREDIT_CARD,
            NECONOMIC_L = result.NECONOMIC_L,
            NEMPL_QUA = result.NEMPL_QUA,
            NIMAGENUM = result.NIMAGENUM,
            NPERSON_TYP = result.NPERSON_TYP,
            NAREA = result.NAREA,
            DDRIVEXPDAT = result.DDRIVEXPDAT,
            NTYPDRIVER = result.NTYPDRIVER,
            NDISABILITY = result.NDISABILITY,
            NLIMITDRIV = result.NLIMITDRIV,
            SLEGALNAME = result.SLEGALNAME,
            SLASTNAME2 = result.SLASTNAME2,
            NHEALTH_ORG = result.NHEALTH_ORG,
            NAFP = result.NAFP,
            DWEDD = result.DWEDD,
            SBILL_IND = result.SBILL_IND,
            NINCAPACITY = result.NINCAPACITY,
            DINCAPACITY = result.DINCAPACITY,
            NINCAP_COD = result.NINCAP_COD,
            NNATIONALITY = result.NNATIONALITY,
            SDIGIT = result.SDIGIT,
            DRETIREMENT = result.DRETIREMENT,
            DINDEPENDANT = result.DINDEPENDANT,
            DDEPENDANT = result.DDEPENDANT,
            NMAILINGPREF = result.NMAILINGPREF,
            NLANGUAGE = result.NLANGUAGE,
            NSPECIALITY = result.NSPECIALITY,
            NCOMP_TYPE = result.NCOMP_TYPE,
            SCLIENAME = result.SCLIENAME,
            SLEDGERPROCESS = result.SLEDGERPROCESS,
            SCOMPLCOD = result.SCOMPLCOD,
            NTYPECOMPANY = result.NTYPECOMPANY,
            SFATCA = result.SFATCA,
            SCLIENTPEP = result.SCLIENTPEP,
            SUSPERSON = result.SUSPERSON,
            NADDRESSID = result.NADDRESSID,
            NPHONEID = result.NPHONEID,
            SCRS = result.SCRS,
            SMARRIEDSURNAME = result.SMARRIEDSURNAME,
            SSPOUSENAME = result.SSPOUSENAME,
            SOTHERTITLE = result.SOTHERTITLE,
            SOTHERSPECIALITY = result.SOTHERSPECIALITY,
            NRESIDENCECOUNTRY = result.NRESIDENCECOUNTRY,
            NBIRTHCOUNTRY = result.NBIRTHCOUNTRY,
            NPOSITION_CLI = result.NPOSITION_CLI,
            NCLASEMPRESALEGAL = result.NCLASEMPRESALEGAL,
        };
        await PopulateTABLE5522DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE146DropdownAsync();
        await PopulateTABLE149DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE222DropdownAsync();
        await PopulateTABLE147DropdownAsync();
        await PopulateTABLE5006DropdownAsync();
        await PopulateTABLE5503DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5505DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5518DropdownAsync();
        await PopulateTABLE85DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9213DropdownAsync();
        return View("~/Views/Insudb/CLIENT/Edit.cshtml", updateDto);
    }

    // POST: CLIENT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCLIENT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5522DropdownAsync();
        await PopulateTABLE14DropdownAsync();
        await PopulateTABLE146DropdownAsync();
        await PopulateTABLE149DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE18DropdownAsync();
        await PopulateTABLE222DropdownAsync();
        await PopulateTABLE147DropdownAsync();
        await PopulateTABLE5006DropdownAsync();
        await PopulateTABLE5503DropdownAsync();
        await PopulateTABLE5504DropdownAsync();
        await PopulateTABLE5505DropdownAsync();
        await PopulateTABLE5521DropdownAsync();
        await PopulateTABLE5523DropdownAsync();
        await PopulateTABLE5524DropdownAsync();
        await PopulateTABLE5549DropdownAsync();
        await PopulateTABLE5550DropdownAsync();
        await PopulateTABLE5518DropdownAsync();
        await PopulateTABLE85DropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulateTABLE9213DropdownAsync();
        return View("~/Views/Insudb/CLIENT/Edit.cshtml", updateDto);
    }

    // GET: CLIENT/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT/Delete.cshtml", result);
    }

    // POST: CLIENT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: CLIENT/GetByNCIVILSTA?NCIVILSTA=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNCIVILSTA(int NCIVILSTA)
    {
        var items = await _service.FindAsync(p => p.NCIVILSTA == NCIVILSTA);
        return Json(items.Select(i => new { value = i.SCLIENT, text = i.SACCOUNT_IN }));
    }

    // GET: CLIENT/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.SCLIENT, text = i.SACCOUNT_IN }));
    }

    // GET: CLIENT/GetByNRESIDENCECOUNTRY?NRESIDENCECOUNTRY=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNRESIDENCECOUNTRY(int NRESIDENCECOUNTRY)
    {
        var items = await _service.FindAsync(p => p.NRESIDENCECOUNTRY == NRESIDENCECOUNTRY);
        return Json(items.Select(i => new { value = i.SCLIENT, text = i.SACCOUNT_IN }));
    }

    private async Task PopulateTABLE5522DropdownAsync()
    {
        var items = await _TABLE5522Service.GetAllAsync();
        ViewData["NINVOICING"] = new SelectList(items, nameof(TABLE5522Dto.NINVOICING), "SDESCRIPT");
    }

    private async Task PopulateTABLE14DropdownAsync()
    {
        var items = await _TABLE14Service.GetAllAsync();
        ViewData["NCIVILSTA"] = new SelectList(items, nameof(TABLE14Dto.NCIVILSTA), "SDESCRIPT");
    }

    private async Task PopulateTABLE146DropdownAsync()
    {
        var items = await _TABLE146Service.GetAllAsync();
        ViewData["NCLASS"] = new SelectList(items, nameof(TABLE146Dto.NCLASS), "SDESCRIPT");
    }

    private async Task PopulateTABLE149DropdownAsync()
    {
        var items = await _TABLE149Service.GetAllAsync();
        ViewData["NHOUSE_TYPE"] = new SelectList(items, nameof(TABLE149Dto.NHOUSE_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE18DropdownAsync()
    {
        var items = await _TABLE18Service.GetAllAsync();
        ViewData["SSEXCLIEN"] = new SelectList(items, nameof(TABLE18Dto.SSEXCLIEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE222DropdownAsync()
    {
        var items = await _TABLE222Service.GetAllAsync();
        ViewData["NTITLE"] = new SelectList(items, nameof(TABLE222Dto.NTITLE), "SDESCRIPT");
    }

    private async Task PopulateTABLE147DropdownAsync()
    {
        var items = await _TABLE147Service.GetAllAsync();
        ViewData["NECONOMIC_L"] = new SelectList(items, nameof(TABLE147Dto.NECONOMIC_L), "SDESCRIPT");
    }

    private async Task PopulateTABLE5006DropdownAsync()
    {
        var items = await _TABLE5006Service.GetAllAsync();
        ViewData["NPERSON_TYP"] = new SelectList(items, nameof(TABLE5006Dto.NPERSON_TYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5503DropdownAsync()
    {
        var items = await _TABLE5503Service.GetAllAsync();
        ViewData["NAREA"] = new SelectList(items, nameof(TABLE5503Dto.NAREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE5504DropdownAsync()
    {
        var items = await _TABLE5504Service.GetAllAsync();
        ViewData["NTYPDRIVER"] = new SelectList(items, nameof(TABLE5504Dto.NTYPDRIVER), "SDESCRIPT");
    }

    private async Task PopulateTABLE5505DropdownAsync()
    {
        var items = await _TABLE5505Service.GetAllAsync();
        ViewData["NDISABILITY"] = new SelectList(items, nameof(TABLE5505Dto.NDISABILITY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5521DropdownAsync()
    {
        var items = await _TABLE5521Service.GetAllAsync();
        ViewData["NLIMITDRIV"] = new SelectList(items, nameof(TABLE5521Dto.NLIMITDRIV), "SDESCRIPT");
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

    private async Task PopulateTABLE5518DropdownAsync()
    {
        var items = await _TABLE5518Service.GetAllAsync();
        ViewData["NNATIONALITY"] = new SelectList(items, nameof(TABLE5518Dto.NNATIONALITY), "SDESCRIPT");
    }

    private async Task PopulateTABLE85DropdownAsync()
    {
        var items = await _TABLE85Service.GetAllAsync();
        ViewData["NLANGUAGE"] = new SelectList(items, nameof(TABLE85Dto.NLANGUAGE), "SDESCRIPT");
    }

    private async Task PopulateTABLE66DropdownAsync()
    {
        var items = await _TABLE66Service.GetAllAsync();
        ViewData["NRESIDENCECOUNTRY"] = new SelectList(items, nameof(TABLE66Dto.NCOUNTRY), "SDESCRIPT");
        ViewData["NBIRTHCOUNTRY"] = new SelectList(items, nameof(TABLE66Dto.NCOUNTRY), "SDESCRIPT");
    }

    private async Task PopulateTABLE9213DropdownAsync()
    {
        var items = await _TABLE9213Service.GetAllAsync();
        ViewData["NPOSITION_CLI"] = new SelectList(items, nameof(TABLE9213Dto.NPOSITION_CLI), "SDESCRIPT");
    }

}
