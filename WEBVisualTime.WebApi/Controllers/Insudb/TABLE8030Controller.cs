using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8030Controller : CrudApiController<TABLE8030Dto, CreateTABLE8030Dto, UpdateTABLE8030Dto, int>
{
    public TABLE8030Controller(ITABLE8030Service service) : base(service, dto => dto.NREPTYPE) { }
}
