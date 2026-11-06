using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6046;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6046Controller : CrudApiController<TABLE6046Dto, CreateTABLE6046Dto, UpdateTABLE6046Dto, int>
{
    public TABLE6046Controller(ITABLE6046Service service) : base(service, dto => dto.NCLI_CATEGORY) { }
}
