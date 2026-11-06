using WEBVisualTime.Servicios.Insudb.DTOs.TABLE502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE502Controller : CrudApiController<TABLE502Dto, CreateTABLE502Dto, UpdateTABLE502Dto, long>
{
    public TABLE502Controller(ITABLE502Service service) : base(service, dto => dto.NCODIGINT) { }
}
