using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FIELDSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FIELDSHEETController : Controller
{
    private readonly IFIELDSHEETService _service;

    public FIELDSHEETController(IFIELDSHEETService service
    )
    {
        _service = service;
    }

    // GET: FIELDSHEET
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FIELDSHEET/Index.cshtml");

    // GET: FIELDSHEET/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FIELDSHEET/Details.cshtml", result);
    }

    // GET: FIELDSHEET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/FIELDSHEET/Create.cshtml", new CreateFIELDSHEETDto());
    }

    // POST: FIELDSHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFIELDSHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/FIELDSHEET/Create.cshtml", createDto);
    }

    // GET: FIELDSHEET/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFIELDSHEETDto
        {
            NSHEET = result.NSHEET,
            NFIELD = result.NFIELD,
            DCOMPDATE = result.DCOMPDATE,
            NFIELDTYPE = result.NFIELDTYPE,
            STABLE = result.STABLE,
            NUSERCODE = result.NUSERCODE,
            SFIELDDESC = result.SFIELDDESC,
            SCOLUMNNAME = result.SCOLUMNNAME,
            SVALUE = result.SVALUE,
            SRUTINE = result.SRUTINE,
            NROWORDER = result.NROWORDER,
            NFIELDORDER = result.NFIELDORDER,
            SVALUESLIST = result.SVALUESLIST,
            NFIELDLARGE = result.NFIELDLARGE,
            NOBJTYPE = result.NOBJTYPE,
            NTABLEHOMO = result.NTABLEHOMO,
            NOPERATOR = result.NOPERATOR,
            NCONDIT = result.NCONDIT,
            SFIELDCOMMEN = result.SFIELDCOMMEN,
            SFIELDREL = result.SFIELDREL,
            SOBLIGATORY = result.SOBLIGATORY,
            SLASTMOVE = result.SLASTMOVE,
            NDATATYPE = result.NDATATYPE,
            SRPARENTH = result.SRPARENTH,
            SLPARENTH = result.SLPARENTH,
            NDECIMAL = result.NDECIMAL,
            SREPORT = result.SREPORT,
            LPADVAR = result.LPADVAR,
            RPADVAR = result.RPADVAR,
            NLEVEL = result.NLEVEL,
            NCRITER_ORDER = result.NCRITER_ORDER,
            NDEFTYPE = result.NDEFTYPE,
            NIDREC = result.NIDREC,
            SDESCRIPT = result.SDESCRIPT,
            SUPDATEIND = result.SUPDATEIND,
        };
        return View("~/Views/Insudb/FIELDSHEET/Edit.cshtml", updateDto);
    }

    // POST: FIELDSHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateFIELDSHEETDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/FIELDSHEET/Edit.cshtml", updateDto);
    }

    // GET: FIELDSHEET/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FIELDSHEET/Delete.cshtml", result);
    }

    // POST: FIELDSHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
