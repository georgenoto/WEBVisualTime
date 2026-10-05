using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE87;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE88;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WINDOWSController : Controller
{
    private readonly IWINDOWSService _service;
    private readonly ITABLE87Service _TABLE87Service;
    private readonly ITABLE88Service _TABLE88Service;

    public WINDOWSController(IWINDOWSService service
        , ITABLE87Service TABLE87Service
        , ITABLE88Service TABLE88Service
    )
    {
        _service = service;
        _TABLE87Service = TABLE87Service;
        _TABLE88Service = TABLE88Service;
    }

    // GET: WINDOWS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/WINDOWS/Index.cshtml", result);
    }

    // GET: WINDOWS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WINDOWS/Details.cshtml", result);
    }

    // GET: WINDOWS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE87DropdownAsync();
        await PopulateTABLE88DropdownAsync();
        return View("~/Views/Insudb/WINDOWS/Create.cshtml", new CreateWINDOWSDto());
    }

    // POST: WINDOWS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWINDOWSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE87DropdownAsync();
        await PopulateTABLE88DropdownAsync();
        return View("~/Views/Insudb/WINDOWS/Create.cshtml", createDto);
    }

    // GET: WINDOWS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWINDOWSDto
        {
            SCODISPL = result.SCODISPL,
            NAMELEVEL = result.NAMELEVEL,
            SCODISP = result.SCODISP,
            NIMG_INDEX = result.NIMG_INDEX,
            SCODMEN = result.SCODMEN,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SDIRECTGO = result.SDIRECTGO,
            NG_IDENTI = result.NG_IDENTI,
            NINQLEVEL = result.NINQLEVEL,
            NMODULES = result.NMODULES,
            SPSEUDO = result.SPSEUDO,
            NSEQUENCE = result.NSEQUENCE,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NWINDOWTY = result.NWINDOWTY,
            SHELPPATH = result.SHELPPATH,
            NHEIGHT = result.NHEIGHT,
            SAUTOREP = result.SAUTOREP,
            SQUOTE = result.SQUOTE,
            NTYPE_REPORT = result.NTYPE_REPORT,
            SINDLETTER = result.SINDLETTER,
            NLENGTH_NOTES = result.NLENGTH_NOTES,
            SFILEPATH = result.SFILEPATH,
            SWINDOWURL = result.SWINDOWURL,
        };
        await PopulateTABLE87DropdownAsync();
        await PopulateTABLE88DropdownAsync();
        return View("~/Views/Insudb/WINDOWS/Edit.cshtml", updateDto);
    }

    // POST: WINDOWS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWINDOWSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCODISPL, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE87DropdownAsync();
        await PopulateTABLE88DropdownAsync();
        return View("~/Views/Insudb/WINDOWS/Edit.cshtml", updateDto);
    }

    // GET: WINDOWS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WINDOWS/Delete.cshtml", result);
    }

    // POST: WINDOWS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE87DropdownAsync()
    {
        var items = await _TABLE87Service.GetAllAsync();
        ViewData["NMODULES"] = new SelectList(items, nameof(TABLE87Dto.NMODULES), "SDESCRIPT");
    }

    private async Task PopulateTABLE88DropdownAsync()
    {
        var items = await _TABLE88Service.GetAllAsync();
        ViewData["NWINDOWTY"] = new SelectList(items, nameof(TABLE88Dto.NWINDOWTY), "SDESCRIPT");
    }

}
