using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8Controller : CrudApiController<TABLE8Dto, CreateTABLE8Dto, UpdateTABLE8Dto, string>
{
    public TABLE8Controller(ITABLE8Service service) : base(service, dto => dto.SREINTYPE) { }
}
