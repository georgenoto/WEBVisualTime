using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5003Controller : CrudApiController<TABLE5003Dto, CreateTABLE5003Dto, UpdateTABLE5003Dto, int>
{
    public TABLE5003Controller(ITABLE5003Service service) : base(service, dto => dto.NREJECTCAUSE) { }
}
