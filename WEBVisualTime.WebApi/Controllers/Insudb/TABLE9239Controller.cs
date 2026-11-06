using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9239;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9239Controller : CrudApiController<TABLE9239Dto, CreateTABLE9239Dto, UpdateTABLE9239Dto, int>
{
    public TABLE9239Controller(ITABLE9239Service service) : base(service, dto => dto.NREJECT_CAUSE) { }
}
