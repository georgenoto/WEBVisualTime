using WEBVisualTime.Servicios.Insudb.DTOs.TABLE994;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE994Controller : CrudApiController<TABLE994Dto, CreateTABLE994Dto, UpdateTABLE994Dto, int>
{
    public TABLE994Controller(ITABLE994Service service) : base(service, dto => dto.NACTION) { }
}
