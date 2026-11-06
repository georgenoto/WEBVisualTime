using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9101;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9101Controller : CrudApiController<TABLE9101Dto, CreateTABLE9101Dto, UpdateTABLE9101Dto, int>
{
    public TABLE9101Controller(ITABLE9101Service service) : base(service, dto => dto.NMATERIAL) { }
}
