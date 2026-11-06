using WEBVisualTime.Servicios.Insudb.DTOs.TABLE195;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE195Controller : CrudApiController<TABLE195Dto, CreateTABLE195Dto, UpdateTABLE195Dto, long>
{
    public TABLE195Controller(ITABLE195Service service) : base(service, dto => dto.SCODIGINT) { }
}
