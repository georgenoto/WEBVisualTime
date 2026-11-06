using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PHONES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE564;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PHONESController : Controller
{
    private readonly IPHONESService _service;
    private readonly ITABLE8060Service _TABLE8060Service;
    private readonly ITABLE564Service _TABLE564Service;

    public PHONESController(IPHONESService service
        , ITABLE8060Service TABLE8060Service
        , ITABLE564Service TABLE564Service
    )
    {
        _service = service;
        _TABLE8060Service = TABLE8060Service;
        _TABLE564Service = TABLE564Service;
    }

    // GET: PHONES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PHONES/Index.cshtml");

    // GET: PHONES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PHONES/Details.cshtml", result);
    }

    // GET: PHONES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8060DropdownAsync();
        await PopulateTABLE564DropdownAsync();
        return View("~/Views/Insudb/PHONES/Create.cshtml", new CreatePHONESDto());
    }

    // POST: PHONES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePHONESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8060DropdownAsync();
        await PopulateTABLE564DropdownAsync();
        return View("~/Views/Insudb/PHONES/Create.cshtml", createDto);
    }

    // GET: PHONES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePHONESDto
        {
            NRECOWNER = result.NRECOWNER,
            SKEYADDRESS = result.SKEYADDRESS,
            NKEYPHONES = result.NKEYPHONES,
            DEFFECDATE = result.DEFFECDATE,
            NBESTTIMETOCALL = result.NBESTTIMETOCALL,
            NAREA_CODE = result.NAREA_CODE,
            SPHONE = result.SPHONE,
            NORDER = result.NORDER,
            NEXTENS1 = result.NEXTENS1,
            NEXTENS2 = result.NEXTENS2,
            NPHONE_TYPE = result.NPHONE_TYPE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NCOUNTRY_CODE = result.NCOUNTRY_CODE,
            SASSOCADDR = result.SASSOCADDR,
            NPHONECLAS = result.NPHONECLAS,
        };
        await PopulateTABLE8060DropdownAsync();
        await PopulateTABLE564DropdownAsync();
        return View("~/Views/Insudb/PHONES/Edit.cshtml", updateDto);
    }

    // POST: PHONES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePHONESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRECOWNER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8060DropdownAsync();
        await PopulateTABLE564DropdownAsync();
        return View("~/Views/Insudb/PHONES/Edit.cshtml", updateDto);
    }

    // GET: PHONES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PHONES/Delete.cshtml", result);
    }

    // POST: PHONES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8060DropdownAsync()
    {
        var items = await _TABLE8060Service.GetAllAsync();
        ViewData["NBESTTIMETOCALL"] = new SelectList(items, nameof(TABLE8060Dto.NBESTTIMETOCALL), "SSTATREGT");
    }

    private async Task PopulateTABLE564DropdownAsync()
    {
        var items = await _TABLE564Service.GetAllAsync();
        ViewData["NPHONE_TYPE"] = new SelectList(items, nameof(TABLE564Dto.NPHONE_TYPE), "SDESCRIPT");
    }

}
