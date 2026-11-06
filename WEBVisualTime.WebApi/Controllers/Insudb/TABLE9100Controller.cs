using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9100Controller : CrudApiController<TABLE9100Dto, CreateTABLE9100Dto, UpdateTABLE9100Dto, int>
{
    public TABLE9100Controller(ITABLE9100Service service) : base(service, dto => dto.NSHIPUSE) { }
}
