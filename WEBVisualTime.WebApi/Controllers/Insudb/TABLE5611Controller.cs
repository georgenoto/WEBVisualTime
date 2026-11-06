using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5611;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5611Controller : CrudApiController<TABLE5611Dto, CreateTABLE5611Dto, UpdateTABLE5611Dto, int>
{
    public TABLE5611Controller(ITABLE5611Service service) : base(service, dto => dto.NCON_EARTHQUAKE) { }
}
