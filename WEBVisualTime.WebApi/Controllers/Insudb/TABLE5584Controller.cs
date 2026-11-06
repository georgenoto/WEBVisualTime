using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5584;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5584Controller : CrudApiController<TABLE5584Dto, CreateTABLE5584Dto, UpdateTABLE5584Dto, int>
{
    public TABLE5584Controller(ITABLE5584Service service) : base(service, dto => dto.NTYPE_TAR) { }
}
