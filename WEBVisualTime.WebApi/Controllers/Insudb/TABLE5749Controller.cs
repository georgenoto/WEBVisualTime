using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5749;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5749Controller : CrudApiController<TABLE5749Dto, CreateTABLE5749Dto, UpdateTABLE5749Dto, int>
{
    public TABLE5749Controller(ITABLE5749Service service) : base(service, dto => dto.NTYPEVAL) { }
}
