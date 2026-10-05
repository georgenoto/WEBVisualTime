using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_TMP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_TMPController : Controller
{
    private readonly ICLIENT_TMPService _service;
    private readonly IPOLICYService _POLICYService;
    private readonly ITABLE12Service _TABLE12Service;

    public CLIENT_TMPController(ICLIENT_TMPService service
        , IPOLICYService POLICYService
        , ITABLE12Service TABLE12Service
    )
    {
        _service = service;
        _POLICYService = POLICYService;
        _TABLE12Service = TABLE12Service;
    }

    // GET: CLIENT_TMP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIENT_TMP/Index.cshtml", result);
    }

    // GET: CLIENT_TMP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_TMP/Details.cshtml", result);
    }

    // GET: CLIENT_TMP/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIENT_TMP/Create.cshtml", new CreateCLIENT_TMPDto());
    }

    // POST: CLIENT_TMP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_TMPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIENT_TMP/Create.cshtml", createDto);
    }

    // GET: CLIENT_TMP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_TMPDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NGROUP = result.NGROUP,
            NROLE = result.NROLE,
            NID = result.NID,
            STYPEAGE = result.STYPEAGE,
            DBIRTHDATE = result.DBIRTHDATE,
            NINITAGE = result.NINITAGE,
            NENDAGE = result.NENDAGE,
            NINSURED = result.NINSURED,
            NRENTAMOUNT = result.NRENTAMOUNT,
            NCURRENCY = result.NCURRENCY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SVIP = result.SVIP,
            SSEXCLIEN = result.SSEXCLIEN,
        };
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIENT_TMP/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_TMP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_TMPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        await PopulateTABLE12DropdownAsync();
        return View("~/Views/Insudb/CLIENT_TMP/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_TMP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_TMP/Delete.cshtml", result);
    }

    // POST: CLIENT_TMP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

}
