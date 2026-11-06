using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5745;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5745Controller : CrudApiController<TABLE5745Dto, CreateTABLE5745Dto, UpdateTABLE5745Dto, string>
{
    public TABLE5745Controller(ITABLE5745Service service) : base(service, dto => dto.SAFP_TYPE) { }
}
