using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7039;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7039Controller : CrudApiController<TABLE7039Dto, CreateTABLE7039Dto, UpdateTABLE7039Dto, int>
{
    public TABLE7039Controller(ITABLE7039Service service) : base(service, dto => dto.NBUILDTYPE) { }
}
