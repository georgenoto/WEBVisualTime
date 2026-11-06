using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE181Controller : CrudApiController<TABLE181Dto, CreateTABLE181Dto, UpdateTABLE181Dto, string>
{
    public TABLE181Controller(ITABLE181Service service) : base(service, dto => dto.SSTATUSVA) { }
}
