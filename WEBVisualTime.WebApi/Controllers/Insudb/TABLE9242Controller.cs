using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9242Controller : CrudApiController<TABLE9242Dto, CreateTABLE9242Dto, UpdateTABLE9242Dto, int>
{
    public TABLE9242Controller(ITABLE9242Service service) : base(service, dto => dto.NTYPEDOC_PAY) { }
}
