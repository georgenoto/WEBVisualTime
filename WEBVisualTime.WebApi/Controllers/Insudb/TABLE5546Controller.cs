using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5546;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5546Controller : CrudApiController<TABLE5546Dto, CreateTABLE5546Dto, UpdateTABLE5546Dto, int>
{
    public TABLE5546Controller(ITABLE5546Service service) : base(service, dto => dto.NLEVEL) { }
}
