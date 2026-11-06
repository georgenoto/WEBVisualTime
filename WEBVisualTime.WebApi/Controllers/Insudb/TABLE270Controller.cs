using WEBVisualTime.Servicios.Insudb.DTOs.TABLE270;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE270Controller : CrudApiController<TABLE270Dto, CreateTABLE270Dto, UpdateTABLE270Dto, int>
{
    public TABLE270Controller(ITABLE270Service service) : base(service, dto => dto.NBENEF_TYPE) { }
}
