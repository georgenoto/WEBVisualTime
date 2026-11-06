using WEBVisualTime.Servicios.Insudb.DTOs.TABLE324;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE324Controller : CrudApiController<TABLE324Dto, CreateTABLE324Dto, UpdateTABLE324Dto, int>
{
    public TABLE324Controller(ITABLE324Service service) : base(service, dto => dto.NTYPE) { }
}
