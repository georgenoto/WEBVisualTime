using WEBVisualTime.Servicios.Insudb.DTOs.TABLE277;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE277Controller : CrudApiController<TABLE277Dto, CreateTABLE277Dto, UpdateTABLE277Dto, int>
{
    public TABLE277Controller(ITABLE277Service service) : base(service, dto => dto.NSERVICE) { }
}
