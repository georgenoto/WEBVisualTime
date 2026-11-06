using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1000Controller : CrudApiController<TABLE1000Dto, CreateTABLE1000Dto, UpdateTABLE1000Dto, int>
{
    public TABLE1000Controller(ITABLE1000Service service) : base(service, dto => dto.NCODTOLER) { }
}
