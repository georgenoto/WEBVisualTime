using WEBVisualTime.Servicios.Insudb.DTOs.TABLE902;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE902Controller : CrudApiController<TABLE902Dto, CreateTABLE902Dto, UpdateTABLE902Dto, long>
{
    public TABLE902Controller(ITABLE902Service service) : base(service, dto => dto.SCODIGINT) { }
}
