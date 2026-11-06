using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5501Controller : CrudApiController<TABLE5501Dto, CreateTABLE5501Dto, UpdateTABLE5501Dto, int>
{
    public TABLE5501Controller(ITABLE5501Service service) : base(service, dto => dto.NLEGAL_SCH) { }
}
