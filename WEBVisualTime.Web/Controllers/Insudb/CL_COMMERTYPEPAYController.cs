using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COMMERTYPEPAY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CL_COMMERTYPEPAYController : Controller
{
    private readonly ICL_COMMERTYPEPAYService _service;

    public CL_COMMERTYPEPAYController(ICL_COMMERTYPEPAYService service
    )
    {
        _service = service;
    }

    // GET: CL_COMMERTYPEPAY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Index.cshtml", result);
    }

    // GET: CL_COMMERTYPEPAY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Details.cshtml", result);
    }

    // GET: CL_COMMERTYPEPAY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Create.cshtml", new CreateCL_COMMERTYPEPAYDto());
    }

    // POST: CL_COMMERTYPEPAY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCL_COMMERTYPEPAYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Create.cshtml", createDto);
    }

    // GET: CL_COMMERTYPEPAY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCL_COMMERTYPEPAYDto
        {
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            SDESCRIPT = result.SDESCRIPT,
            SIND_CONTROL = result.SIND_CONTROL,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Edit.cshtml", updateDto);
    }

    // POST: CL_COMMERTYPEPAY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCL_COMMERTYPEPAYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_COMMPAY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Edit.cshtml", updateDto);
    }

    // GET: CL_COMMERTYPEPAY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COMMERTYPEPAY/Delete.cshtml", result);
    }

    // POST: CL_COMMERTYPEPAY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
