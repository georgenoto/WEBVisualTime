using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE37Controller : CrudApiController<TABLE37Dto, CreateTABLE37Dto, UpdateTABLE37Dto, string>
{
    public TABLE37Controller(ITABLE37Service service) : base(service, dto => dto.SBRANCHT) { }
}
