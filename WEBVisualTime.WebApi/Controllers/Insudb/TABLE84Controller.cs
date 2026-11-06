using WEBVisualTime.Servicios.Insudb.DTOs.TABLE84;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE84Controller : CrudApiController<TABLE84Dto, CreateTABLE84Dto, UpdateTABLE84Dto, int>
{
    public TABLE84Controller(ITABLE84Service service) : base(service, dto => dto.NDEPARTME) { }
}
