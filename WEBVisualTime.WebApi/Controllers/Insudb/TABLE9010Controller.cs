using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9010;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9010Controller : CrudApiController<TABLE9010Dto, CreateTABLE9010Dto, UpdateTABLE9010Dto, int>
{
    public TABLE9010Controller(ITABLE9010Service service) : base(service, dto => dto.NSINCEYEAR) { }
}
