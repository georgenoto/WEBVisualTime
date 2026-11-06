using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE200Controller : CrudApiController<TABLE200Dto, CreateTABLE200Dto, UpdateTABLE200Dto, int>
{
    public TABLE200Controller(ITABLE200Service service) : base(service, dto => dto.NINT_STATUS) { }
}
