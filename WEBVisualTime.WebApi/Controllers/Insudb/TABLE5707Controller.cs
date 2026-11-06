using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5707;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5707Controller : CrudApiController<TABLE5707Dto, CreateTABLE5707Dto, UpdateTABLE5707Dto, int>
{
    public TABLE5707Controller(ITABLE5707Service service) : base(service, dto => dto.NINTERTYPE) { }
}
