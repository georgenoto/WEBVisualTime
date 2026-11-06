using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9257;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9257Controller : CrudApiController<TABLE9257Dto, CreateTABLE9257Dto, UpdateTABLE9257Dto, int>
{
    public TABLE9257Controller(ITABLE9257Service service) : base(service, dto => dto.NTYPE_SERV) { }
}
