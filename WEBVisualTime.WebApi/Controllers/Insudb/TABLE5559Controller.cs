using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5559;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5559Controller : CrudApiController<TABLE5559Dto, CreateTABLE5559Dto, UpdateTABLE5559Dto, int>
{
    public TABLE5559Controller(ITABLE5559Service service) : base(service, dto => dto.NRETARIF) { }
}
