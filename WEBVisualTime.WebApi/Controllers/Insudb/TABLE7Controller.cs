using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7Controller : CrudApiController<TABLE7Dto, CreateTABLE7Dto, UpdateTABLE7Dto, long>
{
    public TABLE7Controller(ITABLE7Service service) : base(service, dto => dto.NBANK_CODE) { }
}
