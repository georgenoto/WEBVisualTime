using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LOCAT;
using WEBVisualTime.Servicios.Insudb.DTOs.MUNICIPALITY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ADDRESSController : Controller
{
    private readonly IADDRESSService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE66Service _TABLE66Service;
    private readonly IPROVINCEService _PROVINCEService;
    private readonly ITAB_LOCATService _TAB_LOCATService;
    private readonly IMUNICIPALITYService _MUNICIPALITYService;

    public ADDRESSController(IADDRESSService service
        , ICLIENTService CLIENTService
        , ITABLE66Service TABLE66Service
        , IPROVINCEService PROVINCEService
        , ITAB_LOCATService TAB_LOCATService
        , IMUNICIPALITYService MUNICIPALITYService
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE66Service = TABLE66Service;
        _PROVINCEService = PROVINCEService;
        _TAB_LOCATService = TAB_LOCATService;
        _MUNICIPALITYService = MUNICIPALITYService;
    }

    // GET: ADDRESS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ADDRESS/Index.cshtml");

    // GET: ADDRESS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ADDRESS/Details.cshtml", result);
    }

    // GET: ADDRESS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        await PopulateMUNICIPALITYDropdownAsync();
        return View("~/Views/Insudb/ADDRESS/Create.cshtml", new CreateADDRESSDto());
    }

    // POST: ADDRESS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateADDRESSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        await PopulateMUNICIPALITYDropdownAsync();
        return View("~/Views/Insudb/ADDRESS/Create.cshtml", createDto);
    }

    // GET: ADDRESS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateADDRESSDto
        {
            NRECOWNER = result.NRECOWNER,
            SKEYADDRESS = result.SKEYADDRESS,
            SRECTYPE = result.SRECTYPE,
            DEFFECDATE = result.DEFFECDATE,
            SSTREET = result.SSTREET,
            SSTREET1 = result.SSTREET1,
            SZONE = result.SZONE,
            SCLIENT = result.SCLIENT,
            SCERTYPE = result.SCERTYPE,
            SE_MAIL = result.SE_MAIL,
            DCOMPDATE = result.DCOMPDATE,
            NLAT_SECOND = result.NLAT_SECOND,
            NLON_SECOND = result.NLON_SECOND,
            NLAT_COORD = result.NLAT_COORD,
            NLON_COORD = result.NLON_COORD,
            NCONTRAT = result.NCONTRAT,
            NLAT_CARDIN = result.NLAT_CARDIN,
            NLAT_MINUTE = result.NLAT_MINUTE,
            NLON_CARDIN = result.NLON_CARDIN,
            NLON_MINUTE = result.NLON_MINUTE,
            NCERTIF = result.NCERTIF,
            NCLAIM = result.NCLAIM,
            NPOLICY = result.NPOLICY,
            NZIP_CODE = result.NZIP_CODE,
            NLAT_GRADE = result.NLAT_GRADE,
            NCOUNTRY = result.NCOUNTRY,
            NLON_GRADE = result.NLON_GRADE,
            NUSERCODE = result.NUSERCODE,
            NBK_AGENCY = result.NBK_AGENCY,
            NBANK_CODE = result.NBANK_CODE,
            NBRANCH = result.NBRANCH,
            NOFFICE = result.NOFFICE,
            NPROVINCE = result.NPROVINCE,
            NPRODUCT = result.NPRODUCT,
            NLOCAL = result.NLOCAL,
            DNULLDATE = result.DNULLDATE,
            SBUILD = result.SBUILD,
            NMUNICIPALITY = result.NMUNICIPALITY,
            NFLOOR = result.NFLOOR,
            SDEPARTMENT = result.SDEPARTMENT,
            SPOPULATION = result.SPOPULATION,
            SINFOR = result.SINFOR,
            SPOBOX = result.SPOBOX,
            SDESCADD = result.SDESCADD,
            NCOD_AGREE = result.NCOD_AGREE,
            SCOSTCENTER = result.SCOSTCENTER,
            NNOTINFORMEMAIL = result.NNOTINFORMEMAIL,
            SLEDGERPROCESS = result.SLEDGERPROCESS,
            NTYPEOFADDRESS = result.NTYPEOFADDRESS,
            SINVALID_IND = result.SINVALID_IND,
            SSEND_MAIL = result.SSEND_MAIL,
            SMAIL = result.SMAIL,
            SBILL = result.SBILL,
            NDELEGATION = result.NDELEGATION,
            NNORMSTATUS = result.NNORMSTATUS,
            DNORMDATE = result.DNORMDATE,
            SZIP_CODE = result.SZIP_CODE,
            SINDSENTEMAIL = result.SINDSENTEMAIL,
            SELEVATION = result.SELEVATION,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        await PopulateMUNICIPALITYDropdownAsync();
        return View("~/Views/Insudb/ADDRESS/Edit.cshtml", updateDto);
    }

    // POST: ADDRESS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateADDRESSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRECOWNER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE66DropdownAsync();
        await PopulatePROVINCEDropdownAsync();
        await PopulateTAB_LOCATDropdownAsync();
        await PopulateMUNICIPALITYDropdownAsync();
        return View("~/Views/Insudb/ADDRESS/Edit.cshtml", updateDto);
    }

    // GET: ADDRESS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ADDRESS/Delete.cshtml", result);
    }

    // POST: ADDRESS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE66DropdownAsync()
    {
        var items = await _TABLE66Service.GetAllAsync();
        ViewData["NCOUNTRY"] = new SelectList(items, nameof(TABLE66Dto.NCOUNTRY), "SDESCRIPT");
    }

    private async Task PopulatePROVINCEDropdownAsync()
    {
        var items = await _PROVINCEService.GetAllAsync();
        ViewData["NPROVINCE"] = new SelectList(items, nameof(PROVINCEDto.NPROVINCE), "SDESCRIPT");
    }

    private async Task PopulateTAB_LOCATDropdownAsync()
    {
        var items = await _TAB_LOCATService.GetAllAsync();
        ViewData["NLOCAL"] = new SelectList(items, nameof(TAB_LOCATDto.NLOCAL), "SDESCRIPT");
    }

    private async Task PopulateMUNICIPALITYDropdownAsync()
    {
        var items = await _MUNICIPALITYService.GetAllAsync();
        ViewData["NMUNICIPALITY"] = new SelectList(items, nameof(MUNICIPALITYDto.NMUNICIPALITY), "SDESCRIPT");
    }

}
