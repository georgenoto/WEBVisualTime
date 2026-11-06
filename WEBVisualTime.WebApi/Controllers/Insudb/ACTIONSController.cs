using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ACTIONSController : CrudApiController<ACTIONSDto, CreateACTIONSDto, UpdateACTIONSDto, int>
{
    public ACTIONSController(IACTIONSService service) : base(service, dto => dto.NACTION) { }
}
