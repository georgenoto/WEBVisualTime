using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5527;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5527Controller : CrudApiController<TABLE5527Dto, CreateTABLE5527Dto, UpdateTABLE5527Dto, int>
{
    public TABLE5527Controller(ITABLE5527Service service) : base(service, dto => dto.NTYPEPAY) { }
}
