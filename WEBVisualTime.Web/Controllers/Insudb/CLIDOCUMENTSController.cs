using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCUMENTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIDOCUMENTSController : Controller
{
    private readonly ICLIDOCUMENTSService _service;

    public CLIDOCUMENTSController(ICLIDOCUMENTSService service
    )
    {
        _service = service;
    }

    // GET: CLIDOCUMENTS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIDOCUMENTS/Index.cshtml");

    // GET: CLIDOCUMENTS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIDOCUMENTS/Details.cshtml", result);
    }

    // GET: CLIDOCUMENTS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CLIDOCUMENTS/Create.cshtml", new CreateCLIDOCUMENTSDto());
    }

    // POST: CLIDOCUMENTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIDOCUMENTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIDOCUMENTS/Create.cshtml", createDto);
    }

    // GET: CLIDOCUMENTS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIDOCUMENTSDto
        {
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            SCLINUMDOCU = result.SCLINUMDOCU,
            SCLIENT = result.SCLIENT,
            DISSUEDAT = result.DISSUEDAT,
            DEXPIRDAT = result.DEXPIRDAT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            NTYPEXP = result.NTYPEXP,
            SIDCOMPL = result.SIDCOMPL,
        };
        return View("~/Views/Insudb/CLIDOCUMENTS/Edit.cshtml", updateDto);
    }

    // POST: CLIDOCUMENTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIDOCUMENTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPCLIENTDOC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIDOCUMENTS/Edit.cshtml", updateDto);
    }

    // GET: CLIDOCUMENTS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIDOCUMENTS/Delete.cshtml", result);
    }

    // POST: CLIDOCUMENTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
