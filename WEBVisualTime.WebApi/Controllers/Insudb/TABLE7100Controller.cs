using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7100Controller : CrudApiController<TABLE7100Dto, CreateTABLE7100Dto, UpdateTABLE7100Dto, int>
{
    public TABLE7100Controller(ITABLE7100Service service) : base(service, dto => dto.NORDERTYPE) { }
}
