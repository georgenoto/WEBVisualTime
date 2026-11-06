using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5534;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5534Controller : CrudApiController<TABLE5534Dto, CreateTABLE5534Dto, UpdateTABLE5534Dto, int>
{
    public TABLE5534Controller(ITABLE5534Service service) : base(service, dto => dto.NDAMAG_AUTO) { }
}
