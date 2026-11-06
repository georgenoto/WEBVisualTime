using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CUENTECN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CUENTECNController : Controller
{
    private readonly ICUENTECNService _service;
    private readonly ITABLE97Service _TABLE97Service;

    public CUENTECNController(ICUENTECNService service
        , ITABLE97Service TABLE97Service
    )
    {
        _service = service;
        _TABLE97Service = TABLE97Service;
    }

    // GET: CUENTECN
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CUENTECN/Index.cshtml");

    // GET: CUENTECN/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CUENTECN/Details.cshtml", result);
    }

    // GET: CUENTECN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CUENTECN/Create.cshtml", new CreateCUENTECNDto());
    }

    // POST: CUENTECN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCUENTECNDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CUENTECN/Create.cshtml", createDto);
    }

    // GET: CUENTECN/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCUENTECNDto
        {
            NTYPE_REL = result.NTYPE_REL,
            NIDCONSEC = result.NIDCONSEC,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NBRANCH = result.NBRANCH,
            STYPE_ACC = result.STYPE_ACC,
            NTYPE_PER = result.NTYPE_PER,
            NPERIODY = result.NPERIODY,
            NCURRENCY = result.NCURRENCY,
            NCLAIM_CED = result.NCLAIM_CED,
            NCLAIM_REC = result.NCLAIM_REC,
            NCOMISION = result.NCOMISION,
            NCOMPANY = result.NCOMPANY,
            DCOMPDATE = result.DCOMPDATE,
            NDEV_RESCLA = result.NDEV_RESCLA,
            NDEV_RESPRE = result.NDEV_RESPRE,
            NE_CAR_PREM = result.NE_CAR_PREM,
            NE_CAR_SIN = result.NE_CAR_SIN,
            DEFFECDATE = result.DEFFECDATE,
            NGASTO_REAS = result.NGASTO_REAS,
            NIMPUESTO = result.NIMPUESTO,
            NINTER_PREM = result.NINTER_PREM,
            NINTER_SIN = result.NINTER_SIN,
            SMOVE_ACC = result.SMOVE_ACC,
            DNULLDATE = result.DNULLDATE,
            NPART_BENEF = result.NPART_BENEF,
            NPREM_ANU = result.NPREM_ANU,
            NPREM_CED = result.NPREM_CED,
            NPREM_NO_AN = result.NPREM_NO_AN,
            NPREM_RES_A = result.NPREM_RES_A,
            SPRINT = result.SPRINT,
            NR_CAR_PREM = result.NR_CAR_PREM,
            NR_CAR_SIN = result.NR_CAR_SIN,
            NRES_AJ_SIN = result.NRES_AJ_SIN,
            NRES_SINPEN = result.NRES_SINPEN,
            NRET_RESPRE = result.NRET_RESPRE,
            NSAL_F_COMP = result.NSAL_F_COMP,
            NSAL_F_REIN = result.NSAL_F_REIN,
            NCLAIMAMO = result.NCLAIMAMO,
            NUSERCODE = result.NUSERCODE,
            NYEAR = result.NYEAR,
            NYEAR_SER = result.NYEAR_SER,
            SACTIVE = result.SACTIVE,
            NREQUESTNU = result.NREQUESTNU,
            DDATEPAY = result.DDATEPAY,
            DLEDGERDAT = result.DLEDGERDAT,
            DPOSTED = result.DPOSTED,
            NCORREDOR = result.NCORREDOR,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NCITY_TAX = result.NCITY_TAX,
            NISLR_TAX = result.NISLR_TAX,
            NSUPER_TAX = result.NSUPER_TAX,
            NTECH_TAX = result.NTECH_TAX,
            NSHARE = result.NSHARE,
            NAMOUNT_BENEF = result.NAMOUNT_BENEF,
        };
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CUENTECN/Edit.cshtml", updateDto);
    }

    // POST: CUENTECN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCUENTECNDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDCONSEC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/CUENTECN/Edit.cshtml", updateDto);
    }

    // GET: CUENTECN/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CUENTECN/Delete.cshtml", result);
    }

    // POST: CUENTECN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE97DropdownAsync()
    {
        var items = await _TABLE97Service.GetAllAsync();
        ViewData["NTYPE_PER"] = new SelectList(items, nameof(TABLE97Dto.NTYPE_PER), "SDESCRIPT");
    }

}
