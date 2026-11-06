using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE999Controller : CrudApiController<TABLE999Dto, CreateTABLE999Dto, UpdateTABLE999Dto, string>
{
    public TABLE999Controller(ITABLE999Service service) : base(service, dto => dto.SSTAT_ERROR) { }
}
