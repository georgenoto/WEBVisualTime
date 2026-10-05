using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DOCU;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9217;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_DOCUController : Controller
{
    private readonly ITAB_DOCUService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly ITABLE9217Service _TABLE9217Service;

    public TAB_DOCUController(ITAB_DOCUService service
        , ITABLE10Service TABLE10Service
        , ITABLE9217Service TABLE9217Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _TABLE9217Service = TABLE9217Service;
    }

    // GET: TAB_DOCU
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_DOCU/Index.cshtml", result);
    }

    // GET: TAB_DOCU/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_DOCU/Details.cshtml", result);
    }

    // GET: TAB_DOCU/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        return View("~/Views/Insudb/TAB_DOCU/Create.cshtml", new CreateTAB_DOCUDto());
    }

    // POST: TAB_DOCU/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_DOCUDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        return View("~/Views/Insudb/TAB_DOCU/Create.cshtml", createDto);
    }

    // GET: TAB_DOCU/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_DOCUDto
        {
            NBRANCH = result.NBRANCH,
            NDOC_CODE = result.NDOC_CODE,
            NPRODUCT = result.NPRODUCT,
            NCOVER = result.NCOVER,
            NMODULEC = result.NMODULEC,
            NCAUSECOD = result.NCAUSECOD,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            SSHORT_DES = result.SSHORT_DES,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SCLAIMPAY = result.SCLAIMPAY,
            NDAYS_PRESC = result.NDAYS_PRESC,
            STEXT = result.STEXT,
            SREQUIERED = result.SREQUIERED,
            NPERSON_TYP = result.NPERSON_TYP,
            NDOC_TYPE = result.NDOC_TYPE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        return View("~/Views/Insudb/TAB_DOCU/Edit.cshtml", updateDto);
    }

    // POST: TAB_DOCU/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_DOCUDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        return View("~/Views/Insudb/TAB_DOCU/Edit.cshtml", updateDto);
    }

    // GET: TAB_DOCU/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_DOCU/Delete.cshtml", result);
    }

    // POST: TAB_DOCU/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE10DropdownAsync()
    {
        var items = await _TABLE10Service.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TABLE10Dto.NBRANCH), "SDESCRIPT");
    }

    private async Task PopulateTABLE9217DropdownAsync()
    {
        var items = await _TABLE9217Service.GetAllAsync();
        ViewData["NDOC_TYPE"] = new SelectList(items, nameof(TABLE9217Dto.NDOC_TYPE), "SDESCRIPT");
    }

}
