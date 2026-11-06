using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE50Controller : CrudApiController<TABLE50Dto, CreateTABLE50Dto, UpdateTABLE50Dto, string>
{
    public TABLE50Controller(ITABLE50Service service) : base(service, dto => dto.SCOLINVOT) { }
}
