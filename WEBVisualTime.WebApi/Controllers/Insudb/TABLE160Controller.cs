using WEBVisualTime.Servicios.Insudb.DTOs.TABLE160;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE160Controller : CrudApiController<TABLE160Dto, CreateTABLE160Dto, UpdateTABLE160Dto, int>
{
    public TABLE160Controller(ITABLE160Service service) : base(service, dto => dto.NPAY_CONCEP) { }
}
