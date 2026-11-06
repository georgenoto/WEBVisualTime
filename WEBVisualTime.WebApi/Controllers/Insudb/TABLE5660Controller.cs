using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5660;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5660Controller : CrudApiController<TABLE5660Dto, CreateTABLE5660Dto, UpdateTABLE5660Dto, int>
{
    public TABLE5660Controller(ITABLE5660Service service) : base(service, dto => dto.NTYPE_CALC) { }
}
