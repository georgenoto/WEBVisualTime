using WEBVisualTime.Servicios.Insudb.DTOs.TABLE237;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE237Controller : CrudApiController<TABLE237Dto, CreateTABLE237Dto, UpdateTABLE237Dto, int>
{
    public TABLE237Controller(ITABLE237Service service) : base(service, dto => dto.NPACKING) { }
}
