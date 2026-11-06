using WEBVisualTime.Servicios.Insudb.DTOs.TABLE418;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE418Controller : CrudApiController<TABLE418Dto, CreateTABLE418Dto, UpdateTABLE418Dto, long>
{
    public TABLE418Controller(ITABLE418Service service) : base(service, dto => dto.NCODIGINT) { }
}
