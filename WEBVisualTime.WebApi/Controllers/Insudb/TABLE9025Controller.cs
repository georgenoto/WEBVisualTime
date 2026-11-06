using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9025;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9025Controller : CrudApiController<TABLE9025Dto, CreateTABLE9025Dto, UpdateTABLE9025Dto, int>
{
    public TABLE9025Controller(ITABLE9025Service service) : base(service, dto => dto.NRENTABILITY) { }
}
