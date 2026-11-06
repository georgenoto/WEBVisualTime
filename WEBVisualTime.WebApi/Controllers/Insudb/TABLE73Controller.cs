using WEBVisualTime.Servicios.Insudb.DTOs.TABLE73;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE73Controller : CrudApiController<TABLE73Dto, CreateTABLE73Dto, UpdateTABLE73Dto, int>
{
    public TABLE73Controller(ITABLE73Service service) : base(service, dto => dto.NRELREQEXC) { }
}
