using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9267;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9267Controller : CrudApiController<TABLE9267Dto, CreateTABLE9267Dto, UpdateTABLE9267Dto, int>
{
    public TABLE9267Controller(ITABLE9267Service service) : base(service, dto => dto.NOPERTYPE) { }
}
