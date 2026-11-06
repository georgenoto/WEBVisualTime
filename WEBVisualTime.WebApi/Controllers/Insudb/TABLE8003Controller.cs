using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8003Controller : CrudApiController<TABLE8003Dto, CreateTABLE8003Dto, UpdateTABLE8003Dto, int>
{
    public TABLE8003Controller(ITABLE8003Service service) : base(service, dto => dto.NTYPROUTE) { }
}
