using WEBVisualTime.Servicios.Insudb.DTOs.TABLE113;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE113Controller : CrudApiController<TABLE113Dto, CreateTABLE113Dto, UpdateTABLE113Dto, int>
{
    public TABLE113Controller(ITABLE113Service service) : base(service, dto => dto.NBENEFAPL) { }
}
