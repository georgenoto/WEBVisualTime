using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8500;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8500Controller : CrudApiController<TABLE8500Dto, CreateTABLE8500Dto, UpdateTABLE8500Dto, int>
{
    public TABLE8500Controller(ITABLE8500Service service) : base(service, dto => dto.NTYPE_SCHCOM) { }
}
