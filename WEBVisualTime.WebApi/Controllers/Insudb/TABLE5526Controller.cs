using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5526;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5526Controller : CrudApiController<TABLE5526Dto, CreateTABLE5526Dto, UpdateTABLE5526Dto, int>
{
    public TABLE5526Controller(ITABLE5526Service service) : base(service, dto => dto.NSTATQUOTA) { }
}
