using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5009;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5009Controller : CrudApiController<TABLE5009Dto, CreateTABLE5009Dto, UpdateTABLE5009Dto, int>
{
    public TABLE5009Controller(ITABLE5009Service service) : base(service, dto => dto.NCOMERLINE) { }
}
