using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DOCUMENTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLORDER_DOCUMENTSController : Controller
{
    private readonly ICLORDER_DOCUMENTSService _service;
    private readonly IDOCUMENTSService _DOCUMENTSService;
    private readonly ITABLE692Service _TABLE692Service;

    public CLORDER_DOCUMENTSController(ICLORDER_DOCUMENTSService service
        , IDOCUMENTSService DOCUMENTSService
        , ITABLE692Service TABLE692Service
    )
    {
        _service = service;
        _DOCUMENTSService = DOCUMENTSService;
        _TABLE692Service = TABLE692Service;
    }

    // GET: CLORDER_DOCUMENTS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLORDER_DOCUMENTS/Index.cshtml");

    // GET: CLORDER_DOCUMENTS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Details.cshtml", result);
    }

    // GET: CLORDER_DOCUMENTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateDOCUMENTSDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Create.cshtml", new CreateCLORDER_DOCUMENTSDto());
    }

    // POST: CLORDER_DOCUMENTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLORDER_DOCUMENTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateDOCUMENTSDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Create.cshtml", createDto);
    }

    // GET: CLORDER_DOCUMENTS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLORDER_DOCUMENTSDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            SCLIENT = result.SCLIENT,
            NID = result.NID,
            NDOC_CODE = result.NDOC_CODE,
            NCONSEC = result.NCONSEC,
            NORDER_NUM = result.NORDER_NUM,
            NCONSEC_ORDERDOC = result.NCONSEC_ORDERDOC,
            NAPPLY = result.NAPPLY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateDOCUMENTSDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Edit.cshtml", updateDto);
    }

    // POST: CLORDER_DOCUMENTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLORDER_DOCUMENTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateDOCUMENTSDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Edit.cshtml", updateDto);
    }

    // GET: CLORDER_DOCUMENTS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_DOCUMENTS/Delete.cshtml", result);
    }

    // POST: CLORDER_DOCUMENTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateDOCUMENTSDropdownAsync()
    {
        var items = await _DOCUMENTSService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(DOCUMENTSDto.NCLAIM), "SDESCRIPT");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(DOCUMENTSDto.NCASE_NUM), "SDESCRIPT");
        ViewData["SCLIENT"] = new SelectList(items, nameof(DOCUMENTSDto.SCLIENT), "SDESCRIPT");
        ViewData["NID"] = new SelectList(items, nameof(DOCUMENTSDto.NID), "SDESCRIPT");
        ViewData["NDOC_CODE"] = new SelectList(items, nameof(DOCUMENTSDto.NDOC_CODE), "SDESCRIPT");
        ViewData["NCONSEC"] = new SelectList(items, nameof(DOCUMENTSDto.NCONSEC), "SDESCRIPT");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

}
