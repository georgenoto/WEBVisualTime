using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_SETT_HISController : Controller
{
    private readonly ICLAIM_SETT_HISService _service;
    private readonly ITABLE9252Service _TABLE9252Service;
    private readonly ITABLE9251Service _TABLE9251Service;
    private readonly ITABLE9250Service _TABLE9250Service;
    private readonly ITABLE9249Service _TABLE9249Service;
    private readonly ITABLE9266Service _TABLE9266Service;
    private readonly ITABLE9274Service _TABLE9274Service;

    public CLAIM_SETT_HISController(ICLAIM_SETT_HISService service
        , ITABLE9252Service TABLE9252Service
        , ITABLE9251Service TABLE9251Service
        , ITABLE9250Service TABLE9250Service
        , ITABLE9249Service TABLE9249Service
        , ITABLE9266Service TABLE9266Service
        , ITABLE9274Service TABLE9274Service
    )
    {
        _service = service;
        _TABLE9252Service = TABLE9252Service;
        _TABLE9251Service = TABLE9251Service;
        _TABLE9250Service = TABLE9250Service;
        _TABLE9249Service = TABLE9249Service;
        _TABLE9266Service = TABLE9266Service;
        _TABLE9274Service = TABLE9274Service;
    }

    // GET: CLAIM_SETT_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_SETT_HIS/Index.cshtml");

    // GET: CLAIM_SETT_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Details.cshtml", result);
    }

    // GET: CLAIM_SETT_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9266DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Create.cshtml", new CreateCLAIM_SETT_HISDto());
    }

    // POST: CLAIM_SETT_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_SETT_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9266DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Create.cshtml", createDto);
    }

    // GET: CLAIM_SETT_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_SETT_HISDto
        {
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
            NTRANSAC = result.NTRANSAC,
            DOPERDATE = result.DOPERDATE,
            NPAYMENT_METHOD = result.NPAYMENT_METHOD,
            NPAYEE = result.NPAYEE,
            NSETTLEMENT_STAT = result.NSETTLEMENT_STAT,
            NSETTLEMENT_CONC = result.NSETTLEMENT_CONC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SREMARKS = result.SREMARKS,
            NMOVEMENT_TYPE = result.NMOVEMENT_TYPE,
            NNULLCODE = result.NNULLCODE,
            DLEDGERDAT = result.DLEDGERDAT,
            NREQUEST_NU = result.NREQUEST_NU,
        };
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9266DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_SETT_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_SETT_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSETTLEMENT_NUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9251DropdownAsync();
        await PopulateTABLE9250DropdownAsync();
        await PopulateTABLE9249DropdownAsync();
        await PopulateTABLE9266DropdownAsync();
        await PopulateTABLE9274DropdownAsync();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_SETT_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_SETT_HIS/Delete.cshtml", result);
    }

    // POST: CLAIM_SETT_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9252DropdownAsync()
    {
        var items = await _TABLE9252Service.GetAllAsync();
        ViewData["NPAYMENT_METHOD"] = new SelectList(items, nameof(TABLE9252Dto.NPAYMENT_METHOD), "SDESCRIPT");
    }

    private async Task PopulateTABLE9251DropdownAsync()
    {
        var items = await _TABLE9251Service.GetAllAsync();
        ViewData["NPAYEE"] = new SelectList(items, nameof(TABLE9251Dto.NPAYEE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9250DropdownAsync()
    {
        var items = await _TABLE9250Service.GetAllAsync();
        ViewData["NSETTLEMENT_STAT"] = new SelectList(items, nameof(TABLE9250Dto.NSETTLEMENT_STAT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9249DropdownAsync()
    {
        var items = await _TABLE9249Service.GetAllAsync();
        ViewData["NSETTLEMENT_CONC"] = new SelectList(items, nameof(TABLE9249Dto.NSETTLEMENT_CONC), "SDESCRIPT");
    }

    private async Task PopulateTABLE9266DropdownAsync()
    {
        var items = await _TABLE9266Service.GetAllAsync();
        ViewData["NMOVEMENT_TYPE"] = new SelectList(items, nameof(TABLE9266Dto.NMOVEMENT_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9274DropdownAsync()
    {
        var items = await _TABLE9274Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE9274Dto.NNULLCODE), "SDESCRIPT");
    }

}
