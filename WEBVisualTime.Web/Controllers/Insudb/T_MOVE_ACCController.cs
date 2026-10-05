using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_MOVE_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_MOVE_ACCController : Controller
{
    private readonly IT_MOVE_ACCService _service;
    private readonly ICOLFORMREFService _COLFORMREFService;

    public T_MOVE_ACCController(IT_MOVE_ACCService service
        , ICOLFORMREFService COLFORMREFService
    )
    {
        _service = service;
        _COLFORMREFService = COLFORMREFService;
    }

    // GET: T_MOVE_ACC
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_MOVE_ACC/Index.cshtml", result);
    }

    // GET: T_MOVE_ACC/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_MOVE_ACC/Details.cshtml", result);
    }

    // GET: T_MOVE_ACC/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_MOVE_ACC/Create.cshtml", new CreateT_MOVE_ACCDto());
    }

    // POST: T_MOVE_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_MOVE_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_MOVE_ACC/Create.cshtml", createDto);
    }

    // GET: T_MOVE_ACC/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_MOVE_ACCDto
        {
            NBORDEREAUX = result.NBORDEREAUX,
            NSEQUENCE = result.NSEQUENCE,
            NTYP_ACCO = result.NTYP_ACCO,
            NCURRENCY = result.NCURRENCY,
            SCLIENT = result.SCLIENT,
            NCREDIT = result.NCREDIT,
            NDEBIT = result.NDEBIT,
            NTYPE_MOVE = result.NTYPE_MOVE,
            NBRANCH = result.NBRANCH,
            SAUTORIZA = result.SAUTORIZA,
            NEXCHANGE = result.NEXCHANGE,
            SNUMFORM = result.SNUMFORM,
            NINTERMED = result.NINTERMED,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NRECEIPT = result.NRECEIPT,
            NPROPONUM = result.NPROPONUM,
            NCERTIF = result.NCERTIF,
            STYPE_ACC = result.STYPE_ACC,
            DOPERDATE = result.DOPERDATE,
            NIDCONSEC = result.NIDCONSEC,
            NAMOUNT = result.NAMOUNT,
            NBANKEXT = result.NBANKEXT,
            SCHEQUE = result.SCHEQUE,
            NCLAIM = result.NCLAIM,
            SDESCRIPT = result.SDESCRIPT,
            SMANUALMOV = result.SMANUALMOV,
            NPAYNUMBE = result.NPAYNUMBE,
            SSTATREGT = result.SSTATREGT,
            NTRANSAC = result.NTRANSAC,
            NTRANSACTIO = result.NTRANSACTIO,
            NTYPE_PAY = result.NTYPE_PAY,
            NTYPE_TRAN = result.NTYPE_TRAN,
            NUSERCODE = result.NUSERCODE,
            NPROVINCE = result.NPROVINCE,
            DCOMPDATE = result.DCOMPDATE,
            NIDDOCUMENT = result.NIDDOCUMENT,
            NREQUEST_NU = result.NREQUEST_NU,
            SPROCESS = result.SPROCESS,
            NORIGCURR = result.NORIGCURR,
            DVALUEDATE = result.DVALUEDATE,
            SNULL_RECOR = result.SNULL_RECOR,
            NCASHNUM = result.NCASHNUM,
            NAMOAFECT = result.NAMOAFECT,
            NAMOEXENT = result.NAMOEXENT,
            NPAY_COMM = result.NPAY_COMM,
            NCURR_ACC = result.NCURR_ACC,
            DPOSTED = result.DPOSTED,
            SPROCESS_IND = result.SPROCESS_IND,
            NBULLETINS = result.NBULLETINS,
            NNOTENUM = result.NNOTENUM,
            SACTION = result.SACTION,
            NAMOUNTDEC = result.NAMOUNTDEC,
            NCOD_AGREE = result.NCOD_AGREE,
            NORI_AMOUNT = result.NORI_AMOUNT,
        };
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_MOVE_ACC/Edit.cshtml", updateDto);
    }

    // POST: T_MOVE_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_MOVE_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBORDEREAUX, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCOLFORMREFDropdownAsync();
        return View("~/Views/Insudb/T_MOVE_ACC/Edit.cshtml", updateDto);
    }

    // GET: T_MOVE_ACC/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_MOVE_ACC/Delete.cshtml", result);
    }

    // POST: T_MOVE_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

}
