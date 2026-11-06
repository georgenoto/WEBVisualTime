using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Web.Models;

public sealed class ClientIndexViewModel
{
    public PagedResult<CLIENTDto> Result { get; init; } = new(Array.Empty<CLIENTDto>(), 0, 1, 20);
    public string? Search { get; init; }
    public string? ErrorMessage { get; init; }
    public string? ErrorReference { get; init; }
}
