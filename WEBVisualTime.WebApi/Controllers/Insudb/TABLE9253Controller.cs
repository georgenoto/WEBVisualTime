using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9253;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9253Controller : CrudApiController<TABLE9253Dto, CreateTABLE9253Dto, UpdateTABLE9253Dto, int>
{
    public TABLE9253Controller(ITABLE9253Service service) : base(service, dto => dto.NCLASS_PROV) { }
}
