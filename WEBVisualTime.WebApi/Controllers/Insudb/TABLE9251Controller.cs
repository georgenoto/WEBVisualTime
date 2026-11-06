using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9251;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9251Controller : CrudApiController<TABLE9251Dto, CreateTABLE9251Dto, UpdateTABLE9251Dto, int>
{
    public TABLE9251Controller(ITABLE9251Service service) : base(service, dto => dto.NPAYEE) { }
}
