using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Services.Common;
using WEBVisualTime.Web.Models;
using WEBVisualTime.Datos;

namespace WEBVisualTime.Web.Controllers.Common;

// Concrete adapters retain the existing controller names, URLs and typed service contracts.
public abstract class CatalogController<TDto, TCreateDto, TUpdateDto, TKey> : Controller
    where TDto : class where TCreateDto : class, new() where TUpdateDto : class, new()
{
    private readonly IService<TDto, TCreateDto, TUpdateDto, TKey> service;
    private readonly CrudDefinition definition;
    protected CatalogController(IService<TDto, TCreateDto, TUpdateDto, TKey> service,
        string name, string key, string[] columns)
    {
        this.service = service;
        definition = new(name, key, columns, ModelIntegrityRules.ReadOnlyReason(name));
    }
    private ViewResult Page(string view, object model)
    {
        ViewData["Crud"] = definition;
        return View($"~/Views/Shared/Catalog/{view}.cshtml", model);
    }
    private ViewResult ReadOnlyPage()
    {
        Response.StatusCode = 409;
        return Page("ReadOnly", definition.ReadOnlyReason!);
    }
    [HttpGet]
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => ListPageLoader.LoadAsync(this, service, page, q, "~/Views/Shared/Catalog/Index.cshtml", definition);
    [HttpGet]
    public async Task<IActionResult> Details(TKey id)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Page("Details", dto);
    }
    [HttpGet]
    public IActionResult Create() => definition.ReadOnlyReason is not null ? ReadOnlyPage() : Page("Form", new TCreateDto());
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TCreateDto createDto)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        if (!ModelState.IsValid) return Page("Form", createDto);
        await service.CreateAsync(createDto);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Edit(TKey id)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        var dto = await service.GetByIdAsync(id);
        if (dto is null) return NotFound();
        var updateDto = new TUpdateDto();
        foreach (var property in typeof(TUpdateDto).GetProperties().Where(p => p.CanWrite))
        {
            var source = typeof(TDto).GetProperty(property.Name);
            if (source is not null && source.PropertyType == property.PropertyType)
                property.SetValue(updateDto, source.GetValue(dto));
        }
        return Page("Form", updateDto);
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(TUpdateDto updateDto)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        if (!ModelState.IsValid) return Page("Form", updateDto);
        var key = typeof(TUpdateDto).GetProperty(definition.Key)?.GetValue(updateDto);
        if (key is not TKey id) return BadRequest();
        if (!await service.UpdateAsync(id, updateDto)) return NotFound();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Delete(TKey id)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Page("Delete", dto);
    }
    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(TKey id)
    {
        if (definition.ReadOnlyReason is not null) return ReadOnlyPage();
        await service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
