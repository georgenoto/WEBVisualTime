using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5700;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5700Controller : CrudApiController<TABLE5700Dto, CreateTABLE5700Dto, UpdateTABLE5700Dto, int>
{
    public TABLE5700Controller(ITABLE5700Service service) : base(service, dto => dto.NOPERTYPE) { }
}
