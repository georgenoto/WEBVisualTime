using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9250Controller : CrudApiController<TABLE9250Dto, CreateTABLE9250Dto, UpdateTABLE9250Dto, int>
{
    public TABLE9250Controller(ITABLE9250Service service) : base(service, dto => dto.NSETTLEMENT_STAT) { }
}
