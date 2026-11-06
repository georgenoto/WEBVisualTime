using WEBVisualTime.Servicios.Insudb.DTOs.TABLE322;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE322Controller : CrudApiController<TABLE322Dto, CreateTABLE322Dto, UpdateTABLE322Dto, int>
{
    public TABLE322Controller(ITABLE322Service service) : base(service, dto => dto.NCONDACTION) { }
}
