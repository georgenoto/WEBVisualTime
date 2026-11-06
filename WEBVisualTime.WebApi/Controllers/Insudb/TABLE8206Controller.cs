using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8206Controller : CrudApiController<TABLE8206Dto, CreateTABLE8206Dto, UpdateTABLE8206Dto, int>
{
    public TABLE8206Controller(ITABLE8206Service service) : base(service, dto => dto.NACTION) { }
}
