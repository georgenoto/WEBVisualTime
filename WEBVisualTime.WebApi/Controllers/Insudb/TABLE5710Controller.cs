using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5710;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5710Controller : CrudApiController<TABLE5710Dto, CreateTABLE5710Dto, UpdateTABLE5710Dto, int>
{
    public TABLE5710Controller(ITABLE5710Service service) : base(service, dto => dto.NPERIOD) { }
}
