using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9254Controller : CrudApiController<TABLE9254Dto, CreateTABLE9254Dto, UpdateTABLE9254Dto, int>
{
    public TABLE9254Controller(ITABLE9254Service service) : base(service, dto => dto.NTYPEDISC_PROV) { }
}
