using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5644;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5644Controller : CrudApiController<TABLE5644Dto, CreateTABLE5644Dto, UpdateTABLE5644Dto, int>
{
    public TABLE5644Controller(ITABLE5644Service service) : base(service, dto => dto.NTYPE_PERIOD) { }
}
