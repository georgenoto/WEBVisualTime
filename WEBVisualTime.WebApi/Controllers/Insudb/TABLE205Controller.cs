using WEBVisualTime.Servicios.Insudb.DTOs.TABLE205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE205Controller : CrudApiController<TABLE205Dto, CreateTABLE205Dto, UpdateTABLE205Dto, int>
{
    public TABLE205Controller(ITABLE205Service service) : base(service, dto => dto.NINFRACTION) { }
}
