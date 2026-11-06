using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5522;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5522Controller : CrudApiController<TABLE5522Dto, CreateTABLE5522Dto, UpdateTABLE5522Dto, int>
{
    public TABLE5522Controller(ITABLE5522Service service) : base(service, dto => dto.NINVOICING) { }
}
