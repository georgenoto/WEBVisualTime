using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.AGENCIES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class AGENCIESController : Controller
{
    private readonly IAGENCIESService _service;
    private readonly ITABLE5555Service _TABLE5555Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly ITABLE9Service _TABLE9Service;

    public AGENCIESController(IAGENCIESService service
        , ITABLE5555Service TABLE5555Service
        , ITABLE5556Service TABLE5556Service
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _TABLE5555Service = TABLE5555Service;
        _TABLE5556Service = TABLE5556Service;
        _TABLE9Service = TABLE9Service;
    }

    // GET: AGENCIES
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/AGENCIES/Index.cshtml");

    // GET: AGENCIES/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGENCIES/Details.cshtml", result);
    }

    // GET: AGENCIES/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/AGENCIES/Create.cshtml", new CreateAGENCIESDto());
    }

    // POST: AGENCIES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAGENCIESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/AGENCIES/Create.cshtml", createDto);
    }

    // GET: AGENCIES/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateAGENCIESDto
        {
            NAGENCY = result.NAGENCY,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NBRAN_OFF = result.NBRAN_OFF,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SPAY = result.SPAY,
        };
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/AGENCIES/Edit.cshtml", updateDto);
    }

    // POST: AGENCIES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateAGENCIESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NAGENCY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/AGENCIES/Edit.cshtml", updateDto);
    }

    // GET: AGENCIES/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGENCIES/Delete.cshtml", result);
    }

    // POST: AGENCIES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: AGENCIES/GetByNOFFICEAGEN?NOFFICEAGEN=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICEAGEN(int NOFFICEAGEN)
    {
        var items = await _service.FindAsync(p => p.NOFFICEAGEN == NOFFICEAGEN);
        return Json(items.Select(i => new { value = i.NAGENCY, text = i.SPAY }));
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NBRAN_OFF"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
