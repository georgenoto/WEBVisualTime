using WEBVisualTime.Servicios.Insudb.DTOs.TABLE311;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE311Controller : CrudApiController<TABLE311Dto, CreateTABLE311Dto, UpdateTABLE311Dto, int>
{
    public TABLE311Controller(ITABLE311Service service) : base(service, dto => dto.NARITOPER) { }
}
