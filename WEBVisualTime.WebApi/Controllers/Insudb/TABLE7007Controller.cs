using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7007Controller : CrudApiController<TABLE7007Dto, CreateTABLE7007Dto, UpdateTABLE7007Dto, long>
{
    public TABLE7007Controller(ITABLE7007Service service) : base(service, dto => dto.NCODIGINT) { }
}
