using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5614;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5614Controller : CrudApiController<TABLE5614Dto, CreateTABLE5614Dto, UpdateTABLE5614Dto, int>
{
    public TABLE5614Controller(ITABLE5614Service service) : base(service, dto => dto.NINUNDAT) { }
}
