using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5672;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5672Controller : CrudApiController<TABLE5672Dto, CreateTABLE5672Dto, UpdateTABLE5672Dto, int>
{
    public TABLE5672Controller(ITABLE5672Service service) : base(service, dto => dto.NTYPPORT) { }
}
