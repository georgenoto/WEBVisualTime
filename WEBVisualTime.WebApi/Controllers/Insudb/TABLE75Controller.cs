using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE75Controller : CrudApiController<TABLE75Dto, CreateTABLE75Dto, UpdateTABLE75Dto, int>
{
    public TABLE75Controller(ITABLE75Service service) : base(service, dto => dto.NBRANCH_LED) { }
}
