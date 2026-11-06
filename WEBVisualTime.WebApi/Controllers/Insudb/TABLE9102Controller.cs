using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9102;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9102Controller : CrudApiController<TABLE9102Dto, CreateTABLE9102Dto, UpdateTABLE9102Dto, int>
{
    public TABLE9102Controller(ITABLE9102Service service) : base(service, dto => dto.NSHIPTYPE) { }
}
