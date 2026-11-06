using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5535;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5535Controller : CrudApiController<TABLE5535Dto, CreateTABLE5535Dto, UpdateTABLE5535Dto, int>
{
    public TABLE5535Controller(ITABLE5535Service service) : base(service, dto => dto.NDAMAGE_MAGNIF) { }
}
