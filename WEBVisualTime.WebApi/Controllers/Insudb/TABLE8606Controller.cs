using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8606Controller : CrudApiController<TABLE8606Dto, CreateTABLE8606Dto, UpdateTABLE8606Dto, int>
{
    public TABLE8606Controller(ITABLE8606Service service) : base(service, dto => dto.NTYPE_GROUP) { }
}
