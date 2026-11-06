using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9027;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9027Controller : CrudApiController<TABLE9027Dto, CreateTABLE9027Dto, UpdateTABLE9027Dto, int>
{
    public TABLE9027Controller(ITABLE9027Service service) : base(service, dto => dto.NECONOMIC) { }
}
