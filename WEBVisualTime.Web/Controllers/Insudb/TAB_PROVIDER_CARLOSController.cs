using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER_CARLOS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROVIDER_CARLOSController : Controller
{
    private readonly ITAB_PROVIDER_CARLOSService _service;

    public TAB_PROVIDER_CARLOSController(ITAB_PROVIDER_CARLOSService service
    )
    {
        _service = service;
    }

    // GET: TAB_PROVIDER_CARLOS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Index.cshtml", result);
    }

    // GET: TAB_PROVIDER_CARLOS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Details.cshtml", result);
    }

    // GET: TAB_PROVIDER_CARLOS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Create.cshtml", new CreateTAB_PROVIDER_CARLOSDto());
    }

    // POST: TAB_PROVIDER_CARLOS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROVIDER_CARLOSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Create.cshtml", createDto);
    }

    // GET: TAB_PROVIDER_CARLOS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROVIDER_CARLOSDto
        {
            NPROVIDER = result.NPROVIDER,
            NTYPEPROV = result.NTYPEPROV,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DINPDATE = result.DINPDATE,
            DOUTDATE = result.DOUTDATE,
            NOFFICE = result.NOFFICE,
            NMAX_SERV_ORD = result.NMAX_SERV_ORD,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NPER_DISC = result.NPER_DISC,
            SCONCESIONARY = result.SCONCESIONARY,
            SAGENCYDESC = result.SAGENCYDESC,
            NCLASS_PROV = result.NCLASS_PROV,
            NCATEG_PROV = result.NCATEG_PROV,
            NTYPEDISC_PROV = result.NTYPEDISC_PROV,
            NSUBTYPEPROV = result.NSUBTYPEPROV,
            DREQDATE = result.DREQDATE,
            DREGDATE = result.DREGDATE,
            NDISC_PROV = result.NDISC_PROV,
            NCURRDISC_PROV = result.NCURRDISC_PROV,
            NAMODISC_PROV = result.NAMODISC_PROV,
            NPAYMENT_METHOD = result.NPAYMENT_METHOD,
            NJOINED = result.NJOINED,
            NCOD_INSTEDUC = result.NCOD_INSTEDUC,
            NCOD_MEDCOLLEGE = result.NCOD_MEDCOLLEGE,
            SINTERNATIONALPROVIDER = result.SINTERNATIONALPROVIDER,
        };
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROVIDER_CARLOS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROVIDER_CARLOSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROVIDER_CARLOS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROVIDER_CARLOS/Delete.cshtml", result);
    }

    // POST: TAB_PROVIDER_CARLOS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
