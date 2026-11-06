using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9229;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9229Controller : CrudApiController<TABLE9229Dto, CreateTABLE9229Dto, UpdateTABLE9229Dto, int>
{
    public TABLE9229Controller(ITABLE9229Service service) : base(service, dto => dto.NPAY_ID) { }
}
