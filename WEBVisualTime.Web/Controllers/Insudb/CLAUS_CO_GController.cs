using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUS_CO_G;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAUS_CO_GController : Controller
{
    private readonly ICLAUS_CO_GService _service;

    public CLAUS_CO_GController(ICLAUS_CO_GService service
    )
    {
        _service = service;
    }

    // GET: CLAUS_CO_G
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAUS_CO_G/Index.cshtml", result);
    }

    // GET: CLAUS_CO_G/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUS_CO_G/Details.cshtml", result);
    }

    // GET: CLAUS_CO_G/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CLAUS_CO_G/Create.cshtml", new CreateCLAUS_CO_GDto());
    }

    // POST: CLAUS_CO_G/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAUS_CO_GDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLAUS_CO_G/Create.cshtml", createDto);
    }

    // GET: CLAUS_CO_G/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAUS_CO_GDto
        {
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
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        return View("~/Views/Insudb/CLAUS_CO_G/Edit.cshtml", updateDto);
    }

    // POST: CLAUS_CO_G/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAUS_CO_GDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLAUS_CO_G/Edit.cshtml", updateDto);
    }

    // GET: CLAUS_CO_G/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUS_CO_G/Delete.cshtml", result);
    }

    // POST: CLAUS_CO_G/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
