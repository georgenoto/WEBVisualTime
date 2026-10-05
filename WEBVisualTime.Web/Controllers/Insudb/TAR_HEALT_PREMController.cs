using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAR_HEALT_PREM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE10;
using WEBVisualTime.Servicios.Insudb.DTOs.PRODMASTER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAR_HEALT_PREMController : Controller
{
    private readonly ITAR_HEALT_PREMService _service;
    private readonly ITABLE10Service _TABLE10Service;
    private readonly IPRODMASTERService _PRODMASTERService;
    private readonly ITABLE9214Service _TABLE9214Service;
    private readonly ITABLE9215Service _TABLE9215Service;
    private readonly ITABLE9Service _TABLE9Service;

    public TAR_HEALT_PREMController(ITAR_HEALT_PREMService service
        , ITABLE10Service TABLE10Service
        , IPRODMASTERService PRODMASTERService
        , ITABLE9214Service TABLE9214Service
        , ITABLE9215Service TABLE9215Service
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _TABLE10Service = TABLE10Service;
        _PRODMASTERService = PRODMASTERService;
        _TABLE9214Service = TABLE9214Service;
        _TABLE9215Service = TABLE9215Service;
        _TABLE9Service = TABLE9Service;
    }

    // GET: TAR_HEALT_PREM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Index.cshtml", result);
    }

    // GET: TAR_HEALT_PREM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Details.cshtml", result);
    }

    // GET: TAR_HEALT_PREM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Create.cshtml", new CreateTAR_HEALT_PREMDto());
    }

    // POST: TAR_HEALT_PREM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAR_HEALT_PREMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Create.cshtml", createDto);
    }

    // GET: TAR_HEALT_PREM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAR_HEALT_PREMDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            NROLE = result.NROLE,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NGEOGRAPHAREA = result.NGEOGRAPHAREA,
            NATTENSYSTEM = result.NATTENSYSTEM,
            NOFFICE = result.NOFFICE,
            NCAPITAL_INIT = result.NCAPITAL_INIT,
            NCAPITAL_END = result.NCAPITAL_END,
            NPOLICY_YEAR_INIT = result.NPOLICY_YEAR_INIT,
            NPOLICY_YEAR_END = result.NPOLICY_YEAR_END,
            NCURRENCY = result.NCURRENCY,
            NAGE_INIT = result.NAGE_INIT,
            NAGE_END = result.NAGE_END,
            NAMOUNTF = result.NAMOUNTF,
            NAMOUNTM = result.NAMOUNTM,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Edit.cshtml", updateDto);
    }

    // POST: TAR_HEALT_PREM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAR_HEALT_PREMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE10DropdownAsync();
        await PopulatePRODMASTERDropdownAsync();
        await PopulateTABLE9214DropdownAsync();
        await PopulateTABLE9215DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Edit.cshtml", updateDto);
    }

    // GET: TAR_HEALT_PREM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAR_HEALT_PREM/Delete.cshtml", result);
    }

    // POST: TAR_HEALT_PREM/Delete/{id}
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

    private async Task PopulatePRODMASTERDropdownAsync()
    {
        var items = await _PRODMASTERService.GetAllAsync();
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PRODMASTERDto.NPRODUCT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9214DropdownAsync()
    {
        var items = await _TABLE9214Service.GetAllAsync();
        ViewData["NGEOGRAPHAREA"] = new SelectList(items, nameof(TABLE9214Dto.NGEOGRAPHAREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE9215DropdownAsync()
    {
        var items = await _TABLE9215Service.GetAllAsync();
        ViewData["NATTENSYSTEM"] = new SelectList(items, nameof(TABLE9215Dto.NATTENSYSTEM), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
