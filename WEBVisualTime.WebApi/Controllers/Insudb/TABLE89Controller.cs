using WEBVisualTime.Servicios.Insudb.DTOs.TABLE89;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE89Controller : CrudApiController<TABLE89Dto, CreateTABLE89Dto, UpdateTABLE89Dto, long>
{
    public TABLE89Controller(ITABLE89Service service) : base(service, dto => dto.NCODIGINT) { }
}
