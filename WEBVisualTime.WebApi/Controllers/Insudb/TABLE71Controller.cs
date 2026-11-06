using WEBVisualTime.Servicios.Insudb.DTOs.TABLE71;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE71Controller : CrudApiController<TABLE71Dto, CreateTABLE71Dto, UpdateTABLE71Dto, int>
{
    public TABLE71Controller(ITABLE71Service service) : base(service, dto => dto.NBRANCH_EST) { }
}
