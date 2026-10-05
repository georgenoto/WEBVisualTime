using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_DFLT_USER_PREF_USAGES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_DFLT_USER_PREF_USAGESController : Controller
{
    private readonly ICDI_DFLT_USER_PREF_USAGESService _service;

    public CDI_DFLT_USER_PREF_USAGESController(ICDI_DFLT_USER_PREF_USAGESService service
    )
    {
        _service = service;
    }

    // GET: CDI_DFLT_USER_PREF_USAGES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Index.cshtml", result);
    }

    // GET: CDI_DFLT_USER_PREF_USAGES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Details.cshtml", result);
    }

    // GET: CDI_DFLT_USER_PREF_USAGES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Create.cshtml", new CreateCDI_DFLT_USER_PREF_USAGESDto());
    }

    // POST: CDI_DFLT_USER_PREF_USAGES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_DFLT_USER_PREF_USAGESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Create.cshtml", createDto);
    }

    // GET: CDI_DFLT_USER_PREF_USAGES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_DFLT_USER_PREF_USAGESDto
        {
            P_SNAME = result.P_SNAME,
            P_CGVERSION = result.P_CGVERSION,
            PF_SEQ = result.PF_SEQ,
            DUP_SNAME = result.DUP_SNAME,
            VALUE = result.VALUE,
            DUP_INTERNAL = result.DUP_INTERNAL,
            DUP_TYPE = result.DUP_TYPE,
            DESCRIPTION_MSGID = result.DESCRIPTION_MSGID,
            MANDATORY = result.MANDATORY,
            CHR_DOMAIN = result.CHR_DOMAIN,
            CHR_MAXLEN = result.CHR_MAXLEN,
            NUM_HIVAL = result.NUM_HIVAL,
            NUM_LOVAL = result.NUM_LOVAL,
            DOM = result.DOM,
            TAB = result.TAB,
            CON = result.CON,
            COL = result.COL,
            MOD = result.MOD,
            DTU = result.DTU,
            CONU = result.CONU,
            IGRP = result.IGRP,
            DCU = result.DCU,
            ABT = result.ABT,
            VAT = result.VAT,
            OBT = result.OBT,
            TME = result.TME,
            ARL = result.ARL,
            TAT = result.TAT,
            TOP = result.TOP,
            OPP = result.OPP,
            VVA = result.VVA,
            ABTABT = result.ABTABT,
            TCO = result.TCO,
            GES = result.GES,
            PCK = result.PCK,
            LOV = result.LOV,
            SUB = result.SUB,
            ACI = result.ACI,
            NLS_LANG = result.NLS_LANG,
            DESCRIPTION = result.DESCRIPTION,
        };
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Edit.cshtml", updateDto);
    }

    // POST: CDI_DFLT_USER_PREF_USAGES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_DFLT_USER_PREF_USAGESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.P_SNAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Edit.cshtml", updateDto);
    }

    // GET: CDI_DFLT_USER_PREF_USAGES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_DFLT_USER_PREF_USAGES/Delete.cshtml", result);
    }

    // POST: CDI_DFLT_USER_PREF_USAGES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
