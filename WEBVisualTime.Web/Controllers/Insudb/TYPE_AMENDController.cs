using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPE_AMEND;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5569;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9232;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TYPE_AMENDController : Controller
{
    private readonly ITYPE_AMENDService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE6059Service _TABLE6059Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE5569Service _TABLE5569Service;
    private readonly ITABLE9232Service _TABLE9232Service;

    public TYPE_AMENDController(ITYPE_AMENDService service
        , ITABLE10Service TABLE10Service
        , ITABLE6059Service TABLE6059Service
        , IUSERSService USERSService
        , ITABLE5569Service TABLE5569Service
        , ITABLE9232Service TABLE9232Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _TABLE6059Service = TABLE6059Service;
        _USERSService = USERSService;
        _TABLE5569Service = TABLE5569Service;
        _TABLE9232Service = TABLE9232Service;
    }

    // GET: TYPE_AMEND
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TYPE_AMEND/Index.cshtml");

    // GET: TYPE_AMEND/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPE_AMEND/Details.cshtml", result);
    }

    // GET: TYPE_AMEND/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5569DropdownAsync();
        await PopulateTABLE9232DropdownAsync();
        return View("~/Views/Insudb/TYPE_AMEND/Create.cshtml", new CreateTYPE_AMENDDto());
    }

    // POST: TYPE_AMEND/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTYPE_AMENDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5569DropdownAsync();
        await PopulateTABLE9232DropdownAsync();
        return View("~/Views/Insudb/TYPE_AMEND/Create.cshtml", createDto);
    }

    // GET: TYPE_AMEND/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTYPE_AMENDDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NTYPE_AMEND = result.NTYPE_AMEND,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            SIND_ORDER_SERV = result.SIND_ORDER_SERV,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTYPEISSUE = result.NTYPEISSUE,
            NLEVEL = result.NLEVEL,
            SRETARIF = result.SRETARIF,
            SDESCRIPT = result.SDESCRIPT,
            NTYPE_EV_ENDOR = result.NTYPE_EV_ENDOR,
            SRESOLUTION = result.SRESOLUTION,
            SGOVAPRNAME = result.SGOVAPRNAME,
            DRESDATE = result.DRESDATE,
            SCONDSVS = result.SCONDSVS,
            NTYPEA_AMEND = result.NTYPEA_AMEND,
            SSHOWSTATUS = result.SSHOWSTATUS,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5569DropdownAsync();
        await PopulateTABLE9232DropdownAsync();
        return View("~/Views/Insudb/TYPE_AMEND/Edit.cshtml", updateDto);
    }

    // POST: TYPE_AMEND/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTYPE_AMENDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE5569DropdownAsync();
        await PopulateTABLE9232DropdownAsync();
        return View("~/Views/Insudb/TYPE_AMEND/Edit.cshtml", updateDto);
    }

    // GET: TYPE_AMEND/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TYPE_AMEND/Delete.cshtml", result);
    }

    // POST: TYPE_AMEND/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE6059DropdownAsync()
    {
        var items = await _TABLE6059Service.GetAllAsync();
        ViewData["NTYPE_AMEND"] = new SelectList(items, nameof(TABLE6059Dto.NTYPE_AMEND), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE5569DropdownAsync()
    {
        var items = await _TABLE5569Service.GetAllAsync();
        ViewData["NTYPEISSUE"] = new SelectList(items, nameof(TABLE5569Dto.NTYPEISSUE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9232DropdownAsync()
    {
        var items = await _TABLE9232Service.GetAllAsync();
        ViewData["NTYPE_EV_ENDOR"] = new SelectList(items, nameof(TABLE9232Dto.NTYPE_EV_ENDOR), "SDESCRIPT");
    }

}
