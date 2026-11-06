using WEBVisualTime.Servicios.Insudb.DTOs.TABLE695;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE695Controller : CrudApiController<TABLE695Dto, CreateTABLE695Dto, UpdateTABLE695Dto, int>
{
    public TABLE695Controller(ITABLE695Service service) : base(service, dto => dto.NSYSMODUL) { }
}
