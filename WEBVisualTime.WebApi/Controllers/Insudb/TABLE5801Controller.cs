using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5801;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5801Controller : CrudApiController<TABLE5801Dto, CreateTABLE5801Dto, UpdateTABLE5801Dto, int>
{
    public TABLE5801Controller(ITABLE5801Service service) : base(service, dto => dto.NTYPE_CALC) { }
}
