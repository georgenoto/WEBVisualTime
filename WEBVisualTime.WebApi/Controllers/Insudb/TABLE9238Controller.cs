using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9238Controller : CrudApiController<TABLE9238Dto, CreateTABLE9238Dto, UpdateTABLE9238Dto, int>
{
    public TABLE9238Controller(ITABLE9238Service service) : base(service, dto => dto.NORDERTYPE) { }
}
