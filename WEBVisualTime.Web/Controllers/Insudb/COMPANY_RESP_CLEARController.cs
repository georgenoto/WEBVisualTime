using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY_RESP_CLEAR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COMPANY_RESP_CLEARController : Controller
{
    private readonly ICOMPANY_RESP_CLEARService _service;

    public COMPANY_RESP_CLEARController(ICOMPANY_RESP_CLEARService service
    )
    {
        _service = service;
    }

    // GET: COMPANY_RESP_CLEAR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Index.cshtml", result);
    }

    // GET: COMPANY_RESP_CLEAR/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Details.cshtml", result);
    }

    // GET: COMPANY_RESP_CLEAR/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Create.cshtml", new CreateCOMPANY_RESP_CLEARDto());
    }

    // POST: COMPANY_RESP_CLEAR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOMPANY_RESP_CLEARDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Create.cshtml", createDto);
    }

    // GET: COMPANY_RESP_CLEAR/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOMPANY_RESP_CLEARDto
        {
            NCOMPANY = result.NCOMPANY,
            SACCOUNT = result.SACCOUNT,
            SCLIENT = result.SCLIENT,
            SBANKNAME = result.SBANKNAME,
            DCOMPDATE = result.DCOMPDATE,
            NCOUNTRY = result.NCOUNTRY,
            DINPDATE = result.DINPDATE,
            SSTATREGT = result.SSTATREGT,
            NTAXRATE = result.NTAXRATE,
            STYPE = result.STYPE,
            SREGSVS = result.SREGSVS,
            NUSERCODE = result.NUSERCODE,
            SNATIONAL = result.SNATIONAL,
            NCLASIFIC = result.NCLASIFIC,
            SABA_ID = result.SABA_ID,
            SWIFT_IT = result.SWIFT_IT,
            NLOCAL = result.NLOCAL,
            SCITY = result.SCITY,
            NBANKCOUNTRY = result.NBANKCOUNTRY,
        };
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // POST: COMPANY_RESP_CLEAR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOMPANY_RESP_CLEARDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOMPANY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Edit.cshtml", updateDto);
    }

    // GET: COMPANY_RESP_CLEAR/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COMPANY_RESP_CLEAR/Delete.cshtml", result);
    }

    // POST: COMPANY_RESP_CLEAR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
