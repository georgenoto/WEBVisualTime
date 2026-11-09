using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SELLCHANNEL_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERM_TYP;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SELLCHANNEL_PRODController : Controller
{
    private readonly ISELLCHANNEL_PRODService _service;
    private readonly ITABLE9223Service _TABLE9223Service;
    private readonly IINTERM_TYPService _INTERM_TYPService;
    private readonly ITABLE5532Service _TABLE5532Service;

    public SELLCHANNEL_PRODController(ISELLCHANNEL_PRODService service
        , ITABLE9223Service TABLE9223Service
        , IINTERM_TYPService INTERM_TYPService
        , ITABLE5532Service TABLE5532Service
    )
    {
        _service = service;
        _TABLE9223Service = TABLE9223Service;
        _INTERM_TYPService = INTERM_TYPService;
        _TABLE5532Service = TABLE5532Service;
    }

    // GET: SELLCHANNEL_PROD
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SELLCHANNEL_PROD/Index.cshtml");

    // GET: SELLCHANNEL_PROD/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Details.cshtml", result);
    }

    // GET: SELLCHANNEL_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9223DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Create.cshtml", new CreateSELLCHANNEL_PRODDto());
    }

    // POST: SELLCHANNEL_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSELLCHANNEL_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9223DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Create.cshtml", createDto);
    }

    // GET: SELLCHANNEL_PROD/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSELLCHANNEL_PRODDto
        {
            DEFFECDATE = result.DEFFECDATE,
            NCLASSIFICATION = result.NCLASSIFICATION,
            NINTERTYP = result.NINTERTYP,
            NSELLCHANNEL = result.NSELLCHANNEL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DNULLDATE = result.DNULLDATE,
        };
        await PopulateTABLE9223DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Edit.cshtml", updateDto);
    }

    // POST: SELLCHANNEL_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateSELLCHANNEL_PRODDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9223DropdownAsync();
        await PopulateINTERM_TYPDropdownAsync();
        await PopulateTABLE5532DropdownAsync();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Edit.cshtml", updateDto);
    }

    // GET: SELLCHANNEL_PROD/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SELLCHANNEL_PROD/Delete.cshtml", result);
    }

    // POST: SELLCHANNEL_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9223DropdownAsync()
    {
        var items = await _TABLE9223Service.GetAllAsync();
        ViewData["NCLASSIFICATION"] = new SelectList(items, nameof(TABLE9223Dto.NCLASSIFICATION), "SDESCRIPT");
    }

    private async Task PopulateINTERM_TYPDropdownAsync()
    {
        var items = await _INTERM_TYPService.GetAllAsync();
        ViewData["NINTERTYP"] = new SelectList(items, nameof(INTERM_TYPDto.NINTERTYP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5532DropdownAsync()
    {
        var items = await _TABLE5532Service.GetAllAsync();
        ViewData["NSELLCHANNEL"] = new SelectList(items, nameof(TABLE5532Dto.NSELLCHANNEL), "SDESCRIPT");
    }

}
