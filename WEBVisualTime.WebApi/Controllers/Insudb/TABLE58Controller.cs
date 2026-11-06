using WEBVisualTime.Servicios.Insudb.DTOs.TABLE58;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE58Controller : CrudApiController<TABLE58Dto, CreateTABLE58Dto, UpdateTABLE58Dto, int>
{
    public TABLE58Controller(ITABLE58Service service) : base(service, dto => dto.NTYPE_INDEX) { }
}
