using WEBVisualTime.Servicios.Insudb.DTOs.TABLE199;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE199Controller : CrudApiController<TABLE199Dto, CreateTABLE199Dto, UpdateTABLE199Dto, int>
{
    public TABLE199Controller(ITABLE199Service service) : base(service, dto => dto.NPAY_TYPE) { }
}
