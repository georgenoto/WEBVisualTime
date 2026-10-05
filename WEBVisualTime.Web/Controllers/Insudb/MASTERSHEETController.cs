using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERSHEET;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERSHEETController : Controller
{
    private readonly IMASTERSHEETService _service;
    private readonly IMASTERSHEETService _MASTERSHEETService;

    public MASTERSHEETController(IMASTERSHEETService service
        , IMASTERSHEETService MASTERSHEETService
    )
    {
        _service = service;
        _MASTERSHEETService = MASTERSHEETService;
    }

    // GET: MASTERSHEET
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASTERSHEET/Index.cshtml", result);
    }

    // GET: MASTERSHEET/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERSHEET/Details.cshtml", result);
    }

    // GET: MASTERSHEET/Create
    public async Task<IActionResult> Create()
    {
        await PopulateMASTERSHEETDropdownAsync();
        return View("~/Views/Insudb/MASTERSHEET/Create.cshtml", new CreateMASTERSHEETDto());
    }

    // POST: MASTERSHEET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERSHEETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateMASTERSHEETDropdownAsync();
        return View("~/Views/Insudb/MASTERSHEET/Create.cshtml", createDto);
    }

    // GET: MASTERSHEET/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERSHEETDto
        {
            NSHEET = result.NSHEET,
            NINTERTYPE = result.NINTERTYPE,
            SPROCESS = result.SPROCESS,
            NFORMAT = result.NFORMAT,
            DCOMPDATE = result.DCOMPDATE,
            NSYSTEM = result.NSYSTEM,
            SSELECT = result.SSELECT,
            NPERIOD = result.NPERIOD,
            NUSERCODE = result.NUSERCODE,
            SDESCRIPT = result.SDESCRIPT,
            NUSEROPER = result.NUSEROPER,
            SAUTOMATIC = result.SAUTOMATIC,
            SSHORTDESC = result.SSHORTDESC,
            SGROUPBY = result.SGROUPBY,
            SSTATUSSHEET = result.SSTATUSSHEET,
            NOPERTYPE = result.NOPERTYPE,
            SONLINE = result.SONLINE,
            NNOTENUM = result.NNOTENUM,
            SPROCESS_END = result.SPROCESS_END,
            SPREFIX_FNAME = result.SPREFIX_FNAME,
            SHEADER = result.SHEADER,
            STOTAL = result.STOTAL,
            NPOSITION = result.NPOSITION,
            SMASSIVE = result.SMASSIVE,
            SSPACE = result.SSPACE,
            NTYPE_ALIGN = result.NTYPE_ALIGN,
            SPATH = result.SPATH,
            SSEPARATOR = result.SSEPARATOR,
            SROUTINE = result.SROUTINE,
            SNOGRID = result.SNOGRID,
            SVIEW_INTERFACE = result.SVIEW_INTERFACE,
            SVIEW_REPORT = result.SVIEW_REPORT,
            SREPORT = result.SREPORT,
            SSHEET_FATHER = result.SSHEET_FATHER,
            SFILE_UNIQUE = result.SFILE_UNIQUE,
            SQUERY = result.SQUERY,
            SXSL = result.SXSL,
            SQUERY_XSL = result.SQUERY_XSL,
            SNAME_ROUTINE = result.SNAME_ROUTINE,
            SOUT_ROUTINE = result.SOUT_ROUTINE,
            SWORKFLOWNAME = result.SWORKFLOWNAME,
            SFOLDER = result.SFOLDER,
            SQUEPROCESS = result.SQUEPROCESS,
            SQUEQUERY = result.SQUEQUERY,
            ST_INTERFACE = result.ST_INTERFACE,
            NAVERAGERECORDS = result.NAVERAGERECORDS,
            NTOTALCOLUMNS = result.NTOTALCOLUMNS,
            SDATEFORMAT = result.SDATEFORMAT,
            SDECIMAL = result.SDECIMAL,
        };
        await PopulateMASTERSHEETDropdownAsync();
        return View("~/Views/Insudb/MASTERSHEET/Edit.cshtml", updateDto);
    }

    // POST: MASTERSHEET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTERSHEETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NSHEET, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateMASTERSHEETDropdownAsync();
        return View("~/Views/Insudb/MASTERSHEET/Edit.cshtml", updateDto);
    }

    // GET: MASTERSHEET/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERSHEET/Delete.cshtml", result);
    }

    // POST: MASTERSHEET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateMASTERSHEETDropdownAsync()
    {
        var items = await _MASTERSHEETService.GetAllAsync();
        ViewData["NSHEET"] = new SelectList(items, nameof(MASTERSHEETDto.NSHEET), "SPROCESS");
    }

}
