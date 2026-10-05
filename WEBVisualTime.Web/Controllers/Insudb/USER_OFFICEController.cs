using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_OFFICE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class USER_OFFICEController : Controller
{
    private readonly IUSER_OFFICEService _service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly IUSERSService _USERSService;

    public USER_OFFICEController(IUSER_OFFICEService service
        , ITABLE5556Service TABLE5556Service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _TABLE5556Service = TABLE5556Service;
        _USERSService = USERSService;
    }

    // GET: USER_OFFICE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/USER_OFFICE/Index.cshtml", result);
    }

    // GET: USER_OFFICE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USER_OFFICE/Details.cshtml", result);
    }

    // GET: USER_OFFICE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5556DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_OFFICE/Create.cshtml", new CreateUSER_OFFICEDto());
    }

    // POST: USER_OFFICE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateUSER_OFFICEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5556DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_OFFICE/Create.cshtml", createDto);
    }

    // GET: USER_OFFICE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateUSER_OFFICEDto
        {
            NUSER = result.NUSER,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        await PopulateTABLE5556DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_OFFICE/Edit.cshtml", updateDto);
    }

    // POST: USER_OFFICE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateUSER_OFFICEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NUSER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5556DropdownAsync();
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_OFFICE/Edit.cshtml", updateDto);
    }

    // GET: USER_OFFICE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USER_OFFICE/Delete.cshtml", result);
    }

    // POST: USER_OFFICE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
