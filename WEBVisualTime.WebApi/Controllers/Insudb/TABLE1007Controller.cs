using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1007Controller : CrudApiController<TABLE1007Dto, CreateTABLE1007Dto, UpdateTABLE1007Dto, long>
{
    public TABLE1007Controller(ITABLE1007Service service) : base(service, dto => dto.NCODIGINT) { }
}
