using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9031Controller : CrudApiController<TABLE9031Dto, CreateTABLE9031Dto, UpdateTABLE9031Dto, int>
{
    public TABLE9031Controller(ITABLE9031Service service) : base(service, dto => dto.NBRANCHCIA) { }
}
