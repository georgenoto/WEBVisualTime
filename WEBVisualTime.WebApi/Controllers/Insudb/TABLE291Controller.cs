using WEBVisualTime.Servicios.Insudb.DTOs.TABLE291;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE291Controller : CrudApiController<TABLE291Dto, CreateTABLE291Dto, UpdateTABLE291Dto, string>
{
    public TABLE291Controller(ITABLE291Service service) : base(service, dto => dto.STYPE_ASSIG) { }
}
