using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1009;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1009Controller : CrudApiController<TABLE1009Dto, CreateTABLE1009Dto, UpdateTABLE1009Dto, long>
{
    public TABLE1009Controller(ITABLE1009Service service) : base(service, dto => dto.NCODIGINT) { }
}
