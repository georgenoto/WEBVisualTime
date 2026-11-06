using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5603Controller : CrudApiController<TABLE5603Dto, CreateTABLE5603Dto, UpdateTABLE5603Dto, int>
{
    public TABLE5603Controller(ITABLE5603Service service) : base(service, dto => dto.NAREAWAIT) { }
}
