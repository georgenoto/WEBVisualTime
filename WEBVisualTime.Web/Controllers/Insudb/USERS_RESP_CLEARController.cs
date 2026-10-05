using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS_RESP_CLEAR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class USERS_RESP_CLEARController : Controller
{
    private readonly IUSERS_RESP_CLEARService _service;

    public USERS_RESP_CLEARController(IUSERS_RESP_CLEARService service
    )
    {
        _service = service;
    }

    // GET: USERS_RESP_CLEAR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Index.cshtml", result);
    }

    // GET: USERS_RESP_CLEAR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Details.cshtml", result);
    }

    // GET: USERS_RESP_CLEAR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Create.cshtml", new CreateUSERS_RESP_CLEARDto());
    }

    // POST: USERS_RESP_CLEAR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateUSERS_RESP_CLEARDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Create.cshtml", createDto);
    }

    // GET: USERS_RESP_CLEAR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateUSERS_RESP_CLEARDto
        {
            NUSERCODE = result.NUSERCODE,
            SACCESSWO = result.SACCESSWO,
            NOFFICE = result.NOFFICE,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            SINITIALS = result.SINITIALS,
            SSCHE_CODE = result.SSCHE_CODE,
            SSTATREGT = result.SSTATREGT,
            STYPE = result.STYPE,
            NDEPARTME = result.NDEPARTME,
            SMENU = result.SMENU,
            SCHNEXTLOGON = result.SCHNEXTLOGON,
            SNEVERCHANGE = result.SNEVERCHANGE,
            SNEVEREXPIRES = result.SNEVEREXPIRES,
            SLOCKEDOUT = result.SLOCKEDOUT,
            DFROMDATE = result.DFROMDATE,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            NFAILED_LOGON_ATTEMPTS = result.NFAILED_LOGON_ATTEMPTS,
            DPASSWORD_EXPIRES = result.DPASSWORD_EXPIRES,
        };
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // POST: USERS_RESP_CLEAR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateUSERS_RESP_CLEARDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NUSERCODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // GET: USERS_RESP_CLEAR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/USERS_RESP_CLEAR/Delete.cshtml", result);
    }

    // POST: USERS_RESP_CLEAR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
