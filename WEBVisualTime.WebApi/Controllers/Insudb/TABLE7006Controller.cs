using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7006Controller : CrudApiController<TABLE7006Dto, CreateTABLE7006Dto, UpdateTABLE7006Dto, long>
{
    public TABLE7006Controller(ITABLE7006Service service) : base(service, dto => dto.NCODIGINT) { }
}
