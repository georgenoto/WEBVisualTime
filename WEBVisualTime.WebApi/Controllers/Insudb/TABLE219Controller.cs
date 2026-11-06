using WEBVisualTime.Servicios.Insudb.DTOs.TABLE219;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE219Controller : CrudApiController<TABLE219Dto, CreateTABLE219Dto, UpdateTABLE219Dto, long>
{
    public TABLE219Controller(ITABLE219Service service) : base(service, dto => dto.NCODIGINT) { }
}
