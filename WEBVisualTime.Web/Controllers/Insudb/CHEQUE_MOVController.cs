using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CHEQUE_MOV;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5577;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CHEQUE_MOVController : Controller
{
    private readonly ICHEQUE_MOVService _service;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE5577Service _TABLE5577Service;

    public CHEQUE_MOVController(ICHEQUE_MOVService service
        , ICOMPANYService COMPANYService
        , ITABLE7Service TABLE7Service
        , ITABLE5577Service TABLE5577Service
    )
    {
        _service = service;
        _COMPANYService = COMPANYService;
        _TABLE7Service = TABLE7Service;
        _TABLE5577Service = TABLE5577Service;
    }

    // GET: CHEQUE_MOV
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CHEQUE_MOV/Index.cshtml");

    // GET: CHEQUE_MOV/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQUE_MOV/Details.cshtml", result);
    }

    // GET: CHEQUE_MOV/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE5577DropdownAsync();
        return View("~/Views/Insudb/CHEQUE_MOV/Create.cshtml", new CreateCHEQUE_MOVDto());
    }

    // POST: CHEQUE_MOV/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCHEQUE_MOVDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE5577DropdownAsync();
        return View("~/Views/Insudb/CHEQUE_MOV/Create.cshtml", createDto);
    }

    // GET: CHEQUE_MOV/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCHEQUE_MOVDto
        {
            NCOMPANY = result.NCOMPANY,
            NBANK_CODE = result.NBANK_CODE,
            SCHEQUENU = result.SCHEQUENU,
            DEFFECDATE = result.DEFFECDATE,
            NCHEOPERTYP = result.NCHEOPERTYP,
            NCHEOPER_REASON = result.NCHEOPER_REASON,
            NID = result.NID,
            NBANK_INTER = result.NBANK_INTER,
            SCHEQUEINTER = result.SCHEQUEINTER,
            DNEW_DATE = result.DNEW_DATE,
            SDEPNUMBER = result.SDEPNUMBER,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NFIN_INT = result.NFIN_INT,
            NNOTENUM = result.NNOTENUM,
        };
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE5577DropdownAsync();
        return View("~/Views/Insudb/CHEQUE_MOV/Edit.cshtml", updateDto);
    }

    // POST: CHEQUE_MOV/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCHEQUE_MOVDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE5577DropdownAsync();
        return View("~/Views/Insudb/CHEQUE_MOV/Edit.cshtml", updateDto);
    }

    // GET: CHEQUE_MOV/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHEQUE_MOV/Delete.cshtml", result);
    }

    // POST: CHEQUE_MOV/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
        ViewData["NBANK_INTER"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5577DropdownAsync()
    {
        var items = await _TABLE5577Service.GetAllAsync();
        ViewData["NCHEOPER_REASON"] = new SelectList(items, nameof(TABLE5577Dto.NCHEOPER_REASON), "SDESCRIPT");
    }

}
