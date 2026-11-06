using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9276;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9275;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMMPAYREQ_HISController : Controller
{
    private readonly ICOMMPAYREQ_HISService _service;
    private readonly ICOMMPAYMENTREQUESTSService _COMMPAYMENTREQUESTSService;
    private readonly ITABLE9276Service _TABLE9276Service;
    private readonly ITABLE9275Service _TABLE9275Service;

    public COMMPAYREQ_HISController(ICOMMPAYREQ_HISService service
        , ICOMMPAYMENTREQUESTSService COMMPAYMENTREQUESTSService
        , ITABLE9276Service TABLE9276Service
        , ITABLE9275Service TABLE9275Service
    )
    {
        _service = service;
        _COMMPAYMENTREQUESTSService = COMMPAYMENTREQUESTSService;
        _TABLE9276Service = TABLE9276Service;
        _TABLE9275Service = TABLE9275Service;
    }

    // GET: COMMPAYREQ_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/COMMPAYREQ_HIS/Index.cshtml");

    // GET: COMMPAYREQ_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Details.cshtml", result);
    }

    // GET: COMMPAYREQ_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateTABLE9276DropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Create.cshtml", new CreateCOMMPAYREQ_HISDto());
    }

    // POST: COMMPAYREQ_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMMPAYREQ_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateTABLE9276DropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Create.cshtml", createDto);
    }

    // GET: COMMPAYREQ_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMMPAYREQ_HISDto
        {
            NID_COMMPAYREQ = result.NID_COMMPAYREQ,
            NMOVEMENT = result.NMOVEMENT,
            DMOVEMENT_DATE = result.DMOVEMENT_DATE,
            NMOVEMENT_TYPE = result.NMOVEMENT_TYPE,
            NSTATUS = result.NSTATUS,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SCLARIFICATIONREQUESTED = result.SCLARIFICATIONREQUESTED,
            SJUSTIFICATIONREQUESTED = result.SJUSTIFICATIONREQUESTED,
            NUSERCODE_RESPONSIBLE = result.NUSERCODE_RESPONSIBLE,
            DRESULTDATE = result.DRESULTDATE,
            SIND_RESULT = result.SIND_RESULT,
            SIND_ASSUMEIVA = result.SIND_ASSUMEIVA,
            NCURRENCY_PAY = result.NCURRENCY_PAY,
            NAMOUNT_PAY = result.NAMOUNT_PAY,
            NNULLCODE = result.NNULLCODE,
        };
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateTABLE9276DropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Edit.cshtml", updateDto);
    }

    // POST: COMMPAYREQ_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMMPAYREQ_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID_COMMPAYREQ, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOMMPAYMENTREQUESTSDropdownAsync();
        await PopulateTABLE9276DropdownAsync();
        await PopulateTABLE9275DropdownAsync();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Edit.cshtml", updateDto);
    }

    // GET: COMMPAYREQ_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMMPAYREQ_HIS/Delete.cshtml", result);
    }

    // POST: COMMPAYREQ_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOMMPAYMENTREQUESTSDropdownAsync()
    {
        var items = await _COMMPAYMENTREQUESTSService.GetAllAsync();
        ViewData["NID_COMMPAYREQ"] = new SelectList(items, nameof(COMMPAYMENTREQUESTSDto.NID_COMMPAYREQ), "SCLIENAME_HOLDER");
    }

    private async Task PopulateTABLE9276DropdownAsync()
    {
        var items = await _TABLE9276Service.GetAllAsync();
        ViewData["NMOVEMENT_TYPE"] = new SelectList(items, nameof(TABLE9276Dto.NMOVEMENT_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9275DropdownAsync()
    {
        var items = await _TABLE9275Service.GetAllAsync();
        ViewData["NSTATUS"] = new SelectList(items, nameof(TABLE9275Dto.NSTATUS), "SDESCRIPT");
    }

}
