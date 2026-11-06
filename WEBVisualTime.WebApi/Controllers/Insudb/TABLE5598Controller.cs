using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5598;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5598Controller : CrudApiController<TABLE5598Dto, CreateTABLE5598Dto, UpdateTABLE5598Dto, int>
{
    public TABLE5598Controller(ITABLE5598Service service) : base(service, dto => dto.NACTIONCOV) { }
}
