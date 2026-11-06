using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5812;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5812Controller : CrudApiController<TABLE5812Dto, CreateTABLE5812Dto, UpdateTABLE5812Dto, int>
{
    public TABLE5812Controller(ITABLE5812Service service) : base(service, dto => dto.NDOC_CODE) { }
}
