using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9221Controller : CrudApiController<TABLE9221Dto, CreateTABLE9221Dto, UpdateTABLE9221Dto, int>
{
    public TABLE9221Controller(ITABLE9221Service service) : base(service, dto => dto.NTYPEEXHAUS) { }
}
