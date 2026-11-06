using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5560;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5560Controller : CrudApiController<TABLE5560Dto, CreateTABLE5560Dto, UpdateTABLE5560Dto, int>
{
    public TABLE5560Controller(ITABLE5560Service service) : base(service, dto => dto.NCALCAPITAL) { }
}
