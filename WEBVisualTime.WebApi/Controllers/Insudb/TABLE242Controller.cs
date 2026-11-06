using WEBVisualTime.Servicios.Insudb.DTOs.TABLE242;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE242Controller : CrudApiController<TABLE242Dto, CreateTABLE242Dto, UpdateTABLE242Dto, int>
{
    public TABLE242Controller(ITABLE242Service service) : base(service, dto => dto.NUNIT_TYPE) { }
}
