using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_ORD_CONCEPTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PAY_ORD_CONCEPTSController : Controller
{
    private readonly IPAY_ORD_CONCEPTSService _service;
    private readonly ITABLE293Service _TABLE293Service;

    public PAY_ORD_CONCEPTSController(IPAY_ORD_CONCEPTSService service
        , ITABLE293Service TABLE293Service
    )
    {
        _service = service;
        _TABLE293Service = TABLE293Service;
    }

    // GET: PAY_ORD_CONCEPTS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PAY_ORD_CONCEPTS/Index.cshtml");

    // GET: PAY_ORD_CONCEPTS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Details.cshtml", result);
    }

    // GET: PAY_ORD_CONCEPTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Create.cshtml", new CreatePAY_ORD_CONCEPTSDto());
    }

    // POST: PAY_ORD_CONCEPTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePAY_ORD_CONCEPTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Create.cshtml", createDto);
    }

    // GET: PAY_ORD_CONCEPTS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePAY_ORD_CONCEPTSDto
        {
            NCOMPANY = result.NCOMPANY,
            NCONCEPT = result.NCONCEPT,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Edit.cshtml", updateDto);
    }

    // POST: PAY_ORD_CONCEPTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePAY_ORD_CONCEPTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMPANY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE293DropdownAsync();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Edit.cshtml", updateDto);
    }

    // GET: PAY_ORD_CONCEPTS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PAY_ORD_CONCEPTS/Delete.cshtml", result);
    }

    // POST: PAY_ORD_CONCEPTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE293DropdownAsync()
    {
        var items = await _TABLE293Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE293Dto.NCONCEPT), "SDESCRIPT");
    }

}
