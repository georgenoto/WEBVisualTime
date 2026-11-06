using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE2000Controller : CrudApiController<TABLE2000Dto, CreateTABLE2000Dto, UpdateTABLE2000Dto, long>
{
    public TABLE2000Controller(ITABLE2000Service service) : base(service, dto => dto.NAPLY) { }
}
