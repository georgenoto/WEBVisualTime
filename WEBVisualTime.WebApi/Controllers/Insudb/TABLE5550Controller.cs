using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5550Controller : CrudApiController<TABLE5550Dto, CreateTABLE5550Dto, UpdateTABLE5550Dto, int>
{
    public TABLE5550Controller(ITABLE5550Service service) : base(service, dto => dto.NINCAP_COD) { }
}
