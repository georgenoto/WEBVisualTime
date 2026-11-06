using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8101;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8101Controller : CrudApiController<TABLE8101Dto, CreateTABLE8101Dto, UpdateTABLE8101Dto, int>
{
    public TABLE8101Controller(ITABLE8101Service service) : base(service, dto => dto.NAPLY) { }
}
