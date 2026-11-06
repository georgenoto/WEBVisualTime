using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9029;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9029Controller : CrudApiController<TABLE9029Dto, CreateTABLE9029Dto, UpdateTABLE9029Dto, int>
{
    public TABLE9029Controller(ITABLE9029Service service) : base(service, dto => dto.NCODRATING) { }
}
