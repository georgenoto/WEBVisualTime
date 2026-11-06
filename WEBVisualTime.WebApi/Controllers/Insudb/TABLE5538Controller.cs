using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5538;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5538Controller : CrudApiController<TABLE5538Dto, CreateTABLE5538Dto, UpdateTABLE5538Dto, int>
{
    public TABLE5538Controller(ITABLE5538Service service) : base(service, dto => dto.NSTRUCTURE_TYPE) { }
}
