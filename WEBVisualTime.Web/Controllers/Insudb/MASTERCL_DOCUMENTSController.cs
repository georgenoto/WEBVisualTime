using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DOCUMENTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERCL_DOCUMENTSController : Controller
{
    private readonly IMASTERCL_DOCUMENTSService _service;

    public MASTERCL_DOCUMENTSController(IMASTERCL_DOCUMENTSService service
    )
    {
        _service = service;
    }

    // GET: MASTERCL_DOCUMENTS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Index.cshtml", result);
    }

    // GET: MASTERCL_DOCUMENTS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Details.cshtml", result);
    }

    // GET: MASTERCL_DOCUMENTS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Create.cshtml", new CreateMASTERCL_DOCUMENTSDto());
    }

    // POST: MASTERCL_DOCUMENTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERCL_DOCUMENTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Create.cshtml", createDto);
    }

    // GET: MASTERCL_DOCUMENTS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERCL_DOCUMENTSDto
        {
            NMASTERORDER = result.NMASTERORDER,
            NCONSEC_MASTERORDERDOC = result.NCONSEC_MASTERORDERDOC,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            SCLIENT = result.SCLIENT,
            NID = result.NID,
            NDOC_CODE = result.NDOC_CODE,
            NCONSEC = result.NCONSEC,
            NAPPLY = result.NAPPLY,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Edit.cshtml", updateDto);
    }

    // POST: MASTERCL_DOCUMENTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTERCL_DOCUMENTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMASTERORDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Edit.cshtml", updateDto);
    }

    // GET: MASTERCL_DOCUMENTS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_DOCUMENTS/Delete.cshtml", result);
    }

    // POST: MASTERCL_DOCUMENTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
