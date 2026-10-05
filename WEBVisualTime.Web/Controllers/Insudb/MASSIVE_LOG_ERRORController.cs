using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_ERROR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASSIVE_LOG_ERRORController : Controller
{
    private readonly IMASSIVE_LOG_ERRORService _service;

    public MASSIVE_LOG_ERRORController(IMASSIVE_LOG_ERRORService service
    )
    {
        _service = service;
    }

    // GET: MASSIVE_LOG_ERROR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Index.cshtml", result);
    }

    // GET: MASSIVE_LOG_ERROR/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Details.cshtml", result);
    }

    // GET: MASSIVE_LOG_ERROR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Create.cshtml", new CreateMASSIVE_LOG_ERRORDto());
    }

    // POST: MASSIVE_LOG_ERROR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASSIVE_LOG_ERRORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Create.cshtml", createDto);
    }

    // GET: MASSIVE_LOG_ERROR/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASSIVE_LOG_ERRORDto
        {
            SKEY = result.SKEY,
            NKEY = result.NKEY,
            NROW = result.NROW,
            NSEQ = result.NSEQ,
            NCONSEC = result.NCONSEC,
            SACTION = result.SACTION,
            NCODERROR = result.NCODERROR,
            SERRORTYP = result.SERRORTYP,
            STYP_CONDI = result.STYP_CONDI,
            NSECTION = result.NSECTION,
            SCODISPL = result.SCODISPL,
            SERRORMESSEROW = result.SERRORMESSEROW,
            SBREAK = result.SBREAK,
            NCOD_AGREE = result.NCOD_AGREE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NACTION = result.NACTION,
        };
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Edit.cshtml", updateDto);
    }

    // POST: MASSIVE_LOG_ERROR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASSIVE_LOG_ERRORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Edit.cshtml", updateDto);
    }

    // GET: MASSIVE_LOG_ERROR/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_LOG_ERROR/Delete.cshtml", result);
    }

    // POST: MASSIVE_LOG_ERROR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
