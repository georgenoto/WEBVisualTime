using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CASH_CONCEPTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CASH_CONCEPTSController : Controller
{
    private readonly ICASH_CONCEPTSService _service;
    private readonly ITABLE22Service _TABLE22Service;
    private readonly ICOMPANYService _COMPANYService;

    public CASH_CONCEPTSController(ICASH_CONCEPTSService service
        , ITABLE22Service TABLE22Service
        , ICOMPANYService COMPANYService
    )
    {
        _service = service;
        _TABLE22Service = TABLE22Service;
        _COMPANYService = COMPANYService;
    }

    // GET: CASH_CONCEPTS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CASH_CONCEPTS/Index.cshtml", result);
    }

    // GET: CASH_CONCEPTS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_CONCEPTS/Details.cshtml", result);
    }

    // GET: CASH_CONCEPTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE22DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_CONCEPTS/Create.cshtml", new CreateCASH_CONCEPTSDto());
    }

    // POST: CASH_CONCEPTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCASH_CONCEPTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE22DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_CONCEPTS/Create.cshtml", createDto);
    }

    // GET: CASH_CONCEPTS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCASH_CONCEPTSDto
        {
            NCONCEPT = result.NCONCEPT,
            NCOMPANY = result.NCOMPANY,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE22DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_CONCEPTS/Edit.cshtml", updateDto);
    }

    // POST: CASH_CONCEPTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCASH_CONCEPTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCONCEPT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE22DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        return View("~/Views/Insudb/CASH_CONCEPTS/Edit.cshtml", updateDto);
    }

    // GET: CASH_CONCEPTS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CASH_CONCEPTS/Delete.cshtml", result);
    }

    // POST: CASH_CONCEPTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE22DropdownAsync()
    {
        var items = await _TABLE22Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE22Dto.NCONCEPT), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

}
