using WEBVisualTime.Servicios.Insudb.DTOs.TABLE201;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE201Controller : CrudApiController<TABLE201Dto, CreateTABLE201Dto, UpdateTABLE201Dto, int>
{
    public TABLE201Controller(ITABLE201Service service) : base(service, dto => dto.NTYPEWARRANTY) { }
}
