using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9234;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9234Controller : CrudApiController<TABLE9234Dto, CreateTABLE9234Dto, UpdateTABLE9234Dto, int>
{
    public TABLE9234Controller(ITABLE9234Service service) : base(service, dto => dto.NTYP_SECTION) { }
}
