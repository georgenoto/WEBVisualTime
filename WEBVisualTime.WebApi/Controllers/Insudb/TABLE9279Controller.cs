using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9279Controller : CrudApiController<TABLE9279Dto, CreateTABLE9279Dto, UpdateTABLE9279Dto, int>
{
    public TABLE9279Controller(ITABLE9279Service service) : base(service, dto => dto.NSUBLIMIT_TYPE) { }
}
