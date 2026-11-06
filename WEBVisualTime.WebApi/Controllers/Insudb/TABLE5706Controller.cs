using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5706;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5706Controller : CrudApiController<TABLE5706Dto, CreateTABLE5706Dto, UpdateTABLE5706Dto, int>
{
    public TABLE5706Controller(ITABLE5706Service service) : base(service, dto => dto.NTABLE) { }
}
