using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_BANK_TRANS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_BANK_TRANSController : Controller
{
    private readonly IT_BANK_TRANSService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;

    public T_BANK_TRANSController(IT_BANK_TRANSService service
        , ICOLFORMREFService COLFORMREFService
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
    }

    // GET: T_BANK_TRANS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/T_BANK_TRANS/Index.cshtml");

    // GET: T_BANK_TRANS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_BANK_TRANS/Details.cshtml", result);
    }

    // GET: T_BANK_TRANS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_TRANS/Create.cshtml", new CreateT_BANK_TRANSDto());
    }

    // POST: T_BANK_TRANS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_BANK_TRANSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_TRANS/Create.cshtml", createDto);
    }

    // GET: T_BANK_TRANS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_BANK_TRANSDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NACC_BANK = result.NACC_BANK,
            NACC_TYPE = result.NACC_TYPE,
            SACCO_NUM = result.SACCO_NUM,
            NBANK_CODE = result.NBANK_CODE,
            NBK_AGENCY = result.NBK_AGENCY,
            SCLIENT = result.SCLIENT,
            NMOVEMENT = result.NMOVEMENT,
            DEFFECDATE = result.DEFFECDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NEXCHANGE = result.NEXCHANGE,
            SACTION = result.SACTION,
        };
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_TRANS/Edit.cshtml", updateDto);
    }

    // POST: T_BANK_TRANS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_BANK_TRANSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_BANK_TRANS/Edit.cshtml", updateDto);
    }

    // GET: T_BANK_TRANS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_BANK_TRANS/Delete.cshtml", result);
    }

    // POST: T_BANK_TRANS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

}
