using WEBVisualTime.Servicios.Insudb.DTOs.TABLE21;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE21Controller : CrudApiController<TABLE21Dto, CreateTABLE21Dto, UpdateTABLE21Dto, long>
{
    public TABLE21Controller(ITABLE21Service service) : base(service, dto => dto.NLEVEL) { }
}
