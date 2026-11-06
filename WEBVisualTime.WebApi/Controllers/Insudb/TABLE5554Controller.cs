using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5554Controller : CrudApiController<TABLE5554Dto, CreateTABLE5554Dto, UpdateTABLE5554Dto, int>
{
    public TABLE5554Controller(ITABLE5554Service service) : base(service, dto => dto.NINPUTTYP) { }
}
