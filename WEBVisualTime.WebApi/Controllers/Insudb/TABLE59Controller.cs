using WEBVisualTime.Servicios.Insudb.DTOs.TABLE59;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE59Controller : CrudApiController<TABLE59Dto, CreateTABLE59Dto, UpdateTABLE59Dto, int>
{
    public TABLE59Controller(ITABLE59Service service) : base(service, dto => dto.NTYPE_PARAMETER) { }
}
