using WEBVisualTime.Servicios.Insudb.DTOs.TABLE159;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE159Controller : CrudApiController<TABLE159Dto, CreateTABLE159Dto, UpdateTABLE159Dto, int>
{
    public TABLE159Controller(ITABLE159Service service) : base(service, dto => dto.NGROUP_PRES) { }
}
