using WEBVisualTime.Servicios.Insudb.DTOs.TABLE561;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE561Controller : CrudApiController<TABLE561Dto, CreateTABLE561Dto, UpdateTABLE561Dto, int>
{
    public TABLE561Controller(ITABLE561Service service) : base(service, dto => dto.NEVALSTAT) { }
}
