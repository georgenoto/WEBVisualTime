using WEBVisualTime.Servicios.Insudb.DTOs.TABLE26;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE26Controller : CrudApiController<TABLE26Dto, CreateTABLE26Dto, UpdateTABLE26Dto, long>
{
    public TABLE26Controller(ITABLE26Service service) : base(service, dto => dto.NCODIGINT) { }
}
