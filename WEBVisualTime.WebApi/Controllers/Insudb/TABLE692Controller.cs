using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE692Controller : CrudApiController<TABLE692Dto, CreateTABLE692Dto, UpdateTABLE692Dto, int>
{
    public TABLE692Controller(ITABLE692Service service) : base(service, dto => dto.NDEMAN_TYPE) { }
}
