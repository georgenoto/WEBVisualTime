using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5609;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5609Controller : CrudApiController<TABLE5609Dto, CreateTABLE5609Dto, UpdateTABLE5609Dto, int>
{
    public TABLE5609Controller(ITABLE5609Service service) : base(service, dto => dto.NCLAIMCLASS) { }
}
