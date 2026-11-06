using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9204Controller : CrudApiController<TABLE9204Dto, CreateTABLE9204Dto, UpdateTABLE9204Dto, int>
{
    public TABLE9204Controller(ITABLE9204Service service) : base(service, dto => dto.NSEVERITYPEP) { }
}
