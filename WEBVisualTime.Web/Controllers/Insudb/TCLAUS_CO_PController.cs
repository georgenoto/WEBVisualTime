using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_P;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCLAUS_CO_PController : Controller
{
    private readonly ITCLAUS_CO_PService _service;

    public TCLAUS_CO_PController(ITCLAUS_CO_PService service
    )
    {
        _service = service;
    }

    // GET: TCLAUS_CO_P
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TCLAUS_CO_P/Index.cshtml", result);
    }

    // GET: TCLAUS_CO_P/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCLAUS_CO_P/Details.cshtml", result);
    }

    // GET: TCLAUS_CO_P/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCLAUS_CO_P/Create.cshtml", new CreateTCLAUS_CO_PDto());
    }

    // POST: TCLAUS_CO_P/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCLAUS_CO_PDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCLAUS_CO_P/Create.cshtml", createDto);
    }

    // GET: TCLAUS_CO_P/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCLAUS_CO_PDto
        {
            SKEY = result.SKEY,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCLAUSE = result.NCLAUSE,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            STYPE_CLAUSE = result.STYPE_CLAUSE,
            SDOC_ATTACH = result.SDOC_ATTACH,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            SMODIFIED = result.SMODIFIED,
            SSELECTED = result.SSELECTED,
            IND_INPOLICY = result.IND_INPOLICY,
        };
        return View("~/Views/Insudb/TCLAUS_CO_P/Edit.cshtml", updateDto);
    }

    // POST: TCLAUS_CO_P/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTCLAUS_CO_PDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCLAUS_CO_P/Edit.cshtml", updateDto);
    }

    // GET: TCLAUS_CO_P/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCLAUS_CO_P/Delete.cshtml", result);
    }

    // POST: TCLAUS_CO_P/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
