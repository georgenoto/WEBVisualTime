using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1006Controller : CrudApiController<TABLE1006Dto, CreateTABLE1006Dto, UpdateTABLE1006Dto, int>
{
    public TABLE1006Controller(ITABLE1006Service service) : base(service, dto => dto.NPRIORITY) { }
}
