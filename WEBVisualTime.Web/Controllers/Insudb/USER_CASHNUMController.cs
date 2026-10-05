using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.USER_CASHNUM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class USER_CASHNUMController : Controller
{
    private readonly IUSER_CASHNUMService _service;
    private readonly IUSERSService _USERSService;

    public USER_CASHNUMController(IUSER_CASHNUMService service
        , IUSERSService USERSService
    )
    {
        _service = service;
        _USERSService = USERSService;
    }

    // GET: USER_CASHNUM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/USER_CASHNUM/Index.cshtml", result);
    }

    // GET: USER_CASHNUM/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USER_CASHNUM/Details.cshtml", result);
    }

    // GET: USER_CASHNUM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_CASHNUM/Create.cshtml", new CreateUSER_CASHNUMDto());
    }

    // POST: USER_CASHNUM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateUSER_CASHNUMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_CASHNUM/Create.cshtml", createDto);
    }

    // GET: USER_CASHNUM/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateUSER_CASHNUMDto
        {
            NCASHNUM = result.NCASHNUM,
            SSTATUS = result.SSTATUS,
            DCOMPDATE = result.DCOMPDATE,
            NUSER = result.NUSER,
            NUSERCODE = result.NUSERCODE,
            NCASHSUP = result.NCASHSUP,
            NHEADSUP = result.NHEADSUP,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NTYPECASH = result.NTYPECASH,
        };
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_CASHNUM/Edit.cshtml", updateDto);
    }

    // POST: USER_CASHNUM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateUSER_CASHNUMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCASHNUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        return View("~/Views/Insudb/USER_CASHNUM/Edit.cshtml", updateDto);
    }

    // GET: USER_CASHNUM/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USER_CASHNUM/Delete.cshtml", result);
    }

    // POST: USER_CASHNUM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSER"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NCASHSUP"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NHEADSUP"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

}
