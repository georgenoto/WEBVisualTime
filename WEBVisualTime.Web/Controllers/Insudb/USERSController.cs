using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE105;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE84;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class USERSController : Controller
{
    private readonly IUSERSService _service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ISECUR_SCHEService _SECUR_SCHEService;
    private readonly ITABLE105Service _TABLE105Service;
    private readonly ITABLE84Service _TABLE84Service;

    public USERSController(IUSERSService service
        , ITABLE9Service TABLE9Service
        , ICLIENTService CLIENTService
        , ISECUR_SCHEService SECUR_SCHEService
        , ITABLE105Service TABLE105Service
        , ITABLE84Service TABLE84Service
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
        _CLIENTService = CLIENTService;
        _SECUR_SCHEService = SECUR_SCHEService;
        _TABLE105Service = TABLE105Service;
        _TABLE84Service = TABLE84Service;
    }

    // GET: USERS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/USERS/Index.cshtml", result);
    }

    // GET: USERS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USERS/Details.cshtml", result);
    }

    // GET: USERS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE105DropdownAsync();
        await PopulateTABLE84DropdownAsync();
        return View("~/Views/Insudb/USERS/Create.cshtml", new CreateUSERSDto());
    }

    // POST: USERS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateUSERSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE105DropdownAsync();
        await PopulateTABLE84DropdownAsync();
        return View("~/Views/Insudb/USERS/Create.cshtml", createDto);
    }

    // GET: USERS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateUSERSDto
        {
            NUSERCODE = result.NUSERCODE,
            SACCESSWO = result.SACCESSWO,
            NOFFICE = result.NOFFICE,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            SINITIALS = result.SINITIALS,
            SSCHE_CODE = result.SSCHE_CODE,
            SSTATREGT = result.SSTATREGT,
            STYPE = result.STYPE,
            NDEPARTME = result.NDEPARTME,
            SMENU = result.SMENU,
            SCHNEXTLOGON = result.SCHNEXTLOGON,
            SNEVERCHANGE = result.SNEVERCHANGE,
            SNEVEREXPIRES = result.SNEVEREXPIRES,
            SLOCKEDOUT = result.SLOCKEDOUT,
            DFROMDATE = result.DFROMDATE,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            NFAILED_LOGON_ATTEMPTS = result.NFAILED_LOGON_ATTEMPTS,
            DPASSWORD_EXPIRES = result.DPASSWORD_EXPIRES,
        };
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE105DropdownAsync();
        await PopulateTABLE84DropdownAsync();
        return View("~/Views/Insudb/USERS/Edit.cshtml", updateDto);
    }

    // POST: USERS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateUSERSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NUSERCODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateSECUR_SCHEDropdownAsync();
        await PopulateTABLE105DropdownAsync();
        await PopulateTABLE84DropdownAsync();
        return View("~/Views/Insudb/USERS/Edit.cshtml", updateDto);
    }

    // GET: USERS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USERS/Delete.cshtml", result);
    }

    // POST: USERS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: USERS/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NUSERCODE, text = i.SACCESSWO }));
    }

    // GET: USERS/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NUSERCODE, text = i.SACCESSWO }));
    }

    // GET: USERS/GetBySSCHE_CODE?SSCHE_CODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySSCHE_CODE(string SSCHE_CODE)
    {
        var items = await _service.FindAsync(p => p.SSCHE_CODE == SSCHE_CODE);
        return Json(items.Select(i => new { value = i.NUSERCODE, text = i.SACCESSWO }));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateSECUR_SCHEDropdownAsync()
    {
        var items = await _SECUR_SCHEService.GetAllAsync();
        ViewData["SSCHE_CODE"] = new SelectList(items, nameof(SECUR_SCHEDto.SSCHE_CODE), "SLONGDESC");
    }

    private async Task PopulateTABLE105DropdownAsync()
    {
        var items = await _TABLE105Service.GetAllAsync();
        ViewData["STYPE"] = new SelectList(items, nameof(TABLE105Dto.STYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE84DropdownAsync()
    {
        var items = await _TABLE84Service.GetAllAsync();
        ViewData["NDEPARTME"] = new SelectList(items, nameof(TABLE84Dto.NDEPARTME), "SDESCRIPT");
    }

}
