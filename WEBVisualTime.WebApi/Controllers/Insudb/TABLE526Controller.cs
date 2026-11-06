using WEBVisualTime.Servicios.Insudb.DTOs.TABLE526;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE526Controller : CrudApiController<TABLE526Dto, CreateTABLE526Dto, UpdateTABLE526Dto, int>
{
    public TABLE526Controller(ITABLE526Service service) : base(service, dto => dto.NTYPE_PROCE) { }
}
