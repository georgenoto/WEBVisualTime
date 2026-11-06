using WEBVisualTime.Servicios.Insudb.DTOs.TABLE126;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE126Controller : CrudApiController<TABLE126Dto, CreateTABLE126Dto, UpdateTABLE126Dto, long>
{
    public TABLE126Controller(ITABLE126Service service) : base(service, dto => dto.NVALUESMO) { }
}
