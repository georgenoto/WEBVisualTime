using WEBVisualTime.Servicios.Insudb.DTOs.TABLE255;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE255Controller : CrudApiController<TABLE255Dto, CreateTABLE255Dto, UpdateTABLE255Dto, long>
{
    public TABLE255Controller(ITABLE255Service service) : base(service, dto => dto.NCODIGINT) { }
}
