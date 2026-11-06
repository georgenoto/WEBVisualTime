using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Services.Common;
using WEBVisualTime.Web.Models;

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
        definition = new(name, key, columns);
    }
    private ViewResult Page(string view, object model)
    {
        ViewData["Crud"] = definition;
        return View($"~/Views/Shared/Catalog/{view}.cshtml", model);
    }
    [HttpGet]
    public async Task<IActionResult> Index() => Page("Index", await service.GetAllAsync());
    [HttpGet]
    public async Task<IActionResult> Details(TKey id)
    {
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Page("Details", dto);
    }
    [HttpGet]
    public IActionResult Create() => Page("Form", new TCreateDto());
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TCreateDto createDto)
    {
        if (!ModelState.IsValid) return Page("Form", createDto);
        await service.CreateAsync(createDto);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Edit(TKey id)
    {
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
        if (!ModelState.IsValid) return Page("Form", updateDto);
        var key = typeof(TUpdateDto).GetProperty(definition.Key)?.GetValue(updateDto);
        if (key is not TKey id) return BadRequest();
        if (!await service.UpdateAsync(id, updateDto)) return NotFound();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Delete(TKey id)
    {
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Page("Delete", dto);
    }
    [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(TKey id)
    {
        await service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
