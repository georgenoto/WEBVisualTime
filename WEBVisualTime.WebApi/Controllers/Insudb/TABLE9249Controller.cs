using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9249Controller : CrudApiController<TABLE9249Dto, CreateTABLE9249Dto, UpdateTABLE9249Dto, int>
{
    public TABLE9249Controller(ITABLE9249Service service) : base(service, dto => dto.NSETTLEMENT_CONC) { }
}
