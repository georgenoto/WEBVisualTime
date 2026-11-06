using WEBVisualTime.Servicios.Insudb.DTOs.TABLE179;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE179Controller : CrudApiController<TABLE179Dto, CreateTABLE179Dto, UpdateTABLE179Dto, int>
{
    public TABLE179Controller(ITABLE179Service service) : base(service, dto => dto.NTYPECASH) { }
}
