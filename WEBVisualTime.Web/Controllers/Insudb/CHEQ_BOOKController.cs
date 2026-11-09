using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQ_BOOK;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.BANK_ACC;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CHEQ_BOOKController : Controller
{
    private readonly ICHEQ_BOOKService _service;
    private readonly IBANK_ACCService _BANK_ACCService;

    public CHEQ_BOOKController(ICHEQ_BOOKService service
        , IBANK_ACCService BANK_ACCService
    )
    {
        _service = service;
        _BANK_ACCService = BANK_ACCService;
    }

    // GET: CHEQ_BOOK
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CHEQ_BOOK/Index.cshtml");

    // GET: CHEQ_BOOK/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQ_BOOK/Details.cshtml", result);
    }

    // GET: CHEQ_BOOK/Create
    public async Task<IActionResult> Create()
    {
        await PopulateBANK_ACCDropdownAsync();
        return View("~/Views/Insudb/CHEQ_BOOK/Create.cshtml", new CreateCHEQ_BOOKDto());
    }

    // POST: CHEQ_BOOK/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCHEQ_BOOKDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateBANK_ACCDropdownAsync();
        return View("~/Views/Insudb/CHEQ_BOOK/Create.cshtml", createDto);
    }

    // GET: CHEQ_BOOK/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCHEQ_BOOKDto
        {
            NACC_BANK = result.NACC_BANK,
            DEFFECDATE = result.DEFFECDATE,
            SCHEQUE_END = result.SCHEQUE_END,
            SCHEQUE_LAS = result.SCHEQUE_LAS,
            SCHEQUE_STA = result.SCHEQUE_STA,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NQ_CHE_DAMA = result.NQ_CHE_DAMA,
            NQ_CHE_NULL = result.NQ_CHE_NULL,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateBANK_ACCDropdownAsync();
        return View("~/Views/Insudb/CHEQ_BOOK/Edit.cshtml", updateDto);
    }

    // POST: CHEQ_BOOK/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCHEQ_BOOKDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateBANK_ACCDropdownAsync();
        return View("~/Views/Insudb/CHEQ_BOOK/Edit.cshtml", updateDto);
    }

    // GET: CHEQ_BOOK/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQ_BOOK/Delete.cshtml", result);
    }

    // POST: CHEQ_BOOK/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateBANK_ACCDropdownAsync()
    {
        var items = await _BANK_ACCService.GetAllAsync();
        ViewData["NACC_BANK"] = new SelectList(items, nameof(BANK_ACCDto.NACC_BANK), "SACC_LEDGER");
    }

}
