using WEBVisualTime.Servicios.Insudb.DTOs.TABLE696;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE696Controller : CrudApiController<TABLE696Dto, CreateTABLE696Dto, UpdateTABLE696Dto, int>
{
    public TABLE696Controller(ITABLE696Service service) : base(service, dto => dto.NPOLICYSALE) { }
}
