using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9205Controller : CrudApiController<TABLE9205Dto, CreateTABLE9205Dto, UpdateTABLE9205Dto, int>
{
    public TABLE9205Controller(ITABLE9205Service service) : base(service, dto => dto.NCITY_AXE) { }
}
