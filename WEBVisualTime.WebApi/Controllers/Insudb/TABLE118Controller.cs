using WEBVisualTime.Servicios.Insudb.DTOs.TABLE118;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE118Controller : CrudApiController<TABLE118Dto, CreateTABLE118Dto, UpdateTABLE118Dto, int>
{
    public TABLE118Controller(ITABLE118Service service) : base(service, dto => dto.NARTICLE) { }
}
