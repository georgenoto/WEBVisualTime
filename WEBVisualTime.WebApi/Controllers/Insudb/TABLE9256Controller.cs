using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9256;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9256Controller : CrudApiController<TABLE9256Dto, CreateTABLE9256Dto, UpdateTABLE9256Dto, int>
{
    public TABLE9256Controller(ITABLE9256Service service) : base(service, dto => dto.NCOD_MEDCOLLEGE) { }
}
