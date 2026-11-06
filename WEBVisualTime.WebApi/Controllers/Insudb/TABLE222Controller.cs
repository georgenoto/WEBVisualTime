using WEBVisualTime.Servicios.Insudb.DTOs.TABLE222;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE222Controller : CrudApiController<TABLE222Dto, CreateTABLE222Dto, UpdateTABLE222Dto, int>
{
    public TABLE222Controller(ITABLE222Service service) : base(service, dto => dto.NTITLE) { }
}
