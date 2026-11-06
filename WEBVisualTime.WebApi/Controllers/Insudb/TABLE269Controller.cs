using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE269Controller : CrudApiController<TABLE269Dto, CreateTABLE269Dto, UpdateTABLE269Dto, int>
{
    public TABLE269Controller(ITABLE269Service service) : base(service, dto => dto.NDED_TYPE) { }
}
