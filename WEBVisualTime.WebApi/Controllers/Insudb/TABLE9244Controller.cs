using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9244;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9244Controller : CrudApiController<TABLE9244Dto, CreateTABLE9244Dto, UpdateTABLE9244Dto, int>
{
    public TABLE9244Controller(ITABLE9244Service service) : base(service, dto => dto.NACTIONCLAIM) { }
}
