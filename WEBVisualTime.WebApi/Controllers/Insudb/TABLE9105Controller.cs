using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9105Controller : CrudApiController<TABLE9105Dto, CreateTABLE9105Dto, UpdateTABLE9105Dto, int>
{
    public TABLE9105Controller(ITABLE9105Service service) : base(service, dto => dto.NROUTINETYPE) { }
}
