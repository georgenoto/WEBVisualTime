using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE64Controller : CrudApiController<TABLE64Dto, CreateTABLE64Dto, UpdateTABLE64Dto, string>
{
    public TABLE64Controller(ITABLE64Service service) : base(service, dto => dto.SFRANTYPE) { }
}
