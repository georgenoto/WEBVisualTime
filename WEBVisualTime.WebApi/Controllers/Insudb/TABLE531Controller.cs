using WEBVisualTime.Servicios.Insudb.DTOs.TABLE531;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE531Controller : CrudApiController<TABLE531Dto, CreateTABLE531Dto, UpdateTABLE531Dto, int>
{
    public TABLE531Controller(ITABLE531Service service) : base(service, dto => dto.NSOURCE) { }
}
