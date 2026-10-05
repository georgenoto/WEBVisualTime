using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MODUL_INSURED;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MODUL_INSUREDController : Controller
{
    private readonly IMODUL_INSUREDService _service;

    public MODUL_INSUREDController(IMODUL_INSUREDService service
    )
    {
        _service = service;
    }

    // GET: MODUL_INSURED
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MODUL_INSURED/Index.cshtml", result);
    }

    // GET: MODUL_INSURED/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODUL_INSURED/Details.cshtml", result);
    }

    // GET: MODUL_INSURED/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MODUL_INSURED/Create.cshtml", new CreateMODUL_INSUREDDto());
    }

    // POST: MODUL_INSURED/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMODUL_INSUREDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MODUL_INSURED/Create.cshtml", createDto);
    }

    // GET: MODUL_INSURED/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMODUL_INSUREDDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            SCLIENT = result.SCLIENT,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        return View("~/Views/Insudb/MODUL_INSURED/Edit.cshtml", updateDto);
    }

    // POST: MODUL_INSURED/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMODUL_INSUREDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MODUL_INSURED/Edit.cshtml", updateDto);
    }

    // GET: MODUL_INSURED/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MODUL_INSURED/Delete.cshtml", result);
    }

    // POST: MODUL_INSURED/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
