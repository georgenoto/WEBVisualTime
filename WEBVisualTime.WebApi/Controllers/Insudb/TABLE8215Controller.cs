using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8215Controller : CrudApiController<TABLE8215Dto, CreateTABLE8215Dto, UpdateTABLE8215Dto, int>
{
    public TABLE8215Controller(ITABLE8215Service service) : base(service, dto => dto.NTYPE_VALUECOLLECT) { }
}
