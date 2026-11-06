using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7040;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7040Controller : CrudApiController<TABLE7040Dto, CreateTABLE7040Dto, UpdateTABLE7040Dto, int>
{
    public TABLE7040Controller(ITABLE7040Service service) : base(service, dto => dto.NSPCOMBTYPE) { }
}
