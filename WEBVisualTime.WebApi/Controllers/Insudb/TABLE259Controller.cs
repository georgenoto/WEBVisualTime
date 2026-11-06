using WEBVisualTime.Servicios.Insudb.DTOs.TABLE259;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE259Controller : CrudApiController<TABLE259Dto, CreateTABLE259Dto, UpdateTABLE259Dto, long>
{
    public TABLE259Controller(ITABLE259Service service) : base(service, dto => dto.NCODIGINT) { }
}
