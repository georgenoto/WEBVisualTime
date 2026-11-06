using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5613;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5613Controller : CrudApiController<TABLE5613Dto, CreateTABLE5613Dto, UpdateTABLE5613Dto, int>
{
    public TABLE5613Controller(ITABLE5613Service service) : base(service, dto => dto.NCONTAINRISK) { }
}
