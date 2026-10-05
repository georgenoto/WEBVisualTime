using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PAY_FRACTI;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PAY_FRACTIController : Controller
{
    private readonly IPAY_FRACTIService _service;
    private readonly ITABLE36Service _TABLE36Service;

    public PAY_FRACTIController(IPAY_FRACTIService service
        , ITABLE36Service TABLE36Service
    )
    {
        _service = service;
        _TABLE36Service = TABLE36Service;
    }

    // GET: PAY_FRACTI
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PAY_FRACTI/Index.cshtml", result);
    }

    // GET: PAY_FRACTI/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PAY_FRACTI/Details.cshtml", result);
    }

    // GET: PAY_FRACTI/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/PAY_FRACTI/Create.cshtml", new CreatePAY_FRACTIDto());
    }

    // POST: PAY_FRACTI/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePAY_FRACTIDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/PAY_FRACTI/Create.cshtml", createDto);
    }

    // GET: PAY_FRACTI/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePAY_FRACTIDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPAYFREQ = result.NPAYFREQ,
            NQUOTA = result.NQUOTA,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NRATEPAYF = result.NRATEPAYF,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/PAY_FRACTI/Edit.cshtml", updateDto);
    }

    // POST: PAY_FRACTI/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePAY_FRACTIDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/PAY_FRACTI/Edit.cshtml", updateDto);
    }

    // GET: PAY_FRACTI/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PAY_FRACTI/Delete.cshtml", result);
    }

    // POST: PAY_FRACTI/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NPAYFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

}
