using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NOTIFICA_ERPController : Controller
{
    private readonly INOTIFICA_ERPService _service;

    public NOTIFICA_ERPController(INOTIFICA_ERPService service
    )
    {
        _service = service;
    }

    // GET: NOTIFICA_ERP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NOTIFICA_ERP/Index.cshtml", result);
    }

    // GET: NOTIFICA_ERP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOTIFICA_ERP/Details.cshtml", result);
    }

    // GET: NOTIFICA_ERP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/NOTIFICA_ERP/Create.cshtml", new CreateNOTIFICA_ERPDto());
    }

    // POST: NOTIFICA_ERP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNOTIFICA_ERPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/NOTIFICA_ERP/Create.cshtml", createDto);
    }

    // GET: NOTIFICA_ERP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNOTIFICA_ERPDto
        {
            SPROCESO = result.SPROCESO,
            SKEY = result.SKEY,
            SESTADO = result.SESTADO,
            DFECHA_PROCESO = result.DFECHA_PROCESO,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DOPERDATE = result.DOPERDATE,
        };
        return View("~/Views/Insudb/NOTIFICA_ERP/Edit.cshtml", updateDto);
    }

    // POST: NOTIFICA_ERP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNOTIFICA_ERPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/NOTIFICA_ERP/Edit.cshtml", updateDto);
    }

    // GET: NOTIFICA_ERP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOTIFICA_ERP/Delete.cshtml", result);
    }

    // POST: NOTIFICA_ERP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
