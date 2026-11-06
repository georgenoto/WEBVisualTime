using WEBVisualTime.Servicios.Insudb.DTOs.TABLE196;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE196Controller : CrudApiController<TABLE196Dto, CreateTABLE196Dto, UpdateTABLE196Dto, long>
{
    public TABLE196Controller(ITABLE196Service service) : base(service, dto => dto.SCODIGINT) { }
}
