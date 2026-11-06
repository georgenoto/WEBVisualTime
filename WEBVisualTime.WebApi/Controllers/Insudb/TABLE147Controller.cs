using WEBVisualTime.Servicios.Insudb.DTOs.TABLE147;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE147Controller : CrudApiController<TABLE147Dto, CreateTABLE147Dto, UpdateTABLE147Dto, int>
{
    public TABLE147Controller(ITABLE147Service service) : base(service, dto => dto.NECONOMIC_L) { }
}
