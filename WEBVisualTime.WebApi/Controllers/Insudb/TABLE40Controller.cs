using WEBVisualTime.Servicios.Insudb.DTOs.TABLE40;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE40Controller : CrudApiController<TABLE40Dto, CreateTABLE40Dto, UpdateTABLE40Dto, long>
{
    public TABLE40Controller(ITABLE40Service service) : base(service, dto => dto.SCODIGINT) { }
}
