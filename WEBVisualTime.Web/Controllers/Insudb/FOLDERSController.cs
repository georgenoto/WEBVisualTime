using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FOLDERS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FOLDERSController : Controller
{
    private readonly IFOLDERSService _service;
    private readonly IPROPERTYLIBRARYService _PROPERTYLIBRARYService;

    public FOLDERSController(IFOLDERSService service
        , IPROPERTYLIBRARYService PROPERTYLIBRARYService
    )
    {
        _service = service;
        _PROPERTYLIBRARYService = PROPERTYLIBRARYService;
    }

    // GET: FOLDERS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/FOLDERS/Index.cshtml");

    // GET: FOLDERS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FOLDERS/Details.cshtml", result);
    }

    // GET: FOLDERS/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/FOLDERS/Create.cshtml", new CreateFOLDERSDto());
    }

    // POST: FOLDERS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFOLDERSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/FOLDERS/Create.cshtml", createDto);
    }

    // GET: FOLDERS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFOLDERSDto
        {
            NFOLDER = result.NFOLDER,
            SFOLDERNAME = result.SFOLDERNAME,
            SROOTNAME = result.SROOTNAME,
            NIMAGE = result.NIMAGE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCLASS = result.SCLASS,
            SFOLDERKEY = result.SFOLDERKEY,
            NFOLDERKEY = result.NFOLDERKEY,
            SORIGI = result.SORIGI,
        };
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/FOLDERS/Edit.cshtml", updateDto);
    }

    // POST: FOLDERS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateFOLDERSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NFOLDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePROPERTYLIBRARYDropdownAsync();
        return View("~/Views/Insudb/FOLDERS/Edit.cshtml", updateDto);
    }

    // GET: FOLDERS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FOLDERS/Delete.cshtml", result);
    }

    // POST: FOLDERS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePROPERTYLIBRARYDropdownAsync()
    {
        var items = await _PROPERTYLIBRARYService.GetAllAsync();
        ViewData["NFOLDERKEY"] = new SelectList(items, nameof(PROPERTYLIBRARYDto.NIDPROPERTY), "SPROPERTY");
    }

}
