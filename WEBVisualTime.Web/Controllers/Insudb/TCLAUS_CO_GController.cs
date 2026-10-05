using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TCLAUS_CO_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TCLAUS_CO_GController : Controller
{
    private readonly ITCLAUS_CO_GService _service;

    public TCLAUS_CO_GController(ITCLAUS_CO_GService service
    )
    {
        _service = service;
    }

    // GET: TCLAUS_CO_G
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TCLAUS_CO_G/Index.cshtml", result);
    }

    // GET: TCLAUS_CO_G/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCLAUS_CO_G/Details.cshtml", result);
    }

    // GET: TCLAUS_CO_G/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TCLAUS_CO_G/Create.cshtml", new CreateTCLAUS_CO_GDto());
    }

    // POST: TCLAUS_CO_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTCLAUS_CO_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCLAUS_CO_G/Create.cshtml", createDto);
    }

    // GET: TCLAUS_CO_G/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTCLAUS_CO_GDto
        {
            SKEY = result.SKEY,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NGROUP = result.NGROUP,
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
        return View("~/Views/Insudb/TCLAUS_CO_G/Edit.cshtml", updateDto);
    }

    // POST: TCLAUS_CO_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTCLAUS_CO_GDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TCLAUS_CO_G/Edit.cshtml", updateDto);
    }

    // GET: TCLAUS_CO_G/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TCLAUS_CO_G/Delete.cshtml", result);
    }

    // POST: TCLAUS_CO_G/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
