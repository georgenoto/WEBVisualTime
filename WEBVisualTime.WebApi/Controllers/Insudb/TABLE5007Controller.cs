using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5007Controller : CrudApiController<TABLE5007Dto, CreateTABLE5007Dto, UpdateTABLE5007Dto, string>
{
    public TABLE5007Controller(ITABLE5007Service service) : base(service, dto => dto.SINDTYPTOT) { }
}
