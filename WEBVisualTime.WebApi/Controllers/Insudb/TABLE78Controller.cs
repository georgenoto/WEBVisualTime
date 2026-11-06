using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE78Controller : CrudApiController<TABLE78Dto, CreateTABLE78Dto, UpdateTABLE78Dto, int>
{
    public TABLE78Controller(ITABLE78Service service) : base(service, dto => dto.NMOV_TYPE) { }
}
