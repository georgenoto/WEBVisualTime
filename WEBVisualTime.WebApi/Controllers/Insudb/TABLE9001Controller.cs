using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9001Controller : CrudApiController<TABLE9001Dto, CreateTABLE9001Dto, UpdateTABLE9001Dto, int>
{
    public TABLE9001Controller(ITABLE9001Service service) : base(service, dto => dto.NTYPE) { }
}
