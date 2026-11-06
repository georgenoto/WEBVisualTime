using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5604;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5604Controller : CrudApiController<TABLE5604Dto, CreateTABLE5604Dto, UpdateTABLE5604Dto, int>
{
    public TABLE5604Controller(ITABLE5604Service service) : base(service, dto => dto.NWAITCL_CODE) { }
}
