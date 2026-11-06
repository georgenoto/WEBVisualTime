using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_MODUL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_MODULController : Controller
{
    private readonly ITAB_MODULService _service;
    private readonly ITABLE9214Service _TABLE9214Service;
    private readonly ITABLE9215Service _TABLE9215Service;

    public TAB_MODULController(ITAB_MODULService service
        , ITABLE9214Service TABLE9214Service
        , ITABLE9215Service TABLE9215Service
    )
    {
        _service = service;
        _TABLE9214Service = TABLE9214Service;
        _TABLE9215Service = TABLE9215Service;
    }

    // GET: TAB_MODUL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_MODUL/Index.cshtml");

    // GET: TAB_MODUL/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MODUL/Details.cshtml", result);
    }

    // GET: TAB_MODUL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/TAB_MODUL/Create.cshtml", new CreateTAB_MODULDto());
    }

    // POST: TAB_MODUL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_MODULDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/TAB_MODUL/Create.cshtml", createDto);
    }

    // GET: TAB_MODUL/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_MODULDto
        {
            NBRANCH = result.NBRANCH,
            NMODULEC = result.NMODULEC,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            SCHANALLO = result.SCHANALLO,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SDESCRIPT = result.SDESCRIPT,
            DNULLDATE = result.DNULLDATE,
            SREQUIRE = result.SREQUIRE,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
            SCONDSVS = result.SCONDSVS,
            SROUTINE = result.SROUTINE,
            NPREMIRAT = result.NPREMIRAT,
            NCHPRELEV = result.NCHPRELEV,
            NRATEPREADD = result.NRATEPREADD,
            NRATEPRESUB = result.NRATEPRESUB,
            SCHANGETYP = result.SCHANGETYP,
            STYP_RAT = result.STYP_RAT,
            SVIGEN = result.SVIGEN,
            SDEPEND = result.SDEPEND,
            SCLAIMMANDATORYFIELDS = result.SCLAIMMANDATORYFIELDS,
            NGEOGRAPHAREA = result.NGEOGRAPHAREA,
            NATTENSYSTEM = result.NATTENSYSTEM,
        };
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/TAB_MODUL/Edit.cshtml", updateDto);
    }

    // POST: TAB_MODUL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_MODULDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        return View("~/Views/Insudb/TAB_MODUL/Edit.cshtml", updateDto);
    }

    // GET: TAB_MODUL/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_MODUL/Delete.cshtml", result);
    }

    // POST: TAB_MODUL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9214DropdownAsync()
    {
        var items = await _TABLE9214Service.GetAllAsync();
        ViewData["NGEOGRAPHAREA"] = new SelectList(items, nameof(TABLE9214Dto.NGEOGRAPHAREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE9215DropdownAsync()
    {
        var items = await _TABLE9215Service.GetAllAsync();
        ViewData["NATTENSYSTEM"] = new SelectList(items, nameof(TABLE9215Dto.NATTENSYSTEM), "SDESCRIPT");
    }

}
